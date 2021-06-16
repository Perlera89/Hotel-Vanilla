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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        public Usuarios usuarios = new Usuarios();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Crimson;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.RoyalBlue;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void chkClave_OnChange(object sender, EventArgs e)
        {
            if (chkClave.Checked == true)
                claveTextBox.UseSystemPasswordChar = false;
            else
                claveTextBox.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try {
                if (nombreTextBox.Text.Equals("") || correoTextBox.Text.Equals("") || claveTextBox.Text.Equals(""))
                {
                    frmMensajeAviso.Avisar("Debe llenar todos los campos");
                }
                else { 
                    Usuarios usu = new Usuarios();
                    CUsuarios cUsu = new CUsuarios();

                    usuariosBindingSource.EndEdit();
                    usu = (Usuarios)usuariosBindingSource.Current;

                    cUsu.AgregarUsuario(usu);
                    frmMensajeExito.Confirmar("Usuario registrado");

                    this.Close();
                
                }
            }

            catch (Exception ex) {
                frmMensajeAviso.Avisar("Ya existe un usuario con ese correo");
            }
        }

        private void correoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            usuariosBindingSource.AddNew();
        }

        private void claveTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (nombreTextBox.Text.Equals("") || correoTextBox.Text.Equals("") || claveTextBox.Text.Equals(""))
                    {
                        frmMensajeAviso.Avisar("Debe llenar todos los campos");
                    }
                    else
                    {
                        Usuarios usu = new Usuarios();
                        CUsuarios cUsu = new CUsuarios();

                        usuariosBindingSource.EndEdit();
                        usu = (Usuarios)usuariosBindingSource.Current;

                        cUsu.AgregarUsuario(usu);
                        frmMensajeExito.Confirmar("Usuario registrado");

                        this.Close();

                    }
                }

                catch (Exception ex)
                {
                    frmMensajeAviso.Avisar("Ya existe un usuario con ese correo");
                }
            }
        }
    }
}
