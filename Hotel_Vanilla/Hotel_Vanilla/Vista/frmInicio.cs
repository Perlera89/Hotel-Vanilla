using Hotel_Vanilla.CONTROLADOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Hotel_Vanilla.Vista
{
    public partial class frmInicio : Form
    {
        CHuespedes huespedes = new CHuespedes();
        CHabitaciones habitaciones = new CHabitaciones();
        CSucesos cSucesos = new CSucesos();
        public frmInicio()
        {
            InitializeComponent();
        }

        private const int tamanioGrid = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectanguloGrid;

        public string Titulo { get; set; }
        public string Mensaje { get; set; }

        //Metodo para cambiar tamanio
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            //Area cliente del control
            var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));
            //creacion del rectangulo
            rectanguloGrid = new Rectangle(ClientRectangle.Width-tamanioGrid, ClientRectangle.Height-tamanioGrid, tamanioGrid, tamanioGrid);
            //Excluimos tamanio del formulario
            region.Exclude(rectanguloGrid);
            //Indicamos el panel principal
            panelPrincipal.Region = region;
            Invalidate();
        }

        //Metodo para cambiar tamanio
        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areamouse:
                    base.WndProc(ref sms);
                    //Establecemos el punto cliente para el area que se va minimizar
                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
                    //Determinamos si se encuentra el punto en el area
                    if (!rectanguloGrid.Contains(RefPoint))
                    {
                        break;
                    }

                    //iniciamos instancia usando el puntero
                    sms.Result = new IntPtr(botonizquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }

        //Estilos del rectangulo
        protected override void OnPaint(PaintEventArgs e)
        {
            //Establecemos color
            SolidBrush solid = new SolidBrush(System.Drawing.Color.Gold);
            e.Graphics.FillRectangle(solid, rectanguloGrid);    

            //enviamos el color a la base
            base.OnPaint(e);

            ControlPaint.DrawSizeGrip(e.Graphics, System.Drawing.Color.Gold, rectanguloGrid);
        }

        //Maximizar y minimizar
        int lx, ly;
        int sw, sh;

        public void MostrarNotificacion(string titulo, string mensaje, ToolTipIcon icono)
        {
            notificacion.Icon = new Icon(Path.GetFullPath(@"../../Logo.ico"));
            notificacion.Text = "Se han realizado cambios en el sistema";
            notificacion.BalloonTipTitle = titulo;
            notificacion.BalloonTipText = mensaje;
            notificacion.BalloonTipIcon = icono;

            notificacion.Visible = true;
            notificacion.ShowBalloonTip(300);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            var sucesos = cSucesos.UltimoSuceso();
            foreach(var suceso in sucesos)
            {
                Titulo = suceso.tipoSuceso;
                Mensaje = suceso.descripcion;
            }

            MostrarNotificacion(Titulo, Mensaje, ToolTipIcon.Info);
            AbrirFormulario<frmDefault>();
            lblHuespedes.Text = huespedes.TotalHuespedes().ToString();
            lblHabitaciones.Text = habitaciones.TotalHabitaciones().ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            frmMensajeAdvertencia advertencia = new frmMensajeAdvertencia("¿Estas seguro de cerrar el Programa?");
            resultado = advertencia.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //Maximizar
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //Guarda la posicion actual
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            //ocupar toda la pantalla
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnAmpliar.Visible = false;
            btnRestaurar.Visible = true;
        }

        //Restaurar
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);

            btnRestaurar.Visible = false;
            btnAmpliar.Visible = true;
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmReservaciones>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmHuespedes>();
        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmHabitaciones>();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDefault>();
            this.Text = "Hotel Vanilla - Inicio";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelSuperior1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmReservaciones>();
            this.Text = "Hotel Vanilla - Reservaciones";
        }

        private void btnHuespedes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmHuespedes>();
            this.Text = "Hotel Vanilla - Huespedes";
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmHabitaciones>();
            this.Text = "Hotel Vanilla - Habitaciones";
        }

        private void btnSucesos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmSucesos>();
            this.Text = "Hotel Vanilla - Sucesos";
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAjustes>();
            this.Text = "Hotel Vanilla - Ajustes";
        }

        private void notificacion_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
        }

        //Metodo para abrir un nuevo formulario en el contenedor
        private void AbrirFormulario<frmAbrir>() where frmAbrir : Form, new()
        {
            Form formularios;

            //abrimos el formulario en el contenedor
            formularios = panelContenedor.Controls.OfType<frmAbrir>().FirstOrDefault();

            if(formularios == null)
            {
                //abrimos un formulario secundario
                formularios = new frmAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                //agregamos el formulario al panel y lo traemos al frente
                panelContenedor.Controls.Add(formularios);
                panelContenedor.Tag = formularios;
                formularios.Show();

                formularios.BringToFront();
            }
            else
            {
                formularios.BringToFront();
            }
        }
    }
}
