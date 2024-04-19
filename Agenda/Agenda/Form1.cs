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
            buttonImagen.Enabled = false;

            // Activa botones
            dataGridViewContactos.Enabled = true;
            buttonAnadir.Enabled = true;
            buttonEliminar.Enabled = true;
            buttonModificar.Enabled = string.IsNullOrWhiteSpace(textBoxId.Text) ? false : true;
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
            buttonImagen.Enabled = true;

            // Desactiva botones
            dataGridViewContactos.Enabled = false;
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
            pictureBoxImagen.Image = null;
        }

        private void obtenerContactos()
        {
            DataTable table = Repository.obtenerContactos();

            dataGridViewContactos.DataSource = table;
            dataGridViewContactos.ReadOnly = true;

            seleccionarContacto(0);
        }

        private void seleccionarContacto(int fila)
        {
            // Get the selected row
            var row = dataGridViewContactos.Rows[fila];

            // Set textboxes to selected row values
            textBoxId.Text = row.Cells[0].Value.ToString();
            textBoxNombre.Text = row.Cells[1].Value.ToString();
            dateTimePickerFechaNacimiento.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            textBoxTelefono.Text = row.Cells[3].Value.ToString();
            richTextBoxObservaciones.Text = row.Cells[4].Value.ToString();
            pictureBoxImagen.Image = Repository.decodificarImagen(row.Cells[5].Value.ToString());
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
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
                seleccionarContacto(e.RowIndex);
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
                string? imagen = Repository.codificarImagen(pictureBoxImagen.Image);

                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(telefono))
                {
                    throw new Exception("Campos Nombre y Teléfono obligatorios");
                }

                Contacto contacto = new(id, nombre, fechaNacimiento, telefono, observaciones, imagen);

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

        private void buttonImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected image file path
                    string imagePath = openFileDialog.FileName;

                    // Load the image into the PictureBox
                    Image image = Image.FromFile(imagePath);
                    pictureBoxImagen.Image = image;
                    pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
