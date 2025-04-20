using System.Windows.Forms;

namespace Actividad3_Crud.Formularios
{
    public partial class formDamas : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDamas));
            this.chLisBoxDamas = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCatDamas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalirDama = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatDamas)).BeginInit();
            this.SuspendLayout();
            // 
            // chLisBoxDamas
            // 
            this.chLisBoxDamas.FormattingEnabled = true;
            this.chLisBoxDamas.Items.AddRange(new object[] {
            "21",
            "21.5",
            "22",
            "22.5",
            "23",
            "23.5",
            "24",
            "24.5",
            "25",
            "25.5",
            "26",
            "26.5",
            "27"});
            this.chLisBoxDamas.Location = new System.Drawing.Point(12, 52);
            this.chLisBoxDamas.Name = "chLisBoxDamas";
            this.chLisBoxDamas.Size = new System.Drawing.Size(149, 293);
            this.chLisBoxDamas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tallas Habilitadas";
            // 
            // dgvCatDamas
            // 
            this.dgvCatDamas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatDamas.Location = new System.Drawing.Point(225, 52);
            this.dgvCatDamas.Name = "dgvCatDamas";
            this.dgvCatDamas.RowHeadersWidth = 51;
            this.dgvCatDamas.RowTemplate.Height = 24;
            this.dgvCatDamas.Size = new System.Drawing.Size(547, 293);
            this.dgvCatDamas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(225, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "MOSTRAR CATÁLOGO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalirDama
            // 
            this.btnSalirDama.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalirDama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirDama.Location = new System.Drawing.Point(593, 367);
            this.btnSalirDama.Name = "btnSalirDama";
            this.btnSalirDama.Size = new System.Drawing.Size(178, 62);
            this.btnSalirDama.TabIndex = 4;
            this.btnSalirDama.Text = "SALIR";
            this.btnSalirDama.UseVisualStyleBackColor = false;
            this.btnSalirDama.Click += new System.EventHandler(this.btnSalirDama_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "CATALAGO DEPARTAMENTO DAMAS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // formDamas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalirDama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCatDamas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chLisBoxDamas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formDamas";
            this.Text = "DAMAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatDamas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chLisBoxDamas;

        private System.Windows.Forms.Label label1;
        private DataGridView dgvCatDamas;
        private Button button1;
        private Button btnSalirDama;
        private Label label2;
    }

}