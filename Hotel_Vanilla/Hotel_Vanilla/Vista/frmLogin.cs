using Hotel_Vanilla.CONTROLADOR;
using Hotel_Vanilla.ENTIDAD;
using Hotel_Vanilla.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Vanilla
{
    //falta desarrollar el MDI
    public partial class Form1 : Form
    {
        frmInicio inicio = new frmInicio();
        public Form1()
        {
            //Creamos un hilo
            Thread t = new Thread(new ThreadStart(SplashStart));

            //Arranca el hilo
            t.Start();

            //Ponemos a dormir la forma principal
            Thread.Sleep(5800);

            InitializeComponent();

            //Finalizamos el hilo
            t.Abort();
        }
        
        public void SplashStart()
        {
              Application.Run(new frmSplash());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmMensajeAdvertencia advertencia = new frmMensajeAdvertencia("¿Estas seguro de cerrar el Programa?");
            resultado = advertencia.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister registro = new frmRegister();
            registro.ShowDialog();
        }

        private void chkClave_OnChange(object sender, EventArgs e)
        {
            if (chkClave.Checked == true)
                claveTextBox.UseSystemPasswordChar = false;
            else
                claveTextBox.UseSystemPasswordChar = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            usuariosBindingSource.AddNew();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuarios usu;
            CUsuarios cUsuarios = new CUsuarios();
            usuariosBindingSource.EndEdit();

            usu = (Usuarios)usuariosBindingSource.Current;

            usuariosBindingSource.DataSource = cUsuarios.CompararDatos(usu);
            usu = (Usuarios)usuariosBindingSource.Current;

            if (usu != null)
            {
                frmInicio frm = new frmInicio();
                MessageBox.Show("Bienvenida/o");

                frm.lblUsuario.Text = usu.nombre;
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
                usuariosBindingSource.AddNew();
            }
        }

        private void claveTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inicio.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }  
    } 
}
