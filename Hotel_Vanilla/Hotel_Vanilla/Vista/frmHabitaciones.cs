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
        CHabitaciones habitaciones = new CHabitaciones();

        public frmHabitaciones()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            CHabitaciones cspMostrar = new CHabitaciones();
            spMostrarHabitacionesBindingSource.DataSource = null;
            spMostrarHabitacionesBindingSource.DataSource = cspMostrar.ConsultarHabitacion();
        }


        //Accion de ingresar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmManejoHabitaciones manejoHabitacion = new frmManejoHabitaciones();
            manejoHabitacion.btnGuardar.Text = "Agregar";
            manejoHabitacion.ShowDialog();

            Cargar();
        }


        //Accion de actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmManejoHabitaciones manejoHabitacion = new frmManejoHabitaciones();
            manejoHabitacion.lblidHabitacion.Text = dtgHabitaciones.CurrentRow.Cells[0].Value.ToString();
            manejoHabitacion.numeroHabitacionTextBox.Text = dtgHabitaciones.CurrentRow.Cells[1].Value.ToString();
            manejoHabitacion.tarifaTextBox.Text = dtgHabitaciones.CurrentRow.Cells[2].Value.ToString();
            manejoHabitacion.tipoHabitacion = dtgHabitaciones.CurrentRow.Cells[3].Value.ToString();
            manejoHabitacion.btnGuardar.Text = "Actualizar";
            manejoHabitacion.accion = true;
            manejoHabitacion.ShowDialog();

            Cargar();
        }

        //Accion de eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmMensajeAdvertencia advertencia = new frmMensajeAdvertencia("¿Estas seguro de eliminar el registro?");
            resultado = advertencia.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                
                if (dtgHabitaciones.SelectedRows.Count > 0)
                {
                    habitaciones.EliminarHabitacion(Convert.ToInt32(dtgHabitaciones.CurrentRow.Cells[0].Value.ToString()));
                    Cargar();
                }

                else
                {
                    frmMensajeAviso.Avisar("Elija un registro para ejecutar la acción");
                }
            }
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
