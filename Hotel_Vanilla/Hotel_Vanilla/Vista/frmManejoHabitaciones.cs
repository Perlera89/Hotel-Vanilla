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
            if (btnGuardar.Text=="Agregar")
            {
                CspMostrarHabitaciones Chabitacion = new CspMostrarHabitaciones();
                sp_MostrarHabitaciones habitacion =(sp_MostrarHabitaciones) spMostrarHabitacionesBindingSource.Current;
                Chabitacion.AgregarHabitacion(habitacion, Convert.ToInt32(idTipoHabitacion_FKTextBox.Text));
                Limpiar();
            }
            else if (btnGuardar.Text=="Actualizar")
            {
                CspMostrarHabitaciones Chabitacion = new CspMostrarHabitaciones();
                //Habitaciones habitacion = (Habitaciones)habitacionesBindingSource.Current;
                Chabitacion.ActualizarHabitacion(Convert.ToInt32(lblidHabitacion.Text),
                                                numeroHabitacionTextBox.Text,
                                                Convert.ToDecimal(tarifaTextBox.Text),
                                                Convert.ToInt32(idTipoHabitacion_FKTextBox.Text));
                this.Close();
            }
        }

        public Boolean accion = false;
        private void frmManejoHabitaciones_Load(object sender, EventArgs e)
        {
            if (accion==false)
            {
                spMostrarHabitacionesBindingSource.AddNew();
            }
            else
            {
                spMostrarHabitacionesBindingSource.EndEdit();
            }
        }

        public void Limpiar()
        {
            numeroHabitacionTextBox.Clear();
            tarifaTextBox.Clear();
            idTipoHabitacion_FKTextBox.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
