
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoReservas));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDefault = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtFechaReserva = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCheckin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCheckout = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDias = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPagos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescuento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbbHabitacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbHuesped = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).BeginInit();
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
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 50);
            this.panelSuperior.TabIndex = 11;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(191, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(436, 28);
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
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelInferior.Location = new System.Drawing.Point(0, 450);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(800, 50);
            this.panelInferior.TabIndex = 12;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtFechaReserva
            // 
            this.txtFechaReserva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFechaReserva.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaReserva.ForeColor = System.Drawing.Color.Black;
            this.txtFechaReserva.HintForeColor = System.Drawing.Color.Empty;
            this.txtFechaReserva.HintText = "Fecha de reserva";
            this.txtFechaReserva.isPassword = false;
            this.txtFechaReserva.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtFechaReserva.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtFechaReserva.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFechaReserva.LineThickness = 4;
            this.txtFechaReserva.Location = new System.Drawing.Point(59, 67);
            this.txtFechaReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaReserva.Name = "txtFechaReserva";
            this.txtFechaReserva.Size = new System.Drawing.Size(379, 33);
            this.txtFechaReserva.TabIndex = 16;
            this.txtFechaReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCheckin
            // 
            this.txtCheckin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckin.ForeColor = System.Drawing.Color.Black;
            this.txtCheckin.HintForeColor = System.Drawing.Color.Empty;
            this.txtCheckin.HintText = "Check in";
            this.txtCheckin.isPassword = false;
            this.txtCheckin.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtCheckin.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtCheckin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCheckin.LineThickness = 4;
            this.txtCheckin.Location = new System.Drawing.Point(59, 108);
            this.txtCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckin.Name = "txtCheckin";
            this.txtCheckin.Size = new System.Drawing.Size(379, 33);
            this.txtCheckin.TabIndex = 17;
            this.txtCheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCheckout
            // 
            this.txtCheckout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckout.ForeColor = System.Drawing.Color.Black;
            this.txtCheckout.HintForeColor = System.Drawing.Color.Empty;
            this.txtCheckout.HintText = "Check out";
            this.txtCheckout.isPassword = false;
            this.txtCheckout.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtCheckout.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtCheckout.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCheckout.LineThickness = 4;
            this.txtCheckout.Location = new System.Drawing.Point(59, 149);
            this.txtCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckout.Name = "txtCheckout";
            this.txtCheckout.Size = new System.Drawing.Size(379, 33);
            this.txtCheckout.TabIndex = 18;
            this.txtCheckout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDias
            // 
            this.txtDias.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.ForeColor = System.Drawing.Color.Black;
            this.txtDias.HintForeColor = System.Drawing.Color.Empty;
            this.txtDias.HintText = "Dias";
            this.txtDias.isPassword = false;
            this.txtDias.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtDias.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtDias.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDias.LineThickness = 4;
            this.txtDias.Location = new System.Drawing.Point(59, 190);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(379, 33);
            this.txtDias.TabIndex = 19;
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPagos
            // 
            this.txtPagos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPagos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagos.ForeColor = System.Drawing.Color.Black;
            this.txtPagos.HintForeColor = System.Drawing.Color.Empty;
            this.txtPagos.HintText = "Pago adelantado";
            this.txtPagos.isPassword = false;
            this.txtPagos.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtPagos.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtPagos.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPagos.LineThickness = 4;
            this.txtPagos.Location = new System.Drawing.Point(59, 231);
            this.txtPagos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagos.Name = "txtPagos";
            this.txtPagos.Size = new System.Drawing.Size(379, 33);
            this.txtPagos.TabIndex = 20;
            this.txtPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescuento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.ForeColor = System.Drawing.Color.Black;
            this.txtDescuento.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescuento.HintText = "Descuento";
            this.txtDescuento.isPassword = false;
            this.txtDescuento.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtDescuento.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtDescuento.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDescuento.LineThickness = 4;
            this.txtDescuento.Location = new System.Drawing.Point(59, 272);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(379, 33);
            this.txtDescuento.TabIndex = 21;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtTotal.HintText = "Total";
            this.txtTotal.isPassword = false;
            this.txtTotal.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.txtTotal.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txtTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTotal.LineThickness = 4;
            this.txtTotal.Location = new System.Drawing.Point(59, 313);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(379, 33);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbbHabitacion
            // 
            this.cbbHabitacion.Animated = true;
            this.cbbHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.cbbHabitacion.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cbbHabitacion.BorderThickness = 2;
            this.cbbHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHabitacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbHabitacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbHabitacion.FocusedState.Parent = this.cbbHabitacion;
            this.cbbHabitacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHabitacion.ForeColor = System.Drawing.Color.Black;
            this.cbbHabitacion.HoverState.Parent = this.cbbHabitacion;
            this.cbbHabitacion.ItemHeight = 30;
            this.cbbHabitacion.Items.AddRange(new object[] {
            "Habitacion"});
            this.cbbHabitacion.ItemsAppearance.Parent = this.cbbHabitacion;
            this.cbbHabitacion.Location = new System.Drawing.Point(59, 353);
            this.cbbHabitacion.Name = "cbbHabitacion";
            this.cbbHabitacion.ShadowDecoration.Parent = this.cbbHabitacion;
            this.cbbHabitacion.Size = new System.Drawing.Size(379, 36);
            this.cbbHabitacion.TabIndex = 28;
            this.cbbHabitacion.Tag = "Habitacion";
            // 
            // cbbHuesped
            // 
            this.cbbHuesped.Animated = true;
            this.cbbHuesped.BackColor = System.Drawing.Color.Transparent;
            this.cbbHuesped.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cbbHuesped.BorderThickness = 2;
            this.cbbHuesped.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHuesped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHuesped.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbHuesped.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbHuesped.FocusedState.Parent = this.cbbHuesped;
            this.cbbHuesped.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHuesped.ForeColor = System.Drawing.Color.Black;
            this.cbbHuesped.HoverState.Parent = this.cbbHuesped;
            this.cbbHuesped.ItemHeight = 30;
            this.cbbHuesped.Items.AddRange(new object[] {
            "Huesped"});
            this.cbbHuesped.ItemsAppearance.Parent = this.cbbHuesped;
            this.cbbHuesped.Location = new System.Drawing.Point(59, 395);
            this.cbbHuesped.Name = "cbbHuesped";
            this.cbbHuesped.ShadowDecoration.Parent = this.cbbHuesped;
            this.cbbHuesped.Size = new System.Drawing.Size(379, 36);
            this.cbbHuesped.TabIndex = 29;
            this.cbbHuesped.Tag = "Huesped";
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
            this.btnCancelar.Location = new System.Drawing.Point(490, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(250, 51);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.Red;
            this.btnCancelar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnGuardar.Location = new System.Drawing.Point(490, 313);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(250, 51);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.guna2TextBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(650, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id: ";
            // 
            // frmManejoReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.cbbHuesped);
            this.Controls.Add(this.cbbHabitacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPagos);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtCheckout);
            this.Controls.Add(this.txtCheckin);
            this.Controls.Add(this.txtFechaReserva);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManejoReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Reservaciones";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).EndInit();
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDias;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCheckout;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCheckin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFechaReserva;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescuento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPagos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTotal;
        private Bunifu.Framework.UI.BunifuImageButton btnDefault;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbHuesped;
        private Guna.UI2.WinForms.Guna2ComboBox cbbHabitacion;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
    }
}