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
        CSucesos cSucesos = new CSucesos();
        frmInicio inicio = new frmInicio();

        public string Titulo { get; set; }
        public string Mensaje { get; set; }

        public frmHabitaciones()
        {
            InitializeComponent();
        }

        private void CargarHabitaciones()
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

            CargarHabitaciones();
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

            CargarHabitaciones();
        }

        //Accion de eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmMensajeAdvertencia advertencia = new frmMensajeAdvertencia("¿Estas seguro de eliminar el registro?");
            resultado = advertencia.ShowDialog();

            if (dtgHabitaciones.SelectedRows.Count <= 0)
            {
                frmMensajeAviso.Avisar("Elija un registro para ejecutar la acción");
            }

            else if (resultado == DialogResult.OK && dtgHabitaciones.SelectedRows.Count > 0)
            {
                habitaciones.EliminarHabitacion(Convert.ToInt32(dtgHabitaciones.CurrentRow.Cells[0].Value.ToString()));

                frmMensajeExito.Confirmar("Se ha Eliminado correctamente");

                var sucesos = cSucesos.UltimoSuceso();
                foreach (var suceso in sucesos)
                {
                    Titulo = suceso.tipoSuceso;
                    Mensaje = suceso.descripcion;
                }
                inicio.MostrarNotificacion(Titulo, Mensaje, ToolTipIcon.Error);

                CargarHabitaciones();
            }
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            spMostrarHabitacionesBindingSource.DataSource = habitaciones.BuscarHabitaciones(txtBuscar.Text);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarHabitaciones();
            txtBuscar.Text = "Buscar";
            btnActualizar.Focus();

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                spMostrarHabitacionesBindingSource.DataSource = habitaciones.BuscarHabitaciones(txtBuscar.Text);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
            }
        }
    }
}
