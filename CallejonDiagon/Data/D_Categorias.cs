using CallejonDiagon.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallejonDiagon.Data
{
    internal class D_Categorias
    {
        public DataTable ListaCategorias(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_listaCategorias", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
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
        public string GuardarCategorias(int nOpcion, E_Categoria oPro)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_guardarCategoria", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nidCategoria", MySqlDbType.Int32).Value = oPro.IdCategoria;
                Comando.Parameters.Add("cdescripcion", MySqlDbType.VarChar).Value = oPro.Descripcion;

                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "nCodSalida";
                p.MySqlDbType = MySqlDbType.Int32;
                p.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(p);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Respuesta = Convert.ToString(p.Value);

            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
        public string ActivoCate(int nidCategoria)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_esActivoCategoria", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nidCategoria", MySqlDbType.Int32).Value = nidCategoria;
                SqlCon.Open();
                Respuesta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No Modificado";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }

    }
}
