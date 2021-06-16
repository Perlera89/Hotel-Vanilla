
namespace Hotel_Vanilla.Vista
{
    partial class frmAjustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjustes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOcupantes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMensaje = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.chkClave = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCambiarUsuario = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTipo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnGuardarEstado = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtEstado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAsunto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtgEstados = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEliminarTipo = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnGuardarTipo = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnEliminarEstado = new Guna.UI2.WinForms.Guna2TileButton();
            this.dtgTipoHabitaciones = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_MostrarTipoHabitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoHabitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOcupantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstados)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_MostrarTipoHabitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoHabitacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoEllipsis = true;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(184, 23);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "Ajustes del sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Hotel_Vanilla.Properties.Resources.LogoVanilla;
            this.pictureBox1.Location = new System.Drawing.Point(729, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // txtOcupantes
            // 
            this.txtOcupantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOcupantes.BackColor = System.Drawing.Color.Transparent;
            this.txtOcupantes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOcupantes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOcupantes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOcupantes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOcupantes.DisabledState.Parent = this.txtOcupantes;
            this.txtOcupantes.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtOcupantes.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtOcupantes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOcupantes.FocusedState.Parent = this.txtOcupantes;
            this.txtOcupantes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOcupantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtOcupantes.Location = new System.Drawing.Point(444, 420);
            this.txtOcupantes.Name = "txtOcupantes";
            this.txtOcupantes.ShadowDecoration.Parent = this.txtOcupantes;
            this.txtOcupantes.Size = new System.Drawing.Size(77, 36);
            this.txtOcupantes.TabIndex = 45;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(344, 331);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(111, 19);
            this.bunifuCustomLabel2.TabIndex = 48;
            this.bunifuCustomLabel2.Text = "Habitaciones";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(681, 331);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(140, 19);
            this.bunifuCustomLabel3.TabIndex = 53;
            this.bunifuCustomLabel3.Text = "Notificar un error:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensaje.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMensaje.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.txtMensaje.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMensaje.BorderThickness = 2;
            this.txtMensaje.CausesValidation = false;
            this.txtMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMensaje.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtMensaje.isPassword = false;
            this.txtMensaje.Location = new System.Drawing.Point(685, 407);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(253, 57);
            this.txtMensaje.TabIndex = 7;
            this.txtMensaje.Text = "Mensaje";
            this.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMensaje.Enter += new System.EventHandler(this.txtMensaje_Enter);
            this.txtMensaje.Leave += new System.EventHandler(this.txtMensaje_Leave);
            // 
            // btnEnviar
            // 
            this.btnEnviar.ActiveBorderThickness = 1;
            this.btnEnviar.ActiveCornerRadius = 20;
            this.btnEnviar.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEnviar.ActiveLineColor = System.Drawing.Color.White;
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.ButtonText = "Enviar";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.IdleBorderThickness = 1;
            this.btnEnviar.IdleCornerRadius = 20;
            this.btnEnviar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnEnviar.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnEnviar.Location = new System.Drawing.Point(801, 474);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(136, 41);
            this.btnEnviar.TabIndex = 61;
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(503, 28);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(181, 19);
            this.bunifuCustomLabel7.TabIndex = 62;
            this.bunifuCustomLabel7.Text = "Cambiar informacion:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.HintText = "Usuario";
            this.txtUsuario.isPassword = false;
            this.txtUsuario.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtUsuario.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtUsuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtUsuario.LineThickness = 4;
            this.txtUsuario.Location = new System.Drawing.Point(507, 64);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(219, 33);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtPass.HintText = "Password";
            this.txtPass.isPassword = true;
            this.txtPass.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtPass.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPass.LineThickness = 4;
            this.txtPass.Location = new System.Drawing.Point(507, 146);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(219, 33);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "Correo";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(507, 105);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 33);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // chkClave
            // 
            this.chkClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkClave.BackColor = System.Drawing.Color.RoyalBlue;
            this.chkClave.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.chkClave.Checked = false;
            this.chkClave.CheckedOnColor = System.Drawing.Color.RoyalBlue;
            this.chkClave.ForeColor = System.Drawing.Color.White;
            this.chkClave.Location = new System.Drawing.Point(507, 189);
            this.chkClave.Name = "chkClave";
            this.chkClave.Size = new System.Drawing.Size(20, 20);
            this.chkClave.TabIndex = 67;
            this.chkClave.OnChange += new System.EventHandler(this.bunifuCheckbox3_OnChange);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(533, 189);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(91, 17);
            this.bunifuCustomLabel8.TabIndex = 68;
            this.bunifuCustomLabel8.Text = "Mostrar clave";
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.ActiveBorderThickness = 1;
            this.btnCambiarUsuario.ActiveCornerRadius = 20;
            this.btnCambiarUsuario.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnCambiarUsuario.ActiveForecolor = System.Drawing.Color.White;
            this.btnCambiarUsuario.ActiveLineColor = System.Drawing.Color.White;
            this.btnCambiarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btnCambiarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambiarUsuario.BackgroundImage")));
            this.btnCambiarUsuario.ButtonText = "Cambiar";
            this.btnCambiarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCambiarUsuario.IdleBorderThickness = 1;
            this.btnCambiarUsuario.IdleCornerRadius = 20;
            this.btnCambiarUsuario.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCambiarUsuario.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnCambiarUsuario.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnCambiarUsuario.Location = new System.Drawing.Point(507, 211);
            this.btnCambiarUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(117, 41);
            this.btnCambiarUsuario.TabIndex = 69;
            this.btnCambiarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTipo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.Color.Black;
            this.txtTipo.HintForeColor = System.Drawing.Color.Empty;
            this.txtTipo.HintText = "Tipo";
            this.txtTipo.isPassword = false;
            this.txtTipo.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtTipo.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtTipo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTipo.LineThickness = 4;
            this.txtTipo.Location = new System.Drawing.Point(348, 370);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(173, 33);
            this.txtTipo.TabIndex = 2;
            this.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGuardarEstado
            // 
            this.btnGuardarEstado.CheckedState.Parent = this.btnGuardarEstado;
            this.btnGuardarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarEstado.CustomImages.Parent = this.btnGuardarEstado;
            this.btnGuardarEstado.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardarEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEstado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEstado.HoverState.Parent = this.btnGuardarEstado;
            this.btnGuardarEstado.Location = new System.Drawing.Point(147, 109);
            this.btnGuardarEstado.Name = "btnGuardarEstado";
            this.btnGuardarEstado.ShadowDecoration.Parent = this.btnGuardarEstado;
            this.btnGuardarEstado.Size = new System.Drawing.Size(84, 33);
            this.btnGuardarEstado.TabIndex = 72;
            this.btnGuardarEstado.Text = "Guardar";
            this.btnGuardarEstado.Click += new System.EventHandler(this.btnGuardarEstado_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.HintForeColor = System.Drawing.Color.Empty;
            this.txtEstado.HintText = "Estado";
            this.txtEstado.isPassword = false;
            this.txtEstado.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtEstado.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtEstado.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEstado.LineThickness = 4;
            this.txtEstado.Location = new System.Drawing.Point(26, 109);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(114, 33);
            this.txtEstado.TabIndex = 1;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAsunto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAsunto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.ForeColor = System.Drawing.Color.Black;
            this.txtAsunto.HintForeColor = System.Drawing.Color.Empty;
            this.txtAsunto.HintText = "Asunto";
            this.txtAsunto.isPassword = false;
            this.txtAsunto.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtAsunto.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtAsunto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAsunto.LineThickness = 4;
            this.txtAsunto.Location = new System.Drawing.Point(685, 365);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(241, 33);
            this.txtAsunto.TabIndex = 6;
            this.txtAsunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtgEstados
            // 
            this.dtgEstados.AllowUserToAddRows = false;
            this.dtgEstados.AllowUserToDeleteRows = false;
            this.dtgEstados.AllowUserToResizeColumns = false;
            this.dtgEstados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgEstados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEstados.AutoGenerateColumns = false;
            this.dtgEstados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEstados.BackgroundColor = System.Drawing.Color.White;
            this.dtgEstados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEstados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgEstados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEstados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEstados.ColumnHeadersHeight = 21;
            this.dtgEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtgEstados.DataSource = this.estadosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEstados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEstados.EnableHeadersVisualStyles = false;
            this.dtgEstados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEstados.Location = new System.Drawing.Point(26, 148);
            this.dtgEstados.Name = "dtgEstados";
            this.dtgEstados.ReadOnly = true;
            this.dtgEstados.RowHeadersVisible = false;
            this.dtgEstados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEstados.Size = new System.Drawing.Size(295, 159);
            this.dtgEstados.TabIndex = 75;
            this.dtgEstados.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgEstados.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgEstados.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgEstados.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgEstados.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgEstados.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgEstados.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgEstados.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEstados.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgEstados.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgEstados.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgEstados.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgEstados.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgEstados.ThemeStyle.HeaderStyle.Height = 21;
            this.dtgEstados.ThemeStyle.ReadOnly = true;
            this.dtgEstados.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgEstados.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgEstados.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgEstados.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgEstados.ThemeStyle.RowsStyle.Height = 22;
            this.dtgEstados.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgEstados.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(22, 82);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(65, 19);
            this.bunifuCustomLabel4.TabIndex = 76;
            this.bunifuCustomLabel4.Text = "Estados";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(344, 428);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(94, 19);
            this.bunifuCustomLabel5.TabIndex = 77;
            this.bunifuCustomLabel5.Text = "Ocupantes";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.Controls.Add(this.btnEliminarTipo);
            this.guna2Panel1.Controls.Add(this.btnGuardarTipo);
            this.guna2Panel1.Controls.Add(this.txtAsunto);
            this.guna2Panel1.Controls.Add(this.btnEliminarEstado);
            this.guna2Panel1.Controls.Add(this.dtgTipoHabitaciones);
            this.guna2Panel1.Controls.Add(this.bunifuCustomLabel5);
            this.guna2Panel1.Controls.Add(this.btnCambiarUsuario);
            this.guna2Panel1.Controls.Add(this.txtOcupantes);
            this.guna2Panel1.Controls.Add(this.bunifuCustomLabel3);
            this.guna2Panel1.Controls.Add(this.bunifuCustomLabel8);
            this.guna2Panel1.Controls.Add(this.bunifuCustomLabel2);
            this.guna2Panel1.Controls.Add(this.txtTipo);
            this.guna2Panel1.Controls.Add(this.btnGuardarEstado);
            this.guna2Panel1.Controls.Add(this.chkClave);
            this.guna2Panel1.Controls.Add(this.bunifuCustomLabel7);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(951, 527);
            this.guna2Panel1.TabIndex = 78;
            // 
            // btnEliminarTipo
            // 
            this.btnEliminarTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarTipo.CheckedState.Parent = this.btnEliminarTipo;
            this.btnEliminarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTipo.CustomImages.Parent = this.btnEliminarTipo;
            this.btnEliminarTipo.FillColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTipo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTipo.HoverState.Parent = this.btnEliminarTipo;
            this.btnEliminarTipo.Location = new System.Drawing.Point(438, 465);
            this.btnEliminarTipo.Name = "btnEliminarTipo";
            this.btnEliminarTipo.ShadowDecoration.Parent = this.btnEliminarTipo;
            this.btnEliminarTipo.Size = new System.Drawing.Size(84, 33);
            this.btnEliminarTipo.TabIndex = 83;
            this.btnEliminarTipo.Text = "Eliminar";
            this.btnEliminarTipo.Click += new System.EventHandler(this.btnEliminarTipo_Click);
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarTipo.CheckedState.Parent = this.btnGuardarTipo;
            this.btnGuardarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarTipo.CustomImages.Parent = this.btnGuardarTipo;
            this.btnGuardarTipo.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardarTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTipo.HoverState.Parent = this.btnGuardarTipo;
            this.btnGuardarTipo.Location = new System.Drawing.Point(348, 465);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.ShadowDecoration.Parent = this.btnGuardarTipo;
            this.btnGuardarTipo.Size = new System.Drawing.Size(84, 33);
            this.btnGuardarTipo.TabIndex = 82;
            this.btnGuardarTipo.Text = "Guardar";
            this.btnGuardarTipo.Click += new System.EventHandler(this.btnGuardarTipo_Click);
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.CheckedState.Parent = this.btnEliminarEstado;
            this.btnEliminarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEstado.CustomImages.Parent = this.btnEliminarEstado;
            this.btnEliminarEstado.FillColor = System.Drawing.Color.OrangeRed;
            this.btnEliminarEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEstado.HoverState.Parent = this.btnEliminarEstado;
            this.btnEliminarEstado.Location = new System.Drawing.Point(237, 109);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.ShadowDecoration.Parent = this.btnEliminarEstado;
            this.btnEliminarEstado.Size = new System.Drawing.Size(84, 33);
            this.btnEliminarEstado.TabIndex = 81;
            this.btnEliminarEstado.Text = "Eliminar";
            this.btnEliminarEstado.Click += new System.EventHandler(this.btnEliminarEstado_Click);
            // 
            // dtgTipoHabitaciones
            // 
            this.dtgTipoHabitaciones.AllowUserToAddRows = false;
            this.dtgTipoHabitaciones.AllowUserToDeleteRows = false;
            this.dtgTipoHabitaciones.AllowUserToResizeColumns = false;
            this.dtgTipoHabitaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgTipoHabitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgTipoHabitaciones.AutoGenerateColumns = false;
            this.dtgTipoHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTipoHabitaciones.BackgroundColor = System.Drawing.Color.White;
            this.dtgTipoHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgTipoHabitaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgTipoHabitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTipoHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgTipoHabitaciones.ColumnHeadersHeight = 21;
            this.dtgTipoHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dtgTipoHabitaciones.DataSource = this.sp_MostrarTipoHabitacionesBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTipoHabitaciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgTipoHabitaciones.EnableHeadersVisualStyles = false;
            this.dtgTipoHabitaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgTipoHabitaciones.Location = new System.Drawing.Point(26, 331);
            this.dtgTipoHabitaciones.Name = "dtgTipoHabitaciones";
            this.dtgTipoHabitaciones.ReadOnly = true;
            this.dtgTipoHabitaciones.RowHeadersVisible = false;
            this.dtgTipoHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTipoHabitaciones.Size = new System.Drawing.Size(295, 167);
            this.dtgTipoHabitaciones.TabIndex = 77;
            this.dtgTipoHabitaciones.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgTipoHabitaciones.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgTipoHabitaciones.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgTipoHabitaciones.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgTipoHabitaciones.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgTipoHabitaciones.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgTipoHabitaciones.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgTipoHabitaciones.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgTipoHabitaciones.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgTipoHabitaciones.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgTipoHabitaciones.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgTipoHabitaciones.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgTipoHabitaciones.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgTipoHabitaciones.ThemeStyle.HeaderStyle.Height = 21;
            this.dtgTipoHabitaciones.ThemeStyle.ReadOnly = true;
            this.dtgTipoHabitaciones.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgTipoHabitaciones.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgTipoHabitaciones.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgTipoHabitaciones.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgTipoHabitaciones.ThemeStyle.RowsStyle.Height = 22;
            this.dtgTipoHabitaciones.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgTipoHabitaciones.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEstado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreEstado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre estado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.Estados);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idTipoHabitacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "numeroOcupantes";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ocupantes";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // sp_MostrarTipoHabitacionesBindingSource
            // 
            this.sp_MostrarTipoHabitacionesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.sp_MostrarTipoHabitaciones);
            // 
            // tipoHabitacionesBindingSource
            // 
            this.tipoHabitacionesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.TipoHabitaciones);
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 527);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dtgEstados);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjustes";
            this.Text = "frmAjustes";
            this.Load += new System.EventHandler(this.frmAjustes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOcupantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstados)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_MostrarTipoHabitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoHabitacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtOcupantes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMensaje;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnviar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuCheckbox chkClave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCambiarUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTipo;
        private Guna.UI2.WinForms.Guna2TileButton btnGuardarEstado;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEstado;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAsunto;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView dtgEstados;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.BindingSource tipoHabitacionesBindingSource;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgTipoHabitaciones;
        private System.Windows.Forms.BindingSource sp_MostrarTipoHabitacionesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Guna.UI2.WinForms.Guna2TileButton btnEliminarEstado;
        private Guna.UI2.WinForms.Guna2TileButton btnEliminarTipo;
        private Guna.UI2.WinForms.Guna2TileButton btnGuardarTipo;
    }
}