
namespace Hotel_Vanilla.Vista
{
    partial class frmManejoHuespedes
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
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label idEstado_FKLabel;
            System.Windows.Forms.Label idHuespedLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoHuespedes));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDefault = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelInferior = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.huespedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.idEstado_FKTextBox = new System.Windows.Forms.TextBox();
            this.idHuespedTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            apellidosLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            idEstado_FKLabel = new System.Windows.Forms.Label();
            idHuespedLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(80, 179);
            apellidosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 46;
            apellidosLabel.Text = "Apellidos:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(80, 256);
            correoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 48;
            correoLabel.Text = "Correo:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(80, 200);
            direccionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 50;
            direccionLabel.Text = "Dirección:";
            // 
            // idEstado_FKLabel
            // 
            idEstado_FKLabel.AutoSize = true;
            idEstado_FKLabel.Location = new System.Drawing.Point(80, 279);
            idEstado_FKLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idEstado_FKLabel.Name = "idEstado_FKLabel";
            idEstado_FKLabel.Size = new System.Drawing.Size(55, 13);
            idEstado_FKLabel.TabIndex = 52;
            idEstado_FKLabel.Text = "Id Estado:";
            // 
            // idHuespedLabel
            // 
            idHuespedLabel.AutoSize = true;
            idHuespedLabel.Location = new System.Drawing.Point(474, 97);
            idHuespedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idHuespedLabel.Name = "idHuespedLabel";
            idHuespedLabel.Size = new System.Drawing.Size(68, 13);
            idHuespedLabel.TabIndex = 54;
            idHuespedLabel.Text = "Id Huesped :";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(80, 158);
            nombresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 56;
            nombresLabel.Text = "Nombres:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(80, 226);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 58;
            telefonoLabel.Text = "Teléfono:";
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
            this.panelSuperior.TabIndex = 32;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(217, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(435, 29);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "MANTENIMIENTO DE HUESPEDES";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(650, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Id: ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.Gold;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 450);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(800, 50);
            this.panelInferior.TabIndex = 45;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.panelSuperior;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(153, 177);
            this.apellidosTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(263, 20);
            this.apellidosTextBox.TabIndex = 47;
            // 
            // huespedesBindingSource
            // 
            this.huespedesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.Huespedes);
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(153, 254);
            this.correoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(263, 20);
            this.correoTextBox.TabIndex = 49;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(153, 198);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(263, 20);
            this.direccionTextBox.TabIndex = 51;
            // 
            // idEstado_FKTextBox
            // 
            this.idEstado_FKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "idEstado_FK", true));
            this.idEstado_FKTextBox.Location = new System.Drawing.Point(153, 277);
            this.idEstado_FKTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idEstado_FKTextBox.Name = "idEstado_FKTextBox";
            this.idEstado_FKTextBox.Size = new System.Drawing.Size(263, 20);
            this.idEstado_FKTextBox.TabIndex = 53;
            // 
            // idHuespedTextBox
            // 
            this.idHuespedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "idHuesped", true));
            this.idHuespedTextBox.Location = new System.Drawing.Point(547, 95);
            this.idHuespedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idHuespedTextBox.Name = "idHuespedTextBox";
            this.idHuespedTextBox.Size = new System.Drawing.Size(68, 20);
            this.idHuespedTextBox.TabIndex = 55;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(153, 156);
            this.nombresTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(263, 20);
            this.nombresTextBox.TabIndex = 57;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.huespedesBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(153, 224);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(263, 20);
            this.telefonoTextBox.TabIndex = 59;
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
            this.btnCancelar.Location = new System.Drawing.Point(490, 359);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Red;
            this.btnCancelar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(250, 51);
            this.btnCancelar.TabIndex = 31;
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
            this.btnGuardar.Location = new System.Drawing.Point(490, 292);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(250, 51);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // frmManejoHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(idEstado_FKLabel);
            this.Controls.Add(this.idEstado_FKTextBox);
            this.Controls.Add(idHuespedLabel);
            this.Controls.Add(this.idHuespedTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManejoHuespedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Huespedes";
            this.Load += new System.EventHandler(this.frmManejoHuespedes_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private System.Windows.Forms.Panel panelSuperior;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btnDefault;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelInferior;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.BindingSource huespedesBindingSource;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public System.Windows.Forms.TextBox apellidosTextBox;
        public System.Windows.Forms.TextBox correoTextBox;
        public System.Windows.Forms.TextBox direccionTextBox;
        public System.Windows.Forms.TextBox idEstado_FKTextBox;
        public System.Windows.Forms.TextBox idHuespedTextBox;
        public System.Windows.Forms.TextBox nombresTextBox;
        public System.Windows.Forms.TextBox telefonoTextBox;
        public Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
    }
}