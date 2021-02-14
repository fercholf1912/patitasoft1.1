using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapaDatos
{
    public class DControl
    {
        public DataTable Listar(int idmascota)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("control_listar", SqlCon);
                Comando.Parameters.Add("@id_mascota", SqlDbType.Int).Value = idmascota;
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
        public string Insertar(ControlMascota Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("control_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_mascota", SqlDbType.Int).Value = Obj.IdMascota;
                Comando.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Obj.IdUsuario;
                Comando.Parameters.Add("@peso", SqlDbType.Decimal).Value = Obj.Peso;

                Comando.Parameters.Add("@talla ", SqlDbType.Decimal).Value = Obj.Talla;
                Comando.Parameters.Add("@foto", SqlDbType.VarChar).Value = Obj.Foto;

                Comando.Parameters.Add("@observacion", SqlDbType.VarChar).Value = Obj.Observacion;
                Comando.Parameters.Add("@vacuna", SqlDbType.Structured).Value = Obj.Vacuna;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
