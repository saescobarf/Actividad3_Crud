namespace Actividad3_Crud.Formularios
{
    partial class FormProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedor));
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnMostrarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtNifProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(682, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 39);
            this.button1.TabIndex = 35;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(184, 223);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.Size = new System.Drawing.Size(679, 220);
            this.dgvProveedores.TabIndex = 34;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(523, 162);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(341, 40);
            this.btnEliminarProveedor.TabIndex = 33;
            this.btnEliminarProveedor.Text = "ELIMINAR POR NIF";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click);
            // 
            // btnMostrarProveedor
            // 
            this.btnMostrarProveedor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMostrarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnMostrarProveedor.Location = new System.Drawing.Point(19, 298);
            this.btnMostrarProveedor.Name = "btnMostrarProveedor";
            this.btnMostrarProveedor.Size = new System.Drawing.Size(159, 71);
            this.btnMostrarProveedor.TabIndex = 32;
            this.btnMostrarProveedor.Text = "MOSTRAR PROVEEDORES";
            this.btnMostrarProveedor.UseVisualStyleBackColor = false;
            this.btnMostrarProveedor.Click += new System.EventHandler(this.btnMostrarProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificarProveedor.Location = new System.Drawing.Point(523, 108);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(341, 39);
            this.btnModificarProveedor.TabIndex = 31;
            this.btnModificarProveedor.Text = "MODIFICAR POR NIF";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.Green;
            this.btnAgregarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarProveedor.Location = new System.Drawing.Point(523, 54);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(341, 37);
            this.btnAgregarProveedor.TabIndex = 30;
            this.btnAgregarProveedor.Text = "AGREGAR";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(184, 150);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(242, 22);
            this.txtDireccionProveedor.TabIndex = 27;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(184, 108);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(242, 22);
            this.txtNombreProveedor.TabIndex = 26;
            // 
            // txtNifProveedor
            // 
            this.txtNifProveedor.Location = new System.Drawing.Point(184, 60);
            this.txtNifProveedor.Name = "txtNifProveedor";
            this.txtNifProveedor.Size = new System.Drawing.Size(242, 22);
            this.txtNifProveedor.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(479, 40);
            this.label7.TabIndex = 24;
            this.label7.Text = "REGISTRAR PROVEEDOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "*DIRECCIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 50);
            this.label2.TabIndex = 19;
            this.label2.Text = "*NOMBRE \r\nPROVEEDOR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "NIF:";
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnMostrarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtNifProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProveedor";
            this.Text = "PROVEEDOR";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnMostrarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtNifProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}