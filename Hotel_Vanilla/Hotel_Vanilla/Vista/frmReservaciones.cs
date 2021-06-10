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
    public partial class frmReservaciones : Form
    {

        CManejoReservas cReservas = new CManejoReservas();

        public frmReservaciones()
        {
            InitializeComponent();
        }

        //Accion de mostrar
        private void CargarReservas()
        {
            this.sp_MostrarManejoReservasTableAdapter.ClearBeforeFill = true;
            this.sp_MostrarManejoReservasTableAdapter.Fill(this.vanillaBDDataSet1.sp_MostrarManejoReservas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmManejoReservas reserva = new frmManejoReservas();
            reserva.ShowDialog();

            CargarReservas();
        }

        //Accion de actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //se verifica que haya seleccionado un registro
            if (dtgReservas.SelectedRows.Count > 0)
            {
                frmManejoReservas reserva = new frmManejoReservas();
                reserva.txtIdReserva.Text = dtgReservas.CurrentRow.Cells[0].Value.ToString();
                reserva.txtFechaReserva.Text = dtgReservas.CurrentRow.Cells[4].Value.ToString();
                reserva.txtFechaCheckIn.Text = dtgReservas.CurrentRow.Cells[5].Value.ToString();
                reserva.txtFechaCheckOut.Text = dtgReservas.CurrentRow.Cells[6].Value.ToString();
                reserva.txtDiasAlojamiento.Text = dtgReservas.CurrentRow.Cells[7].Value.ToString();
                reserva.txtPagoAdelantado.Text = dtgReservas.CurrentRow.Cells[9].Value.ToString();
                reserva.txtDescuento.Text = dtgReservas.CurrentRow.Cells[11].Value.ToString();
                reserva.txtTotal.Text = dtgReservas.CurrentRow.Cells[12].Value.ToString();
                reserva.habitacion = dtgReservas.CurrentRow.Cells[3].Value.ToString();
                reserva.huesped = dtgReservas.CurrentRow.Cells[1].Value.ToString();

                reserva.btnGuardar.Text = "Actualizar";
                reserva.txtFechaCheckOut.Visible = true;
                reserva.lblCheckOut.Visible = true;
                reserva.accion = true;
                reserva.ShowDialog();

                CargarReservas();
            }

            else
            {
                frmMensajeAviso.Avisar("Seleccione un registro para ejecutar la acción");
            }
        }

        private void frmReservaciones_Load(object sender, EventArgs e)
        {
            this.sp_MostrarManejoReservasTableAdapter.Fill(this.vanillaBDDataSet1.sp_MostrarManejoReservas);
            for (var i = 0; i < dtgReservas.Columns.Count; i++)
            {
                dtgReservas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            dtgReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
        }

        //Accion de eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmMensajeAdvertencia advertencia = new frmMensajeAdvertencia("¿Estas seguro de eliminar el registro?");
            resultado = advertencia.ShowDialog();

            //se verifica que haya seleccionado un registro
            if(dtgReservas.SelectedRows.Count <= 0)
            {
                frmMensajeAviso.Avisar("Seleccione un registro para ejecutar la acción");
            }

            else if (resultado == DialogResult.OK && dtgReservas.SelectedRows.Count > 0)
            {
                CManejoReservas cReserva = new CManejoReservas();
                ManejoReservas Dreservas = new ManejoReservas();
                //tomando los datos actuales de bindin y asignandolo al objeto de ManejoReservas
                Dreservas.idReserva = Convert.ToInt32(dtgReservas.CurrentRow.Cells[0].Value.ToString());
                //mandando el objeto reservas como parametro al metodo de agrregar reserva
                cReserva.EliminarReserva(Dreservas);
                CargarReservas();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sp_MostrarManejoReservasBindingSource1.DataSource = cReservas.BuscarReservaciones(txtBuscar.Text);
        }
    }
}
