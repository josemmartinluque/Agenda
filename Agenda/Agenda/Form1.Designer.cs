namespace Agenda
{
    partial class FormAgendaDeContactos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxContacto = new GroupBox();
            pictureBoxImagen = new PictureBox();
            textBoxId = new TextBox();
            textBoxNombre = new TextBox();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            textBoxTelefono = new TextBox();
            richTextBoxObservaciones = new RichTextBox();
            labelId = new Label();
            labelNombre = new Label();
            labelFechaNacimiento = new Label();
            labelTelefono = new Label();
            labelObservaciones = new Label();
            buttonAnadir = new Button();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            dataGridViewContactos = new DataGridView();
            buttonImagen = new Button();
            groupBoxContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).BeginInit();
            SuspendLayout();
            // 
            // groupBoxContacto
            // 
            groupBoxContacto.Controls.Add(pictureBoxImagen);
            groupBoxContacto.Controls.Add(textBoxId);
            groupBoxContacto.Controls.Add(textBoxNombre);
            groupBoxContacto.Controls.Add(dateTimePickerFechaNacimiento);
            groupBoxContacto.Controls.Add(textBoxTelefono);
            groupBoxContacto.Controls.Add(richTextBoxObservaciones);
            groupBoxContacto.Controls.Add(labelId);
            groupBoxContacto.Controls.Add(labelNombre);
            groupBoxContacto.Controls.Add(labelFechaNacimiento);
            groupBoxContacto.Controls.Add(labelTelefono);
            groupBoxContacto.Controls.Add(labelObservaciones);
            groupBoxContacto.Location = new Point(57, 35);
            groupBoxContacto.Margin = new Padding(4, 5, 4, 5);
            groupBoxContacto.Name = "groupBoxContacto";
            groupBoxContacto.Padding = new Padding(4, 5, 4, 5);
            groupBoxContacto.Size = new Size(1019, 398);
            groupBoxContacto.TabIndex = 0;
            groupBoxContacto.TabStop = false;
            groupBoxContacto.Text = "Contacto:";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.Location = new Point(704, 62);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(254, 300);
            pictureBoxImagen.TabIndex = 8;
            pictureBoxImagen.TabStop = false;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(210, 57);
            textBoxId.Margin = new Padding(4, 5, 4, 5);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(83, 31);
            textBoxId.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(210, 105);
            textBoxNombre.Margin = new Padding(4, 5, 4, 5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(350, 31);
            textBoxNombre.TabIndex = 6;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Enabled = false;
            dateTimePickerFechaNacimiento.Location = new Point(210, 153);
            dateTimePickerFechaNacimiento.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(284, 31);
            dateTimePickerFechaNacimiento.TabIndex = 1;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(210, 202);
            textBoxTelefono.Margin = new Padding(4, 5, 4, 5);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.ReadOnly = true;
            textBoxTelefono.Size = new Size(190, 31);
            textBoxTelefono.TabIndex = 7;
            // 
            // richTextBoxObservaciones
            // 
            richTextBoxObservaciones.Location = new Point(210, 250);
            richTextBoxObservaciones.Margin = new Padding(4, 5, 4, 5);
            richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            richTextBoxObservaciones.ReadOnly = true;
            richTextBoxObservaciones.Size = new Size(335, 112);
            richTextBoxObservaciones.TabIndex = 1;
            richTextBoxObservaciones.Text = "";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(36, 62);
            labelId.Margin = new Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(32, 25);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(36, 110);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(82, 25);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(36, 163);
            labelFechaNacimiento.Margin = new Padding(4, 0, 4, 0);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(156, 25);
            labelFechaNacimiento.TabIndex = 2;
            labelFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(36, 207);
            labelTelefono.Margin = new Padding(4, 0, 4, 0);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(83, 25);
            labelTelefono.TabIndex = 3;
            labelTelefono.Text = "Teléfono:";
            // 
            // labelObservaciones
            // 
            labelObservaciones.AutoSize = true;
            labelObservaciones.Location = new Point(36, 255);
            labelObservaciones.Margin = new Padding(4, 0, 4, 0);
            labelObservaciones.Name = "labelObservaciones";
            labelObservaciones.Size = new Size(132, 25);
            labelObservaciones.TabIndex = 4;
            labelObservaciones.Text = "Observaciones:";
            // 
            // buttonAnadir
            // 
            buttonAnadir.Location = new Point(57, 462);
            buttonAnadir.Margin = new Padding(4, 5, 4, 5);
            buttonAnadir.Name = "buttonAnadir";
            buttonAnadir.Size = new Size(107, 38);
            buttonAnadir.TabIndex = 1;
            buttonAnadir.Text = "Añadir";
            buttonAnadir.UseVisualStyleBackColor = true;
            buttonAnadir.Click += buttonAnadir_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(173, 462);
            buttonEliminar.Margin = new Padding(4, 5, 4, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(107, 38);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(289, 462);
            buttonModificar.Margin = new Padding(4, 5, 4, 5);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(107, 38);
            buttonModificar.TabIndex = 3;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Enabled = false;
            buttonGuardar.Location = new Point(854, 462);
            buttonGuardar.Margin = new Padding(4, 5, 4, 5);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(107, 38);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Enabled = false;
            buttonCancelar.Location = new Point(969, 462);
            buttonCancelar.Margin = new Padding(4, 5, 4, 5);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(107, 38);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // dataGridViewContactos
            // 
            dataGridViewContactos.AllowUserToAddRows = false;
            dataGridViewContactos.AllowUserToDeleteRows = false;
            dataGridViewContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContactos.Location = new Point(57, 527);
            dataGridViewContactos.Margin = new Padding(4, 5, 4, 5);
            dataGridViewContactos.Name = "dataGridViewContactos";
            dataGridViewContactos.RowHeadersVisible = false;
            dataGridViewContactos.RowHeadersWidth = 62;
            dataGridViewContactos.RowTemplate.Height = 25;
            dataGridViewContactos.Size = new Size(1019, 203);
            dataGridViewContactos.TabIndex = 6;
            dataGridViewContactos.CellClick += dataGridViewContactos_CellClick;
            // 
            // buttonImagen
            // 
            buttonImagen.Location = new Point(633, 464);
            buttonImagen.Name = "buttonImagen";
            buttonImagen.Size = new Size(112, 34);
            buttonImagen.TabIndex = 7;
            buttonImagen.Text = "Imagen";
            buttonImagen.UseVisualStyleBackColor = true;
            buttonImagen.Click += buttonImagen_Click;
            // 
            // FormAgendaDeContactos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(buttonImagen);
            Controls.Add(buttonAnadir);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonCancelar);
            Controls.Add(groupBoxContacto);
            Controls.Add(dataGridViewContactos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAgendaDeContactos";
            Text = "Agenda de Contactos";
            Load += FormAgendaDeContactos_Load;
            groupBoxContacto.ResumeLayout(false);
            groupBoxContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxContacto;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private RichTextBox richTextBoxObservaciones;
        private TextBox textBoxTelefono;
        private TextBox textBoxNombre;
        private TextBox textBoxId;
        private Label labelObservaciones;
        private Label labelTelefono;
        private Label labelFechaNacimiento;
        private Label labelNombre;
        private Label labelId;
        private Button buttonAnadir;
        private Button buttonEliminar;
        private Button buttonModificar;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private DataGridView dataGridViewContactos;
        private PictureBox pictureBoxImagen;
        private Button buttonImagen;
    }
}
