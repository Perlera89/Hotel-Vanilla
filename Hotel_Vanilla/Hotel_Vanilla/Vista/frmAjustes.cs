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

namespace Hotel_Vanilla.Vista
{
    public partial class frmAjustes : Form
    {
        string Emisor { get; set; }
        string Receptor { get; set; }
        string Asunto { get; set; }
        string Mensaje { get; set; }
        frmInicio inicio = new frmInicio();
        public frmAjustes()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //La cadena "servidor" es el servidor de correo que enviará tu mensaje
            string servidor = "smtp.gmail.com";
            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
            MailMessage mensaje = new MailMessage(
            Emisor = inicio.lblUsuario.Text,
            Receptor = "Manuel Perlera",
            txtAsunto.Text,
            txtMensaje.Text
                );

            //Envía el mensaje.
            SmtpClient cliente = new SmtpClient(servidor);

            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential(Emisor, inicio.lblPass.Text);
            cliente.Port = 587;
            cliente.Host = "manuenitoo@gmail.com";
            cliente.EnableSsl = true;

            //Añade credenciales si el servidor lo requiere.
            //cliente.Credentials = CredentialCache.DefaultNetworkCredentials;
            cliente.Send(mensaje);
        }
    }
}
