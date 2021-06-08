
namespace Hotel_Vanilla.Vista
{
    partial class frmManejoReservas
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
            System.Windows.Forms.Label descuentoLabel;
            System.Windows.Forms.Label fechaCheckInLabel;
            System.Windows.Forms.Label fechaReservaLabel;
            System.Windows.Forms.Label idReservaLabel1;
            System.Windows.Forms.Label numeroDiasLabel;
            System.Windows.Forms.Label pagoAdelantadoLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label habitacionLabel;
            System.Windows.Forms.Label idHuespedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoReservas));
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDefault = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.fechaCheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaCheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaReservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idReservaTextBox1 = new System.Windows.Forms.TextBox();
            this.numeroDiasTextBox = new System.Windows.Forms.TextBox();
            this.pagoAdelantadoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.cbHabitacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.manejoReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_MostrarManejoReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.huespedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idHuesped_FKComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            descuentoLabel = new System.Windows.Forms.Label();
            fechaCheckInLabel = new System.Windows.Forms.Label();
            fechaReservaLabel = new System.Windows.Forms.Label();
            idReservaLabel1 = new System.Windows.Forms.Label();
            numeroDiasLabel = new System.Windows.Forms.Label();
            pagoAdelantadoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            habitacionLabel = new System.Windows.Forms.Label();
            idHuespedLabel = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manejoReservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_MostrarManejoReservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descuentoLabel
            // 
            descuentoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(63, 312);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(60, 13);
            descuentoLabel.TabIndex = 45;
            descuentoLabel.Text = "descuento:";
            descuentoLabel.Click += new System.EventHandler(this.descuentoLabel_Click);
            // 
            // fechaCheckInLabel
            // 
            fechaCheckInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            fechaCheckInLabel.AutoSize = true;
            fechaCheckInLabel.Location = new System.Drawing.Point(63, 167);
            fechaCheckInLabel.Name = "fechaCheckInLabel";
            fechaCheckInLabel.Size = new System.Drawing.Size(83, 13);
            fechaCheckInLabel.TabIndex = 47;
            fechaCheckInLabel.Text = "fecha Check In:";
            // 
            // fechaReservaLabel
            // 
            fechaReservaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            fechaReservaLabel.AutoSize = true;
            fechaReservaLabel.Location = new System.Drawing.Point(63, 141);
            fechaReservaLabel.Name = "fechaReservaLabel";
            fechaReservaLabel.Size = new System.Drawing.Size(80, 13);
            fechaReservaLabel.TabIndex = 51;
            fechaReservaLabel.Text = "fecha Reserva:";
            // 
            // idReservaLabel1
            // 
            idReservaLabel1.AutoSize = true;
            idReservaLabel1.Location = new System.Drawing.Point(414, 97);
            idReservaLabel1.Name = "idReservaLabel1";
            idReservaLabel1.Size = new System.Drawing.Size(61, 13);
            idReservaLabel1.TabIndex = 57;
            idReservaLabel1.Text = "id Reserva:";
            // 
            // numeroDiasLabel
            // 
            numeroDiasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            numeroDiasLabel.AutoSize = true;
            numeroDiasLabel.Location = new System.Drawing.Point(63, 218);
            numeroDiasLabel.Name = "numeroDiasLabel";
            numeroDiasLabel.Size = new System.Drawing.Size(69, 13);
            numeroDiasLabel.TabIndex = 59;
            numeroDiasLabel.Text = "numero Dias:";
            // 
            // pagoAdelantadoLabel
            // 
            pagoAdelantadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            pagoAdelantadoLabel.AutoSize = true;
            pagoAdelantadoLabel.Location = new System.Drawing.Point(63, 286);
            pagoAdelantadoLabel.Name = "pagoAdelantadoLabel";
            pagoAdelantadoLabel.Size = new System.Drawing.Size(91, 13);
            pagoAdelantadoLabel.TabIndex = 61;
            pagoAdelantadoLabel.Text = "pago Adelantado:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(63, 338);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(30, 13);
            totalLabel.TabIndex = 63;
            totalLabel.Text = "total:";
            totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // habitacionLabel
            // 
            habitacionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            habitacionLabel.AutoSize = true;
            habitacionLabel.Location = new System.Drawing.Point(93, 244);
            habitacionLabel.Name = "habitacionLabel";
            habitacionLabel.Size = new System.Drawing.Size(61, 13);
            habitacionLabel.TabIndex = 65;
            habitacionLabel.Text = "Habitacion:";
            habitacionLabel.Click += new System.EventHandler(this.habitacionLabel_Click);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(63, 193);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(91, 13);
            this.lblCheckOut.TabIndex = 49;
            this.lblCheckOut.Text = "fecha Check Out:";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSuperior.Controls.Add(this.bunifuCustomLabel1);
            this.panelSuperior.Controls.Add(this.btnDefault);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 50);
            this.panelSuperior.TabIndex = 11;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(191, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(496, 29);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "MANTENIMIENTO DE RESERVACIONES";
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnDefault.Image = global::Hotel_Vanilla.Properties.Resources.Icono;
            this.btnDefault.ImageActive = null;
            this.btnDefault.Location = new System.Drawing.Point(12, 0);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(50, 50);
            this.btnDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDefault.TabIndex = 14;
            this.btnDefault.TabStop = false;
            this.btnDefault.Zoom = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = global::Hotel_Vanilla.Properties.Resources.cerrar__1_;
            this.btnCerrar.Location = new System.Drawing.Point(764, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.Gold;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 509);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(800, 50);
            this.panelInferior.TabIndex = 12;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.panelSuperior;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.Tomato;
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 7;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = global::Hotel_Vanilla.Properties.Resources.cancelar;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 90D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(497, 346);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(243, 51);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.Red;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 7;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = global::Hotel_Vanilla.Properties.Resources.guardar;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(497, 279);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(243, 51);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "1";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(639, 67);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 1;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(101, 67);
            this.guna2TextBox1.TabIndex = 30;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(650, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id: ";
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(160, 309);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(277, 20);
            this.descuentoTextBox.TabIndex = 46;
            this.descuentoTextBox.Leave += new System.EventHandler(this.descuentoTextBox_Leave);
            // 
            // fechaCheckInDateTimePicker
            // 
            this.fechaCheckInDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fechaCheckInDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechaCheckInDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaCheckIn", true));
            this.fechaCheckInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaCheckInDateTimePicker.Location = new System.Drawing.Point(160, 163);
            this.fechaCheckInDateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.fechaCheckInDateTimePicker.Name = "fechaCheckInDateTimePicker";
            this.fechaCheckInDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.fechaCheckInDateTimePicker.TabIndex = 48;
            this.fechaCheckInDateTimePicker.Value = new System.DateTime(2021, 6, 7, 1, 57, 54, 0);
            this.fechaCheckInDateTimePicker.ValueChanged += new System.EventHandler(this.fechaCheckInDateTimePicker_ValueChanged);
            // 
            // fechaCheckOutDateTimePicker
            // 
            this.fechaCheckOutDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fechaCheckOutDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechaCheckOutDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaCheckOut", true));
            this.fechaCheckOutDateTimePicker.Enabled = false;
            this.fechaCheckOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaCheckOutDateTimePicker.Location = new System.Drawing.Point(160, 189);
            this.fechaCheckOutDateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.fechaCheckOutDateTimePicker.Name = "fechaCheckOutDateTimePicker";
            this.fechaCheckOutDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.fechaCheckOutDateTimePicker.TabIndex = 50;
            this.fechaCheckOutDateTimePicker.Value = new System.DateTime(2021, 6, 7, 1, 57, 46, 0);
            this.fechaCheckOutDateTimePicker.ValueChanged += new System.EventHandler(this.fechaCheckOutDateTimePicker_ValueChanged);
            // 
            // fechaReservaDateTimePicker
            // 
            this.fechaReservaDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fechaReservaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechaReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaReserva", true));
            this.fechaReservaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaReservaDateTimePicker.Location = new System.Drawing.Point(160, 137);
            this.fechaReservaDateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.fechaReservaDateTimePicker.Name = "fechaReservaDateTimePicker";
            this.fechaReservaDateTimePicker.Size = new System.Drawing.Size(277, 20);
            this.fechaReservaDateTimePicker.TabIndex = 52;
            this.fechaReservaDateTimePicker.Value = new System.DateTime(2021, 6, 7, 2, 12, 59, 0);
            this.fechaReservaDateTimePicker.ValueChanged += new System.EventHandler(this.fechaReservaDateTimePicker_ValueChanged);
            // 
            // idReservaTextBox1
            // 
            this.idReservaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "idReserva", true));
            this.idReservaTextBox1.Location = new System.Drawing.Point(511, 94);
            this.idReservaTextBox1.Name = "idReservaTextBox1";
            this.idReservaTextBox1.Size = new System.Drawing.Size(109, 20);
            this.idReservaTextBox1.TabIndex = 58;
            // 
            // numeroDiasTextBox
            // 
            this.numeroDiasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numeroDiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "numeroDias", true));
            this.numeroDiasTextBox.Location = new System.Drawing.Point(160, 215);
            this.numeroDiasTextBox.Name = "numeroDiasTextBox";
            this.numeroDiasTextBox.Size = new System.Drawing.Size(277, 20);
            this.numeroDiasTextBox.TabIndex = 60;
            this.numeroDiasTextBox.TextChanged += new System.EventHandler(this.numeroDiasTextBox_TextChanged);
            this.numeroDiasTextBox.Leave += new System.EventHandler(this.numeroDiasTextBox_Leave);
            // 
            // pagoAdelantadoTextBox
            // 
            this.pagoAdelantadoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagoAdelantadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "pagoAdelantado", true));
            this.pagoAdelantadoTextBox.Location = new System.Drawing.Point(160, 283);
            this.pagoAdelantadoTextBox.Name = "pagoAdelantadoTextBox";
            this.pagoAdelantadoTextBox.Size = new System.Drawing.Size(277, 20);
            this.pagoAdelantadoTextBox.TabIndex = 62;
            this.pagoAdelantadoTextBox.TextChanged += new System.EventHandler(this.pagoAdelantadoTextBox_TextChanged);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(160, 335);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(277, 20);
            this.totalTextBox.TabIndex = 64;
            // 
            // cbHabitacion
            // 
            this.cbHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.cbHabitacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_MostrarManejoReservasBindingSource, "Habitacion", true));
            this.cbHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabitacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHabitacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHabitacion.FocusedState.Parent = this.cbHabitacion;
            this.cbHabitacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbHabitacion.FormattingEnabled = true;
            this.cbHabitacion.HoverState.Parent = this.cbHabitacion;
            this.cbHabitacion.ItemHeight = 30;
            this.cbHabitacion.ItemsAppearance.Parent = this.cbHabitacion;
            this.cbHabitacion.Location = new System.Drawing.Point(160, 241);
            this.cbHabitacion.Name = "cbHabitacion";
            this.cbHabitacion.ShadowDecoration.Parent = this.cbHabitacion;
            this.cbHabitacion.Size = new System.Drawing.Size(277, 36);
            this.cbHabitacion.TabIndex = 66;
            this.cbHabitacion.SelectedIndexChanged += new System.EventHandler(this.habitacionGuna2ComboBox_SelectedIndexChanged);
            // 
            // manejoReservasBindingSource
            // 
            this.manejoReservasBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.ManejoReservas);
            // 
            // sp_MostrarManejoReservasBindingSource
            // 
            this.sp_MostrarManejoReservasBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.spMostrarManejoReservas);
            // 
            // huespedesBindingSource
            // 
            this.huespedesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.Huespedes);
            // 
            // idHuespedLabel
            // 
            idHuespedLabel.AutoSize = true;
            idHuespedLabel.Location = new System.Drawing.Point(90, 364);
            idHuespedLabel.Name = "idHuespedLabel";
            idHuespedLabel.Size = new System.Drawing.Size(64, 13);
            idHuespedLabel.TabIndex = 66;
            idHuespedLabel.Text = "id Huesped:";
            // 
            // idHuesped_FKComboBox
            // 
            this.idHuesped_FKComboBox.BackColor = System.Drawing.Color.Transparent;
            this.idHuesped_FKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "idHuesped", true));
            this.idHuesped_FKComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.idHuesped_FKComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idHuesped_FKComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idHuesped_FKComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idHuesped_FKComboBox.FocusedState.Parent = this.idHuesped_FKComboBox;
            this.idHuesped_FKComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.idHuesped_FKComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.idHuesped_FKComboBox.FormattingEnabled = true;
            this.idHuesped_FKComboBox.HoverState.Parent = this.idHuesped_FKComboBox;
            this.idHuesped_FKComboBox.ItemHeight = 30;
            this.idHuesped_FKComboBox.ItemsAppearance.Parent = this.idHuesped_FKComboBox;
            this.idHuesped_FKComboBox.Location = new System.Drawing.Point(160, 361);
            this.idHuesped_FKComboBox.Name = "idHuesped_FKComboBox";
            this.idHuesped_FKComboBox.ShadowDecoration.Parent = this.idHuesped_FKComboBox;
            this.idHuesped_FKComboBox.Size = new System.Drawing.Size(277, 36);
            this.idHuesped_FKComboBox.TabIndex = 67;
            // 
            // frmManejoReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(idHuespedLabel);
            this.Controls.Add(this.idHuesped_FKComboBox);
            this.Controls.Add(habitacionLabel);
            this.Controls.Add(this.cbHabitacion);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(fechaCheckInLabel);
            this.Controls.Add(this.fechaCheckInDateTimePicker);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.fechaCheckOutDateTimePicker);
            this.Controls.Add(fechaReservaLabel);
            this.Controls.Add(this.fechaReservaDateTimePicker);
            this.Controls.Add(idReservaLabel1);
            this.Controls.Add(this.idReservaTextBox1);
            this.Controls.Add(numeroDiasLabel);
            this.Controls.Add(this.numeroDiasTextBox);
            this.Controls.Add(pagoAdelantadoLabel);
            this.Controls.Add(this.pagoAdelantadoTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManejoReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Reservaciones";
            this.Load += new System.EventHandler(this.frmManejoReservas_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manejoReservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_MostrarManejoReservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnDefault;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource manejoReservasBindingSource;
        private System.Windows.Forms.BindingSource sp_MostrarManejoReservasBindingSource;
        public Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        public System.Windows.Forms.TextBox descuentoTextBox;
        public System.Windows.Forms.DateTimePicker fechaCheckInDateTimePicker;
        public System.Windows.Forms.DateTimePicker fechaCheckOutDateTimePicker;
        public System.Windows.Forms.DateTimePicker fechaReservaDateTimePicker;
        public System.Windows.Forms.TextBox numeroDiasTextBox;
        public System.Windows.Forms.TextBox pagoAdelantadoTextBox;
        public System.Windows.Forms.TextBox totalTextBox;
        public Guna.UI2.WinForms.Guna2ComboBox cbHabitacion;
        public System.Windows.Forms.TextBox idReservaTextBox1;
        public System.Windows.Forms.Label lblCheckOut;
        public Guna.UI2.WinForms.Guna2ComboBox idHuesped_FKComboBox;
        private System.Windows.Forms.BindingSource huespedesBindingSource;
    }
}