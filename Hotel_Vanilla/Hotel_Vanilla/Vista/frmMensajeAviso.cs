using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Vanilla.Vista
{
    public partial class frmMensajeAviso : Form
    {
        public frmMensajeAviso(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        public static void Avisar(string mensaje)
        {
            frmMensajeAviso frm = new frmMensajeAviso(mensaje);
            frm.ShowDialog();
        }

        private void frmMensajeAviso_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
