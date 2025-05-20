namespace Gestor_de_Etiquetas
{
    partial class InterfazAjustes
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCrearBackup = new Button();
            btnCargarBackup = new Button();
            LNombreImpresoraActual = new Label();
            numericUpDown1 = new NumericUpDown();
            btnCambiarNumCopias = new Button();
            textBox1 = new TextBox();
            btnCambiarNomImpresora = new Button();
            LSeleccionaArchivo = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 51);
            label1.Name = "label1";
            label1.Size = new Size(167, 58);
            label1.TabIndex = 0;
            label1.Text = "Generar Backup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sans Serif Collection", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(599, 51);
            label2.Name = "label2";
            label2.Size = new Size(154, 58);
            label2.TabIndex = 1;
            label2.Text = "Cargar Backup";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sans Serif Collection", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 304);
            label3.Name = "label3";
            label3.Size = new Size(196, 58);
            label3.TabIndex = 2;
            label3.Text = "Cambiar Impresora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sans Serif Collection", 12.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(643, 326);
            label4.Name = "label4";
            label4.Size = new Size(226, 58);
            label4.TabIndex = 3;
            label4.Text = "# Copias por Impresion";
            // 
            // btnCrearBackup
            // 
            btnCrearBackup.Location = new Point(63, 111);
            btnCrearBackup.Name = "btnCrearBackup";
            btnCrearBackup.Size = new Size(123, 55);
            btnCrearBackup.TabIndex = 4;
            btnCrearBackup.Text = "Generar";
            btnCrearBackup.UseVisualStyleBackColor = true;
            btnCrearBackup.Click += btnCrearBackup_Click;
            // 
            // btnCargarBackup
            // 
            btnCargarBackup.Location = new Point(612, 170);
            btnCargarBackup.Name = "btnCargarBackup";
            btnCargarBackup.Size = new Size(119, 49);
            btnCargarBackup.TabIndex = 5;
            btnCargarBackup.Text = "Aceptar";
            btnCargarBackup.UseVisualStyleBackColor = true;
            btnCargarBackup.Click += btnCargarBackup_Click;
            // 
            // LNombreImpresoraActual
            // 
            LNombreImpresoraActual.AutoSize = true;
            LNombreImpresoraActual.Location = new Point(58, 349);
            LNombreImpresoraActual.Name = "LNombreImpresoraActual";
            LNombreImpresoraActual.Size = new Size(177, 58);
            LNombreImpresoraActual.TabIndex = 6;
            LNombreImpresoraActual.Text = "Nombre Impresora";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(658, 401);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(56, 53);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCambiarNumCopias
            // 
            btnCambiarNumCopias.Location = new Point(750, 405);
            btnCambiarNumCopias.Name = "btnCambiarNumCopias";
            btnCambiarNumCopias.Size = new Size(119, 49);
            btnCambiarNumCopias.TabIndex = 8;
            btnCambiarNumCopias.Text = "Aceptar";
            btnCambiarNumCopias.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sans Serif Collection", 9.749998F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(63, 405);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 42);
            textBox1.TabIndex = 9;
            // 
            // btnCambiarNomImpresora
            // 
            btnCambiarNomImpresora.Location = new Point(63, 453);
            btnCambiarNomImpresora.Name = "btnCambiarNomImpresora";
            btnCambiarNomImpresora.Size = new Size(119, 49);
            btnCambiarNomImpresora.TabIndex = 10;
            btnCambiarNomImpresora.Text = "Cambiar";
            btnCambiarNomImpresora.UseVisualStyleBackColor = true;
            // 
            // LSeleccionaArchivo
            // 
            LSeleccionaArchivo.AutoSize = true;
            LSeleccionaArchivo.ForeColor = Color.Blue;
            LSeleccionaArchivo.Location = new Point(599, 109);
            LSeleccionaArchivo.Name = "LSeleccionaArchivo";
            LSeleccionaArchivo.Size = new Size(193, 58);
            LSeleccionaArchivo.TabIndex = 11;
            LSeleccionaArchivo.Text = "Seleccionar Archivo...";
            LSeleccionaArchivo.Click += LSeleccionaArchivo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // InterfazAjustes
            // 
            AutoScaleDimensions = new SizeF(10F, 58F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 636);
            Controls.Add(LSeleccionaArchivo);
            Controls.Add(btnCambiarNomImpresora);
            Controls.Add(textBox1);
            Controls.Add(btnCambiarNumCopias);
            Controls.Add(numericUpDown1);
            Controls.Add(LNombreImpresoraActual);
            Controls.Add(btnCargarBackup);
            Controls.Add(btnCrearBackup);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Sans Serif Collection", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 8, 3, 8);
            Name = "InterfazAjustes";
            Text = "InterfazAjustes";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCrearBackup;
        private Button btnCargarBackup;
        private Label LNombreImpresoraActual;
        private NumericUpDown numericUpDown1;
        private Button btnCambiarNumCopias;
        private TextBox textBox1;
        private Button btnCambiarNomImpresora;
        private Label LSeleccionaArchivo;
        private OpenFileDialog openFileDialog1;
    }
}