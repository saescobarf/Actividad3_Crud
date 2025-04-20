using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3_Crud.Formularios
{
    public partial class formDamas : Form
    {
        public formDamas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Productos WHERE idDepartamento = 1", cn);
                da.SelectCommand.CommandType = CommandType.Text;
                
                cn.Open();
                da.Fill(dt);

                dgvCatDamas.DataSource = dt;
            }
        }

        private void btnSalirDama_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
