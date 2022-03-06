using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_facturacion
{
    class Acceso_datos
    {
        SqlConnection conexion; 
        SqlCommand cmd; 
        SqlDataReader LectorDatos = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public void AbrirBd() 
        {
            try 
            {
                conexion = new SqlConnection("Data Source=DESKTOP-1LKD8JP\\UNIDB;Initial Catalog=[DBFACTURAS];Integrated Security=true;");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("falló conexión " + ex);
            }
        }

        public void CerrarrBd() 
        {
            try 
            {
                conexion.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("falló cerrar conexión " + ex);
            }
        }

        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string strEmpleado = "";

                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";
                AbrirBd();
                cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text; 
                cmd.CommandTimeout = 10;

                LectorDatos = cmd.ExecuteReader(); 
                while (LectorDatos.Read()) 
                {
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }
                if (LectorDatos != null) 
                {
                    LectorDatos.Close();
                }
                return strEmpleado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";
            }
        }

        public string EjecutarComando (string sentencia)
        {
            string salida = "Los datos se actualizaron satisfactoriamente";

            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarrBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }
;            }
            catch (Exception ex)
            {
                salida = "falló inserción : " + ex;
            }
            return salida;
        }


        public DataTable cargarTabla(string tabla, string strCondicion)
        {
            try
            {
                AbrirBd();
                string sql = "Select * from " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(sql, conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarrBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.ToString());
                return null;
            }
        }

        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarrBd();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló operacion: " + ex);
                return null;
            }
        }
    }
}
                
