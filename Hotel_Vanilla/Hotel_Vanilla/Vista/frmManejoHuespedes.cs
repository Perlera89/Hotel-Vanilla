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
    public partial class frmManejoHuespedes : Form
    {

        public frmManejoHuespedes(/*Huespedes huesped*/)
        {
            InitializeComponent();
            //this.huesped = huesped;
        }

        Huespedes huesped = new Huespedes();
        void cargarControles()
        {
            idHuespedTextBox.Text = huesped.idHuesped.ToString();
            nombresTextBox.Text = huesped.nombres;
            apellidosTextBox.Text = huesped.apellidos;
            direccionTextBox.Text = huesped.direccion;
            telefonoTextBox.Text = huesped.telefono;
            correoTextBox.Text = huesped.correo;
            idEstado_FKTextBox.Text = huesped.idEstado_FK.ToString();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text.Equals("Actualizar"))
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
            else if (btnGuardar.Text.Equals("Guardar"))
            {
                CHuespedes cHuespedes = new CHuespedes();
                Huespedes huespedes = new Huespedes();
                huespedesBindingSource.EndEdit();
                huespedes = (Huespedes)huespedesBindingSource.Current;

                cHuespedes.AgregarHuesped(huespedes);
                this.Close();
            }
        }
        public Boolean accion = false;

        private void frmManejoHuespedes_Load(object sender, EventArgs e)
        {
            if (accion == false)
            {
                huespedesBindingSource.AddNew();
            }
            else
            {
                huespedesBindingSource.EndEdit();
            }
            //cargarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            huesped = null;
            this.Close();
        }
    }
}
