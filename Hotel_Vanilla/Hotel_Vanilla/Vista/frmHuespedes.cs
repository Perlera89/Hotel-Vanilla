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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Huespedes huespedes = new Huespedes();
            frmManejoHuespedes frm = new frmManejoHuespedes(/*huespedes*/);
            frm.ShowDialog();

            //huespedesBindingSource.DataSource = null;
            huespedesBindingSource.DataSource = cHuespedes.ConsultarHuespedes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String Id = huespedesDataGridView.CurrentRow.Cells[0].Value.ToString();
            String nombre = huespedesDataGridView.CurrentRow.Cells[1].Value.ToString();
            String apellido = huespedesDataGridView.CurrentRow.Cells[2].Value.ToString();
            String direccion = huespedesDataGridView.CurrentRow.Cells[3].Value.ToString();
            String telefono = huespedesDataGridView.CurrentRow.Cells[4].Value.ToString();
            String correo = huespedesDataGridView.CurrentRow.Cells[5].Value.ToString();
            String IdEstadoFk = huespedesDataGridView.CurrentRow.Cells[6].Value.ToString();

            int id = 0;
            int IdEstadoFk1 = 0;

            id = Convert.ToInt32(Id);
            IdEstadoFk1 = Convert.ToInt32(IdEstadoFk);

            //Huespedes huespedes = new Huespedes();
            //huespedes.idHuesped = id;
            //huespedes.nombres = nombre;
            //huespedes.apellidos = apellido;
            //huespedes.direccion = direccion;
            //huespedes.telefono = telefono;
            //huespedes.correo = correo;
            //huespedes.idEstado_FK = IdEstadoFk1;

            frmManejoHuespedes frm = new frmManejoHuespedes(/*huespedes*/);
            frm.idHuespedTextBox.Text = id.ToString();
            frm.nombresTextBox.Text = nombre;
            frm.apellidosTextBox.Text = apellido;
            frm.direccionTextBox.Text = direccion;
            frm.telefonoTextBox.Text = telefono;
            frm.correoTextBox.Text = correo;
            frm.idEstado_FKTextBox.Text = IdEstadoFk1.ToString();
            frm.btnGuardar.Text = "Actualizar";
            frm.accion = true;
            frm.ShowDialog();

            huespedesBindingSource.DataSource = null;
            huespedesBindingSource.DataSource = cHuespedes.ConsultarHuespedes();
        }

        CHuespedes cHuespedes = new CHuespedes();
        private void frmHuespedes_Load(object sender, EventArgs e)
        {
            huespedesBindingSource.DataSource = cHuespedes.ConsultarHuespedes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String idS = huespedesDataGridView.CurrentRow.Cells[0].Value.ToString();
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
