using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallejonDiagon.Data
{
    internal class D_User
    {
        public DataTable LoginUs(string cLoginUs, string cPassword)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
              SqlCon=Connection.GetInstancia().ConectarBD();
              MySqlCommand Comando = new MySqlCommand("usp_login",SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cloginUs", MySqlDbType.VarChar).Value= cLoginUs;
                Comando.Parameters.Add("cpasswordUs", MySqlDbType.VarChar).Value = cPassword;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
