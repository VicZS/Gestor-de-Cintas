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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazAlmacenarCintas));
            codigoEscaneado = new TextBox();
            LContenedor = new Label();
            CLBListaCintas = new CheckedListBox();
            btnEliminarCita = new Button();
            CBListaContenedores = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            TBResguardarCinta = new TextBox();
            CLBCintasEnUso = new CheckedListBox();
            btnResguardarCinta = new Button();
            btnCrearReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // codigoEscaneado
            // 
            codigoEscaneado.CharacterCasing = CharacterCasing.Upper;
            codigoEscaneado.Font = new Font("Segoe UI", 20.25F);
            codigoEscaneado.Location = new Point(492, 164);
            codigoEscaneado.MaxLength = 20;
            codigoEscaneado.Name = "codigoEscaneado";
            codigoEscaneado.Size = new Size(461, 43);
            codigoEscaneado.TabIndex = 1;
            codigoEscaneado.KeyDown += codigoEscaneado_KeyDown;
            // 
            // LContenedor
            // 
            LContenedor.AutoSize = true;
            LContenedor.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LContenedor.Location = new Point(492, 246);
            LContenedor.Name = "LContenedor";
            LContenedor.Size = new Size(271, 30);
            LContenedor.TabIndex = 2;
            LContenedor.Text = "Contenedor: T##########";
            // 
            // CLBListaCintas
            // 
            CLBListaCintas.CheckOnClick = true;
            CLBListaCintas.Font = new Font("Segoe UI", 12.75F);
            CLBListaCintas.FormattingEnabled = true;
            CLBListaCintas.Location = new Point(492, 350);
            CLBListaCintas.Name = "CLBListaCintas";
            CLBListaCintas.Size = new Size(472, 229);
            CLBListaCintas.TabIndex = 4;
            CLBListaCintas.SelectedIndexChanged += CLBListaCintas_SelectedIndexChanged;
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.Font = new Font("Segoe UI", 12.75F);
            btnEliminarCita.Location = new Point(788, 599);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(165, 56);
            btnEliminarCita.TabIndex = 5;
            btnEliminarCita.Text = "Eliminar Cinta Seleccionada";
            btnEliminarCita.UseVisualStyleBackColor = true;
            btnEliminarCita.Click += btnEliminarCita_Click;
            // 
            // CBListaContenedores
            // 
            CBListaContenedores.DropDownStyle = ComboBoxStyle.DropDownList;
            CBListaContenedores.Font = new Font("Segoe UI", 15.75F);
            CBListaContenedores.FormattingEnabled = true;
            CBListaContenedores.Location = new Point(492, 303);
            CBListaContenedores.Name = "CBListaContenedores";
            CBListaContenedores.Size = new Size(472, 38);
            CBListaContenedores.TabIndex = 6;
            CBListaContenedores.SelectedIndexChanged += CBListaContenedores_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 63, 96);
            panel1.Location = new Point(458, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 678);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(587, 36);
            label1.Name = "label1";
            label1.Size = new Size(246, 30);
            label1.TabIndex = 8;
            label1.Text = "Escanea Aqui las Cintas ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.delivery;
            pictureBox1.Location = new Point(470, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(587, 66);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 10;
            label2.Text = "para su Envio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(88, 55);
            label3.Name = "label3";
            label3.Size = new Size(379, 30);
            label3.TabIndex = 11;
            label3.Text = "Escanea Aqui para Resguardar Cintas ";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // TBResguardarCinta
            // 
            TBResguardarCinta.CharacterCasing = CharacterCasing.Upper;
            TBResguardarCinta.Font = new Font("Segoe UI", 20.25F);
            TBResguardarCinta.Location = new Point(21, 164);
            TBResguardarCinta.MaxLength = 20;
            TBResguardarCinta.Name = "TBResguardarCinta";
            TBResguardarCinta.Size = new Size(412, 43);
            TBResguardarCinta.TabIndex = 13;
            TBResguardarCinta.TextChanged += TBResguardarCinta_TextChanged;
            TBResguardarCinta.KeyDown += TBResguardarCinta_KeyDown;
            // 
            // CLBCintasEnUso
            // 
            CLBCintasEnUso.CheckOnClick = true;
            CLBCintasEnUso.Font = new Font("Segoe UI", 12.75F);
            CLBCintasEnUso.FormattingEnabled = true;
            CLBCintasEnUso.Location = new Point(21, 253);
            CLBCintasEnUso.Name = "CLBCintasEnUso";
            CLBCintasEnUso.Size = new Size(412, 329);
            CLBCintasEnUso.TabIndex = 14;
            CLBCintasEnUso.SelectedIndexChanged += CLBCintasEnUso_SelectedIndexChanged;
            // 
            // btnResguardarCinta
            // 
            btnResguardarCinta.Font = new Font("Segoe UI", 12.75F);
            btnResguardarCinta.Location = new Point(129, 610);
            btnResguardarCinta.Name = "btnResguardarCinta";
            btnResguardarCinta.Size = new Size(165, 56);
            btnResguardarCinta.TabIndex = 15;
            btnResguardarCinta.Text = "Resguardar Cinta Seleccionada";
            btnResguardarCinta.UseVisualStyleBackColor = true;
            btnResguardarCinta.Click += btnResguardarCinta_Click;
            // 
            // btnCrearReporte
            // 
            btnCrearReporte.Font = new Font("Segoe UI", 12.75F);
            btnCrearReporte.Location = new Point(492, 599);
            btnCrearReporte.Name = "btnCrearReporte";
            btnCrearReporte.Size = new Size(165, 56);
            btnCrearReporte.TabIndex = 16;
            btnCrearReporte.Text = "Crear Reporte";
            btnCrearReporte.UseVisualStyleBackColor = true;
            btnCrearReporte.Click += btnCrearReporte_Click;
            // 
            // InterfazAlmacenarCintas
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 223, 231);
            ClientSize = new Size(976, 678);
            Controls.Add(btnCrearReporte);
            Controls.Add(btnResguardarCinta);
            Controls.Add(CLBCintasEnUso);
            Controls.Add(TBResguardarCinta);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(CBListaContenedores);
            Controls.Add(btnEliminarCita);
            Controls.Add(CLBListaCintas);
            Controls.Add(LContenedor);
            Controls.Add(codigoEscaneado);
            Font = new Font("Comic Sans MS", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazAlmacenarCintas";
            Text = "InterfazAlmacenarCintas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox codigoEscaneado;
        private Label LContenedor;
        private CheckedListBox CLBListaCintas;
        private Button btnEliminarCita;
        private ComboBox CBListaContenedores;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox TBResguardarCinta;
        private CheckedListBox CLBCintasEnUso;
        private Button btnResguardarCinta;
        private Button btnCrearReporte;
    }
}