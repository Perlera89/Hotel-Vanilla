
namespace Hotel_Vanilla.Vista
{
    partial class frmManejoHabitaciones
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
            System.Windows.Forms.Label numeroHabitacionLabel;
            System.Windows.Forms.Label tarifaLabel;
            System.Windows.Forms.Label tipodehabitacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoHabitaciones));
            this.idCaja = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDefault = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.numeroHabitacionTextBox = new System.Windows.Forms.TextBox();
            this.tarifaTextBox = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblidHabitacion = new System.Windows.Forms.Label();
            this.cbTipoHabitacion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipoHabitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spMostrarHabitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            numeroHabitacionLabel = new System.Windows.Forms.Label();
            tarifaLabel = new System.Windows.Forms.Label();
            tipodehabitacionLabel = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoHabitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarHabitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroHabitacionLabel
            // 
            numeroHabitacionLabel.AutoSize = true;
            numeroHabitacionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroHabitacionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            numeroHabitacionLabel.Location = new System.Drawing.Point(65, 289);
            numeroHabitacionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroHabitacionLabel.Name = "numeroHabitacionLabel";
            numeroHabitacionLabel.Size = new System.Drawing.Size(165, 19);
            numeroHabitacionLabel.TabIndex = 61;
            numeroHabitacionLabel.Text = "Numero habitacion:";
            // 
            // tarifaLabel
            // 
            tarifaLabel.AutoSize = true;
            tarifaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tarifaLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            tarifaLabel.Location = new System.Drawing.Point(65, 330);
            tarifaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tarifaLabel.Name = "tarifaLabel";
            tarifaLabel.Size = new System.Drawing.Size(55, 19);
            tarifaLabel.TabIndex = 63;
            tarifaLabel.Text = "Tarifa:";
            // 
            // tipodehabitacionLabel
            // 
            tipodehabitacionLabel.AutoSize = true;
            tipodehabitacionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            tipodehabitacionLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            tipodehabitacionLabel.Location = new System.Drawing.Point(65, 377);
            tipodehabitacionLabel.Name = "tipodehabitacionLabel";
            tipodehabitacionLabel.Size = new System.Drawing.Size(159, 19);
            tipodehabitacionLabel.TabIndex = 65;
            tipodehabitacionLabel.Text = "Tipo de habitacion:";
            // 
            // idCaja
            // 
            this.idCaja.Animated = true;
            this.idCaja.BackColor = System.Drawing.Color.RoyalBlue;
            this.idCaja.BorderColor = System.Drawing.Color.RoyalBlue;
            this.idCaja.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.idCaja.BorderThickness = 2;
            this.idCaja.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idCaja.DefaultText = "";
            this.idCaja.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idCaja.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idCaja.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idCaja.DisabledState.Parent = this.idCaja;
            this.idCaja.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idCaja.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idCaja.FocusedState.Parent = this.idCaja;
            this.idCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.idCaja.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idCaja.HoverState.Parent = this.idCaja;
            this.idCaja.Location = new System.Drawing.Point(639, 69);
            this.idCaja.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.idCaja.Name = "idCaja";
            this.idCaja.PasswordChar = '\0';
            this.idCaja.PlaceholderText = "";
            this.idCaja.ReadOnly = true;
            this.idCaja.SelectedText = "";
            this.idCaja.ShadowDecoration.Parent = this.idCaja;
            this.idCaja.Size = new System.Drawing.Size(101, 67);
            this.idCaja.TabIndex = 54;
            this.idCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.panelSuperior.TabIndex = 47;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(200, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(468, 29);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "MANTENIMIENTO DE HABITACIONES";
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
            this.panelInferior.Location = new System.Drawing.Point(0, 478);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(800, 50);
            this.panelInferior.TabIndex = 56;
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
            this.btnCancelar.Location = new System.Drawing.Point(540, 345);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(200, 51);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Textcolor = System.Drawing.Color.Red;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(540, 280);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(200, 51);
            this.btnGuardar.TabIndex = 45;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.Enter += new System.EventHandler(this.btnGuardar_Enter);
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
            // numeroHabitacionTextBox
            // 
            this.numeroHabitacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spMostrarHabitacionesBindingSource, "numeroHabitacion", true));
            this.numeroHabitacionTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroHabitacionTextBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.numeroHabitacionTextBox.Location = new System.Drawing.Point(234, 285);
            this.numeroHabitacionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numeroHabitacionTextBox.Name = "numeroHabitacionTextBox";
            this.numeroHabitacionTextBox.Size = new System.Drawing.Size(263, 27);
            this.numeroHabitacionTextBox.TabIndex = 62;
            // 
            // tarifaTextBox
            // 
            this.tarifaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spMostrarHabitacionesBindingSource, "tarifa", true));
            this.tarifaTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifaTextBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tarifaTextBox.Location = new System.Drawing.Point(234, 326);
            this.tarifaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tarifaTextBox.Name = "tarifaTextBox";
            this.tarifaTextBox.Size = new System.Drawing.Size(263, 27);
            this.tarifaTextBox.TabIndex = 64;
            this.tarifaTextBox.TextChanged += new System.EventHandler(this.tarifaTextBox_TextChanged);
            this.tarifaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tarifaTextBox_KeyDown);
            this.tarifaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tarifaTextBox_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblId.Location = new System.Drawing.Point(650, 94);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 20);
            this.lblId.TabIndex = 55;
            this.lblId.Text = "Id: ";
            // 
            // lblidHabitacion
            // 
            this.lblidHabitacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spMostrarHabitacionesBindingSource, "idHabitacion", true));
            this.lblidHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidHabitacion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblidHabitacion.Location = new System.Drawing.Point(680, 94);
            this.lblidHabitacion.Name = "lblidHabitacion";
            this.lblidHabitacion.Size = new System.Drawing.Size(41, 23);
            this.lblidHabitacion.TabIndex = 65;
            this.lblidHabitacion.Text = "1";
            // 
            // cbTipoHabitacion
            // 
            this.cbTipoHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoHabitacion.BorderRadius = 14;
            this.cbTipoHabitacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoHabitacionesBindingSource, "Tipodehabitacion", true));
            this.cbTipoHabitacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoHabitacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipoHabitacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTipoHabitacion.FocusedState.Parent = this.cbTipoHabitacion;
            this.cbTipoHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbTipoHabitacion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbTipoHabitacion.FormattingEnabled = true;
            this.cbTipoHabitacion.HoverState.Parent = this.cbTipoHabitacion;
            this.cbTipoHabitacion.ItemHeight = 30;
            this.cbTipoHabitacion.ItemsAppearance.Parent = this.cbTipoHabitacion;
            this.cbTipoHabitacion.Location = new System.Drawing.Point(234, 365);
            this.cbTipoHabitacion.Name = "cbTipoHabitacion";
            this.cbTipoHabitacion.ShadowDecoration.Parent = this.cbTipoHabitacion;
            this.cbTipoHabitacion.Size = new System.Drawing.Size(263, 36);
            this.cbTipoHabitacion.TabIndex = 66;
            this.cbTipoHabitacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipoHabitacion_KeyDown);
            this.cbTipoHabitacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipoHabitacion_KeyPress);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tipoHabitacionesBindingSource
            // 
            this.tipoHabitacionesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.TipoHabitaciones);
            // 
            // spMostrarHabitacionesBindingSource
            // 
            this.spMostrarHabitacionesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.sp_MostrarHabitaciones);
            // 
            // habitacionesBindingSource
            // 
            this.habitacionesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.Habitaciones);
            // 
            // frmManejoHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(tipodehabitacionLabel);
            this.Controls.Add(this.cbTipoHabitacion);
            this.Controls.Add(this.lblidHabitacion);
            this.Controls.Add(numeroHabitacionLabel);
            this.Controls.Add(this.numeroHabitacionTextBox);
            this.Controls.Add(tarifaLabel);
            this.Controls.Add(this.tarifaTextBox);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.idCaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManejoHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Habitaciones";
            this.Load += new System.EventHandler(this.frmManejoHabitaciones_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoHabitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spMostrarHabitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox idCaja;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.Panel panelSuperior;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnDefault;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelInferior;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.BindingSource habitacionesBindingSource;
        private System.Windows.Forms.Label lblId;
        public Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        public System.Windows.Forms.TextBox numeroHabitacionTextBox;
        public System.Windows.Forms.TextBox tarifaTextBox;
        public System.Windows.Forms.Label lblidHabitacion;
        private System.Windows.Forms.BindingSource spMostrarHabitacionesBindingSource;
        private System.Windows.Forms.BindingSource tipoHabitacionesBindingSource;
        public Guna.UI2.WinForms.Guna2ComboBox cbTipoHabitacion;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}