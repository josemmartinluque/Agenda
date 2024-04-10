using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agenda
{
    public partial class FormAgendaDeContactos : Form
    {
        public FormAgendaDeContactos()
        {
            InitializeComponent();
        }

        private void FormAgendaDeContactos_Load(object sender, EventArgs e)
        {
            // Set up your connection string
            string connectionString = "Server=WINAPBXCZRaeb2u\\SQLEXPRESS;Database=Agenda;Trusted_Connection=True;TrustServerCertificate=True";

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

        private void dataGridViewContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                var cellValue = dataGridViewContactos.Rows[e.RowIndex];

                // Set textboxes to selected row values
                textBoxId.Text = cellValue.Cells[0].Value.ToString();
                textBoxNombre.Text = cellValue.Cells[1].Value.ToString();
                dateTimePickerFechaNacimiento.Value = DateTime.Parse(cellValue.Cells[2].Value.ToString());
                textBoxTelefono.Text = cellValue.Cells[3].Value.ToString();
                richTextBoxObservaciones.Text = cellValue.Cells[4].Value.ToString();
            }
        }
    }
}
