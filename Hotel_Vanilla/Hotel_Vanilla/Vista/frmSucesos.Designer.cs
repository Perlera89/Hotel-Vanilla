
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSucesos));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.listSuceso = new Zeroit.Framework.ListView.ZeroitListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelLista = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoEllipsis = true;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(25, 27);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 23);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Sucesos";
            // 
            // listSuceso
            // 
            this.listSuceso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSuceso.CellBorderFocused = new Zeroit.Framework.ListView.Editors.PenPainter.PenPainter(System.Drawing.Color.White, 1F, System.Drawing.Drawing2D.DashStyle.Solid);
            this.listSuceso.CellBorderUnFocused = new Zeroit.Framework.ListView.Editors.PenPainter.PenPainter(System.Drawing.Color.White, 1F, System.Drawing.Drawing2D.DashStyle.Solid);
            this.listSuceso.ColumnHeader = new Zeroit.Framework.ListView.Editors.Brushes.BrushPainter(System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225))))));
            this.listSuceso.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listSuceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSuceso.DrawMode = Zeroit.Framework.ListView.ZeroitListView.drawMode.Stylish;
            this.listSuceso.FillFocused = new Zeroit.Framework.ListView.Editors.Brushes.BrushPainter();
            this.listSuceso.FillUnfocused = new Zeroit.Framework.ListView.Editors.Brushes.BrushPainter(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.listSuceso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSuceso.ForeColor = System.Drawing.Color.RoyalBlue;
            this.listSuceso.HeaderAlignment = Zeroit.Framework.ListView.ZeroitListView.headerAlignment.Center;
            this.listSuceso.HeaderBorder = new Zeroit.Framework.ListView.Editors.PenPainter.PenPainter(System.Drawing.Color.White, 1F, System.Drawing.Drawing2D.DashStyle.Solid);
            this.listSuceso.HeaderColor = System.Drawing.Color.White;
            this.listSuceso.HeaderFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSuceso.HideHeader = false;
            this.listSuceso.HideSelection = false;
            this.listSuceso.LineColor = System.Drawing.Color.White;
            this.listSuceso.LineHeight = 1;
            this.listSuceso.Location = new System.Drawing.Point(0, 0);
            this.listSuceso.Name = "listSuceso";
            this.listSuceso.NumberStyles = ((System.Globalization.NumberStyles)((((((((System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite) 
            | System.Globalization.NumberStyles.AllowLeadingSign) 
            | System.Globalization.NumberStyles.AllowTrailingSign) 
            | System.Globalization.NumberStyles.AllowParentheses) 
            | System.Globalization.NumberStyles.AllowDecimalPoint) 
            | System.Globalization.NumberStyles.AllowThousands) 
            | System.Globalization.NumberStyles.AllowCurrencySymbol)));
            this.listSuceso.OwnerDraw = true;
            this.listSuceso.Radius = 15F;
            this.listSuceso.Rounding = false;
            this.listSuceso.ShowBorder = false;
            this.listSuceso.ShowCellBorder = false;
            this.listSuceso.ShowHeaderLine = false;
            this.listSuceso.Size = new System.Drawing.Size(898, 393);
            this.listSuceso.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.listSuceso.SubTextColor = System.Drawing.Color.Red;
            this.listSuceso.SurrondBorder = false;
            this.listSuceso.TabIndex = 12;
            this.listSuceso.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.listSuceso.UseCompatibleStateImageBehavior = false;
            this.listSuceso.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 1000;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.Width = 100;
            // 
            // panelLista
            // 
            this.panelLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLista.Controls.Add(this.listSuceso);
            this.panelLista.Location = new System.Drawing.Point(29, 74);
            this.panelLista.Name = "panelLista";
            this.panelLista.ShadowDecoration.Parent = this.panelLista;
            this.panelLista.Size = new System.Drawing.Size(898, 393);
            this.panelLista.TabIndex = 13;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cargar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(813, 481);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(114, 34);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "Cargar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmSucesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(951, 527);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSucesos";
            this.Text = "Sucesos";
            this.Load += new System.EventHandler(this.frmSucesos_Load);
            this.panelLista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Zeroit.Framework.ListView.ZeroitListView listSuceso;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Guna.UI2.WinForms.Guna2Panel panelLista;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}