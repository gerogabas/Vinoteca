namespace Vinoteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnVender = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bodega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarVinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarVinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVender
            // 
            this.BtnVender.Location = new System.Drawing.Point(716, 104);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(77, 74);
            this.BtnVender.TabIndex = 0;
            this.BtnVender.Text = "Vender";
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Bodega,
            this.Vino,
            this.Tipo,
            this.Precio});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 27);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(373, 494);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 31;
            // 
            // Bodega
            // 
            this.Bodega.Text = "Bodega";
            this.Bodega.Width = 76;
            // 
            // Vino
            // 
            this.Vino.Text = "Vino";
            this.Vino.Width = 91;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo/Color";
            this.Tipo.Width = 91;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.Width = 75;
            // 
            // btnVerde
            // 
            this.btnVerde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerde.BackgroundImage")));
            this.btnVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerde.Location = new System.Drawing.Point(380, 120);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(64, 58);
            this.btnVerde.TabIndex = 5;
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnRojo
            // 
            this.btnRojo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRojo.BackgroundImage")));
            this.btnRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRojo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRojo.Location = new System.Drawing.Point(380, 242);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(64, 62);
            this.btnRojo.TabIndex = 6;
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(449, 27);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(243, 494);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 22;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bodega";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vino";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo/Color";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Precio";
            this.columnHeader5.Width = 75;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarVinoToolStripMenuItem,
            this.modificarVinoToolStripMenuItem,
            this.quitarVinoToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarVinoToolStripMenuItem
            // 
            this.agregarVinoToolStripMenuItem.Name = "agregarVinoToolStripMenuItem";
            this.agregarVinoToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.agregarVinoToolStripMenuItem.Text = "Agregar Vino";
            this.agregarVinoToolStripMenuItem.Click += new System.EventHandler(this.agregarVinoToolStripMenuItem_Click);
            // 
            // modificarVinoToolStripMenuItem
            // 
            this.modificarVinoToolStripMenuItem.Name = "modificarVinoToolStripMenuItem";
            this.modificarVinoToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.modificarVinoToolStripMenuItem.Text = "Modificar Vino";
            this.modificarVinoToolStripMenuItem.Click += new System.EventHandler(this.modificarVinoToolStripMenuItem_Click);
            // 
            // quitarVinoToolStripMenuItem
            // 
            this.quitarVinoToolStripMenuItem.Name = "quitarVinoToolStripMenuItem";
            this.quitarVinoToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.quitarVinoToolStripMenuItem.Text = "Quitar Vino";
            this.quitarVinoToolStripMenuItem.Click += new System.EventHandler(this.quitarVinoToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Buscar...";
            this.toolStripTextBox1.ToolTipText = "Buscar\r\n";
            this.toolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cargar RND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(826, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnVender);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "El Pasillo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Bodega;
        private System.Windows.Forms.ColumnHeader Vino;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarVinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarVinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

