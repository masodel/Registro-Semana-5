using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Modelos
{
    public class Producto
    {
        public String Codigo { get; set; }

        public String Nombre { get; set; }

        public double Precio { get; set; }

        public Boolean Iva { get; set; }

        public double Monto { get
            {
                return Precio * (Iva ? 1.15 : 1);
            } }
    }
}
