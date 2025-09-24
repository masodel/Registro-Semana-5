using Productos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Productos.Dao
{
    public class ProductoDao
    {
        public static int TAM = 5;
        private Producto[] carrito = new Producto[TAM];
        private int pos = 0;

        public void Agregar(Producto prod)
        {
            if (pos < TAM)
                carrito[pos++] = prod;

            else MessageBox.Show("Carrito lleno", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public Producto[] VerCarrito()
        {
            return carrito;
        }
    }
}
