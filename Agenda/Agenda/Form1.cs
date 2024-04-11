using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;
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

        public void modoStandBy()
        {
            // Desactiva las casillas
            textBoxNombre.ReadOnly = true;
            dateTimePickerFechaNacimiento.Enabled = false;
            textBoxTelefono.ReadOnly = true;
            richTextBoxObservaciones.ReadOnly = true;

            // Desactiva botones
            buttonGuardar.Enabled = false;
            buttonCancelar.Enabled = false;

            // Activa botones
            buttonAnadir.Enabled = true;
            buttonEliminar.Enabled = true;
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                buttonModificar.Enabled = false;
            }
            else
            {
                buttonModificar.Enabled = true;
            }
        }

        public void modoEdicion()
        {
            // Activa las casillas
            textBoxNombre.ReadOnly = false;
            dateTimePickerFechaNacimiento.Enabled = true;
            textBoxTelefono.ReadOnly = false;
            richTextBoxObservaciones.ReadOnly = false;

            // Activa botones
            buttonGuardar.Enabled = true;
            buttonCancelar.Enabled = true;

            // Desactiva botones
            buttonAnadir.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
        }

        public void vaciarForm()
        {
            textBoxId.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            textBoxTelefono.Text = string.Empty;
            richTextBoxObservaciones.Text = string.Empty;
        }

        private void obtenerContactos()
        {
            DataTable table = Repository.obtenerContactos();

            dataGridViewContactos.DataSource = table;
            dataGridViewContactos.ReadOnly = true;
        }

        private void FormAgendaDeContactos_Load(object sender, EventArgs e)
        {
            modoStandBy();
            obtenerContactos();
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

                buttonModificar.Enabled = true;
            }
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            vaciarForm();
            modoEdicion();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxId.Text;

                Repository.eliminarContacto(id);
                obtenerContactos();
                vaciarForm();

                MessageBox.Show("Contacto eliminado de forma exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el contacto: {ex.Message}");
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            modoEdicion();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = string.IsNullOrWhiteSpace(textBoxId.Text) ? -1 : int.Parse(textBoxId.Text);
                string nombre = textBoxNombre.Text;
                DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
                string telefono = textBoxTelefono.Text;
                string observaciones = richTextBoxObservaciones.Text;

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono))
                {
                    throw new Exception("Campos Nombre y Teléfono obligatorios");
                }

                Contacto contacto = new(id, nombre, fechaNacimiento, telefono, observaciones);

                if (contacto.Id == -1)
                {
                    Repository.crearContacto(contacto);
                }
                else
                {
                    Repository.modificarContacto(contacto);
                }

                modoStandBy();
                vaciarForm();
                obtenerContactos();

                MessageBox.Show("Contacto guardado de forma exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el contacto: {ex.Message}");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            modoStandBy();
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                vaciarForm();
            }
        }
    }
}
