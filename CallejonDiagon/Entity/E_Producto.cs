using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallejonDiagon.Entity
{
    public class E_Producto
    {
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string CodigoBusquedaP { get; set; }
        public int IdUnidadMedida { get; set; }
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioDescuento { get; set; }


    }
}
