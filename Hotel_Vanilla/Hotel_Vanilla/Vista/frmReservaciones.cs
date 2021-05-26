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
    public partial class frmReservaciones : Form
    {
        frmManejoReservas reserva = new frmManejoReservas();
        public frmReservaciones()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            reserva.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            reserva.ShowDialog();
        }
    }
}
