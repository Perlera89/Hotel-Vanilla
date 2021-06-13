using Dapper;
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
    public partial class frmManejoHuespedes : Form
    {
        frmInicio inicio = new frmInicio();
        CSucesos cSucesos = new CSucesos();
        public string Titulo { get; set; }
        public string Mensaje { get; set; }
        public Boolean accion = false;
        public string Estado { get; set; }

        Huespedes huesped = new Huespedes();

        public frmManejoHuespedes()
        {
            InitializeComponent();
        }

        private void RellenarComboBox()
        {
            cbEstado.Text = Estado;
        }

        private void CargarEstados()
        {
            IDbConnection conexion = Conexion.conectar();
            List<Estados> estados = new List<Estados>();
            string consulta = "select * from Estados";
            conexion.Open();
            estados = conexion.Query<Estados>(consulta, commandType: CommandType.Text).ToList();
            conexion.Close();

            cbEstado.DataSource = estados;
            cbEstado.DisplayMember = "nombreEstado";
            cbEstado.ValueMember = "idEstado";
            //cbIdHuesped.SelectedIndex = 1;
        }

        public void cargarControles()
        {
            idHuesped.Text = huesped.idHuesped.ToString();
            txtNombres.Text = huesped.nombres;
            txtApellidos.Text = huesped.apellidos;
            txtDireccion.Text = huesped.direccion;
            txtTelefono.Text = huesped.telefono;
            txtCorreo.Text = huesped.correo;
            cbEstado.Text = huesped.idEstado_FK.ToString();
        }

        public void Limpiar()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text.Equals("Actualizar"))
            {
                huesped.idHuesped = Convert.ToInt32(idHuesped.Text);
                huesped.nombres = txtNombres.Text;
                huesped.apellidos = txtApellidos.Text;
                huesped.direccion = txtDireccion.Text;
                huesped.telefono = txtTelefono.Text;
                huesped.correo = txtCorreo.Text;
                huesped.idEstado_FK = Convert.ToInt32(cbEstado.SelectedValue.ToString());

                CHuespedes ch = new CHuespedes();
                ch.ModificarHuesped(huesped);

                Limpiar();
                txtNombres.Focus();

                frmMensajeExito.Confirmar("Se ha Actualizado correctamente");

                var sucesos = cSucesos.UltimoSuceso();
                foreach (var suceso in sucesos)
                {
                    Titulo = suceso.tipoSuceso;
                    Mensaje = suceso.descripcion;
                }

                inicio.MostrarNotificacion(Titulo, Mensaje, ToolTipIcon.Warning);
            }

            else if (btnGuardar.Text.Equals("Guardar"))
            {
                CHuespedes cHuespedes = new CHuespedes();
                Huespedes huespedes = new Huespedes();

                huespedes.nombres = txtNombres.Text;
                huespedes.apellidos = txtApellidos.Text;
                huespedes.direccion = txtDireccion.Text;
                huespedes.telefono = txtTelefono.Text;
                huespedes.correo = txtCorreo.Text;
                huespedes.idEstado_FK = Convert.ToInt32(cbEstado.SelectedValue.ToString());

                cHuespedes.AgregarHuesped(huespedes);


                frmMensajeExito.Confirmar("Se ha Ingresado correctamente");

                var sucesos = cSucesos.UltimoSuceso();
                foreach (var suceso in sucesos)
                {
                    Titulo = suceso.tipoSuceso;
                    Mensaje = suceso.descripcion;
                }

                inicio.MostrarNotificacion(Titulo, Mensaje, ToolTipIcon.Info);

                Limpiar();
                txtNombres.Focus();
                inicio.lblHuespedes.Text = cHuespedes.TotalHuespedes().ToString();
            }
        }

        private void frmManejoHuespedes_Load(object sender, EventArgs e)
        {
            txtNombres.Focus();
            CargarEstados();
            RellenarComboBox();
            if (accion == false)
            {
                huespedesBindingSource.AddNew();
            }

            else
            {
                huespedesBindingSource.EndEdit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            huesped = null;
            this.Close();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void SoloNumeros(KeyPressEventArgs k)
        {
            if (char.IsDigit(k.KeyChar))
            {
                k.Handled = false;
            }

            else if (char.IsSeparator(k.KeyChar))
            {
                k.Handled = false;
            }

            else if (char.IsControl(k.KeyChar))
            {
                k.Handled = false;
            }

            else if (k.KeyChar.ToString().Equals("-"))
            {
                k.Handled = false;
            }

            else
                k.Handled = true;
        }
    }
}
