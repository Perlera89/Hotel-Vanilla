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
    public partial class frmHabitaciones : Form
    {
        frmManejoHabitaciones habitacion = new frmManejoHabitaciones();
        public frmHabitaciones()
        {
            InitializeComponent();
            Clean();
            Cargar();
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


        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            habitacion.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            habitacion.ShowDialog();
        }
    }
}
