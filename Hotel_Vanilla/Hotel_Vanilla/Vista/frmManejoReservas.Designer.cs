
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
            System.Windows.Forms.Label fechaCheckOutLabel;
            System.Windows.Forms.Label fechaReservaLabel;
            System.Windows.Forms.Label idHabitacion_FKLabel;
            System.Windows.Forms.Label idHuesped_FKLabel;
            System.Windows.Forms.Label idReservaLabel;
            System.Windows.Forms.Label numeroDiasLabel;
            System.Windows.Forms.Label pagoAdelantadoLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoReservas));
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
            this.manejoReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.fechaCheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaCheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaReservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idHabitacion_FKTextBox = new System.Windows.Forms.TextBox();
            this.idHuesped_FKTextBox = new System.Windows.Forms.TextBox();
            this.idReservaTextBox = new System.Windows.Forms.TextBox();
            this.numeroDiasTextBox = new System.Windows.Forms.TextBox();
            this.pagoAdelantadoTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            descuentoLabel = new System.Windows.Forms.Label();
            fechaCheckInLabel = new System.Windows.Forms.Label();
            fechaCheckOutLabel = new System.Windows.Forms.Label();
            fechaReservaLabel = new System.Windows.Forms.Label();
            idHabitacion_FKLabel = new System.Windows.Forms.Label();
            idHuesped_FKLabel = new System.Windows.Forms.Label();
            idReservaLabel = new System.Windows.Forms.Label();
            numeroDiasLabel = new System.Windows.Forms.Label();
            pagoAdelantadoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manejoReservasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelSuperior.Controls.Add(this.bunifuCustomLabel1);
            this.panelSuperior.Controls.Add(this.btnDefault);
            this.panelSuperior.Controls.Add(this.btnCerrar);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1200, 77);
            this.panelSuperior.TabIndex = 11;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(286, 14);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(726, 40);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "MANTENIMIENTO DE RESERVACIONES";
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnDefault.Image = global::Hotel_Vanilla.Properties.Resources.Icono;
            this.btnDefault.ImageActive = null;
            this.btnDefault.Location = new System.Drawing.Point(18, 0);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 77);
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
            this.btnCerrar.Location = new System.Drawing.Point(1146, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 51);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.Gold;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 692);
            this.panelInferior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1200, 77);
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
            this.btnCancelar.Location = new System.Drawing.Point(735, 585);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(375, 78);
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
            this.btnGuardar.Location = new System.Drawing.Point(735, 482);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(375, 78);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.guna2TextBox1.Location = new System.Drawing.Point(958, 103);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.ReadOnly = true;
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 1;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(152, 103);
            this.guna2TextBox1.TabIndex = 30;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(975, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id: ";
            // 
            // manejoReservasBindingSource
            // 
            this.manejoReservasBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.ManejoReservas);
            // 
            // descuentoLabel
            // 
            descuentoLabel.AutoSize = true;
            descuentoLabel.Location = new System.Drawing.Point(130, 335);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(88, 20);
            descuentoLabel.TabIndex = 32;
            descuentoLabel.Text = "descuento:";
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "descuento", true));
            this.descuentoTextBox.Location = new System.Drawing.Point(271, 332);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.Size = new System.Drawing.Size(200, 26);
            this.descuentoTextBox.TabIndex = 33;
            // 
            // fechaCheckInLabel
            // 
            fechaCheckInLabel.AutoSize = true;
            fechaCheckInLabel.Location = new System.Drawing.Point(130, 368);
            fechaCheckInLabel.Name = "fechaCheckInLabel";
            fechaCheckInLabel.Size = new System.Drawing.Size(120, 20);
            fechaCheckInLabel.TabIndex = 34;
            fechaCheckInLabel.Text = "fecha Check In:";
            // 
            // fechaCheckInDateTimePicker
            // 
            this.fechaCheckInDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaCheckIn", true));
            this.fechaCheckInDateTimePicker.Location = new System.Drawing.Point(271, 364);
            this.fechaCheckInDateTimePicker.Name = "fechaCheckInDateTimePicker";
            this.fechaCheckInDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fechaCheckInDateTimePicker.TabIndex = 35;
            // 
            // fechaCheckOutLabel
            // 
            fechaCheckOutLabel.AutoSize = true;
            fechaCheckOutLabel.Location = new System.Drawing.Point(130, 400);
            fechaCheckOutLabel.Name = "fechaCheckOutLabel";
            fechaCheckOutLabel.Size = new System.Drawing.Size(132, 20);
            fechaCheckOutLabel.TabIndex = 36;
            fechaCheckOutLabel.Text = "fecha Check Out:";
            // 
            // fechaCheckOutDateTimePicker
            // 
            this.fechaCheckOutDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaCheckOut", true));
            this.fechaCheckOutDateTimePicker.Location = new System.Drawing.Point(271, 396);
            this.fechaCheckOutDateTimePicker.Name = "fechaCheckOutDateTimePicker";
            this.fechaCheckOutDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fechaCheckOutDateTimePicker.TabIndex = 37;
            // 
            // fechaReservaLabel
            // 
            fechaReservaLabel.AutoSize = true;
            fechaReservaLabel.Location = new System.Drawing.Point(130, 432);
            fechaReservaLabel.Name = "fechaReservaLabel";
            fechaReservaLabel.Size = new System.Drawing.Size(116, 20);
            fechaReservaLabel.TabIndex = 38;
            fechaReservaLabel.Text = "fecha Reserva:";
            // 
            // fechaReservaDateTimePicker
            // 
            this.fechaReservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaReserva", true));
            this.fechaReservaDateTimePicker.Location = new System.Drawing.Point(271, 428);
            this.fechaReservaDateTimePicker.Name = "fechaReservaDateTimePicker";
            this.fechaReservaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fechaReservaDateTimePicker.TabIndex = 39;
            // 
            // idHabitacion_FKLabel
            // 
            idHabitacion_FKLabel.AutoSize = true;
            idHabitacion_FKLabel.Location = new System.Drawing.Point(130, 463);
            idHabitacion_FKLabel.Name = "idHabitacion_FKLabel";
            idHabitacion_FKLabel.Size = new System.Drawing.Size(129, 20);
            idHabitacion_FKLabel.TabIndex = 40;
            idHabitacion_FKLabel.Text = "id Habitacion FK:";
            // 
            // idHabitacion_FKTextBox
            // 
            this.idHabitacion_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "idHabitacion_FK", true));
            this.idHabitacion_FKTextBox.Location = new System.Drawing.Point(271, 460);
            this.idHabitacion_FKTextBox.Name = "idHabitacion_FKTextBox";
            this.idHabitacion_FKTextBox.Size = new System.Drawing.Size(200, 26);
            this.idHabitacion_FKTextBox.TabIndex = 41;
            // 
            // idHuesped_FKLabel
            // 
            idHuesped_FKLabel.AutoSize = true;
            idHuesped_FKLabel.Location = new System.Drawing.Point(130, 495);
            idHuesped_FKLabel.Name = "idHuesped_FKLabel";
            idHuesped_FKLabel.Size = new System.Drawing.Size(118, 20);
            idHuesped_FKLabel.TabIndex = 42;
            idHuesped_FKLabel.Text = "id Huesped FK:";
            // 
            // idHuesped_FKTextBox
            // 
            this.idHuesped_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "idHuesped_FK", true));
            this.idHuesped_FKTextBox.Location = new System.Drawing.Point(271, 492);
            this.idHuesped_FKTextBox.Name = "idHuesped_FKTextBox";
            this.idHuesped_FKTextBox.Size = new System.Drawing.Size(200, 26);
            this.idHuesped_FKTextBox.TabIndex = 43;
            // 
            // idReservaLabel
            // 
            idReservaLabel.AutoSize = true;
            idReservaLabel.Location = new System.Drawing.Point(594, 145);
            idReservaLabel.Name = "idReservaLabel";
            idReservaLabel.Size = new System.Drawing.Size(88, 20);
            idReservaLabel.TabIndex = 44;
            idReservaLabel.Text = "id Reserva:";
            // 
            // idReservaTextBox
            // 
            this.idReservaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "idReserva", true));
            this.idReservaTextBox.Location = new System.Drawing.Point(735, 142);
            this.idReservaTextBox.Name = "idReservaTextBox";
            this.idReservaTextBox.Size = new System.Drawing.Size(200, 26);
            this.idReservaTextBox.TabIndex = 45;
            // 
            // numeroDiasLabel
            // 
            numeroDiasLabel.AutoSize = true;
            numeroDiasLabel.Location = new System.Drawing.Point(130, 527);
            numeroDiasLabel.Name = "numeroDiasLabel";
            numeroDiasLabel.Size = new System.Drawing.Size(103, 20);
            numeroDiasLabel.TabIndex = 46;
            numeroDiasLabel.Text = "numero Dias:";
            // 
            // numeroDiasTextBox
            // 
            this.numeroDiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "numeroDias", true));
            this.numeroDiasTextBox.Location = new System.Drawing.Point(271, 524);
            this.numeroDiasTextBox.Name = "numeroDiasTextBox";
            this.numeroDiasTextBox.Size = new System.Drawing.Size(200, 26);
            this.numeroDiasTextBox.TabIndex = 47;
            // 
            // pagoAdelantadoLabel
            // 
            pagoAdelantadoLabel.AutoSize = true;
            pagoAdelantadoLabel.Location = new System.Drawing.Point(130, 559);
            pagoAdelantadoLabel.Name = "pagoAdelantadoLabel";
            pagoAdelantadoLabel.Size = new System.Drawing.Size(135, 20);
            pagoAdelantadoLabel.TabIndex = 48;
            pagoAdelantadoLabel.Text = "pago Adelantado:";
            // 
            // pagoAdelantadoTextBox
            // 
            this.pagoAdelantadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "pagoAdelantado", true));
            this.pagoAdelantadoTextBox.Location = new System.Drawing.Point(271, 556);
            this.pagoAdelantadoTextBox.Name = "pagoAdelantadoTextBox";
            this.pagoAdelantadoTextBox.Size = new System.Drawing.Size(200, 26);
            this.pagoAdelantadoTextBox.TabIndex = 49;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(130, 591);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(44, 20);
            totalLabel.TabIndex = 50;
            totalLabel.Text = "total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "total", true));
            this.totalTextBox.Location = new System.Drawing.Point(271, 588);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 26);
            this.totalTextBox.TabIndex = 51;
            // 
            // frmManejoReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 769);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(this.descuentoTextBox);
            this.Controls.Add(fechaCheckInLabel);
            this.Controls.Add(this.fechaCheckInDateTimePicker);
            this.Controls.Add(fechaCheckOutLabel);
            this.Controls.Add(this.fechaCheckOutDateTimePicker);
            this.Controls.Add(fechaReservaLabel);
            this.Controls.Add(this.fechaReservaDateTimePicker);
            this.Controls.Add(idHabitacion_FKLabel);
            this.Controls.Add(this.idHabitacion_FKTextBox);
            this.Controls.Add(idHuesped_FKLabel);
            this.Controls.Add(this.idHuesped_FKTextBox);
            this.Controls.Add(idReservaLabel);
            this.Controls.Add(this.idReservaTextBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManejoReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Reservaciones";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manejoReservasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
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
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.BindingSource manejoReservasBindingSource;
        private System.Windows.Forms.DateTimePicker fechaCheckInDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaCheckOutDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaReservaDateTimePicker;
        private System.Windows.Forms.TextBox idHabitacion_FKTextBox;
        private System.Windows.Forms.TextBox idHuesped_FKTextBox;
        private System.Windows.Forms.TextBox idReservaTextBox;
        private System.Windows.Forms.TextBox numeroDiasTextBox;
        private System.Windows.Forms.TextBox pagoAdelantadoTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
    }
}