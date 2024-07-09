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
    internal class D_User
    {
        public DataTable LoginUs(string cLoginUs, string cPassword)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_login", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cloginUs", MySqlDbType.VarChar).Value = cLoginUs;
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
        public DataTable ListaUs(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_listaUs", SqlCon);
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
        public DataTable ListaRol()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_listaRol", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
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
        public DataTable ListaSalario()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_listaSalario", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
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
        public string GuardarUs(int nOpcion, E_Empleado oPro)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_guardarUsuario", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion",MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nidEmpleado", MySqlDbType.Int32).Value = oPro.IdEmpleado;
                Comando.Parameters.Add("ccedulaEmpleado", MySqlDbType.VarChar).Value = oPro.CedulaEmpleado;
                Comando.Parameters.Add("cnombreEmpleado", MySqlDbType.VarChar).Value = oPro.NombreEmpleado;
                Comando.Parameters.Add("capellidoEmpleado", MySqlDbType.VarChar).Value = oPro.ApellidoEmpleado;
                Comando.Parameters.Add("nidRol", MySqlDbType.Int32).Value = oPro.IdRol;
                Comando.Parameters.Add("cloginUs", MySqlDbType.VarChar).Value = oPro.LoginUs;
                Comando.Parameters.Add("cpasswordUs", MySqlDbType.VarChar).Value = oPro.PasswordUs;
                Comando.Parameters.Add("nidSalario", MySqlDbType.Int32).Value = oPro.IdSalario;
                Comando.Parameters.Add("ccorreoEmp", MySqlDbType.VarChar).Value = oPro.CorreoEmp;
                Comando.Parameters.Add("ctelefonoEmp", MySqlDbType.VarChar).Value = oPro.TelefonoEmp;
              
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
        public string ActivoUs(int nidEmpleado)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Connexion.GetInstancia().ConectarBD();
                MySqlCommand Comando = new MySqlCommand("usp_esActivo", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nidEmpleado", MySqlDbType.Int32).Value = nidEmpleado;
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
