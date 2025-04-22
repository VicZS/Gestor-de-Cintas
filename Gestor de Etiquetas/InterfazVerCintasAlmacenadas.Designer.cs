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
            monthCalendar1 = new MonthCalendar();
            btnGenerarExcelEntreDias = new Button();
            DTPGenerarExelDiaFin = new DateTimePicker();
            DTPGenerarExelDiaInicio = new DateTimePicker();
            DTPGenerarExelDia = new DateTimePicker();
            btnGenerarExcelDia = new Button();
            TBCintaABuscar = new TextBox();
            btnBuscarCinta = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            fechaMostrarContenedores = new DateTimePicker();
            label6 = new Label();
            listaMostrarContenedoresDia = new ListView();
            panel4 = new Panel();
            panel6 = new Panel();
            label8 = new Label();
            listaContenedoresCintasReutilizables = new ListView();
            btnInfoContenedoresReutilizables = new Button();
            listaMostrarCintas = new ListView();
            label7 = new Label();
            contenedorMostrarCintas = new ComboBox();
            label9 = new Label();
            panel5 = new Panel();
            label10 = new Label();
            listaCintasUso = new ListView();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(1, 4);
            monthCalendar1.Location = new Point(11, 28);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowWeekNumbers = true;
            monthCalendar1.TabIndex = 0;
            // 
            // btnGenerarExcelEntreDias
            // 
            btnGenerarExcelEntreDias.Location = new Point(777, 631);
            btnGenerarExcelEntreDias.Name = "btnGenerarExcelEntreDias";
            btnGenerarExcelEntreDias.Size = new Size(96, 35);
            btnGenerarExcelEntreDias.TabIndex = 4;
            btnGenerarExcelEntreDias.Text = "Guardar";
            btnGenerarExcelEntreDias.UseVisualStyleBackColor = true;
            btnGenerarExcelEntreDias.Click += btnGenerarExcelEntreDias_Click;
            // 
            // DTPGenerarExelDiaFin
            // 
            DTPGenerarExelDiaFin.Location = new Point(663, 595);
            DTPGenerarExelDiaFin.Name = "DTPGenerarExelDiaFin";
            DTPGenerarExelDiaFin.Size = new Size(301, 30);
            DTPGenerarExelDiaFin.TabIndex = 5;
            // 
            // DTPGenerarExelDiaInicio
            // 
            DTPGenerarExelDiaInicio.Location = new Point(663, 537);
            DTPGenerarExelDiaInicio.Name = "DTPGenerarExelDiaInicio";
            DTPGenerarExelDiaInicio.Size = new Size(301, 30);
            DTPGenerarExelDiaInicio.TabIndex = 6;
            // 
            // DTPGenerarExelDia
            // 
            DTPGenerarExelDia.Location = new Point(328, 595);
            DTPGenerarExelDia.Name = "DTPGenerarExelDia";
            DTPGenerarExelDia.Size = new Size(297, 30);
            DTPGenerarExelDia.TabIndex = 7;
            // 
            // btnGenerarExcelDia
            // 
            btnGenerarExcelDia.Location = new Point(424, 631);
            btnGenerarExcelDia.Name = "btnGenerarExcelDia";
            btnGenerarExcelDia.Size = new Size(96, 35);
            btnGenerarExcelDia.TabIndex = 8;
            btnGenerarExcelDia.Text = "Guardar";
            btnGenerarExcelDia.UseVisualStyleBackColor = true;
            btnGenerarExcelDia.Click += btnGenerarExcelDia_Click;
            // 
            // TBCintaABuscar
            // 
            TBCintaABuscar.Location = new Point(462, 27);
            TBCintaABuscar.Name = "TBCintaABuscar";
            TBCintaABuscar.Size = new Size(233, 30);
            TBCintaABuscar.TabIndex = 9;
            // 
            // btnBuscarCinta
            // 
            btnBuscarCinta.Location = new Point(715, 24);
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
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 28);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 11;
            label1.Text = "Buscar Cinta";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 63, 96);
            panel1.Location = new Point(293, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(8, 682);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 63, 96);
            panel2.Location = new Point(296, 497);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 9);
            panel2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 569);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 14;
            label2.Text = "Del Dia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(665, 509);
            label3.Name = "label3";
            label3.Size = new Size(30, 23);
            label3.TabIndex = 15;
            label3.Text = "De";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(663, 569);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 16;
            label4.Text = "Hasta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(328, 511);
            label5.Name = "label5";
            label5.Size = new Size(196, 38);
            label5.TabIndex = 17;
            label5.Text = "Generar Excel";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(14, 63, 96);
            panel3.Location = new Point(299, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(679, 9);
            panel3.TabIndex = 14;
            // 
            // fechaMostrarContenedores
            // 
            fechaMostrarContenedores.Location = new Point(306, 140);
            fechaMostrarContenedores.Name = "fechaMostrarContenedores";
            fechaMostrarContenedores.Size = new Size(305, 30);
            fechaMostrarContenedores.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(307, 75);
            label6.Name = "label6";
            label6.Size = new Size(274, 26);
            label6.TabIndex = 26;
            label6.Text = "Mostrar Contenedores del Dia";
            // 
            // listaMostrarContenedoresDia
            // 
            listaMostrarContenedoresDia.Location = new Point(617, 78);
            listaMostrarContenedoresDia.Name = "listaMostrarContenedoresDia";
            listaMostrarContenedoresDia.Size = new Size(316, 95);
            listaMostrarContenedoresDia.TabIndex = 27;
            listaMostrarContenedoresDia.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(14, 63, 96);
            panel4.Location = new Point(299, 179);
            panel4.Name = "panel4";
            panel4.Size = new Size(679, 9);
            panel4.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(14, 63, 96);
            panel6.Location = new Point(299, 336);
            panel6.Name = "panel6";
            panel6.Size = new Size(679, 11);
            panel6.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(711, 350);
            label8.Name = "label8";
            label8.Size = new Size(230, 26);
            label8.TabIndex = 35;
            label8.Text = "Contenedores con Cintas ";
            // 
            // listaContenedoresCintasReutilizables
            // 
            listaContenedoresCintasReutilizables.Location = new Point(716, 418);
            listaContenedoresCintasReutilizables.Name = "listaContenedoresCintasReutilizables";
            listaContenedoresCintasReutilizables.Size = new Size(218, 73);
            listaContenedoresCintasReutilizables.TabIndex = 37;
            listaContenedoresCintasReutilizables.UseCompatibleStateImageBehavior = false;
            // 
            // btnInfoContenedoresReutilizables
            // 
            btnInfoContenedoresReutilizables.Location = new Point(949, 400);
            btnInfoContenedoresReutilizables.Name = "btnInfoContenedoresReutilizables";
            btnInfoContenedoresReutilizables.Size = new Size(26, 37);
            btnInfoContenedoresReutilizables.TabIndex = 38;
            btnInfoContenedoresReutilizables.Text = "?";
            btnInfoContenedoresReutilizables.UseVisualStyleBackColor = true;
            // 
            // listaMostrarCintas
            // 
            listaMostrarCintas.Location = new Point(617, 220);
            listaMostrarCintas.Name = "listaMostrarCintas";
            listaMostrarCintas.Size = new Size(316, 110);
            listaMostrarCintas.TabIndex = 39;
            listaMostrarCintas.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(307, 204);
            label7.Name = "label7";
            label7.Size = new Size(279, 26);
            label7.TabIndex = 40;
            label7.Text = "Mostrar Cintas del Contenedor";
            // 
            // contenedorMostrarCintas
            // 
            contenedorMostrarCintas.FormattingEnabled = true;
            contenedorMostrarCintas.Location = new Point(307, 299);
            contenedorMostrarCintas.Name = "contenedorMostrarCintas";
            contenedorMostrarCintas.Size = new Size(295, 31);
            contenedorMostrarCintas.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(764, 376);
            label9.Name = "label9";
            label9.Size = new Size(140, 26);
            label9.TabIndex = 42;
            label9.Text = "para Reutilizar";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(14, 63, 96);
            panel5.Location = new Point(661, 338);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 162);
            panel5.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(326, 359);
            label10.Name = "label10";
            label10.Size = new Size(255, 26);
            label10.TabIndex = 43;
            label10.Text = "Cintas en Caja Fuerte / Uso";
            // 
            // listaCintasUso
            // 
            listaCintasUso.Location = new Point(328, 388);
            listaCintasUso.Name = "listaCintasUso";
            listaCintasUso.Size = new Size(283, 97);
            listaCintasUso.TabIndex = 44;
            listaCintasUso.UseCompatibleStateImageBehavior = false;
            // 
            // InterfazVerCintasAlmacenadas
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 182, 196);
            ClientSize = new Size(976, 678);
            Controls.Add(listaCintasUso);
            Controls.Add(label10);
            Controls.Add(panel5);
            Controls.Add(label9);
            Controls.Add(contenedorMostrarCintas);
            Controls.Add(label7);
            Controls.Add(listaMostrarCintas);
            Controls.Add(panel6);
            Controls.Add(btnInfoContenedoresReutilizables);
            Controls.Add(listaContenedoresCintasReutilizables);
            Controls.Add(label8);
            Controls.Add(panel4);
            Controls.Add(listaMostrarContenedoresDia);
            Controls.Add(label6);
            Controls.Add(fechaMostrarContenedores);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnBuscarCinta);
            Controls.Add(TBCintaABuscar);
            Controls.Add(btnGenerarExcelDia);
            Controls.Add(DTPGenerarExelDia);
            Controls.Add(DTPGenerarExelDiaInicio);
            Controls.Add(DTPGenerarExelDiaFin);
            Controls.Add(btnGenerarExcelEntreDias);
            Controls.Add(monthCalendar1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazVerCintasAlmacenadas";
            Text = "InterfazVerCintasAlmacenadas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button btnGenerarExcelEntreDias;
        private DateTimePicker DTPGenerarExelDiaFin;
        private DateTimePicker DTPGenerarExelDiaInicio;
        private DateTimePicker DTPGenerarExelDia;
        private Button btnGenerarExcelDia;
        private TextBox TBCintaABuscar;
        private Button btnBuscarCinta;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Panel panel4;
        private DateTimePicker fechaMostrarContenedores;
        private Label label6;
        private ListView listaMostrarContenedoresDia;
        private Panel panel6;
        private Label label8;
        private ListView listaContenedoresCintasReutilizables;
        private Button btnInfoContenedoresReutilizables;
        private ListView listaMostrarCintas;
        private Label label7;
        private ComboBox contenedorMostrarCintas;
        private Label label9;
        private Panel panel5;
        private Label label10;
        private ListView listaCintasUso;
    }
}