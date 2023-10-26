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
            ((System.ComponentModel.ISupportInitialize)dgvestudiante).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 49);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Estudiante";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 179);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 224);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha Nacimiento";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(110, 277);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtFechaNacimiento
            // 
            dtFechaNacimiento.Location = new Point(193, 224);
            dtFechaNacimiento.Name = "dtFechaNacimiento";
            dtFechaNacimiento.Size = new Size(168, 27);
            dtFechaNacimiento.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(232, 277);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 49);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 8;
            label5.Text = "Lista de Estudiantes";
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(194, 134);
            tbnombre.Name = "tbnombre";
            tbnombre.Size = new Size(125, 27);
            tbnombre.TabIndex = 9;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(194, 183);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(125, 27);
            tbApellido.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 98);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 11;
            label6.Text = "Rut";
            // 
            // tbRut
            // 
            tbRut.Location = new Point(194, 91);
            tbRut.Name = "tbRut";
            tbRut.Size = new Size(125, 27);
            tbRut.TabIndex = 12;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(536, 329);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvestudiante
            // 
            dgvestudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvestudiante.Location = new Point(435, 91);
            dgvestudiante.Name = "dgvestudiante";
            dgvestudiante.RowHeadersWidth = 51;
            dgvestudiante.RowTemplate.Height = 29;
            dgvestudiante.Size = new Size(300, 188);
            dgvestudiante.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Estudiantes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvestudiante).EndInit();
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
    }
}