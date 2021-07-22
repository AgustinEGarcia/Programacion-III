using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CRUD_WindowsForms_ADO.NET___SQL_Server
{
    public class ConexionDB
    {
        private string conexionstring = "Data Source=DESKTOP-Q6DIE0N;Initial Catalog=CrudWindowsForms;" +
            "Integrated Security=True";

        public bool pruebaConexion()
        {

            try
            {
                SqlConnection conexion = new SqlConnection(conexionstring);
                conexion.Open();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }


        public List<Contactos> getContactos()
        {
            string query = "SELECT id, nombre, telefono, mail from Contactos";

            using(SqlConnection conexion = new SqlConnection(conexionstring))
            {
                List<Contactos> listaContactos = new List<Contactos>();

                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Contactos c = new Contactos();
                        c.Id = reader.GetInt32(0);
                        c.Nombre = reader.GetString(1);
                        c.Telefono = reader.GetString(2);
                        c.Mail = reader.GetString(3);

                        listaContactos.Add(c);
                    }

                    reader.Close();
                }
                catch (Exception e)
                {

                    throw new Exception("Hay un error en la BD " + e.Message);
                }

                return listaContactos;
            }
        }

        public Contactos getContacto(int id)
        {
            string query = "SELECT id, nombre, telefono, mail from Contactos" +
                " where id=@id";

            using (SqlConnection conexion = new SqlConnection(conexionstring))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);
                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();

                    Contactos c = new Contactos();
                    c.Id = reader.GetInt32(0);
                    c.Nombre = reader.GetString(1);
                    c.Telefono = reader.GetString(2);
                    c.Mail = reader.GetString(3);

                    return c;
                }
                catch (Exception e)
                {

                    throw new Exception("Hay un error en la BD " + e.Message);
                }
            } 
        }

        public void nuevoContacto(string nombre, string telefono, string mail)
        {
            string query = "INSERT into Contactos (nombre, telefono, mail) values" +
                "(@nombre, @telefono, @mail)";

            using (SqlConnection conexion = new SqlConnection(conexionstring))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@mail", mail);

                try
                {
                    conexion.Open();

                    comando.ExecuteNonQuery();

                    conexion.Close();

                }
                catch (Exception e)
                {

                    throw new Exception("Hay un error en la BD " + e.Message);
                }
            }
        }

        public void editarContacto(string nombre, string telefono, string mail, int id)
        {
            string query = "UPDATE Contactos set nombre=@nombre, telefono=@telefono, mail=@mail" +
                " WHERE id=@id";

            using (SqlConnection conexion = new SqlConnection(conexionstring))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@mail", mail);
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    conexion.Open();

                    comando.ExecuteNonQuery();

                    conexion.Close();

                }
                catch (Exception e)
                {

                    throw new Exception("Hay un error en la BD " + e.Message);
                }
            }
        }

        public void eliminarContacto(int id)
        {
            string query = "DELETE from Contactos WHERE id=@id";

            using (SqlConnection conexion = new SqlConnection(conexionstring))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    conexion.Open();

                    comando.ExecuteNonQuery();

                    conexion.Close();

                }
                catch (Exception e)
                {

                    throw new Exception("Hay un error en la BD " + e.Message);
                }
            }
        }
    }

    public class Contactos
    {
        private int id;
        private string nombre;
        private string telefono;
        private string mail;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
