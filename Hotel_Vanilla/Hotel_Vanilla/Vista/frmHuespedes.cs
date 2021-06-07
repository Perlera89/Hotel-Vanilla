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
        CHuespedes cHuespede = new CHuespedes();
        public frmHuespedes()
        {
            InitializeComponent();

        }

        private void Clean()
        {

        }
        void Cargar()
        {

        }

        private void Buscar()
        {

        }

        CHuespedes cHuespedes = new CHuespedes();
        private void frmHuespedes_Load(object sender, EventArgs e)
        {
            huespedesBindingSource.DataSource = cHuespedes.ConsultarHuespedes();

            //for (var i = 0; i < dtgHuespedes.Columns.Count; i++)
            //{
            //    dtgHuespedes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}

            huespedesGuna2DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Huespedes huespedes = new Huespedes();
            frmManejoHuespedes frm = new frmManejoHuespedes(/*huespedes*/);
            frm.cajaId.Visible = false;
            frm.lblId.Visible = false;
            frm.idHuesped.Visible = false;
            frm.ShowDialog();

            //huespedesBindingSource.DataSource = null;
            huespedesBindingSource.DataSource = cHuespedes.ConsultarHuespedes();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            String Id = huespedesGuna2DataGridView.CurrentRow.Cells[0].Value.ToString();
            String nombre = huespedesGuna2DataGridView.CurrentRow.Cells[1].Value.ToString();
            String apellido = huespedesGuna2DataGridView.CurrentRow.Cells[2].Value.ToString();
            String direccion = huespedesGuna2DataGridView.CurrentRow.Cells[3].Value.ToString();
            String telefono = huespedesGuna2DataGridView.CurrentRow.Cells[4].Value.ToString();
            String correo = huespedesGuna2DataGridView.CurrentRow.Cells[5].Value.ToString();
            String IdEstadoFk = huespedesGuna2DataGridView.CurrentRow.Cells[6].Value.ToString();

            int id = 0;
            int idEstado = 0;

            id = Convert.ToInt32(Id);
            idEstado = Convert.ToInt32(IdEstadoFk);

            frmManejoHuespedes frm = new frmManejoHuespedes(/*huespedes*/);
            frm.idHuesped.Text = id.ToString();
            frm.nombresTextBox.Text = nombre;
            frm.apellidosTextBox.Text = apellido;
            frm.direccionTextBox.Text = direccion;
            frm.telefonoTextBox.Text = telefono;
            frm.correoTextBox.Text = correo;
            frm.idEstado_FKTextBox.Text = idEstado.ToString();
            frm.btnGuardar.Text = "Actualizar";
            frm.accion = true;
            frm.ShowDialog();

            huespedesBindingSource.DataSource = null;
            huespedesBindingSource.DataSource = cHuespedes.ConsultarHuespedes();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            String idS = huespedesGuna2DataGridView.CurrentRow.Cells[0].Value.ToString();
            int id = 0;

            id = Convert.ToInt32(idS);

            CHuespedes ch = new CHuespedes();
            Huespedes huespedes = new Huespedes();

            huespedes.idHuesped = id;

            ch.EliminarHuesped(huespedes);

            huespedesBindingSource.DataSource = null;
            huespedesBindingSource.DataSource = cHuespedes.ConsultarHuespedes();
        }
    }
}
