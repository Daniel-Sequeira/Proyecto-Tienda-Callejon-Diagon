using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallejonDiagon.Entity
{
    public class E_DetalleSalidaProducto
    {

        public int IdDetalleSalidaP {  get; set; }
        public int IdSalidaProducto { get; set; }
        public int IdProducto { get; set; }

        public decimal CantidadSP { get; set; }
        public decimal ImporteTotalSP  { get; set; }

    }
}
