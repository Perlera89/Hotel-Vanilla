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
    public partial class frmManejoHuespedesActualizar : Form
    {
        Huespedes huesped = new Huespedes();
        public frmManejoHuespedesActualizar(Huespedes huesped)
        {
            InitializeComponent();
            this.huesped = huesped;
        }
        void Cargar()
        {
            idHuespedTextBox.Text = huesped.idHuesped.ToString();
            nombresTextBox.Text = huesped.nombres;
            apellidosTextBox.Text = huesped.apellidos;
            direccionTextBox.Text = huesped.direccion;
            telefonoTextBox.Text = huesped.telefono;
            correoTextBox.Text = huesped.correo;
            idEstado_FKTextBox.Text = huesped.idEstado_FK.ToString();
        }

        private void frmManejoHuespedesActualizar_Load(object sender, EventArgs e)
        {
            Cargar();
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            huesped = null;
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            huesped.idHuesped = Convert.ToInt32(idHuespedTextBox.Text);
            huesped.nombres = nombresTextBox.Text;
            huesped.apellidos = apellidosTextBox.Text;
            huesped.direccion = direccionTextBox.Text;
            huesped.telefono = telefonoTextBox.Text;
            huesped.correo = correoTextBox.Text;
            huesped.idEstado_FK = Convert.ToInt32(idEstado_FKTextBox.Text);

            CHuespedes ch = new CHuespedes();
            ch.ModificarHuesped(huesped);
            this.Close();
        }
    }
}
