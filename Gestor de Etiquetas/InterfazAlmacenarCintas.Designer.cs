namespace Gestor_de_Etiquetas
{
    partial class InterfazAlmacenarCintas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            codigoEscaneado = new TextBox();
            contenedorInterfaz = new Label();
            listaCintasInterfaz = new CheckedListBox();
            btnEliminarCita = new Button();
            listaContenedoresInterfaz = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 183);
            label1.Name = "label1";
            label1.Size = new Size(468, 67);
            label1.TabIndex = 0;
            label1.Text = "Empieza a Escanear";
            // 
            // codigoEscaneado
            // 
            codigoEscaneado.CharacterCasing = CharacterCasing.Upper;
            codigoEscaneado.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codigoEscaneado.Location = new Point(144, 93);
            codigoEscaneado.MaxLength = 9;
            codigoEscaneado.Name = "codigoEscaneado";
            codigoEscaneado.Size = new Size(667, 56);
            codigoEscaneado.TabIndex = 1;
            this.codigoEscaneado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codigoEscaneado_KeyDown);

            // 
            // contenedorInterfaz
            // 
            contenedorInterfaz.AutoSize = true;
            contenedorInterfaz.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            contenedorInterfaz.Location = new Point(12, 402);
            contenedorInterfaz.Name = "contenedorInterfaz";
            contenedorInterfaz.Size = new Size(269, 25);
            contenedorInterfaz.TabIndex = 2;
            contenedorInterfaz.Text = "Contenedor: T##########";
            // 
            // listaCintasInterfaz
            // 
            listaCintasInterfaz.FormattingEnabled = true;
            listaCintasInterfaz.Location = new Point(338, 402);
            listaCintasInterfaz.Name = "listaCintasInterfaz";
            listaCintasInterfaz.Size = new Size(291, 204);
            listaCintasInterfaz.TabIndex = 4;
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.Location = new Point(749, 447);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(165, 56);
            btnEliminarCita.TabIndex = 5;
            btnEliminarCita.Text = "Eliminar Cinta Seleccionada";
            btnEliminarCita.UseVisualStyleBackColor = true;
            // 
            // listaContenedoresInterfaz
            // 
            listaContenedoresInterfaz.DropDownStyle = ComboBoxStyle.DropDownList;
            listaContenedoresInterfaz.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaContenedoresInterfaz.FormattingEnabled = true;
            listaContenedoresInterfaz.Location = new Point(12, 456);
            listaContenedoresInterfaz.Name = "listaContenedoresInterfaz";
            listaContenedoresInterfaz.Size = new Size(269, 37);
            listaContenedoresInterfaz.TabIndex = 6;
            // 
            // InterfazAlmacenarCintas
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 182, 196);
            ClientSize = new Size(976, 678);
            Controls.Add(listaContenedoresInterfaz);
            Controls.Add(btnEliminarCita);
            Controls.Add(listaCintasInterfaz);
            Controls.Add(contenedorInterfaz);
            Controls.Add(codigoEscaneado);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazAlmacenarCintas";
            Text = "InterfazAlmacenarCintas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox codigoEscaneado;
        private Label contenedorInterfaz;
        private CheckedListBox listaCintasInterfaz;
        private Button btnEliminarCita;
        private ComboBox listaContenedoresInterfaz;
    }
}