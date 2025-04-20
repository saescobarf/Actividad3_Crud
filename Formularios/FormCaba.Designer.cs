namespace Actividad3_Crud.Formularios
{
    partial class FormCaba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaba));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dgvCaballeros = new System.Windows.Forms.DataGridView();
            this.lblTallasCab = new System.Windows.Forms.Label();
            this.btnCatCaba = new System.Windows.Forms.Button();
            this.btnSalirCaba = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaballeros)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27",
            "27.5",
            "28",
            "28.5",
            "29",
            "29.5",
            "30"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 58);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(188, 327);
            this.checkedListBox1.TabIndex = 0;
            // 
            // dgvCaballeros
            // 
            this.dgvCaballeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaballeros.Location = new System.Drawing.Point(257, 58);
            this.dgvCaballeros.Name = "dgvCaballeros";
            this.dgvCaballeros.RowHeadersWidth = 51;
            this.dgvCaballeros.RowTemplate.Height = 24;
            this.dgvCaballeros.Size = new System.Drawing.Size(505, 327);
            this.dgvCaballeros.TabIndex = 1;
            // 
            // lblTallasCab
            // 
            this.lblTallasCab.AutoSize = true;
            this.lblTallasCab.Location = new System.Drawing.Point(28, 35);
            this.lblTallasCab.Name = "lblTallasCab";
            this.lblTallasCab.Size = new System.Drawing.Size(146, 20);
            this.lblTallasCab.TabIndex = 2;
            this.lblTallasCab.Text = "Tallas Habilitadas";
            // 
            // btnCatCaba
            // 
            this.btnCatCaba.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCatCaba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatCaba.Location = new System.Drawing.Point(257, 409);
            this.btnCatCaba.Name = "btnCatCaba";
            this.btnCatCaba.Size = new System.Drawing.Size(259, 59);
            this.btnCatCaba.TabIndex = 3;
            this.btnCatCaba.Text = "MOSTRAR CATALOGO";
            this.btnCatCaba.UseVisualStyleBackColor = false;
            this.btnCatCaba.Click += new System.EventHandler(this.btnCatCaba_Click);
            // 
            // btnSalirCaba
            // 
            this.btnSalirCaba.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalirCaba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCaba.Location = new System.Drawing.Point(556, 409);
            this.btnSalirCaba.Name = "btnSalirCaba";
            this.btnSalirCaba.Size = new System.Drawing.Size(205, 58);
            this.btnSalirCaba.TabIndex = 4;
            this.btnSalirCaba.Text = "SALIR";
            this.btnSalirCaba.UseVisualStyleBackColor = false;
            this.btnSalirCaba.Click += new System.EventHandler(this.btnSalirCaba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "CATALOGO DEPARTAMENTO CABALLEROS";
            // 
            // FormCaba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirCaba);
            this.Controls.Add(this.btnCatCaba);
            this.Controls.Add(this.lblTallasCab);
            this.Controls.Add(this.dgvCaballeros);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCaba";
            this.Text = "CABALLEROS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaballeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dgvCaballeros;
        private System.Windows.Forms.Label lblTallasCab;
        private System.Windows.Forms.Button btnCatCaba;
        private System.Windows.Forms.Button btnSalirCaba;
        private System.Windows.Forms.Label label1;
    }
}