
namespace Hotel_Vanilla.Vista
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelSuperior1 = new System.Windows.Forms.Panel();
            this.btnDefault = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnAmpliar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.guna2ResizeBox2 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnSucesos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHabitaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHuespedes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReservaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnPerfil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.panelSuperior1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelContenedor);
            this.panelPrincipal.Controls.Add(this.panelSuperior1);
            this.panelPrincipal.Controls.Add(this.panelInferior);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.MinimumSize = new System.Drawing.Size(960, 480);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1200, 700);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelSuperior1
            // 
            this.panelSuperior1.AllowDrop = true;
            this.panelSuperior1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSuperior1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSuperior1.Controls.Add(this.btnDefault);
            this.panelSuperior1.Controls.Add(this.btnRestaurar);
            this.panelSuperior1.Controls.Add(this.btnAmpliar);
            this.panelSuperior1.Controls.Add(this.btnMinimizar);
            this.panelSuperior1.Controls.Add(this.btnCerrar);
            this.panelSuperior1.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior1.Name = "panelSuperior1";
            this.panelSuperior1.Size = new System.Drawing.Size(1200, 85);
            this.panelSuperior1.TabIndex = 1;
            this.panelSuperior1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior1_MouseDown);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnDefault.Image = global::Hotel_Vanilla.Properties.Resources.casa;
            this.btnDefault.ImageActive = null;
            this.btnDefault.Location = new System.Drawing.Point(237, 12);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(50, 50);
            this.btnDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDefault.TabIndex = 1;
            this.btnDefault.TabStop = false;
            this.btnDefault.Zoom = 10;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestaurar.Image = global::Hotel_Vanilla.Properties.Resources.dentro;
            this.btnRestaurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRestaurar.Location = new System.Drawing.Point(1122, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(36, 41);
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnAmpliar
            // 
            this.btnAmpliar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAmpliar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAmpliar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmpliar.FlatAppearance.BorderSize = 0;
            this.btnAmpliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmpliar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmpliar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAmpliar.Image = global::Hotel_Vanilla.Properties.Resources.fuera;
            this.btnAmpliar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAmpliar.Location = new System.Drawing.Point(1122, 3);
            this.btnAmpliar.Name = "btnAmpliar";
            this.btnAmpliar.Size = new System.Drawing.Size(36, 41);
            this.btnAmpliar.TabIndex = 10;
            this.btnAmpliar.UseVisualStyleBackColor = false;
            this.btnAmpliar.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Image = global::Hotel_Vanilla.Properties.Resources.menos;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(1080, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 33);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = global::Hotel_Vanilla.Properties.Resources.cerrar__1_;
            this.btnCerrar.Location = new System.Drawing.Point(1164, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.Gold;
            this.panelInferior.Controls.Add(this.guna2ResizeBox2);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Enabled = false;
            this.panelInferior.Location = new System.Drawing.Point(0, 620);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1200, 80);
            this.panelInferior.TabIndex = 1;
            // 
            // guna2ResizeBox2
            // 
            this.guna2ResizeBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ResizeBox2.ForeColor = System.Drawing.Color.Empty;
            this.guna2ResizeBox2.Location = new System.Drawing.Point(1168, 48);
            this.guna2ResizeBox2.Name = "guna2ResizeBox2";
            this.guna2ResizeBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2ResizeBox2.TabIndex = 3;
            this.guna2ResizeBox2.TargetControl = this.panelPrincipal;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSideBar.Controls.Add(this.bunifuSeparator2);
            this.panelSideBar.Controls.Add(this.btnSucesos);
            this.panelSideBar.Controls.Add(this.btnHabitaciones);
            this.panelSideBar.Controls.Add(this.btnHuespedes);
            this.panelSideBar.Controls.Add(this.btnReservaciones);
            this.panelSideBar.Controls.Add(this.bunifuSeparator1);
            this.panelSideBar.Controls.Add(this.lblCorreo);
            this.panelSideBar.Controls.Add(this.btnPerfil);
            this.panelSideBar.Controls.Add(this.label2);
            this.panelSideBar.Controls.Add(this.label1);
            this.panelSideBar.Controls.Add(this.btnUsuarios);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(230, 700);
            this.panelSideBar.TabIndex = 1;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 544);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(224, 35);
            this.bunifuSeparator2.TabIndex = 10;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // btnSucesos
            // 
            this.btnSucesos.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnSucesos.BackColor = System.Drawing.Color.White;
            this.btnSucesos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSucesos.BorderRadius = 7;
            this.btnSucesos.ButtonText = "Sucesos";
            this.btnSucesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSucesos.DisabledColor = System.Drawing.Color.Gray;
            this.btnSucesos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSucesos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSucesos.Iconimage = global::Hotel_Vanilla.Properties.Resources.notificacion;
            this.btnSucesos.Iconimage_right = null;
            this.btnSucesos.Iconimage_right_Selected = null;
            this.btnSucesos.Iconimage_Selected = null;
            this.btnSucesos.IconMarginLeft = 0;
            this.btnSucesos.IconMarginRight = 0;
            this.btnSucesos.IconRightVisible = true;
            this.btnSucesos.IconRightZoom = 0D;
            this.btnSucesos.IconVisible = true;
            this.btnSucesos.IconZoom = 90D;
            this.btnSucesos.IsTab = false;
            this.btnSucesos.Location = new System.Drawing.Point(22, 478);
            this.btnSucesos.Name = "btnSucesos";
            this.btnSucesos.Normalcolor = System.Drawing.Color.White;
            this.btnSucesos.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnSucesos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSucesos.selected = false;
            this.btnSucesos.Size = new System.Drawing.Size(192, 48);
            this.btnSucesos.TabIndex = 9;
            this.btnSucesos.Text = "Sucesos";
            this.btnSucesos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSucesos.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnSucesos.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucesos.Click += new System.EventHandler(this.btnSucesos_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnHabitaciones.BackColor = System.Drawing.Color.White;
            this.btnHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHabitaciones.BorderRadius = 7;
            this.btnHabitaciones.ButtonText = "Habitaciones";
            this.btnHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabitaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnHabitaciones.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnHabitaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHabitaciones.Iconimage = global::Hotel_Vanilla.Properties.Resources.habitaciones;
            this.btnHabitaciones.Iconimage_right = null;
            this.btnHabitaciones.Iconimage_right_Selected = null;
            this.btnHabitaciones.Iconimage_Selected = null;
            this.btnHabitaciones.IconMarginLeft = 0;
            this.btnHabitaciones.IconMarginRight = 0;
            this.btnHabitaciones.IconRightVisible = true;
            this.btnHabitaciones.IconRightZoom = 0D;
            this.btnHabitaciones.IconVisible = true;
            this.btnHabitaciones.IconZoom = 90D;
            this.btnHabitaciones.IsTab = false;
            this.btnHabitaciones.Location = new System.Drawing.Point(22, 376);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Normalcolor = System.Drawing.Color.White;
            this.btnHabitaciones.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnHabitaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHabitaciones.selected = false;
            this.btnHabitaciones.Size = new System.Drawing.Size(192, 48);
            this.btnHabitaciones.TabIndex = 8;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHabitaciones.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnHabitaciones.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnHuespedes
            // 
            this.btnHuespedes.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnHuespedes.BackColor = System.Drawing.Color.White;
            this.btnHuespedes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuespedes.BorderRadius = 7;
            this.btnHuespedes.ButtonText = "Huespedes";
            this.btnHuespedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuespedes.DisabledColor = System.Drawing.Color.Gray;
            this.btnHuespedes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnHuespedes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHuespedes.Iconimage = global::Hotel_Vanilla.Properties.Resources.huespedes;
            this.btnHuespedes.Iconimage_right = null;
            this.btnHuespedes.Iconimage_right_Selected = null;
            this.btnHuespedes.Iconimage_Selected = null;
            this.btnHuespedes.IconMarginLeft = 0;
            this.btnHuespedes.IconMarginRight = 0;
            this.btnHuespedes.IconRightVisible = true;
            this.btnHuespedes.IconRightZoom = 0D;
            this.btnHuespedes.IconVisible = true;
            this.btnHuespedes.IconZoom = 90D;
            this.btnHuespedes.IsTab = false;
            this.btnHuespedes.Location = new System.Drawing.Point(22, 279);
            this.btnHuespedes.Name = "btnHuespedes";
            this.btnHuespedes.Normalcolor = System.Drawing.Color.White;
            this.btnHuespedes.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnHuespedes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHuespedes.selected = false;
            this.btnHuespedes.Size = new System.Drawing.Size(192, 48);
            this.btnHuespedes.TabIndex = 7;
            this.btnHuespedes.Text = "Huespedes";
            this.btnHuespedes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuespedes.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnHuespedes.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuespedes.Click += new System.EventHandler(this.btnHuespedes_Click);
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnReservaciones.BackColor = System.Drawing.Color.White;
            this.btnReservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservaciones.BorderRadius = 7;
            this.btnReservaciones.ButtonText = "Reservaciones";
            this.btnReservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnReservaciones.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnReservaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReservaciones.Iconimage = global::Hotel_Vanilla.Properties.Resources.reservas;
            this.btnReservaciones.Iconimage_right = null;
            this.btnReservaciones.Iconimage_right_Selected = null;
            this.btnReservaciones.Iconimage_Selected = null;
            this.btnReservaciones.IconMarginLeft = 0;
            this.btnReservaciones.IconMarginRight = 0;
            this.btnReservaciones.IconRightVisible = true;
            this.btnReservaciones.IconRightZoom = 0D;
            this.btnReservaciones.IconVisible = true;
            this.btnReservaciones.IconZoom = 90D;
            this.btnReservaciones.IsTab = false;
            this.btnReservaciones.Location = new System.Drawing.Point(22, 180);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Normalcolor = System.Drawing.Color.White;
            this.btnReservaciones.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnReservaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReservaciones.selected = false;
            this.btnReservaciones.Size = new System.Drawing.Size(192, 48);
            this.btnReservaciones.TabIndex = 6;
            this.btnReservaciones.Text = "Reservaciones";
            this.btnReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReservaciones.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnReservaciones.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaciones.Click += new System.EventHandler(this.btnReservaciones_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 130);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(224, 35);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(87, 68);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 17);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Text = "Perlera89";
            // 
            // btnPerfil
            // 
            this.btnPerfil.ActiveBorderThickness = 1;
            this.btnPerfil.ActiveCornerRadius = 20;
            this.btnPerfil.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.ActiveForecolor = System.Drawing.Color.White;
            this.btnPerfil.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPerfil.BackgroundImage")));
            this.btnPerfil.ButtonText = "Cambiar cuenta";
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPerfil.IdleBorderThickness = 1;
            this.btnPerfil.IdleCornerRadius = 20;
            this.btnPerfil.IdleFillColor = System.Drawing.Color.White;
            this.btnPerfil.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnPerfil.Location = new System.Drawing.Point(12, 93);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(5);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(202, 41);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perfil";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Image = global::Hotel_Vanilla.Properties.Resources.usuario2;
            this.btnUsuarios.ImageActive = null;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(70, 70);
            this.btnUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.TabStop = false;
            this.btnUsuarios.Zoom = 10;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.panelContenedor;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelContenedor.Location = new System.Drawing.Point(237, 87);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(951, 527);
            this.panelContenedor.TabIndex = 2;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(980, 650);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Vanilla";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelSuperior1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelSuperior1;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelInferior;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnAmpliar;
        private Bunifu.Framework.UI.BunifuImageButton btnDefault;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPerfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnUsuarios;
        public System.Windows.Forms.Label lblCorreo;
        private Bunifu.Framework.UI.BunifuFlatButton btnReservaciones;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSucesos;
        private Bunifu.Framework.UI.BunifuFlatButton btnHabitaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuespedes;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox2;
        private System.Windows.Forms.Panel panelContenedor;
    }
}