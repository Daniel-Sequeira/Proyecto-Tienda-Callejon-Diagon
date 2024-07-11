using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallejonDiagon.Entity
{
    public class E_SalidaProducto
    {
        public int IdSalidaProducto { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaRegistroSP { get; set; }
        public decimal SubtotalSP { get; set; } 
        public decimal ImpuestoSP { get; set; }
        public decimal TotalSP { get; set; }
        public int IdEMpleado { get; set; }


    }
}
