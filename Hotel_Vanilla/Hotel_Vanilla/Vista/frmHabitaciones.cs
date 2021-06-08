using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Vanilla.CONTROLADOR;

namespace Hotel_Vanilla.Vista
{
    public partial class frmHabitaciones : Form
    {
        CspMostrarHabitaciones habitaciones = new CspMostrarHabitaciones();
        public frmHabitaciones()
        {
            InitializeComponent();
            Clean();
        }

        private void Clean()
        {

        }
        private void Cargar()
        {
            CspMostrarHabitaciones cspMostrar = new CspMostrarHabitaciones();
            spMostrarHabitacionesBindingSource.DataSource = null;
            spMostrarHabitacionesBindingSource.DataSource = cspMostrar.ConsultarHuespedes();
        }

        private void Buscar()
        {

        }


        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmManejoHabitaciones habitacion = new frmManejoHabitaciones();
            habitacion.btnGuardar.Text = "Agregar";
            habitacion.ShowDialog();

            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            habitaciones.EliminarHabitacion(Convert.ToInt32(dtgHabitaciones.CurrentRow.Cells[0].Value.ToString()));
            Cargar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmManejoHabitaciones habitacion = new frmManejoHabitaciones();
            habitacion.lblidHabitacion.Text = dtgHabitaciones.CurrentRow.Cells[0].Value.ToString();
            habitacion.numeroHabitacionTextBox.Text = dtgHabitaciones.CurrentRow.Cells[1].Value.ToString();
            habitacion.tarifaTextBox.Text = dtgHabitaciones.CurrentRow.Cells[2].Value.ToString();
            habitacion.idTipoHabitacion_FKTextBox.Text = dtgHabitaciones.CurrentRow.Cells[3].Value.ToString();
            habitacion.btnGuardar.Text = "Actualizar";
            habitacion.accion = true;
            habitacion.ShowDialog();

            Cargar();
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
