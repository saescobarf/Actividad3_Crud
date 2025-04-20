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
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {

        }

        private void txtFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarProveedor_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Proveedores Order by nif DESC", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);

                dgvProveedores.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand modifCliente = new SqlCommand("UPDATE Proveedores SET Nombre = '" + txtNombreProveedor.Text + "', Direccion = '" + txtDireccionProveedor.Text + "' WHERE Nif = '" + txtNifProveedor.Text + "'", cn);
                modifCliente.CommandType = CommandType.Text;

                cn.Open();
                modifCliente.ExecuteNonQuery();

                MessageBox.Show("El proveedor se modificó exitosamente!.");
                txtNombreProveedor.Clear();
                txtDireccionProveedor.Clear();
                
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand elimCliente = new SqlCommand("DELETE FROM Proveedores WHERE Dni = '" + txtNifProveedor.Text + "'", cn);
                elimCliente.CommandType = CommandType.Text;

                cn.Open();
                elimCliente.ExecuteNonQuery();

                MessageBox.Show("El proveedor se eliminó exitosamente!.");
                txtNombreProveedor.Clear();
                txtDireccionProveedor.Clear();
                txtNifProveedor.Clear();
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand aggcliente = new SqlCommand("INSERT INTO proveedores (Nombre, direccion) VALUES ('" + txtNombreProveedor.Text + "','" + txtDireccionProveedor.Text + "')", cn);
                aggcliente.CommandType = CommandType.Text;

                cn.Open();
                aggcliente.ExecuteNonQuery();

                MessageBox.Show("El proveedor se guardó con exito!.");
                txtNombreProveedor.Clear();
                txtDireccionProveedor.Clear();
                txtNifProveedor.Clear();
            }
        }
    }
}
