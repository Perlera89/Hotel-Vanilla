using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.CONTROLADOR;

namespace Hotel_Vanilla.Vista
{
    public partial class frmManejoHabitaciones : Form
    {
        CSucesos cSucesos = new CSucesos();
        frmInicio inicio = new frmInicio();

        public String tipoHabitacion;
        public Boolean accion = false;
        public string Titulo { get; set; }
        public string Mensaje { get; set; }

        public frmManejoHabitaciones()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones();
            BorrarValidacion();
            if (ValidarCampos() && btnGuardar.Text == "Guardar")
            {
                CHabitaciones cHabitacion = new CHabitaciones();
                Habitaciones habitacion =(Habitaciones) habitacionesBindingSource.Current;
                habitacion.idTipoHabitacion_FK = Convert.ToInt32(cbTipoHabitacion.SelectedValue.ToString());
                cHabitacion.AgregarHabitacion(habitacion);

                frmMensajeExito.Confirmar("Se ha Ingresado correctamente");

                var sucesos = cSucesos.UltimoSuceso();
                foreach (var suceso in sucesos)
                {
                    Titulo = suceso.tipoSuceso;
                    Mensaje = suceso.descripcion;
                }

                inicio.MostrarNotificacion(Titulo, Mensaje, ToolTipIcon.Info);

                Limpiar();
                numeroHabitacionTextBox.Focus();
            }
            else if (ValidarCampos() && btnGuardar.Text == "Actualizar")
            {
                CHabitaciones cHabitacion = new CHabitaciones();
                Habitaciones habitacion = (Habitaciones)habitacionesBindingSource.Current;
                habitacion.numeroHabitacion = numeroHabitacionTextBox.Text;
                habitacion.tarifa = Convert.ToDecimal(tarifaTextBox.Text);
                habitacion.idTipoHabitacion_FK = Convert.ToInt32(cbTipoHabitacion.SelectedValue.ToString());
                cHabitacion.ActualizarHabitacion(habitacion);

                frmMensajeExito.Confirmar("Se ha Actualizado correctamente");

                var sucesos = cSucesos.UltimoSuceso();
                foreach (var suceso in sucesos)
                {
                    Titulo = suceso.tipoSuceso;
                    Mensaje = suceso.descripcion;
                }

                inicio.MostrarNotificacion(Titulo, Mensaje, ToolTipIcon.Warning);
                this.Close();
            }
        }
        public Habitaciones habitacion;
        private void frmManejoHabitaciones_Load(object sender, EventArgs e)
        {

            if (accion==false)
            {
                habitacionesBindingSource.AddNew();
                cargarCBTipoHabitacion();
                cbTipoHabitacion.Text = tipoHabitacion;
            }
            else
            {
                habitacionesBindingSource.EndEdit();
                //limpiando y cargando los datos a las cajas que se traen desde habitaciones
                habitacionesBindingSource.Clear();
                habitacionesBindingSource.DataSource = habitacion;

                cargarCBTipoHabitacion();
                cbTipoHabitacion.Text = tipoHabitacion;
            } 
        }

        public void Limpiar()
        {
            numeroHabitacionTextBox.Clear();
            tarifaTextBox.Clear();
            cbTipoHabitacion.SelectedIndex=-1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarCBTipoHabitacion()
        {
            CTipoHabitaciones cTipoHabitaciones = new CTipoHabitaciones();
            cbTipoHabitacion.DataSource = cTipoHabitaciones.MostrarTipoHabitaciones();
            cbTipoHabitacion.DisplayMember = "Tipodehabitacion";
            cbTipoHabitacion.ValueMember = "idTipoHabitacion";

            if (cbTipoHabitacion.Items.Count > 0)
            {
                cbTipoHabitacion.SelectedIndex = -1;
            }
        }

        private void tarifaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar>=48&&e.KeyChar<=57 || e.KeyChar==46 ||e.KeyChar==08)
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

        private void tarifaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                e.Handled = false;
                return;
            }
        }

        private Boolean ValidarCampos()
        {
            Boolean permitir = true;
            if (numeroHabitacionTextBox.Text.Equals(""))
            {
                errorProvider.SetError(numeroHabitacionTextBox, "Este campo es obligatorio");
                permitir = false;
            }
            if (tarifaTextBox.Text.Equals("0")||tarifaTextBox.Text.Equals(""))
            {
                errorProvider.SetError(tarifaTextBox, "Este campo es obligatorio");
                permitir = false;
            }
            if (cbTipoHabitacion.Text.Equals(""))
            {
                errorProvider.SetError(cbTipoHabitacion, "Este campo es obligatorio");
                permitir = false;
            }

            return permitir;
        }

        private void BorrarValidacion()
        {
            errorProvider.SetError(numeroHabitacionTextBox, "");
            errorProvider.SetError(tarifaTextBox, "");
            errorProvider.SetError(cbTipoHabitacion, "");
        }
        private int punto = 0;

        private void tarifaTextBox_TextChanged(object sender, EventArgs e)
        {
            //Se evalua cada elemento de la cadena en la caja de texto
            for (int i = 0; i <tarifaTextBox.Text.Length; i++)
            {
                //si uno de esos elementos es un punto la variable punto aumenta en uno
                if (tarifaTextBox.Text[i].ToString().Equals("."))
                {
                    punto += 1;
                    //si la variable punto es 2,se devuelve una cadena con un elemento menos, el ultimo punto se borra
                    if (punto == 2)
                    {
                        tarifaTextBox.Text = tarifaTextBox.Text.Substring(0, tarifaTextBox.Text.Length - 1).ToString();
                        //para que la barra para escribir se coloque al final del ultimos elemto ingresado
                        //para que se pueda seguir escribiendo normal
                        tarifaTextBox.SelectionStart = tarifaTextBox.TextLength;
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
            if (!tarifaTextBox.Text.Equals(""))
            {
                //se convierte la cadena a numeros
                Double valor = Convert.ToDouble(tarifaTextBox.Text);
                if (valor > 214748.3648)
                {
                    //si la cadena es mayor al valor maximo de smallmoney coloca un error, da un mensaje y borra la cantidad
                    errorProvider.SetError(tarifaTextBox, "El valor máximo permitido es: 214,748.3648");
                    tarifaTextBox.Text = "";
                }
            }
        }

        private void btnGuardar_Enter(object sender, EventArgs e)
        {
        }

        private void cbTipoHabitacion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbTipoHabitacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnGuardar_Click(sender, e);
            }
        }

        private void cbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
