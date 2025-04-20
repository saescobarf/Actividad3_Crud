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
    public partial class FormCompras : Form
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Compras Order by DniCliente ASC", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                cn.Open();
                da.Fill(dt);

                dgvCompras.DataSource = dt;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand ventaProducto = new SqlCommand("INSERT INTO Compras ( DniCliente, CodigoProducto, FechaCompra) VALUES ('" + txtDniCliente.Text + "','" + txtCodigoProducto.Text + "', '" + txtFechaCompra.Text + "')", cn);
                ventaProducto.CommandType = CommandType.Text;

                cn.Open();
                ventaProducto.ExecuteNonQuery();

                MessageBox.Show("La venta se generó con exito!.");
                txtDniCliente.Clear();
                txtCodigoProducto.Clear();
                txtFechaCompra.Clear();
                
            }
        }

        private void btnModifVenta_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand modifVenta = new SqlCommand("UPDATE Compras SET DniCliente = '" + txtDniCliente.Text + "', CodigoProducto = '" + txtCodigoProducto.Text + "', FechaCompra = '" + txtFechaCompra.Text +"' WHERE codigoProducto = '" + txtCodigoProducto.Text + "' AND DniCliente ='" + txtDniCliente.Text +"'", cn);
                modifVenta.CommandType = CommandType.Text;

                cn.Open();
                modifVenta.ExecuteNonQuery();

                MessageBox.Show("La venta se modificó exitosamente!.");
                txtDniCliente.Clear();
                txtCodigoProducto.Clear();
                txtFechaCompra.Clear();
              
            }
        }

        private void btnElimVenta_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=LAPTOP-SERGIOAL\\SQLEXPRESS;Initial Catalog=ZapateriaCulichi;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand elimProducto = new SqlCommand("DELETE FROM Compras WHERE DniCliente = @dni AND CodigoProducto = @codigo AND FechaCompra = @fecha", cn);

                elimProducto.CommandType = CommandType.Text;
                elimProducto.Parameters.AddWithValue("@dni", txtDniCliente.Text);
                elimProducto.Parameters.AddWithValue("@codigo", txtCodigoProducto.Text);
                elimProducto.Parameters.AddWithValue("@fecha", DateTime.Parse(txtFechaCompra.Text));

                cn.Open();
                elimProducto.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("La venta se eliminó exitosamente!.");
                txtDniCliente.Clear();
                txtCodigoProducto.Clear();
                txtFechaCompra.Clear();
            }
        }
    }
}
