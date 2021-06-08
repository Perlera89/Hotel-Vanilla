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
    }

    public class Suceso
    {
        public string Id { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }

        public Suceso(string id, string fecha, string descripcion)
        {
            Id = id;
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }
}
