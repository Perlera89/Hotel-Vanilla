using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Hotel_Vanilla.CONTROLADOR;
using Hotel_Vanilla.ENTIDAD;

namespace Hotel_Vanilla.Vista
{
    public partial class frmAjustes : Form
    {
        public int IdUsuario { get; set; }

        frmInicio inicio = new frmInicio();
        CEstados cEstados = new CEstados();
        CTipoHabitaciones cTipoH = new CTipoHabitaciones();
        CUsuarios cUsuarios = new CUsuarios();

        public frmAjustes()
        {
            InitializeComponent();
        }

        private void txtMensaje_Enter(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "Mensaje")
                txtMensaje.Text = "";
        }

        private void txtMensaje_Leave(object sender, EventArgs e)
        {
            if (txtMensaje.Text == "")
                txtMensaje.Text = "Mensaje";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
            MailMessage mensaje = new MailMessage();

            mensaje.To.Add("manuenitoo@gmail.com");
            mensaje.Subject = txtAsunto.Text;
            mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            mensaje.Bcc.Add(frmInicio.Correo);
            mensaje.Body = txtMensaje.Text;
            mensaje.BodyEncoding = System.Text.Encoding.UTF8;
            mensaje.IsBodyHtml = true;
            mensaje.From = new MailAddress(frmInicio.Correo);

            //Envía el mensaje.
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential(frmInicio.Correo, frmInicio.Pass);
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

                cliente.Send(mensaje);
                frmMensajeExito.Confirmar("El mensaje se ha enviado con exito");
            }

            catch (Exception)
            {
                frmMensajeAviso.Avisar("Error al enviar");
            }
        }

        private void frmAjustes_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = frmInicio.Usuario;
            txtPass.Text = frmInicio.Pass;
            txtEmail.Text = frmInicio.Correo;
            CargarEstados();
            CargarTipoHabitaciones();
        }

        public void CargarEstados()
        {
            estadosBindingSource.DataSource = cEstados.MostrarEstados();
        }

        public void CargarTipoHabitaciones()
        {
            sp_MostrarTipoHabitacionesBindingSource.DataSource = cTipoH.MostrarTipoHabitaciones() ;
        }

        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            CEstados cEstado = new CEstados();
            Estados estado = new Estados();

            estado.nombreEstado = txtEstado.Text;
            cEstado.AgregarEstado(estado);

            frmMensajeExito.Confirmar("Se ha Ingresado correctamente");
            CargarEstados();
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            CTipoHabitaciones cTipoHabitacion = new CTipoHabitaciones();
            sp_MostrarTipoHabitaciones tipoHabitacion = new sp_MostrarTipoHabitaciones();

            tipoHabitacion.tipo = txtTipo.Text;
            tipoHabitacion.numeroOcupantes = Convert.ToInt32(txtOcupantes.Value);
            cTipoHabitacion.AgregarTipoHabitacion(tipoHabitacion);

            frmMensajeExito.Confirmar("Se ha Ingresado correctamente");
            CargarTipoHabitaciones();
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {

            DialogResult resultado = new DialogResult();
            frmMensajeAdvertencia advertencia = new frmMensajeAdvertencia("¿Estas seguro de eliminar el registro?");
            resultado = advertencia.ShowDialog();


            if (dtgEstados.SelectedRows.Count <= 0)
            {
                frmMensajeAviso.Avisar("Elija un registro para ejecutar la acción");
            }

            else if (resultado == DialogResult.OK && dtgEstados.SelectedRows.Count > 0)
            {
                CEstados cEstado = new CEstados();
                Estados estado = new Estados();

                estado.idEstado = Convert.ToInt32(dtgEstados.CurrentRow.Cells[0].Value.ToString());
                cEstado.EliminarEstado(estado);

                frmMensajeExito.Confirmar("Se ha Eliminado correctamente");
                CargarEstados();
            }
        }

        private void btnEliminarTipo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmMensajeAdvertencia advertencia = new frmMensajeAdvertencia("¿Estas seguro de eliminar el registro?");
            resultado = advertencia.ShowDialog();


            if (dtgTipoHabitaciones.SelectedRows.Count <= 0)
            {
                frmMensajeAviso.Avisar("Elija un registro para ejecutar la acción");
            }

            else if (resultado == DialogResult.OK && dtgTipoHabitaciones.SelectedRows.Count > 0)
            {
                CTipoHabitaciones cTipoHabitacion = new CTipoHabitaciones();
                sp_MostrarTipoHabitaciones tipoHabitacion = new sp_MostrarTipoHabitaciones();

                tipoHabitacion.idTipoHabitacion = Convert.ToInt32(dtgTipoHabitaciones.CurrentRow.Cells[0].Value.ToString());
                cTipoHabitacion.EliminarTipoHabitacion(tipoHabitacion);

                frmMensajeExito.Confirmar("Se ha Eliminado correctamente");
                CargarTipoHabitaciones();
            }
        }
    }
}
