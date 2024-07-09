using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CallejonDiagon.Data
{
    internal class Connexion
    {
        private string DataBase;
        private string Server;
        private string Port;
        private string User;
        private string Password;
        private static Connexion Con = null;

        private Connexion ()
        {
            this.DataBase = "tiendacallejondiagon";
            this.Server = "localhost";
            this.Port = "3306";
            this.User = "Daniel";
            this.Password = "BaseProyecto2024*";
        }

        public MySqlConnection ConectarBD()
        {
            MySqlConnection Cadena = new MySqlConnection();

            try 
            {
               Cadena.ConnectionString="datasource="+this.Server+";Port="+this.Port+";User="+this.User+";Password="+this.Password+";DataBase="+this.DataBase;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Connexion GetInstancia() 
        {
            if (Con == null)
            {
              Con = new Connexion();
            }
            return Con;
        }
    }
}
