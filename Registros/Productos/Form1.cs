using Productos.Dao;
using Productos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        ProductoDao dao = new ProductoDao();
        public Form1()
        {
            InitializeComponent();
        }

        public void LlenarGrid()
        {
            this.dgvRegistro.DataSource = dao.VerCarrito();
            this.dgvRegistro.Refresh();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            try
            {
                prod.Nombre = tbNombre.Text.ToUpper();
                prod.Codigo = tbCodigo.Text.ToUpper();
                prod.Precio = double.Parse(tbPrecio.Text);
                prod.Iva = chkIVA.Checked;

                dao.Agregar(prod);
                LlenarGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: Ingrese un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
