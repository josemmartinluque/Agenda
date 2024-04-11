using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agenda
{
    public partial class FormAgendaDeContactos : Form
    {

        // Set up your connection string
        string connectionString = "Server=WINAPBXCZRaeb2u\\SQLEXPRESS;Database=Agenda;Trusted_Connection=True;TrustServerCertificate=True";

        public FormAgendaDeContactos()
        {
            InitializeComponent();
        }

        private void getContacts()
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

                // Bind the DataGridView to the DataTable
                dataGridViewContactos.DataSource = table;
                dataGridViewContactos.ReadOnly = true;
            }
        }

        private void cleanForm()
        {
            textBoxId.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            textBoxTelefono.Text = string.Empty;
            richTextBoxObservaciones.Text = string.Empty;
        }

        private void FormAgendaDeContactos_Load(object sender, EventArgs e)
        {
            getContacts();
        }

        private void dataGridViewContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                var row = dataGridViewContactos.Rows[e.RowIndex];

                // Set textboxes to selected row values
                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxNombre.Text = row.Cells[1].Value.ToString();
                dateTimePickerFechaNacimiento.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                textBoxTelefono.Text = row.Cells[3].Value.ToString();
                richTextBoxObservaciones.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxId.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Get new data
                        string id = textBoxId.Text;
                        string nombre = textBoxNombre.Text;
                        DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
                        string telefono = textBoxTelefono.Text;
                        string observaciones = richTextBoxObservaciones.Text;

                        // Execute stored procedure
                        using (SqlCommand command = new SqlCommand("ActualizarContacto", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@Nombre", nombre);
                            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                            command.Parameters.AddWithValue("@Telefono", telefono);
                            command.Parameters.AddWithValue("@Observaciones", observaciones);

                            command.ExecuteNonQuery();
                        }

                        getContacts();

                        MessageBox.Show("Contacto actualizado de forma exitosa");

                        cleanForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el contacto: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un contacto");
            }
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Get new data
                        string id = textBoxId.Text;
                        string nombre = textBoxNombre.Text;
                        DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
                        string telefono = textBoxTelefono.Text;
                        string observaciones = richTextBoxObservaciones.Text;

                        // Execute stored procedure
                        using (SqlCommand command = new SqlCommand("CrearContacto", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Id", id);
                            command.Parameters.AddWithValue("@Nombre", nombre);
                            command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                            command.Parameters.AddWithValue("@Telefono", telefono);
                            command.Parameters.AddWithValue("@Observaciones", observaciones);

                            command.ExecuteNonQuery();
                        }

                        getContacts();

                        MessageBox.Show("Contacto creado de forma exitosa");

                        cleanForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el contacto: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Limpie el formulario antes de crear un contacto");
            }
        }
    }
}
