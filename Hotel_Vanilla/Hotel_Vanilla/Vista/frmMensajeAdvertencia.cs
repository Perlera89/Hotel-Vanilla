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
    public partial class frmMensajeAdvertencia : Form
    {
        public frmMensajeAdvertencia(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        public static void Advertir(string mensaje)
        {
            frmMensajeAdvertencia frm = new frmMensajeAdvertencia(mensaje);
            frm.ShowDialog();
        }

        private void frmMensajeAdvertencia_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
