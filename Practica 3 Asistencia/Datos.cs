using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;

namespace winMySQL.Clases
{
    internal class Datos
    {
        String cadenaConexion = "server=Localhost;user=luis;pwd=joseluis;Database=escolar";
        MySqlConnection conexion;
        private void conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
        private void desconectar()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public DataSet ejecutar(String comando)
        {
            try
            {
                conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                desconectar();
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                desconectar();
                return null;
            }
        }
        public bool ejecutarcomando(String comando)
        {
            try
            {
                conectar();
                MySqlCommand cmd = new MySqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                desconectar();
                return false;
            }
        }
    }
}
