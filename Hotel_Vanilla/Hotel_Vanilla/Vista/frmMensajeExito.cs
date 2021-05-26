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
    public partial class frmMensajeExito : Form
    {
        public frmMensajeExito(string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
        }

        private void frmMensajeExito_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        public static void Confirmar(string mensaje)
        {
            frmMensajeExito frm = new frmMensajeExito(mensaje);
            frm.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
