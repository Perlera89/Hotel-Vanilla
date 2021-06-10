
namespace Hotel_Vanilla.Vista
{
    partial class frmSucesos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSucesos));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.panelLista = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgSucesos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucesosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnUltimos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTodos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRecargar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSucesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucesosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoEllipsis = true;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 27);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(90, 24);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Sucesos";
            // 
            // panelLista
            // 
            this.panelLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLista.Controls.Add(this.dtgSucesos);
            this.panelLista.Location = new System.Drawing.Point(29, 73);
            this.panelLista.Name = "panelLista";
            this.panelLista.ShadowDecoration.Parent = this.panelLista;
            this.panelLista.Size = new System.Drawing.Size(898, 403);
            this.panelLista.TabIndex = 13;
            // 
            // dtgSucesos
            // 
            this.dtgSucesos.AllowUserToAddRows = false;
            this.dtgSucesos.AllowUserToDeleteRows = false;
            this.dtgSucesos.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dtgSucesos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgSucesos.AutoGenerateColumns = false;
            this.dtgSucesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgSucesos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSucesos.BackgroundColor = System.Drawing.Color.White;
            this.dtgSucesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgSucesos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgSucesos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSucesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgSucesos.ColumnHeadersHeight = 40;
            this.dtgSucesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgSucesos.DataSource = this.sucesosBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgSucesos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgSucesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgSucesos.EnableHeadersVisualStyles = false;
            this.dtgSucesos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgSucesos.Location = new System.Drawing.Point(0, 0);
            this.dtgSucesos.MultiSelect = false;
            this.dtgSucesos.Name = "dtgSucesos";
            this.dtgSucesos.ReadOnly = true;
            this.dtgSucesos.RowHeadersVisible = false;
            this.dtgSucesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSucesos.Size = new System.Drawing.Size(898, 403);
            this.dtgSucesos.TabIndex = 0;
            this.dtgSucesos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgSucesos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgSucesos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgSucesos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgSucesos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgSucesos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgSucesos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgSucesos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgSucesos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgSucesos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgSucesos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgSucesos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgSucesos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgSucesos.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgSucesos.ThemeStyle.ReadOnly = true;
            this.dtgSucesos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgSucesos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgSucesos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgSucesos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgSucesos.ThemeStyle.RowsStyle.Height = 22;
            this.dtgSucesos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgSucesos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idSuceso";
            this.dataGridViewTextBoxColumn1.FillWeight = 0.7992221F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fechaSuceso";
            this.dataGridViewTextBoxColumn2.FillWeight = 31.66314F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 67;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipoSuceso";
            this.dataGridViewTextBoxColumn3.FillWeight = 62.71526F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 58;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn4.FillWeight = 1154.822F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // sucesosBindingSource
            // 
            this.sucesosBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.Sucesos);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnUltimos
            // 
            this.btnUltimos.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnUltimos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUltimos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUltimos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimos.BorderRadius = 0;
            this.btnUltimos.ButtonText = "Cargar ultimos";
            this.btnUltimos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimos.DisabledColor = System.Drawing.Color.Gray;
            this.btnUltimos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUltimos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUltimos.Iconimage")));
            this.btnUltimos.Iconimage_right = null;
            this.btnUltimos.Iconimage_right_Selected = null;
            this.btnUltimos.Iconimage_Selected = null;
            this.btnUltimos.IconMarginLeft = 0;
            this.btnUltimos.IconMarginRight = 0;
            this.btnUltimos.IconRightVisible = true;
            this.btnUltimos.IconRightZoom = 0D;
            this.btnUltimos.IconVisible = true;
            this.btnUltimos.IconZoom = 90D;
            this.btnUltimos.IsTab = false;
            this.btnUltimos.Location = new System.Drawing.Point(619, 484);
            this.btnUltimos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUltimos.Name = "btnUltimos";
            this.btnUltimos.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnUltimos.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnUltimos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUltimos.selected = false;
            this.btnUltimos.Size = new System.Drawing.Size(150, 34);
            this.btnUltimos.TabIndex = 16;
            this.btnUltimos.Text = "Cargar ultimos";
            this.btnUltimos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimos.Textcolor = System.Drawing.Color.White;
            this.btnUltimos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimos.Click += new System.EventHandler(this.btnUltimos_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Activecolor = System.Drawing.Color.RoyalBlue;
            this.btnTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTodos.BorderRadius = 0;
            this.btnTodos.ButtonText = "Cargar todos";
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodos.DisabledColor = System.Drawing.Color.Gray;
            this.btnTodos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTodos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTodos.Iconimage")));
            this.btnTodos.Iconimage_right = null;
            this.btnTodos.Iconimage_right_Selected = null;
            this.btnTodos.Iconimage_Selected = null;
            this.btnTodos.IconMarginLeft = 0;
            this.btnTodos.IconMarginRight = 0;
            this.btnTodos.IconRightVisible = true;
            this.btnTodos.IconRightZoom = 0D;
            this.btnTodos.IconVisible = true;
            this.btnTodos.IconZoom = 90D;
            this.btnTodos.IsTab = false;
            this.btnTodos.Location = new System.Drawing.Point(777, 484);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btnTodos.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnTodos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTodos.selected = false;
            this.btnTodos.Size = new System.Drawing.Size(150, 34);
            this.btnTodos.TabIndex = 17;
            this.btnTodos.Text = "Cargar todos";
            this.btnTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodos.Textcolor = System.Drawing.Color.White;
            this.btnTodos.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecargar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargar.Image")));
            this.btnRecargar.ImageActive = null;
            this.btnRecargar.Location = new System.Drawing.Point(666, 27);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(46, 38);
            this.btnRecargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecargar.TabIndex = 64;
            this.btnRecargar.TabStop = false;
            this.btnRecargar.Zoom = 10;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.RoyalBlue;
            this.txtBuscar.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtBuscar.BorderThickness = 2;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBuscar.isPassword = false;
            this.txtBuscar.Location = new System.Drawing.Point(771, 27);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(156, 38);
            this.txtBuscar.TabIndex = 63;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::Hotel_Vanilla.Properties.Resources.buscarHabitacion;
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(718, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 38);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmSucesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(951, 536);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnUltimos);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSucesos";
            this.Text = "Sucesos";
            this.Load += new System.EventHandler(this.frmSucesos_Load);
            this.panelLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSucesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucesosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2Panel panelLista;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.BindingSource sucesosBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView dtgSucesos;
        private Bunifu.Framework.UI.BunifuFlatButton btnTodos;
        private Bunifu.Framework.UI.BunifuFlatButton btnUltimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Bunifu.Framework.UI.BunifuImageButton btnRecargar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBuscar;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
    }
}