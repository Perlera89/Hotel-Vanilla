
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
            this.txtIdReserva = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHabitacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbIdHuesped = new Guna.UI2.WinForms.Guna2ComboBox();
            this.huespedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDiasAlojamiento = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.manejoReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPagoAdelantado = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescuento = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFechaReserva = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFechaCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFechaCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.sp_MostrarManejoReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descuentoLabel = new System.Windows.Forms.Label();
            fechaCheckInLabel = new System.Windows.Forms.Label();
            fechaReservaLabel = new System.Windows.Forms.Label();
            numeroDiasLabel = new System.Windows.Forms.Label();
            pagoAdelantadoLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            habitacionLabel = new System.Windows.Forms.Label();
            idHuespedLabel = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasAlojamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manejoReservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_MostrarManejoReservasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descuentoLabel
            // 
            descuentoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            descuentoLabel.AutoSize = true;
            descuentoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            descuentoLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            descuentoLabel.Location = new System.Drawing.Point(67, 365);
            descuentoLabel.Name = "descuentoLabel";
            descuentoLabel.Size = new System.Drawing.Size(94, 19);
            descuentoLabel.TabIndex = 45;
            descuentoLabel.Text = "Descuento:";
            // 
            // fechaCheckInLabel
            // 
            fechaCheckInLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            fechaCheckInLabel.AutoSize = true;
            fechaCheckInLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            fechaCheckInLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            fechaCheckInLabel.Location = new System.Drawing.Point(65, 156);
            fechaCheckInLabel.Name = "fechaCheckInLabel";
            fechaCheckInLabel.Size = new System.Drawing.Size(160, 19);
            fechaCheckInLabel.TabIndex = 47;
            fechaCheckInLabel.Text = "Fecha de Check In:";
            // 
            // fechaReservaLabel
            // 
            fechaReservaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            fechaReservaLabel.AutoSize = true;
            fechaReservaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            fechaReservaLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            fechaReservaLabel.Location = new System.Drawing.Point(65, 114);
            fechaReservaLabel.Name = "fechaReservaLabel";
            fechaReservaLabel.Size = new System.Drawing.Size(151, 19);
            fechaReservaLabel.TabIndex = 51;
            fechaReservaLabel.Text = "Fecha de Reserva:";
            // 
            // numeroDiasLabel
            // 
            numeroDiasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            numeroDiasLabel.AutoSize = true;
            numeroDiasLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            numeroDiasLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            numeroDiasLabel.Location = new System.Drawing.Point(65, 239);
            numeroDiasLabel.Name = "numeroDiasLabel";
            numeroDiasLabel.Size = new System.Drawing.Size(168, 19);
            numeroDiasLabel.TabIndex = 59;
            numeroDiasLabel.Text = "Días de alojamiento:";
            // 
            // pagoAdelantadoLabel
            // 
            pagoAdelantadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            pagoAdelantadoLabel.AutoSize = true;
            pagoAdelantadoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            pagoAdelantadoLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            pagoAdelantadoLabel.Location = new System.Drawing.Point(65, 323);
            pagoAdelantadoLabel.Name = "pagoAdelantadoLabel";
            pagoAdelantadoLabel.Size = new System.Drawing.Size(151, 19);
            pagoAdelantadoLabel.TabIndex = 61;
            pagoAdelantadoLabel.Text = "Pago adelantado:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            totalLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            totalLabel.Location = new System.Drawing.Point(67, 407);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(49, 19);
            totalLabel.TabIndex = 63;
            totalLabel.Text = "Total:";
            // 
            // habitacionLabel
            // 
            habitacionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            habitacionLabel.AutoSize = true;
            habitacionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            habitacionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            habitacionLabel.Location = new System.Drawing.Point(67, 282);
            habitacionLabel.Name = "habitacionLabel";
            habitacionLabel.Size = new System.Drawing.Size(99, 19);
            habitacionLabel.TabIndex = 65;
            habitacionLabel.Text = "Habitación:";
            // 
            // idHuespedLabel
            // 
            idHuespedLabel.AutoSize = true;
            idHuespedLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            idHuespedLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            idHuespedLabel.Location = new System.Drawing.Point(67, 449);
            idHuespedLabel.Name = "idHuespedLabel";
            idHuespedLabel.Size = new System.Drawing.Size(82, 19);
            idHuespedLabel.TabIndex = 66;
            idHuespedLabel.Text = "Huesped:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblCheckOut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCheckOut.Location = new System.Drawing.Point(67, 198);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(173, 19);
            this.lblCheckOut.TabIndex = 49;
            this.lblCheckOut.Text = "Fecha de Check Out:";
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
            this.btnCancelar.Location = new System.Drawing.Point(536, 401);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(200, 50);
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
            this.btnGuardar.Location = new System.Drawing.Point(540, 334);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(200, 50);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Animated = true;
            this.txtIdReserva.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtIdReserva.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtIdReserva.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtIdReserva.BorderThickness = 2;
            this.txtIdReserva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdReserva.DefaultText = "1";
            this.txtIdReserva.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdReserva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdReserva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdReserva.DisabledState.Parent = this.txtIdReserva;
            this.txtIdReserva.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdReserva.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdReserva.FocusedState.Parent = this.txtIdReserva;
            this.txtIdReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtIdReserva.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdReserva.HoverState.Parent = this.txtIdReserva;
            this.txtIdReserva.Location = new System.Drawing.Point(639, 67);
            this.txtIdReserva.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.PasswordChar = '\0';
            this.txtIdReserva.PlaceholderText = "";
            this.txtIdReserva.ReadOnly = true;
            this.txtIdReserva.SelectedText = "";
            this.txtIdReserva.SelectionStart = 1;
            this.txtIdReserva.ShadowDecoration.Parent = this.txtIdReserva;
            this.txtIdReserva.Size = new System.Drawing.Size(101, 67);
            this.txtIdReserva.TabIndex = 30;
            this.txtIdReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // cbHabitacion
            // 
            this.cbHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.cbHabitacion.BorderRadius = 14;
            this.cbHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHabitacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHabitacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHabitacion.FocusedState.Parent = this.cbHabitacion;
            this.cbHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbHabitacion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbHabitacion.FormattingEnabled = true;
            this.cbHabitacion.HoverState.Parent = this.cbHabitacion;
            this.cbHabitacion.ItemHeight = 30;
            this.cbHabitacion.ItemsAppearance.Parent = this.cbHabitacion;
            this.cbHabitacion.Location = new System.Drawing.Point(246, 265);
            this.cbHabitacion.Name = "cbHabitacion";
            this.cbHabitacion.ShadowDecoration.Parent = this.cbHabitacion;
            this.cbHabitacion.Size = new System.Drawing.Size(256, 36);
            this.cbHabitacion.TabIndex = 66;
            // 
            // cbIdHuesped
            // 
            this.cbIdHuesped.BackColor = System.Drawing.Color.Transparent;
            this.cbIdHuesped.BorderRadius = 14;
            this.cbIdHuesped.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "idHuesped", true));
            this.cbIdHuesped.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIdHuesped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdHuesped.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIdHuesped.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIdHuesped.FocusedState.Parent = this.cbIdHuesped;
            this.cbIdHuesped.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbIdHuesped.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbIdHuesped.FormattingEnabled = true;
            this.cbIdHuesped.HoverState.Parent = this.cbIdHuesped;
            this.cbIdHuesped.ItemHeight = 30;
            this.cbIdHuesped.ItemsAppearance.Parent = this.cbIdHuesped;
            this.cbIdHuesped.Location = new System.Drawing.Point(246, 432);
            this.cbIdHuesped.Name = "cbIdHuesped";
            this.cbIdHuesped.ShadowDecoration.Parent = this.cbIdHuesped;
            this.cbIdHuesped.Size = new System.Drawing.Size(256, 36);
            this.cbIdHuesped.TabIndex = 67;
            this.cbIdHuesped.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbIdHuesped_KeyDown);
            // 
            // huespedesBindingSource
            // 
            this.huespedesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.Huespedes);
            // 
            // txtDiasAlojamiento
            // 
            this.txtDiasAlojamiento.BackColor = System.Drawing.Color.Transparent;
            this.txtDiasAlojamiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiasAlojamiento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "numeroDias", true));
            this.txtDiasAlojamiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiasAlojamiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiasAlojamiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiasAlojamiento.DisabledState.Parent = this.txtDiasAlojamiento;
            this.txtDiasAlojamiento.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtDiasAlojamiento.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtDiasAlojamiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiasAlojamiento.FocusedState.Parent = this.txtDiasAlojamiento;
            this.txtDiasAlojamiento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDiasAlojamiento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtDiasAlojamiento.Location = new System.Drawing.Point(246, 224);
            this.txtDiasAlojamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiasAlojamiento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDiasAlojamiento.Name = "txtDiasAlojamiento";
            this.txtDiasAlojamiento.ShadowDecoration.Parent = this.txtDiasAlojamiento;
            this.txtDiasAlojamiento.Size = new System.Drawing.Size(256, 34);
            this.txtDiasAlojamiento.TabIndex = 68;
            this.txtDiasAlojamiento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDiasAlojamiento.Leave += new System.EventHandler(this.numeroDiasTextBox_Leave);
            // 
            // manejoReservasBindingSource
            // 
            this.manejoReservasBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.ManejoReservas);
            // 
            // txtPagoAdelantado
            // 
            this.txtPagoAdelantado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPagoAdelantado.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.manejoReservasBindingSource, "pagoAdelantado", true));
            this.txtPagoAdelantado.DefaultText = "";
            this.txtPagoAdelantado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPagoAdelantado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPagoAdelantado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPagoAdelantado.DisabledState.Parent = this.txtPagoAdelantado;
            this.txtPagoAdelantado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPagoAdelantado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPagoAdelantado.FocusedState.Parent = this.txtPagoAdelantado;
            this.txtPagoAdelantado.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPagoAdelantado.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtPagoAdelantado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPagoAdelantado.HoverState.Parent = this.txtPagoAdelantado;
            this.txtPagoAdelantado.Location = new System.Drawing.Point(246, 306);
            this.txtPagoAdelantado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPagoAdelantado.MaxLength = 12;
            this.txtPagoAdelantado.Name = "txtPagoAdelantado";
            this.txtPagoAdelantado.PasswordChar = '\0';
            this.txtPagoAdelantado.PlaceholderText = "0.0000";
            this.txtPagoAdelantado.SelectedText = "";
            this.txtPagoAdelantado.ShadowDecoration.Parent = this.txtPagoAdelantado;
            this.txtPagoAdelantado.Size = new System.Drawing.Size(256, 36);
            this.txtPagoAdelantado.TabIndex = 69;
            this.txtPagoAdelantado.TextChanged += new System.EventHandler(this.txtPagoAdelantado_TextChanged);
            this.txtPagoAdelantado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoAdelantado_KeyPress);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescuento.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.manejoReservasBindingSource, "descuento", true));
            this.txtDescuento.DefaultText = "";
            this.txtDescuento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescuento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescuento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescuento.DisabledState.Parent = this.txtDescuento;
            this.txtDescuento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescuento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescuento.FocusedState.Parent = this.txtDescuento;
            this.txtDescuento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescuento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtDescuento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescuento.HoverState.Parent = this.txtDescuento;
            this.txtDescuento.Location = new System.Drawing.Point(246, 348);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.PlaceholderText = "0.0000";
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.ShadowDecoration.Parent = this.txtDescuento;
            this.txtDescuento.Size = new System.Drawing.Size(256, 36);
            this.txtDescuento.TabIndex = 70;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuento_KeyPress);
            this.txtDescuento.Leave += new System.EventHandler(this.descuentoTextBox_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.manejoReservasBindingSource, "total", true));
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(246, 390);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "0.0000";
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(256, 36);
            this.txtTotal.TabIndex = 71;
            // 
            // txtFechaReserva
            // 
            this.txtFechaReserva.Animated = true;
            this.txtFechaReserva.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFechaReserva.BorderRadius = 14;
            this.txtFechaReserva.BorderThickness = 1;
            this.txtFechaReserva.CheckedState.Parent = this.txtFechaReserva;
            this.txtFechaReserva.CustomFormat = "dd/MM/yyyy";
            this.txtFechaReserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "fechaReserva", true));
            this.txtFechaReserva.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaReserva", true));
            this.txtFechaReserva.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaReserva.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFechaReserva.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaReserva.HoverState.Parent = this.txtFechaReserva;
            this.txtFechaReserva.Location = new System.Drawing.Point(246, 97);
            this.txtFechaReserva.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaReserva.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.txtFechaReserva.Name = "txtFechaReserva";
            this.txtFechaReserva.ShadowDecoration.Parent = this.txtFechaReserva;
            this.txtFechaReserva.ShowCheckBox = true;
            this.txtFechaReserva.Size = new System.Drawing.Size(256, 36);
            this.txtFechaReserva.TabIndex = 72;
            this.txtFechaReserva.Value = new System.DateTime(2021, 6, 9, 18, 38, 15, 485);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtFechaCheckOut
            // 
            this.txtFechaCheckOut.Animated = true;
            this.txtFechaCheckOut.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFechaCheckOut.BorderRadius = 14;
            this.txtFechaCheckOut.BorderThickness = 1;
            this.txtFechaCheckOut.CheckedState.Parent = this.txtFechaCheckOut;
            this.txtFechaCheckOut.CustomFormat = "dd/MM/yyyy";
            this.txtFechaCheckOut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "fechaCheckOut", true));
            this.txtFechaCheckOut.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaCheckOut", true));
            this.txtFechaCheckOut.Enabled = false;
            this.txtFechaCheckOut.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaCheckOut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFechaCheckOut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFechaCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaCheckOut.HoverState.Parent = this.txtFechaCheckOut;
            this.txtFechaCheckOut.Location = new System.Drawing.Point(246, 181);
            this.txtFechaCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaCheckOut.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.txtFechaCheckOut.Name = "txtFechaCheckOut";
            this.txtFechaCheckOut.ShadowDecoration.Parent = this.txtFechaCheckOut;
            this.txtFechaCheckOut.ShowCheckBox = true;
            this.txtFechaCheckOut.Size = new System.Drawing.Size(256, 36);
            this.txtFechaCheckOut.TabIndex = 73;
            this.txtFechaCheckOut.Value = new System.DateTime(2021, 6, 9, 18, 38, 15, 485);
            // 
            // txtFechaCheckIn
            // 
            this.txtFechaCheckIn.Animated = true;
            this.txtFechaCheckIn.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFechaCheckIn.BorderRadius = 14;
            this.txtFechaCheckIn.BorderThickness = 1;
            this.txtFechaCheckIn.CheckedState.Parent = this.txtFechaCheckIn;
            this.txtFechaCheckIn.CustomFormat = "dd/MM/yyyy";
            this.txtFechaCheckIn.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.manejoReservasBindingSource, "fechaCheckIn", true));
            this.txtFechaCheckIn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manejoReservasBindingSource, "fechaCheckIn", true));
            this.txtFechaCheckIn.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFechaCheckIn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFechaCheckIn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFechaCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaCheckIn.HoverState.Parent = this.txtFechaCheckIn;
            this.txtFechaCheckIn.Location = new System.Drawing.Point(246, 139);
            this.txtFechaCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechaCheckIn.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.txtFechaCheckIn.Name = "txtFechaCheckIn";
            this.txtFechaCheckIn.ShadowDecoration.Parent = this.txtFechaCheckIn;
            this.txtFechaCheckIn.ShowCheckBox = true;
            this.txtFechaCheckIn.Size = new System.Drawing.Size(256, 36);
            this.txtFechaCheckIn.TabIndex = 74;
            this.txtFechaCheckIn.Value = new System.DateTime(2021, 6, 9, 18, 38, 15, 485);
            // 
            // sp_MostrarManejoReservasBindingSource
            // 
            this.sp_MostrarManejoReservasBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.spMostrarManejoReservas);
            // 
            // frmManejoReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.txtFechaCheckIn);
            this.Controls.Add(this.txtFechaCheckOut);
            this.Controls.Add(this.txtFechaReserva);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPagoAdelantado);
            this.Controls.Add(this.txtDiasAlojamiento);
            this.Controls.Add(idHuespedLabel);
            this.Controls.Add(this.cbIdHuesped);
            this.Controls.Add(habitacionLabel);
            this.Controls.Add(this.cbHabitacion);
            this.Controls.Add(descuentoLabel);
            this.Controls.Add(fechaCheckInLabel);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(fechaReservaLabel);
            this.Controls.Add(numeroDiasLabel);
            this.Controls.Add(pagoAdelantadoLabel);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdReserva);
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
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasAlojamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manejoReservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_MostrarManejoReservasBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource manejoReservasBindingSource;
        private System.Windows.Forms.BindingSource sp_MostrarManejoReservasBindingSource;
        public Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        public System.Windows.Forms.Label lblCheckOut;
        public Guna.UI2.WinForms.Guna2ComboBox cbIdHuesped;
        private System.Windows.Forms.BindingSource huespedesBindingSource;
        public Guna.UI2.WinForms.Guna2TextBox txtIdReserva;
        public Guna.UI2.WinForms.Guna2NumericUpDown txtDiasAlojamiento;
        public Guna.UI2.WinForms.Guna2TextBox txtPagoAdelantado;
        public Guna.UI2.WinForms.Guna2TextBox txtTotal;
        public Guna.UI2.WinForms.Guna2TextBox txtDescuento;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtFechaReserva;
        private System.Windows.Forms.ErrorProvider errorProvider;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtFechaCheckIn;
        public Guna.UI2.WinForms.Guna2DateTimePicker txtFechaCheckOut;
        public Guna.UI2.WinForms.Guna2ComboBox cbHabitacion;
    }
}