using Dapper;
using Hotel_Vanilla.CONTROLADOR;
using Hotel_Vanilla.ENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Vanilla.Vista
{
    public partial class frmManejoReservas : Form
    {
        public frmManejoReservas()
        {
            InitializeComponent();
            //txtFechaReserva.Text = DateTime.Today.ToString();
            //txtFechaCheckIn.Text = DateTime.Today.ToString();
            //txtFechaCheckOut.Text = DateTime.Today.ToString();
        }
        CManejoReservas Creservas = new CManejoReservas();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        CSucesos cSucesos = new CSucesos();
        frmInicio inicio = new frmInicio();

        public Boolean accion = false;
        public String habitacion;
        public String huesped;
        internal object fechaCheckOutLabel;

        public string Titulo { get; set; }
        public string Mensaje { get; set; }

        private void RellenarCB()
        {
            cbHabitacion.Text = habitacion;
            cbIdHuesped.Text = huesped;
        }
        public ManejoReservas reservaciones;
        private void frmManejoReservas_Load(object sender, EventArgs e)
        {
            if (accion == false)
            {
                manejoReservasBindingSource.AddNew();
                CargarHuespedes();
                CargarHabitaciones();

            }
            else if (accion)
            {
                manejoReservasBindingSource.EndEdit();
                manejoReservasBindingSource.DataSource = reservaciones;
                CargarHuespedes();
                CargarHabitaciones();

                RellenarCB();
            }

        }
        private void CargarHuespedes()
        {
            IDbConnection conexion = Conexion.conectar();
            List<Huespedes> reservas = new List<Huespedes>();
            string consulta = "sp_Mostrarhuesped";
            conexion.Open();
            reservas = conexion.Query<Huespedes>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();

            cbIdHuesped.DataSource = reservas;
            cbIdHuesped.DisplayMember = "nombres";
            cbIdHuesped.ValueMember = "idHuesped";
            //cbIdHuesped.SelectedIndex = 1;
        }

        private void CargarHabitaciones()
        {
            IDbConnection conexion = Conexion.conectar();
            List<Habitaciones> habitacion = new List<Habitaciones>();
            string consulta = "sp_MostrarHabitaciones";
            conexion.Open();
            habitacion = conexion.Query<Habitaciones>(consulta, commandType: CommandType.StoredProcedure).ToList();
            conexion.Close();

            cbHabitacion.DataSource = habitacion;
            cbHabitacion.DisplayMember = "numeroHabitacion";
            cbHabitacion.ValueMember = "idHabitacion";
            //cbHabitacion.SelectedIndex = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BorrarValidacion();
            if (ValidarCampos() && btnGuardar.Text.Equals("Guardar"))
            {
                //tomando los datos actuales de bindin y asignandolo al objeto de ManejoReservas
                ManejoReservas reservas = (ManejoReservas)manejoReservasBindingSource.Current;
                //ManejoReservas reservas = new ManejoReservas();

                //reservas.fechaReserva = Convert.ToDateTime(txtFechaReserva.Text);
                //reservas.fechaCheckIn = Convert.ToDateTime(txtFechaCheckIn.Text);
                reservas.fechaCheckOut = null;
                //reservas.numeroDias = Convert.ToInt32(txtDiasAlojamiento.Text);
                if (txtPagoAdelantado.Text == "")
                {
                    reservas.pagoAdelantado = Convert.ToDecimal(0.0000);
                }
                //else
                //{
                //    reservas.pagoAdelantado = Convert.ToDecimal(txtPagoAdelantado.Text);
                //}
                if (txtDescuento.Text == "")
                {
                    reservas.descuento = Convert.ToDecimal(0.0000);
                }
                //else
                //{
                //    reservas.descuento = Convert.ToDecimal(txtDescuento.Text);
                //}
                reservas.total = 0;
                reservas.idHabitacion_FK = Convert.ToInt32(cbHabitacion.SelectedValue.ToString());
                reservas.idHuesped_FK = Convert.ToInt32(cbIdHuesped.SelectedValue.ToString());

                //mandando el objeto reservas como parametro al metodo de agrregar reserva
                Creservas.AgregarReserva(reservas);

                frmMensajeExito.Confirmar("Se ha Ingresado correctamente");

                var sucesos = cSucesos.UltimoSuceso();
                foreach (var suceso in sucesos)
                {
                    Titulo = suceso.tipoSuceso;
                    Mensaje = suceso.descripcion;
                }

                inicio.MostrarNotificacion(Titulo, Mensaje, ToolTipIcon.Info);

                Limpiar();

            }

            else if (ValidarCampos() && btnGuardar.Text.Equals("Actualizar"))
            {
                ManejoReservas reservas = new ManejoReservas();
                reservas.idReserva = Convert.ToInt32(txtId.Text);
                reservas.fechaReserva = Convert.ToDateTime(txtFechaReserva.Text);
                reservas.fechaCheckIn = Convert.ToDateTime(txtFechaCheckIn.Text);
                reservas.fechaCheckOut = Convert.ToDateTime(txtCheckOut.Text);
                reservas.numeroDias = Convert.ToInt32(txtDiasAlojamiento.Text);
                if (txtPagoAdelantado.Text == "")
                {
                    reservas.pagoAdelantado = Convert.ToDecimal(0.0000);
                }

                else
                {
                    reservas.pagoAdelantado = Convert.ToDecimal(txtPagoAdelantado.Text);
                }

                if (txtDescuento.Text == "")
                {
                    reservas.descuento = Convert.ToDecimal(0.0000);
                }

                else
                {
                    reservas.descuento = Convert.ToDecimal(txtDescuento.Text);
                }

                reservas.total = 0;
                reservas.idHabitacion_FK = Convert.ToInt32(cbHabitacion.SelectedValue.ToString());
                reservas.idHuesped_FK = Convert.ToInt32(cbIdHuesped.SelectedValue.ToString());

                //mandando el objeto reservas como parametro al metodo de agrregar reserva
                Creservas.ActualizarReserva(reservas);
                this.Close();

                frmMensajeExito.Confirmar("Se ha Actualizado correctamente");

                var sucesos = cSucesos.UltimoSuceso();
                foreach (var suceso in sucesos)
                {
                    Titulo = suceso.tipoSuceso;
                    Mensaje = suceso.descripcion;
                }

                inicio.MostrarNotificacion(Titulo, Mensaje, ToolTipIcon.Warning);
            }


        }
        private void Limpiar()
        {
            txtFechaReserva.Text = DateTime.Now.ToString();
            txtFechaCheckIn.Text = DateTime.Now.ToString();
            txtCheckOut.Text = DateTime.Now.ToString();
            txtDiasAlojamiento.Value = 1;
            cbHabitacion.SelectedIndex = -1;
            txtPagoAdelantado.Text = "";
            txtDescuento.Text = "";
            txtTotal.Text = "";
            cbIdHuesped.SelectedIndex = -1;
            //manejoReservasBindingSource.DataSource = null;
        }
        private void CalcularTotal()
        {
            int dias = Convert.ToInt32(txtDiasAlojamiento.Text);
            Decimal adelantado = Convert.ToDecimal(txtPagoAdelantado.Text);
            Decimal descuento = Convert.ToDecimal(txtDescuento.Text);
            txtTotal.Text = ((dias * CalcularTarifa()) - (adelantado + descuento)).ToString();
        }
        private Decimal CalcularTarifa()
        {
            Decimal tarifa = 0;
            if (cbHabitacion.Text.Equals("001-025-01"))
            {
                tarifa = 25;
            }
            else if (cbHabitacion.Text.Equals("001-030-02"))
            {
                tarifa = 30;
            }
            else if (cbHabitacion.Text.Equals("001-080-05"))
            {
                tarifa = 80;
            }
            else if (cbHabitacion.Text.Equals("001-025-02"))
            {
                tarifa = 25;
            }
            else if (cbHabitacion.Text.Equals("001-015-01"))
            {
                tarifa = 15;
            }
            return tarifa;
        }

        private Boolean ValidarCampos()
        {
            Boolean permitir = true;
            if (cbHabitacion.SelectedIndex == -1)
            {
                errorProvider.SetError(cbHabitacion, "Este campo es obligatorio");
                permitir = false;
            }
            if (cbIdHuesped.SelectedIndex == -1)
            {
                errorProvider.SetError(cbIdHuesped, "Este campo es obligatorio");
                permitir = false;
            }
            //if (txtPagoAdelantado.Text.Equals(""))
            //{
            //    errorProvider.SetError(txtPagoAdelantado, "Este campo es obligatorio");
            //    permitir = false;
            //}
            //if (txtDescuento.Text.Equals(""))
            //{
            //    errorProvider.SetError(txtDescuento, "Este campo es obligatorio");
            //    permitir = false;
            //}
            return permitir;
        }

        private void BorrarValidacion()
        {
            errorProvider.SetError(cbHabitacion, "Este campo es obligatorio");
            errorProvider.SetError(cbIdHuesped, "Este campo es obligatorio");
        }

        private void descuentoTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void txtPagoAdelantado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == 08)
            {
                e.Handled = false;
                return;
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 46 || e.KeyChar == 08)
            {
                e.Handled = false;
                return;
            }

            else
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            int punto = 0;
            //Se evalua cada elemento de la cadena en la caja de texto
            for (int i = 0; i < txtDescuento.Text.Length; i++)
            {
                //si uno de esos elementos es un punto la variable punto aumenta en uno
                if (txtDescuento.Text[i].ToString().Equals("."))
                {
                    punto += 1;
                    //si la variable punto es 2,se devuelve una cadena con un elemento menos, el ultimo punto se borra
                    if (punto == 2)
                    {
                        txtDescuento.Text = txtDescuento.Text.Substring(0, txtDescuento.Text.Length - 1).ToString();
                        //para que la barra para escribir se coloque al final del ultimos elemto ingresado
                        //para que se pueda seguir escribiendo normal
                        txtDescuento.SelectionStart = txtDescuento.TextLength;
                        //la variable se reestablece a 0
                        punto = 0;
                    }
                }
            }

            AlertarValorMaximo();
        }
        private void AlertarValorMaximo()
        {
            //se verifica que el campo no este vacio
            if (!txtDescuento.Text.Equals(""))
            {
                //se convierte la cadena a numeros
                Double valor = Convert.ToDouble(txtDescuento.Text);
                if (valor > 214748.3648)
                {
                    //si la cadena es mayor al valor maximo de smallmoney coloca un error, da un mensaje y borra la cantidad
                    errorProvider.SetError(txtDescuento, "El valor máximo permitido es: 214,748.3648");
                    txtDescuento.Text = "";
                }
            }
        }

        private void txtPagoAdelantado_TextChanged(object sender, EventArgs e)
        {
            int punto = 0;
            //Se evalua cada elemento de la cadena en la caja de texto
            for (int i = 0; i < txtPagoAdelantado.Text.Length; i++)
            {
                //si uno de esos elementos es un punto la variable punto aumenta en uno
                if (txtPagoAdelantado.Text[i].ToString().Equals("."))
                {
                    punto += 1;
                    //si la variable punto es 2,se devuelve una cadena con un elemento menos, el ultimo punto se borra
                    if (punto == 2)
                    {
                        txtPagoAdelantado.Text = txtPagoAdelantado.Text.Substring(0, txtPagoAdelantado.Text.Length - 1).ToString();
                        //para que la barra para escribir se coloque al final del ultimos elemto ingresado
                        //para que se pueda seguir escribiendo normal
                        txtPagoAdelantado.SelectionStart = txtPagoAdelantado.TextLength;
                        //la variable se reestablece a 0
                        punto = 0;
                    }
                }
            }
        }

        private void cbIdHuesped_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void txtDiasAlojamiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                DateTime checkin = Convert.ToDateTime(txtFechaCheckIn.Text);
                int dias = Convert.ToInt32(txtDiasAlojamiento.Text);
                DateTime salida = checkin.AddDays(dias);
                txtCheckOut.Text = (salida).ToString();
            }
        }

        private void txtDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    CalcularTotal();
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
