namespace Actividad3_Crud
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bienvenidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensajeDeBienvenidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quienesSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caballerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienvenidaToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bienvenidaToolStripMenuItem
            // 
            this.bienvenidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensajeDeBienvenidaToolStripMenuItem,
            this.quienesSomosToolStripMenuItem,
            this.misiónToolStripMenuItem,
            this.visiónToolStripMenuItem});
            this.bienvenidaToolStripMenuItem.Name = "bienvenidaToolStripMenuItem";
            this.bienvenidaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.bienvenidaToolStripMenuItem.Text = "Bienvenida";
            // 
            // mensajeDeBienvenidaToolStripMenuItem
            // 
            this.mensajeDeBienvenidaToolStripMenuItem.Name = "mensajeDeBienvenidaToolStripMenuItem";
            this.mensajeDeBienvenidaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.mensajeDeBienvenidaToolStripMenuItem.Text = "Mensaje de Bienvenida";
            this.mensajeDeBienvenidaToolStripMenuItem.Click += new System.EventHandler(this.mensajeDeBienvenidaToolStripMenuItem_Click);
            // 
            // quienesSomosToolStripMenuItem
            // 
            this.quienesSomosToolStripMenuItem.Name = "quienesSomosToolStripMenuItem";
            this.quienesSomosToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.quienesSomosToolStripMenuItem.Text = "¿Quienes somos?";
            this.quienesSomosToolStripMenuItem.Click += new System.EventHandler(this.quienesSomosToolStripMenuItem_Click);
            // 
            // misiónToolStripMenuItem
            // 
            this.misiónToolStripMenuItem.Name = "misiónToolStripMenuItem";
            this.misiónToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.misiónToolStripMenuItem.Text = "Misión";
            this.misiónToolStripMenuItem.Click += new System.EventHandler(this.misiónToolStripMenuItem_Click);
            // 
            // visiónToolStripMenuItem
            // 
            this.visiónToolStripMenuItem.Name = "visiónToolStripMenuItem";
            this.visiónToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.visiónToolStripMenuItem.Text = "Visión";
            this.visiónToolStripMenuItem.Click += new System.EventHandler(this.visiónToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.damasToolStripMenuItem,
            this.caballerosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // damasToolStripMenuItem
            // 
            this.damasToolStripMenuItem.Name = "damasToolStripMenuItem";
            this.damasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.damasToolStripMenuItem.Text = "Damas";
            this.damasToolStripMenuItem.Click += new System.EventHandler(this.damasToolStripMenuItem_Click);
            // 
            // caballerosToolStripMenuItem
            // 
            this.caballerosToolStripMenuItem.Name = "caballerosToolStripMenuItem";
            this.caballerosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.caballerosToolStripMenuItem.Text = "Caballeros";
            this.caballerosToolStripMenuItem.Click += new System.EventHandler(this.caballerosToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.pROVEEDORToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cLIENTEToolStripMenuItem.Text = "Cliente";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
            // 
            // pROVEEDORToolStripMenuItem
            // 
            this.pROVEEDORToolStripMenuItem.Name = "pROVEEDORToolStripMenuItem";
            this.pROVEEDORToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pROVEEDORToolStripMenuItem.Text = "Proveedor";
            this.pROVEEDORToolStripMenuItem.Click += new System.EventHandler(this.pROVEEDORToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 105);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENIDO \r\nA \r\nZAPATERIAS UMI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ZAPATERIA UMI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bienvenidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensajeDeBienvenidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quienesSomosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem damasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caballerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

