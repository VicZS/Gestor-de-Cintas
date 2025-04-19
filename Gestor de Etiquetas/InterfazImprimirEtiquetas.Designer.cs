namespace Gestor_de_Etiquetas
{
    partial class InterfazImprimirEtiquetas
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
            etiquetaReimprimir = new TextBox();
            btnImprimirEtiquetaSiguiente = new Button();
            btnImprimirEtiquetasSiguientes = new Button();
            btnImprimirDiezEtiquetas = new Button();
            numeroEtiquetasSiguientes = new NumericUpDown();
            btnReimprimirEtiqueta = new Button();
            ((System.ComponentModel.ISupportInitialize)numeroEtiquetasSiguientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 379);
            label1.Name = "label1";
            label1.Size = new Size(270, 23);
            label1.TabIndex = 0;
            label1.Text = "Imprimir las siguientes 10 etiquetas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 203);
            label2.Name = "label2";
            label2.Size = new Size(229, 23);
            label2.TabIndex = 1;
            label2.Text = "Imprimir Etiquetas Siguientes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 68);
            label3.Name = "label3";
            label3.Size = new Size(215, 23);
            label3.TabIndex = 2;
            label3.Text = "Imprimir Etiqueta Siguiente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 500);
            label4.Name = "label4";
            label4.Size = new Size(157, 23);
            label4.TabIndex = 3;
            label4.Text = "Reimprimir Etiqueta";
            // 
            // etiquetaReimprimir
            // 
            etiquetaReimprimir.CharacterCasing = CharacterCasing.Upper;
            etiquetaReimprimir.Location = new Point(42, 539);
            etiquetaReimprimir.MaxLength = 9;
            etiquetaReimprimir.Name = "etiquetaReimprimir";
            etiquetaReimprimir.Size = new Size(229, 30);
            etiquetaReimprimir.TabIndex = 4;
            etiquetaReimprimir.TextChanged += etiquetaReimprimir_TextChanged;
            // 
            // btnImprimirEtiquetaSiguiente
            // 
            btnImprimirEtiquetaSiguiente.Location = new Point(42, 110);
            btnImprimirEtiquetaSiguiente.Name = "btnImprimirEtiquetaSiguiente";
            btnImprimirEtiquetaSiguiente.Size = new Size(97, 36);
            btnImprimirEtiquetaSiguiente.TabIndex = 5;
            btnImprimirEtiquetaSiguiente.Text = "Imprimir";
            btnImprimirEtiquetaSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnImprimirEtiquetasSiguientes
            // 
            btnImprimirEtiquetasSiguientes.Location = new Point(42, 297);
            btnImprimirEtiquetasSiguientes.Name = "btnImprimirEtiquetasSiguientes";
            btnImprimirEtiquetasSiguientes.Size = new Size(97, 36);
            btnImprimirEtiquetasSiguientes.TabIndex = 6;
            btnImprimirEtiquetasSiguientes.Text = "Imprimir";
            btnImprimirEtiquetasSiguientes.UseVisualStyleBackColor = true;
            // 
            // btnImprimirDiezEtiquetas
            // 
            btnImprimirDiezEtiquetas.Location = new Point(42, 426);
            btnImprimirDiezEtiquetas.Name = "btnImprimirDiezEtiquetas";
            btnImprimirDiezEtiquetas.Size = new Size(97, 36);
            btnImprimirDiezEtiquetas.TabIndex = 7;
            btnImprimirDiezEtiquetas.Text = "Imprimir";
            btnImprimirDiezEtiquetas.UseVisualStyleBackColor = true;
            // 
            // numeroEtiquetasSiguientes
            // 
            numeroEtiquetasSiguientes.Location = new Point(42, 239);
            numeroEtiquetasSiguientes.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numeroEtiquetasSiguientes.Name = "numeroEtiquetasSiguientes";
            numeroEtiquetasSiguientes.Size = new Size(97, 30);
            numeroEtiquetasSiguientes.TabIndex = 9;
            // 
            // btnReimprimirEtiqueta
            // 
            btnReimprimirEtiqueta.Location = new Point(42, 590);
            btnReimprimirEtiqueta.Name = "btnReimprimirEtiqueta";
            btnReimprimirEtiqueta.Size = new Size(97, 36);
            btnReimprimirEtiqueta.TabIndex = 10;
            btnReimprimirEtiqueta.Text = "Imprimir";
            btnReimprimirEtiqueta.UseVisualStyleBackColor = true;
            btnReimprimirEtiqueta.Click += ReimprimirEtiqueta_Click;
            // 
            // InterfazImprimirEtiquetas
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 182, 196);
            ClientSize = new Size(976, 678);
            Controls.Add(btnReimprimirEtiqueta);
            Controls.Add(numeroEtiquetasSiguientes);
            Controls.Add(btnImprimirDiezEtiquetas);
            Controls.Add(btnImprimirEtiquetasSiguientes);
            Controls.Add(btnImprimirEtiquetaSiguiente);
            Controls.Add(etiquetaReimprimir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazImprimirEtiquetas";
            Text = "InterfazImprimirEtiquetas";
            ((System.ComponentModel.ISupportInitialize)numeroEtiquetasSiguientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox etiquetaReimprimir;
        private Button btnImprimirEtiquetaSiguiente;
        private Button btnImprimirEtiquetasSiguientes;
        private Button btnImprimirDiezEtiquetas;
        private NumericUpDown numeroEtiquetasSiguientes;
        private Button btnReimprimirEtiqueta;
    }
}