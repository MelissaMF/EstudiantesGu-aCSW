namespace UI
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            dtFechaNacimiento = new DateTimePicker();
            btnLimpiar = new Button();
            label5 = new Label();
            tbnombre = new TextBox();
            tbApellido = new TextBox();
            label6 = new Label();
            tbRut = new TextBox();
            btnEliminar = new Button();
            dgvestudiante = new DataGridView();
            Rut = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Fecha_Nacimiento = new DataGridViewTextBoxColumn();
            estudianteBLLBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvestudiante).BeginInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBLLBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 37);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Estudiante";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 100);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 134);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 168);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha Nacimiento";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(96, 208);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtFechaNacimiento.Location = new Point(169, 168);
            dtFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(148, 23);
            dtFechaNacimiento.TabIndex = 5;
            dtFechaNacimiento.Value = new DateTime(2023, 10, 27, 0, 0, 0, 0);
            dtFechaNacimiento.ValueChanged += dtFechaNacimiento_ValueChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(203, 208);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 22);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 37);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 8;
            label5.Text = "Lista de Estudiantes";
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(170, 100);
            tbnombre.Margin = new Padding(3, 2, 3, 2);
            tbnombre.Name = "tbnombre";
            tbnombre.Size = new Size(110, 23);
            tbnombre.TabIndex = 9;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(170, 137);
            tbApellido.Margin = new Padding(3, 2, 3, 2);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(110, 23);
            tbApellido.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 74);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 11;
            label6.Text = "Rut";
            // 
            // tbRut
            // 
            tbRut.Location = new Point(170, 68);
            tbRut.Margin = new Padding(3, 2, 3, 2);
            tbRut.Name = "tbRut";
            tbRut.Size = new Size(110, 23);
            tbRut.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(469, 247);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvestudiante
            // 
            dgvestudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvestudiante.Columns.AddRange(new DataGridViewColumn[] { Rut, Nombre, Apellido, Fecha_Nacimiento });
            dgvestudiante.Location = new Point(381, 68);
            dgvestudiante.Margin = new Padding(3, 2, 3, 2);
            dgvestudiante.Name = "dgvestudiante";
            dgvestudiante.RowHeadersWidth = 51;
            dgvestudiante.RowTemplate.Height = 29;
            dgvestudiante.Size = new Size(455, 141);
            dgvestudiante.TabIndex = 15;
            // 
            // Rut
            // 
            Rut.HeaderText = "Rut";
            Rut.Name = "Rut";
            Rut.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Fecha_Nacimiento
            // 
            Fecha_Nacimiento.HeaderText = "Fecha Nacimiento";
            Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            Fecha_Nacimiento.ReadOnly = true;
            // 
            // estudianteBLLBindingSource
            // 
            estudianteBLLBindingSource.DataSource = typeof(BLL.EstudianteBLL);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 338);
            Controls.Add(dgvestudiante);
            Controls.Add(btnEliminar);
            Controls.Add(tbRut);
            Controls.Add(label6);
            Controls.Add(tbApellido);
            Controls.Add(tbnombre);
            Controls.Add(label5);
            Controls.Add(btnLimpiar);
            Controls.Add(dtFechaNacimiento);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Estudiantes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvestudiante).EndInit();
            ((System.ComponentModel.ISupportInitialize)estudianteBLLBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private DateTimePicker dtFechaNacimiento;
        private Button btnLimpiar;
        private Label label5;
        private TextBox tbnombre;
        private TextBox tbApellido;
        private Label label6;
        private TextBox tbRut;
        private Button btnEliminar;
        private DataGridView dgvestudiante;
        private BindingSource estudianteBLLBindingSource;
        private DataGridViewTextBoxColumn Rut;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Fecha_Nacimiento;
    }
}