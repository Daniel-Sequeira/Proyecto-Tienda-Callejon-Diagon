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
    internal class D_Clientes
    {
        public DataTable ListaClientes(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_listaClientes", SqlCon);
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
        public string GuardarCliente(int nOpcion, E_Cliente oPro)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_guardarCliente", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nidCliente", MySqlDbType.Int32).Value = oPro.IdCliente;
                Comando.Parameters.Add("ccedulaCLiente", MySqlDbType.VarChar).Value = oPro.CedulaCliente;
                Comando.Parameters.Add("cnombreCliente", MySqlDbType.VarChar).Value = oPro.NombreCliente;
                Comando.Parameters.Add("capellidosCliente", MySqlDbType.VarChar).Value = oPro.ApellidosCliente;
                Comando.Parameters.Add("ccorreoCliente", MySqlDbType.VarChar).Value = oPro.CorreoCliente;
                Comando.Parameters.Add("cdireccionCliente", MySqlDbType.VarChar).Value = oPro.DireccionCliente;
                Comando.Parameters.Add("ctelefonoCliente", MySqlDbType.VarChar).Value = oPro.TelefonoCliente;

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
        public string ActivoCLiente(int nidCliente)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_esActivoCliente", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nidCliente", MySqlDbType.Int32).Value = nidCliente;
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
