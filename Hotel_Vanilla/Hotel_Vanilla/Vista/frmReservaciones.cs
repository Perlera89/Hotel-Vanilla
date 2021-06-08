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
        frmManejoReservas reserva = new frmManejoReservas();
        public frmReservaciones()
        {
            InitializeComponent();
            Clean();
        }

        private void Clean()
        {
        }


        //mostrar
        private void CargarReservas()
        {
            this.sp_MostrarManejoReservasTableAdapter.ClearBeforeFill = true;
            // TODO: esta línea de código carga datos en la tabla 'vanillaBDDataSet1.sp_MostrarManejoReservas' Puede moverla o quitarla según sea necesario.
            this.sp_MostrarManejoReservasTableAdapter.Fill(this.vanillaBDDataSet1.sp_MostrarManejoReservas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            reserva.ShowDialog();

            CargarReservas();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmManejoReservas reserva = new frmManejoReservas();
            reserva.idReservaTextBox1.Text = dtgReservas.CurrentRow.Cells[0].Value.ToString();
            reserva.fechaReservaDateTimePicker.Text = dtgReservas.CurrentRow.Cells[4].Value.ToString();
            reserva.fechaCheckInDateTimePicker.Text = dtgReservas.CurrentRow.Cells[5].Value.ToString();
            reserva.fechaCheckOutDateTimePicker.Text = dtgReservas.CurrentRow.Cells[6].Value.ToString();
            reserva.numeroDiasTextBox.Text = dtgReservas.CurrentRow.Cells[7].Value.ToString();
            reserva.pagoAdelantadoTextBox.Text = dtgReservas.CurrentRow.Cells[9].Value.ToString();
            reserva.descuentoTextBox.Text = dtgReservas.CurrentRow.Cells[11].Value.ToString();
            reserva.totalTextBox.Text = dtgReservas.CurrentRow.Cells[12].Value.ToString();
            reserva.habitacion = dtgReservas.CurrentRow.Cells[3].Value.ToString();
            reserva.huesped = dtgReservas.CurrentRow.Cells[1].Value.ToString();

            reserva.btnGuardar.Text = "Actualizar";
            reserva.fechaCheckOutDateTimePicker.Visible =true;
            reserva.lblCheckOut.Visible = true;
            reserva.accion = true;
            reserva.ShowDialog();

            CargarReservas();
        }

        private void frmReservaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vanillaBDDataSet1.sp_MostrarManejoReservas' Puede moverla o quitarla según sea necesario.
            this.sp_MostrarManejoReservasTableAdapter.Fill(this.vanillaBDDataSet1.sp_MostrarManejoReservas);
            for (var i = 0; i < dtgReservas.Columns.Count; i++)
            {
                dtgReservas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dtgReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
}
