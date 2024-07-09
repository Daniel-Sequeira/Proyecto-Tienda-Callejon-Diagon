using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallejonDiagon.Entity
{
    public class E_Empleado
    {
        public int IdEmpleado { get; set; }
        public string CedulaEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string LoginUs { get; set; }
        public string PasswordUs { get; set; }
        public int IdSalario { get; set; }
        public int IdRol {  get; set; }
        public string CorreoEmp { get; set; }
        public string TelefonoEmp { get; set; }
        public DateTime HorarioEntrada { get; set; }
        public DateTime HorarioSalida { get; set; }
        public decimal Salario {  get; set; }



    }
}
