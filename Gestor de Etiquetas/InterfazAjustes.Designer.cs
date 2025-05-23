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
            NUDNumCopias = new NumericUpDown();
            btnCambiarNumCopias = new Button();
            TBNuevoNombreImpresora = new TextBox();
            btnCambiarNomImpresora = new Button();
            LSeleccionaArchivo = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)NUDNumCopias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label1.Location = new Point(63, 78);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 0;
            label1.Text = "Generar Backup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label2.Location = new Point(623, 78);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "Cargar Backup";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label3.Location = new Point(63, 422);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 2;
            label3.Text = "Cambiar Impresora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label4.Location = new Point(623, 422);
            label4.Name = "label4";
            label4.Size = new Size(196, 23);
            label4.TabIndex = 3;
            label4.Text = "# Copias por Impresion";
            // 
            // btnCrearBackup
            // 
            btnCrearBackup.Font = new Font("Segoe UI", 12.75F);
            btnCrearBackup.Location = new Point(65, 150);
            btnCrearBackup.Margin = new Padding(3, 1, 3, 1);
            btnCrearBackup.Name = "btnCrearBackup";
            btnCrearBackup.Size = new Size(119, 35);
            btnCrearBackup.TabIndex = 4;
            btnCrearBackup.Text = "Generar";
            btnCrearBackup.UseVisualStyleBackColor = true;
            btnCrearBackup.Click += btnCrearBackup_Click;
            // 
            // btnCargarBackup
            // 
            btnCargarBackup.Font = new Font("Segoe UI", 12.75F);
            btnCargarBackup.Location = new Point(623, 141);
            btnCargarBackup.Margin = new Padding(3, 1, 3, 1);
            btnCargarBackup.Name = "btnCargarBackup";
            btnCargarBackup.Size = new Size(119, 35);
            btnCargarBackup.TabIndex = 5;
            btnCargarBackup.Text = "Aceptar";
            btnCargarBackup.UseVisualStyleBackColor = true;
            btnCargarBackup.Click += btnCargarBackup_Click;
            // 
            // LNombreImpresoraActual
            // 
            LNombreImpresoraActual.AutoSize = true;
            LNombreImpresoraActual.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LNombreImpresoraActual.Location = new Point(65, 460);
            LNombreImpresoraActual.Name = "LNombreImpresoraActual";
            LNombreImpresoraActual.Size = new Size(154, 23);
            LNombreImpresoraActual.TabIndex = 6;
            LNombreImpresoraActual.Text = "Nombre Impresora";
            // 
            // NUDNumCopias
            // 
            NUDNumCopias.Font = new Font("Segoe UI", 12.75F);
            NUDNumCopias.Location = new Point(623, 479);
            NUDNumCopias.Margin = new Padding(1, 0, 1, 0);
            NUDNumCopias.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            NUDNumCopias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDNumCopias.Name = "NUDNumCopias";
            NUDNumCopias.Size = new Size(58, 30);
            NUDNumCopias.TabIndex = 7;
            NUDNumCopias.TextAlign = HorizontalAlignment.Center;
            NUDNumCopias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCambiarNumCopias
            // 
            btnCambiarNumCopias.Font = new Font("Segoe UI", 12.75F);
            btnCambiarNumCopias.Location = new Point(700, 474);
            btnCambiarNumCopias.Margin = new Padding(3, 1, 3, 1);
            btnCambiarNumCopias.Name = "btnCambiarNumCopias";
            btnCambiarNumCopias.Size = new Size(119, 35);
            btnCambiarNumCopias.TabIndex = 8;
            btnCambiarNumCopias.Text = "Aceptar";
            btnCambiarNumCopias.UseVisualStyleBackColor = true;
            btnCambiarNumCopias.Click += btnCambiarNumCopias_Click;
            // 
            // TBNuevoNombreImpresora
            // 
            TBNuevoNombreImpresora.Font = new Font("Segoe UI", 12.75F);
            TBNuevoNombreImpresora.Location = new Point(63, 514);
            TBNuevoNombreImpresora.Margin = new Padding(3, 1, 3, 1);
            TBNuevoNombreImpresora.Name = "TBNuevoNombreImpresora";
            TBNuevoNombreImpresora.Size = new Size(224, 30);
            TBNuevoNombreImpresora.TabIndex = 9;
            // 
            // btnCambiarNomImpresora
            // 
            btnCambiarNomImpresora.Font = new Font("Segoe UI", 12.75F);
            btnCambiarNomImpresora.Location = new Point(63, 565);
            btnCambiarNomImpresora.Margin = new Padding(3, 1, 3, 1);
            btnCambiarNomImpresora.Name = "btnCambiarNomImpresora";
            btnCambiarNomImpresora.Size = new Size(119, 35);
            btnCambiarNomImpresora.TabIndex = 10;
            btnCambiarNomImpresora.Text = "Cambiar";
            btnCambiarNomImpresora.UseVisualStyleBackColor = true;
            btnCambiarNomImpresora.Click += btnCambiarNomImpresora_Click;
            // 
            // LSeleccionaArchivo
            // 
            LSeleccionaArchivo.AutoSize = true;
            LSeleccionaArchivo.Font = new Font("Segoe UI", 12.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LSeleccionaArchivo.ForeColor = Color.Blue;
            LSeleccionaArchivo.Location = new Point(623, 111);
            LSeleccionaArchivo.Name = "LSeleccionaArchivo";
            LSeleccionaArchivo.Size = new Size(161, 23);
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
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 223, 231);
            ClientSize = new Size(976, 678);
            Controls.Add(LSeleccionaArchivo);
            Controls.Add(btnCambiarNomImpresora);
            Controls.Add(TBNuevoNombreImpresora);
            Controls.Add(btnCambiarNumCopias);
            Controls.Add(NUDNumCopias);
            Controls.Add(LNombreImpresoraActual);
            Controls.Add(btnCargarBackup);
            Controls.Add(btnCrearBackup);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazAjustes";
            Text = "1";
            ((System.ComponentModel.ISupportInitialize)NUDNumCopias).EndInit();
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
        private NumericUpDown NUDNumCopias;
        private Button btnCambiarNumCopias;
        private TextBox TBNuevoNombreImpresora;
        private Button btnCambiarNomImpresora;
        private Label LSeleccionaArchivo;
        private OpenFileDialog openFileDialog1;
    }
}