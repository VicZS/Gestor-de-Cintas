namespace Gestor_de_Etiquetas
{
    partial class InterfazGenerarReporte
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnGenerarExcelDia = new Button();
            DTPGenerarExelDia = new DateTimePicker();
            DTPGenerarExelDiaInicio = new DateTimePicker();
            DTPGenerarExelDiaFin = new DateTimePicker();
            btnGenerarExcelEntreDias = new Button();
            btnGenerarExcelResguardo = new Button();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGenerarExcelEnUso = new Button();
            btnGenerarExceldelContenedor = new Button();
            CBListaContenedores = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 22);
            label5.Name = "label5";
            label5.Size = new Size(365, 40);
            label5.TabIndex = 26;
            label5.Text = "Generar Reporte de Excel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label4.Location = new Point(572, 165);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 25;
            label4.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label3.Location = new Point(574, 105);
            label3.Name = "label3";
            label3.Size = new Size(32, 23);
            label3.TabIndex = 24;
            label3.Text = "De";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label2.Location = new Point(40, 151);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 23;
            label2.Text = "Del Dia";
            // 
            // btnGenerarExcelDia
            // 
            btnGenerarExcelDia.Font = new Font("Segoe UI", 12.75F);
            btnGenerarExcelDia.Location = new Point(123, 227);
            btnGenerarExcelDia.Name = "btnGenerarExcelDia";
            btnGenerarExcelDia.Size = new Size(96, 35);
            btnGenerarExcelDia.TabIndex = 22;
            btnGenerarExcelDia.Text = "Guardar";
            btnGenerarExcelDia.UseVisualStyleBackColor = true;
            btnGenerarExcelDia.Click += btnGenerarExcelDia_Click;
            // 
            // DTPGenerarExelDia
            // 
            DTPGenerarExelDia.Font = new Font("Segoe UI", 12.75F);
            DTPGenerarExelDia.Location = new Point(40, 178);
            DTPGenerarExelDia.Name = "DTPGenerarExelDia";
            DTPGenerarExelDia.Size = new Size(297, 30);
            DTPGenerarExelDia.TabIndex = 21;
            // 
            // DTPGenerarExelDiaInicio
            // 
            DTPGenerarExelDiaInicio.Font = new Font("Segoe UI", 12.75F);
            DTPGenerarExelDiaInicio.Location = new Point(572, 133);
            DTPGenerarExelDiaInicio.Name = "DTPGenerarExelDiaInicio";
            DTPGenerarExelDiaInicio.Size = new Size(301, 30);
            DTPGenerarExelDiaInicio.TabIndex = 20;
            // 
            // DTPGenerarExelDiaFin
            // 
            DTPGenerarExelDiaFin.Font = new Font("Segoe UI", 12.75F);
            DTPGenerarExelDiaFin.Location = new Point(572, 191);
            DTPGenerarExelDiaFin.Name = "DTPGenerarExelDiaFin";
            DTPGenerarExelDiaFin.Size = new Size(301, 30);
            DTPGenerarExelDiaFin.TabIndex = 19;
            // 
            // btnGenerarExcelEntreDias
            // 
            btnGenerarExcelEntreDias.Font = new Font("Segoe UI", 12.75F);
            btnGenerarExcelEntreDias.Location = new Point(686, 227);
            btnGenerarExcelEntreDias.Name = "btnGenerarExcelEntreDias";
            btnGenerarExcelEntreDias.Size = new Size(96, 35);
            btnGenerarExcelEntreDias.TabIndex = 18;
            btnGenerarExcelEntreDias.Text = "Guardar";
            btnGenerarExcelEntreDias.UseVisualStyleBackColor = true;
            btnGenerarExcelEntreDias.Click += btnGenerarExcelEntreDias_Click;
            // 
            // btnGenerarExcelResguardo
            // 
            btnGenerarExcelResguardo.Font = new Font("Segoe UI", 12.75F);
            btnGenerarExcelResguardo.Location = new Point(72, 526);
            btnGenerarExcelResguardo.Name = "btnGenerarExcelResguardo";
            btnGenerarExcelResguardo.Size = new Size(96, 35);
            btnGenerarExcelResguardo.TabIndex = 27;
            btnGenerarExcelResguardo.Text = "Generar";
            btnGenerarExcelResguardo.UseVisualStyleBackColor = true;
            btnGenerarExcelResguardo.Click += btnGenerarExcelResguardo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label1.Location = new Point(40, 490);
            label1.Name = "label1";
            label1.Size = new Size(173, 23);
            label1.TabIndex = 28;
            label1.Text = "Cintas en Resguardo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label6.Location = new Point(396, 490);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 29;
            label6.Text = "Cintas en Uso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label7.Location = new Point(697, 490);
            label7.Name = "label7";
            label7.Size = new Size(188, 23);
            label7.TabIndex = 30;
            label7.Text = "Cintas del Contenedor";
            // 
            // btnGenerarExcelEnUso
            // 
            btnGenerarExcelEnUso.Font = new Font("Segoe UI", 12.75F);
            btnGenerarExcelEnUso.Location = new Point(407, 525);
            btnGenerarExcelEnUso.Name = "btnGenerarExcelEnUso";
            btnGenerarExcelEnUso.Size = new Size(96, 35);
            btnGenerarExcelEnUso.TabIndex = 31;
            btnGenerarExcelEnUso.Text = "Generar";
            btnGenerarExcelEnUso.UseVisualStyleBackColor = true;
            btnGenerarExcelEnUso.Click += btnGenerarExcelEnUso_Click;
            // 
            // btnGenerarExceldelContenedor
            // 
            btnGenerarExceldelContenedor.Font = new Font("Segoe UI", 12.75F);
            btnGenerarExceldelContenedor.Location = new Point(734, 566);
            btnGenerarExceldelContenedor.Name = "btnGenerarExceldelContenedor";
            btnGenerarExceldelContenedor.Size = new Size(96, 35);
            btnGenerarExceldelContenedor.TabIndex = 32;
            btnGenerarExceldelContenedor.Text = "Generar";
            btnGenerarExceldelContenedor.UseVisualStyleBackColor = true;
            btnGenerarExceldelContenedor.Click += btnGenerarExceldelContenedor_Click;
            // 
            // CBListaContenedores
            // 
            CBListaContenedores.AllowDrop = true;
            CBListaContenedores.DropDownStyle = ComboBoxStyle.DropDownList;
            CBListaContenedores.Font = new Font("Segoe UI", 12.75F);
            CBListaContenedores.FormattingEnabled = true;
            CBListaContenedores.Location = new Point(675, 528);
            CBListaContenedores.Name = "CBListaContenedores";
            CBListaContenedores.Size = new Size(234, 31);
            CBListaContenedores.TabIndex = 33;
            // 
            // InterfazGenerarReporte
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 223, 231);
            ClientSize = new Size(976, 678);
            Controls.Add(CBListaContenedores);
            Controls.Add(btnGenerarExceldelContenedor);
            Controls.Add(btnGenerarExcelEnUso);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btnGenerarExcelResguardo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGenerarExcelDia);
            Controls.Add(DTPGenerarExelDia);
            Controls.Add(DTPGenerarExelDiaInicio);
            Controls.Add(DTPGenerarExelDiaFin);
            Controls.Add(btnGenerarExcelEntreDias);
            Font = new Font("Comic Sans MS", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazGenerarReporte";
            Text = "InterfazGenerarReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnGenerarExcelDia;
        private DateTimePicker DTPGenerarExelDia;
        private DateTimePicker DTPGenerarExelDiaInicio;
        private DateTimePicker DTPGenerarExelDiaFin;
        private Button btnGenerarExcelEntreDias;
        private Button btnGenerarExcelResguardo;
        private Label label1;
        private Label label6;
        private Label label7;
        private Button btnGenerarExcelEnUso;
        private Button btnGenerarExceldelContenedor;
        private ComboBox CBListaContenedores;
    }
}