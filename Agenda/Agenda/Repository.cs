using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Repository
    {
        // Set up your connection string
        internal static string connectionString = "Server=WINAPBXCZRaeb2u\\SQLEXPRESS;Database=Agenda;Trusted_Connection=True;TrustServerCertificate=True";
        internal static DataTable obtenerContactos()
        {
            // Execute your SQL query
            string selectQuery = "SELECT * FROM Contactos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);

                // Fill a DataTable with the query results
                DataTable table = new DataTable();
                dataAdapter.Fill(table);

                return table;
            }
        }

        internal static void crearContacto(Contacto contacto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Execute stored procedure
                    using (SqlCommand command = new SqlCommand("CrearContacto", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", contacto.Id);
                        command.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                        command.Parameters.AddWithValue("@FechaNacimiento", contacto.FechaNacimiento);
                        command.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                        command.Parameters.AddWithValue("@Observaciones", contacto.Observaciones);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el contacto: {ex.Message}");
            }
        }

        internal static void modificarContacto(Contacto contacto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Execute stored procedure
                    using (SqlCommand command = new SqlCommand("ActualizarContacto", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", contacto.Id);
                        command.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                        command.Parameters.AddWithValue("@FechaNacimiento", contacto.FechaNacimiento);
                        command.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                        command.Parameters.AddWithValue("@Observaciones", contacto.Observaciones);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el contacto: {ex.Message}");
            }
        }

        internal static void eliminarContacto(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new Exception("Seleccione un contacto");
            }

            DialogResult confirmResult = MessageBox.Show("¿Seguro que quieres eliminar el contacto?", "¡Acción irreversible!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
            {
                throw new Exception("Operación abortada");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Execute stored procedure
                using (SqlCommand command = new SqlCommand("EliminarContacto", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }


}
