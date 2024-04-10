namespace Agenda
{
    partial class Form1
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
            dateTimePickerFechaNacimiento = new DateTimePicker();
            richTextBoxObservaciones = new RichTextBox();
            textBoxTelefono = new TextBox();
            textBoxNombre = new TextBox();
            textBoxId = new TextBox();
            labelObservaciones = new Label();
            labelTelefono = new Label();
            labelFechaNacimiento = new Label();
            labelNombre = new Label();
            labelId = new Label();
            buttonAnadir = new Button();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            dataGridViewContactos = new DataGridView();
            groupBoxContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).BeginInit();
            SuspendLayout();
            // 
            // groupBoxContacto
            // 
            groupBoxContacto.Controls.Add(dateTimePickerFechaNacimiento);
            groupBoxContacto.Controls.Add(richTextBoxObservaciones);
            groupBoxContacto.Controls.Add(textBoxTelefono);
            groupBoxContacto.Controls.Add(textBoxNombre);
            groupBoxContacto.Controls.Add(textBoxId);
            groupBoxContacto.Controls.Add(labelObservaciones);
            groupBoxContacto.Controls.Add(labelTelefono);
            groupBoxContacto.Controls.Add(labelFechaNacimiento);
            groupBoxContacto.Controls.Add(labelNombre);
            groupBoxContacto.Controls.Add(labelId);
            groupBoxContacto.Location = new Point(40, 21);
            groupBoxContacto.Name = "groupBoxContacto";
            groupBoxContacto.Size = new Size(551, 239);
            groupBoxContacto.TabIndex = 0;
            groupBoxContacto.TabStop = false;
            groupBoxContacto.Text = "Contacto:";
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Location = new Point(147, 92);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(200, 23);
            dateTimePickerFechaNacimiento.TabIndex = 1;
            // 
            // richTextBoxObservaciones
            // 
            richTextBoxObservaciones.Location = new Point(147, 150);
            richTextBoxObservaciones.Name = "richTextBoxObservaciones";
            richTextBoxObservaciones.Size = new Size(236, 69);
            richTextBoxObservaciones.TabIndex = 1;
            richTextBoxObservaciones.Text = "";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(147, 121);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(134, 23);
            textBoxTelefono.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(147, 63);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(246, 23);
            textBoxNombre.TabIndex = 6;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(147, 34);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(59, 23);
            textBoxId.TabIndex = 5;
            // 
            // labelObservaciones
            // 
            labelObservaciones.AutoSize = true;
            labelObservaciones.Location = new Point(25, 153);
            labelObservaciones.Name = "labelObservaciones";
            labelObservaciones.Size = new Size(87, 15);
            labelObservaciones.TabIndex = 4;
            labelObservaciones.Text = "Observaciones:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(25, 124);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(55, 15);
            labelTelefono.TabIndex = 3;
            labelTelefono.Text = "Teléfono:";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(25, 98);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(106, 15);
            labelFechaNacimiento.TabIndex = 2;
            labelFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(25, 66);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(25, 37);
            labelId.Name = "labelId";
            labelId.Size = new Size(20, 15);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // buttonAnadir
            // 
            buttonAnadir.Location = new Point(40, 277);
            buttonAnadir.Name = "buttonAnadir";
            buttonAnadir.Size = new Size(75, 23);
            buttonAnadir.TabIndex = 1;
            buttonAnadir.Text = "Añadir";
            buttonAnadir.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(121, 277);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(202, 277);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 3;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(435, 277);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(516, 277);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewContactos
            // 
            dataGridViewContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContactos.Location = new Point(40, 316);
            dataGridViewContactos.Name = "dataGridViewContactos";
            dataGridViewContactos.RowTemplate.Height = 25;
            dataGridViewContactos.Size = new Size(713, 122);
            dataGridViewContactos.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewContactos);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAnadir);
            Controls.Add(groupBoxContacto);
            Name = "Form1";
            Text = "Form1";
            groupBoxContacto.ResumeLayout(false);
            groupBoxContacto.PerformLayout();
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
    }
}
