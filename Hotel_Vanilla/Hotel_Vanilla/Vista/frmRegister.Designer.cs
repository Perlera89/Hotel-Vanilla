
namespace Hotel_Vanilla.Vista
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label nombreLabel;
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkClave = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelInferior = new System.Windows.Forms.Panel();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            claveLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(claveLabel);
            this.panelContenedor.Controls.Add(this.claveTextBox);
            this.panelContenedor.Controls.Add(correoLabel);
            this.panelContenedor.Controls.Add(this.correoTextBox);
            this.panelContenedor.Controls.Add(nombreLabel);
            this.panelContenedor.Controls.Add(this.nombreTextBox);
            this.panelContenedor.Controls.Add(this.bunifuCustomLabel1);
            this.panelContenedor.Controls.Add(this.chkClave);
            this.panelContenedor.Controls.Add(this.btnRegister);
            this.panelContenedor.Controls.Add(this.btnLogin);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Location = new System.Drawing.Point(116, 125);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1119, 620);
            this.panelContenedor.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(327, 388);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(117, 22);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Mostrar clave";
            // 
            // chkClave
            // 
            this.chkClave.BackColor = System.Drawing.Color.RoyalBlue;
            this.chkClave.ChechedOffColor = System.Drawing.Color.RoyalBlue;
            this.chkClave.Checked = true;
            this.chkClave.CheckedOnColor = System.Drawing.Color.RoyalBlue;
            this.chkClave.ForeColor = System.Drawing.Color.White;
            this.chkClave.Location = new System.Drawing.Point(288, 388);
            this.chkClave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chkClave.Name = "chkClave";
            this.chkClave.Size = new System.Drawing.Size(20, 20);
            this.chkClave.TabIndex = 9;
            this.chkClave.OnChange += new System.EventHandler(this.chkClave_OnChange);
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.White;
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "Registrarse";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.White;
            this.btnRegister.IdleForecolor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.IdleLineColor = System.Drawing.Color.RoyalBlue;
            this.btnRegister.Location = new System.Drawing.Point(423, 422);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(272, 63);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Image = global::Hotel_Vanilla.Properties.Resources.usuario1;
            this.btnLogin.Location = new System.Drawing.Point(522, 540);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(69, 60);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 492);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar Sesion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Vanilla.Properties.Resources.id_card;
            this.pictureBox1.Location = new System.Drawing.Point(460, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paneSuperior
            // 
            this.paneSuperior.BackColor = System.Drawing.Color.RoyalBlue;
            this.paneSuperior.Controls.Add(this.btnMinimizar);
            this.paneSuperior.Controls.Add(this.btnCerrar);
            this.paneSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneSuperior.Location = new System.Drawing.Point(0, 0);
            this.paneSuperior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paneSuperior.Name = "paneSuperior";
            this.paneSuperior.Size = new System.Drawing.Size(1356, 234);
            this.paneSuperior.TabIndex = 3;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimizar.Image = global::Hotel_Vanilla.Properties.Resources.menos;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(1239, 5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(54, 51);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Image = global::Hotel_Vanilla.Properties.Resources.cerrar__1_;
            this.btnCerrar.Location = new System.Drawing.Point(1302, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 51);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.paneSuperior;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.Gold;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 748);
            this.panelInferior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(1356, 123);
            this.panelInferior.TabIndex = 4;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.Usuarios);
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(462, 335);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(49, 20);
            claveLabel.TabIndex = 9;
            claveLabel.Text = "clave:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(552, 332);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(100, 26);
            this.claveTextBox.TabIndex = 10;
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(462, 271);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(58, 20);
            correoLabel.TabIndex = 11;
            correoLabel.Text = "correo:";
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(552, 268);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(100, 26);
            this.correoTextBox.TabIndex = 12;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(462, 207);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(67, 20);
            nombreLabel.TabIndex = 15;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(552, 204);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 26);
            this.nombreTextBox.TabIndex = 16;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 871);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.paneSuperior);
            this.Controls.Add(this.panelInferior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel paneSuperior;
        private System.Windows.Forms.Panel panelContenedor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private System.Windows.Forms.Panel panelInferior;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox chkClave;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}