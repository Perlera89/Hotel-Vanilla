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
    public partial class frmUsuarios : Form
    {
        frmManejoUsuarios usuario = new frmManejoUsuarios();
        public frmUsuarios()
        {
            InitializeComponent();
            Cargar();
            Clean();
        }

        private void Clean()
        {

        }
        private void Cargar()
        {

        }

        private void Buscar()
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            usuario.ShowDialog();
        }
    }
}
