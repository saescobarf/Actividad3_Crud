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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand aggProducto = new SqlCommand("INSERT INTO Productos ( Nombre, Precio, NifProveedor, idDepartamento) VALUES ('" + txtNombreProducto.Text + "','" + txtPrecioProducto.Text + "', '" + txtNifProducto.Text + "','" + txtIdDepto.Text + "')", cn);
                aggProducto.CommandType = CommandType.Text;

                cn.Open();
                aggProducto.ExecuteNonQuery();

                MessageBox.Show("El producto se guardó con exito!.");
                txtNombreProducto.Clear();
                txtPrecioProducto.Clear();
                txtNifProducto.Clear();
                txtIdDepto.Clear();
                txtCodigo.Clear();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM productos Order by codigo ASC", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);

                dgvProductos.DataSource = dt;
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand modifProducto = new SqlCommand("UPDATE Productos SET Nombre = '" + txtNombreProducto.Text + "', Precio = '" + txtPrecioProducto.Text + "', NifProveedor = '" + txtNifProducto.Text + "', IdDepartamento = '" + txtIdDepto.Text + "' WHERE codigo = '" + txtCodigo.Text + "'", cn);
                modifProducto.CommandType = CommandType.Text;

                cn.Open();
                modifProducto.ExecuteNonQuery();

                MessageBox.Show("El producto se modificó exitosamente!.");
                txtNombreProducto.Clear();
                txtPrecioProducto.Clear();
                txtNifProducto.Clear();
                txtIdDepto.Clear();
                txtCodigo.Clear();

            }
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM productos Order by codigo ASC", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);

                dgvProductos.DataSource = dt;
            }
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand elimProducto = new SqlCommand("DELETE FROM productos WHERE codigo = '" + txtCodigo.Text + "'", cn);
                elimProducto.CommandType = CommandType.Text;

                cn.Open();
                elimProducto.ExecuteNonQuery();

                MessageBox.Show("El producto se eliminó exitosamente!.");
                txtNombreProducto.Clear();
                txtPrecioProducto.Clear();
                txtNifProducto.Clear();
                txtIdDepto.Clear();
                txtCodigo.Clear();
            }
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM productos Order by codigo ASC", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);

                dgvProductos.DataSource = dt;
            }
        }
    }
}
