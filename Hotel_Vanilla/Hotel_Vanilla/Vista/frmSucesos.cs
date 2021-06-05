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
        List<Suceso> sucesos = new List<Suceso>();
        public frmSucesos()
        {
            InitializeComponent();
        }

        private void frmSucesos_Load(object sender, EventArgs e)
        {
            //sucesos.Add(new Suceso("1", "Se inserto el registro con Id: 15 del consumidor: Gomez con numero de documento: 8173981-813-1 de la comunidad Agua Caliente", "2021-05-24"));
            //sucesos.Add(new Suceso("1", "Se inserto el registro con Id: 15 del consumidor: Gomez con numero de documento: 8173981-813-1 de la comunidad Agua Caliente", "2021-05-24"));
            //sucesos.Add(new Suceso("1", "Se inserto el registro con Id: 15 del consumidor: Gomez con numero de documento: 8173981-813-1 de la comunidad Agua Caliente", "2021-05-24"));
            //sucesos.Add(new Suceso("1", "Se inserto el registro con Id: 15 del consumidor: Gomez con numero de documento: 8173981-813-1 de la comunidad Agua Caliente", "2021-05-24"));
            //sucesos.Add(new Suceso("1", "Se inserto el registro con Id: 15 del consumidor: Gomez con numero de documento: 8173981-813-1 de la comunidad Agua Caliente", "2021-05-24"));
            //sucesos.Add(new Suceso("1", "Se inserto el registro con Id: 15 del consumidor: Gomez con numero de documento: 8173981-813-1 de la comunidad Agua Caliente", "2021-05-24"));

            //foreach (Suceso suceso in sucesos)
            //{
            //    ListViewItem item = new ListViewItem(suceso.Id);

            //    item.SubItems.Add(suceso.Fecha);
            //    item.SubItems.Add(suceso.Descripcion);
            //    listSuceso.Items.Add(item);
            //}
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
