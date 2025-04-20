namespace Actividad3_Crud.Formularios
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtFechaCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnModifVenta = new System.Windows.Forms.Button();
            this.btnElimVenta = new System.Windows.Forms.Button();
            this.btnMostrarVentas = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dni Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de compra\r\n(AAAA-MM-DD):";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(238, 73);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(199, 22);
            this.txtDniCliente.TabIndex = 3;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(238, 120);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(199, 22);
            this.txtCodigoProducto.TabIndex = 4;
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.Location = new System.Drawing.Point(238, 170);
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Size = new System.Drawing.Size(199, 22);
            this.txtFechaCompra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "COMPRAR PRODUCTO";
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(43, 229);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(552, 191);
            this.dgvCompras.TabIndex = 7;
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVenta.Location = new System.Drawing.Point(544, 53);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(221, 40);
            this.btnVenta.TabIndex = 8;
            this.btnVenta.Text = "GENERAR VENTA";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnModifVenta
            // 
            this.btnModifVenta.BackColor = System.Drawing.Color.Gold;
            this.btnModifVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifVenta.Location = new System.Drawing.Point(544, 102);
            this.btnModifVenta.Name = "btnModifVenta";
            this.btnModifVenta.Size = new System.Drawing.Size(221, 40);
            this.btnModifVenta.TabIndex = 9;
            this.btnModifVenta.Text = "MODIFICAR VENTA";
            this.btnModifVenta.UseVisualStyleBackColor = false;
            this.btnModifVenta.Click += new System.EventHandler(this.btnModifVenta_Click);
            // 
            // btnElimVenta
            // 
            this.btnElimVenta.BackColor = System.Drawing.Color.Crimson;
            this.btnElimVenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimVenta.ForeColor = System.Drawing.Color.Snow;
            this.btnElimVenta.Location = new System.Drawing.Point(544, 158);
            this.btnElimVenta.Name = "btnElimVenta";
            this.btnElimVenta.Size = new System.Drawing.Size(221, 40);
            this.btnElimVenta.TabIndex = 10;
            this.btnElimVenta.Text = "ELIMINAR VENTA";
            this.btnElimVenta.UseVisualStyleBackColor = false;
            this.btnElimVenta.Click += new System.EventHandler(this.btnElimVenta_Click);
            // 
            // btnMostrarVentas
            // 
            this.btnMostrarVentas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMostrarVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarVentas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrarVentas.Location = new System.Drawing.Point(614, 229);
            this.btnMostrarVentas.Name = "btnMostrarVentas";
            this.btnMostrarVentas.Size = new System.Drawing.Size(164, 57);
            this.btnMostrarVentas.TabIndex = 11;
            this.btnMostrarVentas.Text = "MOSTRAR VENTAS";
            this.btnMostrarVentas.UseVisualStyleBackColor = false;
            this.btnMostrarVentas.Click += new System.EventHandler(this.btnMostrarVentas_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Snow;
            this.btnRegresar.Location = new System.Drawing.Point(614, 388);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(164, 50);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnMostrarVentas);
            this.Controls.Add(this.btnElimVenta);
            this.Controls.Add(this.btnModifVenta);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaCompra);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompras";
            this.Text = "COMPRAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtFechaCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnModifVenta;
        private System.Windows.Forms.Button btnElimVenta;
        private System.Windows.Forms.Button btnMostrarVentas;
        private System.Windows.Forms.Button btnRegresar;
    }
}