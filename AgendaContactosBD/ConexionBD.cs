using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosBD
{
    class ConexionBD
    {
        private string string_de_conexion = "Data Source=DESKTOP-Q6DIE0N;Initial Catalog=BDconWPF;" +
            "Integrated Security=True";

        public List<Contacto> getContactos()
        {
            string query = "SELECT id, nombre, apellido, telefono, mail from Contactos";

            using (SqlConnection conexion = new SqlConnection(string_de_conexion))
            {
                List<Contacto> listaContactos = new List<Contacto>();

                SqlCommand comando = new SqlCommand(query, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Contacto c = new Contacto();
                        c.Id = reader.GetInt32(0);
                        c.Nombre = reader.GetString(1);
                        c.Apellido = reader.GetString(2);
                        c.Telefono = reader.GetString(3);
                        c.Mail = reader.GetString(4);

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

        public Contacto getContacto(int id)
        {
            string query = "SELECT id, nombre, apellido, telefono, mail from Contactos" +
                " where id=@id";

            using (SqlConnection conexion = new SqlConnection(string_de_conexion))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();

                    Contacto c = new Contacto();
                    c.Id = reader.GetInt32(0);
                    c.Nombre = reader.GetString(1);
                    c.Apellido = reader.GetString(2);
                    c.Telefono = reader.GetString(3);
                    c.Mail = reader.GetString(4);

                    return c;
                }
                catch (Exception e)
                {

                    throw new Exception("Hay un error en la BD " + e.Message);
                }
            }
        }

        public void nuevoContacto(string nombre, string apellido, string telefono, string mail)
        {
            string query = "INSERT into Contactos (nombre, apellido, telefono, mail) values" +
                "(@nombre, @apellido, @telefono, @mail)";

            using (SqlConnection conexion = new SqlConnection(string_de_conexion))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
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

        public void editarContacto(string nombre, string apellido, string telefono, string mail, int id)
        {
            string query = "UPDATE Contactos set nombre=@nombre, apellido=@apellido telefono=@telefono, mail=@mail" +
                " WHERE id=@id";

            using (SqlConnection conexion = new SqlConnection(string_de_conexion))
            {

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
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

            using (SqlConnection conexion = new SqlConnection(string_de_conexion))
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
}
