using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3_Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mensajeDeBienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la tienda en linea ZAPATERIA UMI, donde podra encontrar todo lo que usted necesita y si no lo encuentra se lo conseguimos. Somos su mejor opcioón hoy y siempre.");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quienesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Quienes somos?\n\nSomos una empresa mexicana, que trata de apoyar al comercio mexicano, todos nuestros productos son 100% mexicanos, por que creemos en nosotros y por que sabemos que podemos.");
        }

        private void misiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MISION:\n\nNuestra misión es darnos a conocer a nivel nacional y lograr el objetivo de que todos los mexicanos utilicen productos mexicanos, que abramos los ojos y veamos que no por que el producto sea de otro país, signifique que es mejor.");
        }

        private void visiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VISIÓN:\n\nNuestra visión es que una vez que nos encontremos a nivel nacional, buscaremos el mercado internacional y llevaremos el nombre de nuestro producto, de nuestro país, a todo el mundo para que sepan de lo que somos capaces.");
        }

        private void damasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.formDamas nuevoFormularioDamas = new Formularios.formDamas();
            nuevoFormularioDamas.Show();
        }

        private void caballerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormCaba nuevoFormularioCaballeros = new Formularios.FormCaba();
            nuevoFormularioCaballeros.Show();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormClientes nuevoFormularioClientes = new Formularios.FormClientes();
            nuevoFormularioClientes.Show();
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormProveedor nuevoFormularioProveedor = new Formularios.FormProveedor();
            nuevoFormularioProveedor.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormProductos nuevoFormularioProductos = new Formularios.FormProductos();
            nuevoFormularioProductos.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FormCompras nuevoFormularioCompras = new Formularios.FormCompras();
            nuevoFormularioCompras.Show();
        }
    }
}
