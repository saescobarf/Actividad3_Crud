using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3_Crud.Formularios
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes Order by Apellidos ASC", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);

                dgvClientes.DataSource = dt;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand aggcliente = new SqlCommand("INSERT INTO Clientes (Nombre, Apellidos, FechaNacimiento, Telefono) VALUES ('"+ txtNombre.Text + "','" + txtApellidos.Text + "', '" + txtFechaNac.Text +"','"+ txtCelular.Text + "')", cn);
                aggcliente.CommandType = CommandType.Text;

                cn.Open();
                aggcliente.ExecuteNonQuery();

                MessageBox.Show("El cliente se guardó con exito!.");
                txtNombre.Clear();
                txtApellidos.Clear();
                txtCelular.Clear();
                txtFechaNac.Clear();
                txtDni.Clear();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand modifCliente = new SqlCommand("UPDATE Clientes SET nombre = '"+ txtNombre.Text +"', apellidos = '"+ txtApellidos.Text +"', fechaNacimiento = '"+ txtFechaNac.Text +"', Telefono = '"+ txtCelular.Text+"' WHERE Dni = '"+txtDni.Text +"'", cn);
                modifCliente.CommandType = CommandType.Text;

                cn.Open();
                modifCliente.ExecuteNonQuery();

                MessageBox.Show("El cliente se modificó exitosamente!.");
                txtNombre.Clear();
                txtApellidos.Clear();
                txtCelular.Clear();
                txtFechaNac.Clear();
                txtDni.Clear();
            }
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand elimCliente = new SqlCommand("DELETE FROM Clientes WHERE Dni = '" + txtDni.Text + "'", cn);
                elimCliente.CommandType = CommandType.Text;

                cn.Open();
                elimCliente.ExecuteNonQuery();

                MessageBox.Show("El cliente se eliminó exitosamente!.");
                txtNombre.Clear();
                txtApellidos.Clear();
                txtCelular.Clear();
                txtFechaNac.Clear();
                txtDni.Clear();
            }
        }
    }
}
