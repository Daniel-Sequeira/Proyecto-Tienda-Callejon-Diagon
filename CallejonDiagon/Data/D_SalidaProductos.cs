using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallejonDiagon.Data
{
    internal class D_SalidaProductos
    {
        public DataTable ListaFiltroCategorias(int nidCategoria)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_filtrarProdCategoria", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nidCategoria", MySqlDbType.VarChar).Value = nidCategoria;
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
