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
        }
        CManejoReservas Creservas = new CManejoReservas();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Boolean accion = false;
        public String habitacion;
        public String huesped;
        internal object fechaCheckOutLabel;

        private void RellenarCB()
        {
            cbHabitacion.Text = habitacion;
            idHuesped_FKComboBox.Text = huesped;
        }
        private void frmManejoReservas_Load(object sender, EventArgs e)
        {
            CargarHuespedes();
            CargarHabitaciones();
            RellenarCB();
            if (accion==false)
            {
                manejoReservasBindingSource.AddNew();
            }
            else if(accion)
            {
                manejoReservasBindingSource.EndEdit();
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

            idHuesped_FKComboBox.DataSource = reservas;
            idHuesped_FKComboBox.DisplayMember = "nombres";
            idHuesped_FKComboBox.ValueMember = "idHuesped";
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text.Equals("Guardar"))
            {
                //tomando los datos actuales de bindin y asignandolo al objeto de ManejoReservas
                ManejoReservas Areservas = (ManejoReservas)manejoReservasBindingSource.Current;

                ManejoReservas reservas = new ManejoReservas();
                reservas.fechaReserva = Convert.ToDateTime(Areservas.fechaReserva);
                reservas.fechaCheckIn = Areservas.fechaCheckIn;
                reservas.fechaCheckOut = Areservas.fechaCheckOut;
                reservas.numeroDias = Convert.ToInt32(Areservas.numeroDias);
                reservas.pagoAdelantado = Areservas.pagoAdelantado;
                reservas.descuento = Areservas.descuento;
                reservas.total = 0;
                reservas.idHabitacion_FK = Convert.ToInt32(cbHabitacion.SelectedValue.ToString());
                reservas.idHuesped_FK = Convert.ToInt32(idHuesped_FKComboBox.SelectedValue.ToString());

                //mandando el objeto reservas como parametro al metodo de agrregar reserva
                Creservas.AgregarReserva(reservas);
                this.Close();
            }else if (btnGuardar.Text.Equals("Actualizar"))
            {
                ManejoReservas reservas = new ManejoReservas();
                reservas.idReserva = Convert.ToInt32(idReservaTextBox1.Text);
                reservas.fechaReserva = Convert.ToDateTime(fechaReservaDateTimePicker.Text);
                reservas.fechaCheckIn = Convert.ToDateTime(fechaCheckInDateTimePicker.Text);
                reservas.fechaCheckOut = Convert.ToDateTime(fechaCheckOutDateTimePicker.Text);
                reservas.numeroDias = Convert.ToInt32(numeroDiasTextBox.Text);
                reservas.pagoAdelantado = Convert.ToDecimal(pagoAdelantadoTextBox.Text);
                reservas.descuento = Convert.ToDecimal(descuentoTextBox.Text);
                reservas.total = 0;
                reservas.idHabitacion_FK = Convert.ToInt32(cbHabitacion.SelectedValue.ToString());
                reservas.idHuesped_FK = Convert.ToInt32(idHuesped_FKComboBox.SelectedValue.ToString());

                //mandando el objeto reservas como parametro al metodo de agrregar reserva
                Creservas.ActualizarReserva(reservas);
                this.Close();
            }


        }
        private void CalcularCheckOut()
        {
            DateTime checkin = Convert.ToDateTime(fechaCheckInDateTimePicker.Text);
            int dias = Convert.ToInt32(numeroDiasTextBox.Text);
            fechaCheckOutDateTimePicker.Text = (checkin.AddDays(dias)).ToString();
        }
        private void CalcularTotal()
        {
            int dias = Convert.ToInt32(numeroDiasTextBox.Text);
            Decimal adelantado = Convert.ToDecimal(pagoAdelantadoTextBox.Text);
            Decimal descuento = Convert.ToDecimal(descuentoTextBox.Text);
            totalTextBox.Text = ((dias * CalcularTarifa()) - (adelantado + descuento)).ToString();
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
        private void fechaCheckInDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechaCheckOutDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeroDiasTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaReservaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pagoAdelantadoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void habitacionGuna2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idHuesped_FKLabel1_Click(object sender, EventArgs e)
        {

        }

        private void habitacionLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void descuentoLabel_Click(object sender, EventArgs e)
        {

        }

        private void numeroDiasTextBox_Leave(object sender, EventArgs e)
        {
            CalcularCheckOut();
        }

        private void descuentoTextBox_Leave(object sender, EventArgs e)
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
}
