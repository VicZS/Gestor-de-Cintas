namespace Gestor_de_Etiquetas
{
    partial class InterfazVerCintasAlmacenadasP2
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
            btnAgregarCinta = new Button();
            TBAgregarCinta = new TextBox();
            CBListaContenedores = new ComboBox();
            btnCrearContenedor = new Button();
            TBCrearContenedor = new TextBox();
            DTPCrearContenedor = new DateTimePicker();
            btnEliminarContenedorSeleccionado = new Button();
            CBListaContenedoresEliminar = new ComboBox();
            CLBListaCintasEliminar = new CheckedListBox();
            btnEliminarCintaSeleccionada = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TBCintaEliminar = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnAgregarCinta
            // 
            btnAgregarCinta.Location = new Point(103, 597);
            btnAgregarCinta.Name = "btnAgregarCinta";
            btnAgregarCinta.Size = new Size(154, 34);
            btnAgregarCinta.TabIndex = 45;
            btnAgregarCinta.Text = "Agregar Cinta";
            btnAgregarCinta.UseVisualStyleBackColor = true;
            btnAgregarCinta.Click += btnAgregarCinta_Click;
            // 
            // TBAgregarCinta
            // 
            TBAgregarCinta.CharacterCasing = CharacterCasing.Upper;
            TBAgregarCinta.Location = new Point(26, 561);
            TBAgregarCinta.MaxLength = 8;
            TBAgregarCinta.Name = "TBAgregarCinta";
            TBAgregarCinta.Size = new Size(299, 30);
            TBAgregarCinta.TabIndex = 44;
            // 
            // CBListaContenedores
            // 
            CBListaContenedores.DropDownStyle = ComboBoxStyle.DropDownList;
            CBListaContenedores.FormattingEnabled = true;
            CBListaContenedores.Location = new Point(25, 482);
            CBListaContenedores.Name = "CBListaContenedores";
            CBListaContenedores.Size = new Size(300, 31);
            CBListaContenedores.TabIndex = 43;
            // 
            // btnCrearContenedor
            // 
            btnCrearContenedor.Location = new Point(102, 279);
            btnCrearContenedor.Name = "btnCrearContenedor";
            btnCrearContenedor.Size = new Size(155, 37);
            btnCrearContenedor.TabIndex = 42;
            btnCrearContenedor.Text = "Crear Contenedor";
            btnCrearContenedor.UseVisualStyleBackColor = true;
            btnCrearContenedor.Click += btnCrearContenedor_Click;
            // 
            // TBCrearContenedor
            // 
            TBCrearContenedor.CharacterCasing = CharacterCasing.Upper;
            TBCrearContenedor.Location = new Point(26, 243);
            TBCrearContenedor.Name = "TBCrearContenedor";
            TBCrearContenedor.Size = new Size(300, 30);
            TBCrearContenedor.TabIndex = 41;
            // 
            // DTPCrearContenedor
            // 
            DTPCrearContenedor.Location = new Point(26, 158);
            DTPCrearContenedor.Name = "DTPCrearContenedor";
            DTPCrearContenedor.Size = new Size(300, 30);
            DTPCrearContenedor.TabIndex = 40;
            // 
            // btnEliminarContenedorSeleccionado
            // 
            btnEliminarContenedorSeleccionado.Location = new Point(752, 242);
            btnEliminarContenedorSeleccionado.Name = "btnEliminarContenedorSeleccionado";
            btnEliminarContenedorSeleccionado.Size = new Size(169, 30);
            btnEliminarContenedorSeleccionado.TabIndex = 39;
            btnEliminarContenedorSeleccionado.Text = "Eliminar Contenedor";
            btnEliminarContenedorSeleccionado.UseVisualStyleBackColor = true;
            btnEliminarContenedorSeleccionado.Click += btnEliminarContenedorSeleccionado_Click;
            // 
            // CBListaContenedoresEliminar
            // 
            CBListaContenedoresEliminar.DropDownStyle = ComboBoxStyle.DropDownList;
            CBListaContenedoresEliminar.FormattingEnabled = true;
            CBListaContenedoresEliminar.Location = new Point(665, 200);
            CBListaContenedoresEliminar.Name = "CBListaContenedoresEliminar";
            CBListaContenedoresEliminar.Size = new Size(256, 31);
            CBListaContenedoresEliminar.TabIndex = 38;
            CBListaContenedoresEliminar.SelectedIndexChanged += CBListaContenedoresEliminar_SelectedIndexChanged;
            // 
            // CLBListaCintasEliminar
            // 
            CLBListaCintasEliminar.CheckOnClick = true;
            CLBListaCintasEliminar.FormattingEnabled = true;
            CLBListaCintasEliminar.Location = new Point(665, 430);
            CLBListaCintasEliminar.Name = "CLBListaCintasEliminar";
            CLBListaCintasEliminar.Size = new Size(256, 104);
            CLBListaCintasEliminar.TabIndex = 37;
            // 
            // btnEliminarCintaSeleccionada
            // 
            btnEliminarCintaSeleccionada.Location = new Point(752, 612);
            btnEliminarCintaSeleccionada.Name = "btnEliminarCintaSeleccionada";
            btnEliminarCintaSeleccionada.Size = new Size(169, 30);
            btnEliminarCintaSeleccionada.TabIndex = 36;
            btnEliminarCintaSeleccionada.Text = "Eliminar Cinta";
            btnEliminarCintaSeleccionada.UseVisualStyleBackColor = true;
            btnEliminarCintaSeleccionada.Click += btnEliminarCintaSeleccionada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14F);
            label1.Location = new Point(25, 122);
            label1.Name = "label1";
            label1.Size = new Size(308, 26);
            label1.TabIndex = 46;
            label1.Text = "Fecha de Creacion del Contenedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14F);
            label2.Location = new Point(26, 205);
            label2.Name = "label2";
            label2.Size = new Size(219, 26);
            label2.TabIndex = 47;
            label2.Text = "Nombre del Contenedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14F);
            label3.Location = new Point(735, 162);
            label3.Name = "label3";
            label3.Size = new Size(186, 26);
            label3.TabIndex = 48;
            label3.Text = "Eliminar Contenedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14F);
            label4.Location = new Point(25, 430);
            label4.Name = "label4";
            label4.Size = new Size(354, 26);
            label4.TabIndex = 49;
            label4.Text = "Contenedor Donde se Agregara la Cinta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14F);
            label5.Location = new Point(29, 532);
            label5.Name = "label5";
            label5.Size = new Size(179, 26);
            label5.TabIndex = 50;
            label5.Text = "Nombre de la Cinta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14F);
            label6.Location = new Point(645, 387);
            label6.Name = "label6";
            label6.Size = new Size(276, 26);
            label6.TabIndex = 51;
            label6.Text = "Seleccionar Cinta(s) a Eliminar";
            // 
            // TBCintaEliminar
            // 
            TBCintaEliminar.CharacterCasing = CharacterCasing.Upper;
            TBCintaEliminar.Location = new Point(665, 576);
            TBCintaEliminar.MaxLength = 8;
            TBCintaEliminar.Name = "TBCintaEliminar";
            TBCintaEliminar.Size = new Size(256, 30);
            TBCintaEliminar.TabIndex = 52;
            TBCintaEliminar.KeyDown += TBCintaEliminar_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14F);
            label8.Location = new Point(709, 537);
            label8.Name = "label8";
            label8.Size = new Size(212, 26);
            label8.TabIndex = 53;
            label8.Text = "Buscar Cinta a Eliminar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 27);
            label7.Name = "label7";
            label7.Size = new Size(313, 29);
            label7.TabIndex = 54;
            label7.Text = "Modificar Contenedor / Cintas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 456);
            label9.Name = "label9";
            label9.Size = new Size(74, 23);
            label9.TabIndex = 55;
            label9.Text = "Opcional";
            label9.Click += label9_Click;
            // 
            // InterfazVerCintasAlmacenadasP2
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 182, 196);
            ClientSize = new Size(976, 678);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(TBCintaEliminar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregarCinta);
            Controls.Add(TBAgregarCinta);
            Controls.Add(CBListaContenedores);
            Controls.Add(btnCrearContenedor);
            Controls.Add(TBCrearContenedor);
            Controls.Add(DTPCrearContenedor);
            Controls.Add(btnEliminarContenedorSeleccionado);
            Controls.Add(CBListaContenedoresEliminar);
            Controls.Add(CLBListaCintasEliminar);
            Controls.Add(btnEliminarCintaSeleccionada);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazVerCintasAlmacenadasP2";
            Text = "InterfazVerCintasAlmacenadasP2";
            Load += InterfazVerCintasAlmacenadasP2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAgregarCinta;
        private TextBox TBAgregarCinta;
        private ComboBox CBListaContenedores;
        private Button btnCrearContenedor;
        private TextBox TBCrearContenedor;
        private DateTimePicker DTPCrearContenedor;
        private Button btnEliminarContenedorSeleccionado;
        private ComboBox CBListaContenedoresEliminar;
        private CheckedListBox CLBListaCintasEliminar;
        private Button btnEliminarCintaSeleccionada;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TBCintaEliminar;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}