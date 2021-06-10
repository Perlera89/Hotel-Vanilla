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
    public partial class frmSucesos : Form
    {
        Sucesos sucesos = new Sucesos();
        CSucesos cSucesos = new CSucesos();
        public frmSucesos()
        {
            InitializeComponent();
        }

        private void frmSucesos_Load(object sender, EventArgs e)
        {
            sucesosBindingSource.DataSource = cSucesos.ConsultarUltimosSucesos();

            for (var i = 0; i < dtgSucesos.Columns.Count; i++)
            {
                dtgSucesos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            dtgSucesos.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
        }

        private void btnUltimos_Click(object sender, EventArgs e)
        {
            sucesosBindingSource.DataSource = cSucesos.ConsultarUltimosSucesos();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            sucesosBindingSource.DataSource = cSucesos.ConsultarSucesos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sucesosBindingSource.DataSource = cSucesos.BuscarSucesos(txtBuscar.Text);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            sucesosBindingSource.DataSource = cSucesos.ConsultarUltimosSucesos();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sucesosBindingSource.DataSource = cSucesos.BuscarSucesos(txtBuscar.Text);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
            }
        }
    }
}
