using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace crud
{
    public class CapaDeAccesoDatos
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContactos;Data Source=DESKTOP-MP4FJH1");

        public void ingresarContacto(Contactos contactos)
        {
            try
            {
                conn.Open();
                string query = @"
                                 insert into contacts ([nombre], [apellido], [contacto], [direccion])
                                 values (@nombre, @apellido, @contacto, @direccion)";

                SqlParameter nombre = new SqlParameter("@nombre", contactos.nombre);
                SqlParameter apellido = new SqlParameter("@apellido",contactos.apellido);
                SqlParameter contacto = new SqlParameter("@contacto",contactos.contacto);
                SqlParameter direccion = new SqlParameter("@direccion", contactos.direccion);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(contacto);
                command.Parameters.Add(direccion);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
    