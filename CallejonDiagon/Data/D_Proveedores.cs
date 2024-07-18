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
    internal class D_Proveedores
    {
        public DataTable ListaProve(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_listaProveedores", SqlCon);
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
        public string GuardarProve(int nOpcion, E_Proveedor oPro)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_guardarProveedor", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nidProveedor", MySqlDbType.Int32).Value = oPro.IdProveedor;
                Comando.Parameters.Add("ccedulaProveedor", MySqlDbType.VarChar).Value = oPro.CedulaProveedor;
                Comando.Parameters.Add("cnombreProveedor", MySqlDbType.VarChar).Value = oPro.NombreProveedor;
                Comando.Parameters.Add("ccorreoProveedor", MySqlDbType.VarChar).Value = oPro.CorreoProveedor;
                Comando.Parameters.Add("cdireccionProveedor", MySqlDbType.VarChar).Value = oPro.DireccionProveedor;
                Comando.Parameters.Add("ctelefonoProveedor", MySqlDbType.VarChar).Value = oPro.TelefonoProveedor;
               
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
        public string ActivoProve(int nidProveedor)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_esActivoProve", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nidProveedor", MySqlDbType.Int32).Value = nidProveedor;
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
