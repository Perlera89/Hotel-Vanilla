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
    public partial class frmHuespedes : Form
    {
        public frmHuespedes()
        {
            InitializeComponent();
        }

        CHuespedes cHuespedes = new CHuespedes();
        Huespedes huespedes = new Huespedes();

        private void Cargar()
        {
            CHuespedes cHuespedesMostrar = new CHuespedes();
            spMostrarHuespedBindingSource.DataSource = null;
            spMostrarHuespedBindingSource.DataSource = cHuespedesMostrar.ConsultarHuespedes();
        }

        private void frmHuespedes_Load(object sender, EventArgs e)
        {
            Cargar();
            dtgHuespedes.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
        }

        //Accion de agregar
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmManejoHuespedes frm = new frmManejoHuespedes();
            frm.cajaId.Visible = false;
            frm.lblId.Visible = false;
            frm.idHuesped.Visible = false;
            frm.ShowDialog();
            Cargar();
        }

        //Accion de actualizar
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            frmManejoHuespedes manejoHuesped = new frmManejoHuespedes();
            manejoHuesped.idHuesped.Text = dtgHuespedes.CurrentRow.Cells[0].Value.ToString();
            manejoHuesped.nombresTextBox.Text = dtgHuespedes.CurrentRow.Cells[1].Value.ToString();
            manejoHuesped.apellidosTextBox.Text = dtgHuespedes.CurrentRow.Cells[2].Value.ToString();
            manejoHuesped.direccionTextBox.Text = dtgHuespedes.CurrentRow.Cells[3].Value.ToString();
            manejoHuesped.telefonoTextBox.Text = dtgHuespedes.CurrentRow.Cells[4].Value.ToString();
            manejoHuesped.correoTextBox.Text = dtgHuespedes.CurrentRow.Cells[5].Value.ToString();
            manejoHuesped.idEstado_FKTextBox.Text = dtgHuespedes.CurrentRow.Cells[6].Value.ToString();
            manejoHuesped.btnGuardar.Text = "Actualizar";
            manejoHuesped.accion = true;
            manejoHuesped.ShowDialog();
            Cargar();
        }

        //Accion de eliminar
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmMensajeAdvertencia advertencia = new frmMensajeAdvertencia("¿Estas seguro de eliminar el registro?");
            resultado = advertencia.ShowDialog();

            if (resultado == DialogResult.OK && dtgHuespedes.SelectedRows.Count > 0)
            {
                int huesped = Convert.ToInt32(dtgHuespedes.CurrentRow.Cells[0].Value.ToString());
                 cHuespedes.EliminarHuesped(huesped);
            }

            else
            {
                frmMensajeAviso.Avisar("Elija un registro para ejecutar la acción");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            spMostrarHuespedBindingSource.DataSource = cHuespedes.BuscarHuespedes(txtBuscar.Text);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            spMostrarHuespedBindingSource.DataSource = cHuespedes.ConsultarHuespedes();
            txtBuscar.Text = "Buscar";
            btnActualizar.Focus();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                spMostrarHuespedBindingSource.DataSource = cHuespedes.BuscarHuespedes(txtBuscar.Text);
            }
        }
    }
}
