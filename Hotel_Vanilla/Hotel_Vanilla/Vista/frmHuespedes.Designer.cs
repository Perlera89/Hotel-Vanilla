
namespace Hotel_Vanilla.Vista
{
    partial class frmHuespedes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtBuscar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.huespedesGuna2DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huespedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesGuna2DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoEllipsis = true;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(21, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(224, 24);
            this.bunifuCustomLabel1.TabIndex = 48;
            this.bunifuCustomLabel1.Text = "Gestion de Huespedes";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = global::Hotel_Vanilla.Properties.Resources.buscarHuesped;
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(689, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 38);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
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
            this.txtBuscar.Location = new System.Drawing.Point(742, 22);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(156, 38);
            this.txtBuscar.TabIndex = 54;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.huespedesGuna2DataGridView);
            this.panel1.Location = new System.Drawing.Point(22, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 374);
            this.panel1.TabIndex = 55;
            // 
            // huespedesGuna2DataGridView
            // 
            this.huespedesGuna2DataGridView.AllowUserToAddRows = false;
            this.huespedesGuna2DataGridView.AllowUserToDeleteRows = false;
            this.huespedesGuna2DataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.huespedesGuna2DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.huespedesGuna2DataGridView.AutoGenerateColumns = false;
            this.huespedesGuna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.huespedesGuna2DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.huespedesGuna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.huespedesGuna2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.huespedesGuna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.huespedesGuna2DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.huespedesGuna2DataGridView.ColumnHeadersHeight = 21;
            this.huespedesGuna2DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.huespedesGuna2DataGridView.DataSource = this.huespedesBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.huespedesGuna2DataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.huespedesGuna2DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.huespedesGuna2DataGridView.EnableHeadersVisualStyles = false;
            this.huespedesGuna2DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.huespedesGuna2DataGridView.Location = new System.Drawing.Point(0, 0);
            this.huespedesGuna2DataGridView.Name = "huespedesGuna2DataGridView";
            this.huespedesGuna2DataGridView.ReadOnly = true;
            this.huespedesGuna2DataGridView.RowHeadersVisible = false;
            this.huespedesGuna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.huespedesGuna2DataGridView.Size = new System.Drawing.Size(876, 374);
            this.huespedesGuna2DataGridView.TabIndex = 0;
            this.huespedesGuna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.huespedesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.huespedesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.huespedesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.huespedesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.huespedesGuna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.huespedesGuna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.huespedesGuna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.huespedesGuna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.huespedesGuna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.huespedesGuna2DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.huespedesGuna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.huespedesGuna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.huespedesGuna2DataGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.huespedesGuna2DataGridView.ThemeStyle.ReadOnly = true;
            this.huespedesGuna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.huespedesGuna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.huespedesGuna2DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.huespedesGuna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.huespedesGuna2DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.huespedesGuna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.huespedesGuna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 7;
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = global::Hotel_Vanilla.Properties.Resources.agregarHuesped;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(22, 448);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(169, 49);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.BorderRadius = 7;
            this.btnActualizar.ButtonText = "Actualizar";
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizar.Iconimage = global::Hotel_Vanilla.Properties.Resources.editarHuesped;
            this.btnActualizar.Iconimage_right = null;
            this.btnActualizar.Iconimage_right_Selected = null;
            this.btnActualizar.Iconimage_Selected = null;
            this.btnActualizar.IconMarginLeft = 0;
            this.btnActualizar.IconMarginRight = 0;
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconRightZoom = 0D;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.IconZoom = 90D;
            this.btnActualizar.IsTab = false;
            this.btnActualizar.Location = new System.Drawing.Point(196, 448);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnActualizar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnActualizar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.selected = false;
            this.btnActualizar.Size = new System.Drawing.Size(169, 49);
            this.btnActualizar.TabIndex = 57;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnActualizar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 7;
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = global::Hotel_Vanilla.Properties.Resources.eliminarHuesped;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(729, 448);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.OnHoverTextColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(169, 49);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Textcolor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idHuesped";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombres";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "correo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idEstado_FK";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // huespedesBindingSource
            // 
            this.huespedesBindingSource.DataSource = typeof(Hotel_Vanilla.ENTIDAD.Huespedes);
            // 
            // frmHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 527);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHuespedes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmHuespedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.huespedesGuna2DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.BindingSource huespedesBindingSource;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBuscar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView huespedesGuna2DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
    }
}