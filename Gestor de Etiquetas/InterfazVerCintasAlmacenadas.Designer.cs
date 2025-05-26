namespace Gestor_de_Etiquetas
{
    partial class InterfazVerCintasAlmacenadas
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
            TBCintaABuscar = new TextBox();
            btnBuscarCinta = new Button();
            label1 = new Label();
            DTPMostrarContenedores = new DateTimePicker();
            label6 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            label7 = new Label();
            CBContenedorCintasAMostrar = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            LVListaCintasAlmacenLocal = new ListView();
            LVListaCintasEnUso = new ListView();
            label2 = new Label();
            LVListaContenedoresConCintasReutilizar = new ListView();
            LVListaContenedoresDelDia = new ListView();
            LVListaCintasContenedor = new ListView();
            SuspendLayout();
            // 
            // TBCintaABuscar
            // 
            TBCintaABuscar.CharacterCasing = CharacterCasing.Upper;
            TBCintaABuscar.Font = new Font("Segoe UI", 12.75F);
            TBCintaABuscar.Location = new Point(22, 63);
            TBCintaABuscar.MaxLength = 8;
            TBCintaABuscar.Name = "TBCintaABuscar";
            TBCintaABuscar.Size = new Size(393, 30);
            TBCintaABuscar.TabIndex = 9;
            // 
            // btnBuscarCinta
            // 
            btnBuscarCinta.Font = new Font("Segoe UI", 12.75F);
            btnBuscarCinta.Location = new Point(22, 99);
            btnBuscarCinta.Name = "btnBuscarCinta";
            btnBuscarCinta.Size = new Size(96, 35);
            btnBuscarCinta.TabIndex = 10;
            btnBuscarCinta.Text = "Buscar";
            btnBuscarCinta.UseVisualStyleBackColor = true;
            btnBuscarCinta.Click += btnBuscarCinta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 11;
            label1.Text = "Buscar Cinta";
            label1.Click += label1_Click;
            // 
            // DTPMostrarContenedores
            // 
            DTPMostrarContenedores.CustomFormat = "dd MM yyyy";
            DTPMostrarContenedores.Font = new Font("Segoe UI", 12.75F);
            DTPMostrarContenedores.Format = DateTimePickerFormat.Short;
            DTPMostrarContenedores.Location = new Point(517, 63);
            DTPMostrarContenedores.Name = "DTPMostrarContenedores";
            DTPMostrarContenedores.RightToLeft = RightToLeft.No;
            DTPMostrarContenedores.Size = new Size(389, 30);
            DTPMostrarContenedores.TabIndex = 25;
            DTPMostrarContenedores.ValueChanged += DTPMostrarContenedores_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label6.Location = new Point(517, 28);
            label6.Name = "label6";
            label6.Size = new Size(250, 23);
            label6.TabIndex = 26;
            label6.Text = "Mostrar Contenedores del Dia";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(14, 63, 96);
            panel6.Location = new Point(443, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 676);
            panel6.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label8.Location = new Point(22, 486);
            label8.Name = "label8";
            label8.Size = new Size(212, 23);
            label8.TabIndex = 35;
            label8.Text = "Contenedores con Cintas ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label7.Location = new Point(517, 319);
            label7.Name = "label7";
            label7.Size = new Size(256, 23);
            label7.TabIndex = 40;
            label7.Text = "Mostrar Cintas del Contenedor";
            // 
            // CBContenedorCintasAMostrar
            // 
            CBContenedorCintasAMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            CBContenedorCintasAMostrar.Font = new Font("Segoe UI", 12.75F);
            CBContenedorCintasAMostrar.FormattingEnabled = true;
            CBContenedorCintasAMostrar.Location = new Point(517, 358);
            CBContenedorCintasAMostrar.Name = "CBContenedorCintasAMostrar";
            CBContenedorCintasAMostrar.Size = new Size(389, 31);
            CBContenedorCintasAMostrar.TabIndex = 41;
            CBContenedorCintasAMostrar.SelectedIndexChanged += CBContenedorCintasAMostrar_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label9.Location = new Point(22, 509);
            label9.Name = "label9";
            label9.Size = new Size(127, 23);
            label9.TabIndex = 42;
            label9.Text = "para Reutilizar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label10.Location = new Point(22, 159);
            label10.Name = "label10";
            label10.Size = new Size(173, 23);
            label10.TabIndex = 43;
            label10.Text = "Cintas en Resguardo";
            // 
            // LVListaCintasAlmacenLocal
            // 
            LVListaCintasAlmacenLocal.Font = new Font("Segoe UI", 12.75F);
            LVListaCintasAlmacenLocal.Location = new Point(22, 201);
            LVListaCintasAlmacenLocal.Margin = new Padding(1);
            LVListaCintasAlmacenLocal.Name = "LVListaCintasAlmacenLocal";
            LVListaCintasAlmacenLocal.Size = new Size(393, 112);
            LVListaCintasAlmacenLocal.TabIndex = 20;
            LVListaCintasAlmacenLocal.UseCompatibleStateImageBehavior = false;
            LVListaCintasAlmacenLocal.View = View.List;
            // 
            // LVListaCintasEnUso
            // 
            LVListaCintasEnUso.Font = new Font("Segoe UI", 12.75F);
            LVListaCintasEnUso.Location = new Point(22, 358);
            LVListaCintasEnUso.Margin = new Padding(1);
            LVListaCintasEnUso.Name = "LVListaCintasEnUso";
            LVListaCintasEnUso.Size = new Size(393, 112);
            LVListaCintasEnUso.TabIndex = 46;
            LVListaCintasEnUso.UseCompatibleStateImageBehavior = false;
            LVListaCintasEnUso.View = View.List;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label2.Location = new Point(22, 332);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 45;
            label2.Text = "Cintas en Uso";
            // 
            // LVListaContenedoresConCintasReutilizar
            // 
            LVListaContenedoresConCintasReutilizar.Font = new Font("Segoe UI", 12.75F);
            LVListaContenedoresConCintasReutilizar.Location = new Point(22, 540);
            LVListaContenedoresConCintasReutilizar.Name = "LVListaContenedoresConCintasReutilizar";
            LVListaContenedoresConCintasReutilizar.Size = new Size(393, 94);
            LVListaContenedoresConCintasReutilizar.TabIndex = 47;
            LVListaContenedoresConCintasReutilizar.UseCompatibleStateImageBehavior = false;
            LVListaContenedoresConCintasReutilizar.View = View.List;
            // 
            // LVListaContenedoresDelDia
            // 
            LVListaContenedoresDelDia.Font = new Font("Segoe UI", 12.75F);
            LVListaContenedoresDelDia.Location = new Point(517, 113);
            LVListaContenedoresDelDia.Name = "LVListaContenedoresDelDia";
            LVListaContenedoresDelDia.Size = new Size(389, 112);
            LVListaContenedoresDelDia.TabIndex = 48;
            LVListaContenedoresDelDia.UseCompatibleStateImageBehavior = false;
            LVListaContenedoresDelDia.View = View.List;
            // 
            // LVListaCintasContenedor
            // 
            LVListaCintasContenedor.Font = new Font("Segoe UI", 12.75F);
            LVListaCintasContenedor.Location = new Point(517, 403);
            LVListaCintasContenedor.Name = "LVListaCintasContenedor";
            LVListaCintasContenedor.Size = new Size(389, 231);
            LVListaCintasContenedor.TabIndex = 49;
            LVListaCintasContenedor.UseCompatibleStateImageBehavior = false;
            LVListaCintasContenedor.View = View.List;
            // 
            // InterfazVerCintasAlmacenadas
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 223, 231);
            ClientSize = new Size(976, 678);
            Controls.Add(LVListaCintasContenedor);
            Controls.Add(LVListaContenedoresDelDia);
            Controls.Add(LVListaContenedoresConCintasReutilizar);
            Controls.Add(LVListaCintasEnUso);
            Controls.Add(label2);
            Controls.Add(LVListaCintasAlmacenLocal);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(CBContenedorCintasAMostrar);
            Controls.Add(label7);
            Controls.Add(panel6);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(DTPMostrarContenedores);
            Controls.Add(label1);
            Controls.Add(btnBuscarCinta);
            Controls.Add(TBCintaABuscar);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazVerCintasAlmacenadas";
            Text = "InterfazVerCintasAlmacenadas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TBCintaABuscar;
        private Button btnBuscarCinta;
        private Label label1;
        private DateTimePicker DTPMostrarContenedores;
        private Label label6;
        private Panel panel6;
        private Label label8;
        private Label label7;
        private ComboBox CBContenedorCintasAMostrar;
        private Label label9;
        private Label label10;
        private ListView LVListaCintasAlmacenLocal;
        private ListView LVListaCintasEnUso;
        private Label label2;
        private ListView LVListaContenedoresConCintasReutilizar;
        private ListView LVListaContenedoresDelDia;
        private ListView LVListaCintasContenedor;
    }
}