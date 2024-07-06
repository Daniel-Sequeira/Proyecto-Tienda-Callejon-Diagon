using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallejonDiagon.Entity
{
    public class E_Tienda
    {
        public int  IdTienda { get; set; }
        public string NombreTienda { get; set; }
        public string CedulaJuridica {  get; set; }
        public string TelefonoTienda {  get; set; }
        public string CorreoTienda { get; set; }
        public byte[] LogoTienda { get; set; }
    }
}
