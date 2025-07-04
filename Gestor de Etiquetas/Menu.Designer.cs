﻿namespace Gestor_de_Etiquetas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            BarraMenu = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            PBAjustes = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            btnAbrirMenuReportes = new Button();
            btnEditarCintasAlmacenadas = new Button();
            btnVerCintasAlmacenadas = new Button();
            btnImprimirEtiquetas = new Button();
            btnAlmacenarCintas = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            BarraContenido = new Panel();
            BarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBAjustes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(705, 9);
            label1.Name = "label1";
            label1.Size = new Size(272, 45);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Cintas";
            // 
            // BarraMenu
            // 
            BarraMenu.BackColor = Color.FromArgb(77, 105, 129);
            BarraMenu.Controls.Add(panel4);
            BarraMenu.Controls.Add(panel2);
            BarraMenu.Controls.Add(PBAjustes);
            BarraMenu.Controls.Add(panel1);
            BarraMenu.Controls.Add(panel3);
            BarraMenu.Controls.Add(btnAbrirMenuReportes);
            BarraMenu.Controls.Add(btnEditarCintasAlmacenadas);
            BarraMenu.Controls.Add(btnVerCintasAlmacenadas);
            BarraMenu.Controls.Add(btnImprimirEtiquetas);
            BarraMenu.Controls.Add(btnAlmacenarCintas);
            BarraMenu.Controls.Add(label5);
            BarraMenu.Controls.Add(pictureBox1);
            BarraMenu.Dock = DockStyle.Left;
            BarraMenu.Location = new Point(0, 0);
            BarraMenu.Name = "BarraMenu";
            BarraMenu.Size = new Size(288, 678);
            BarraMenu.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(14, 63, 96);
            panel4.Location = new Point(138, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 399);
            panel4.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 63, 96);
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 10);
            panel2.TabIndex = 10;
            // 
            // PBAjustes
            // 
            PBAjustes.Image = (Image)resources.GetObject("PBAjustes.Image");
            PBAjustes.Location = new Point(217, 0);
            PBAjustes.Name = "PBAjustes";
            PBAjustes.Size = new Size(70, 70);
            PBAjustes.SizeMode = PictureBoxSizeMode.StretchImage;
            PBAjustes.TabIndex = 13;
            PBAjustes.TabStop = false;
            PBAjustes.Click += PBAjustes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 63, 96);
            panel1.Location = new Point(0, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 10);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(14, 63, 96);
            panel3.Location = new Point(-4, 302);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 10);
            panel3.TabIndex = 11;
            // 
            // btnAbrirMenuReportes
            // 
            btnAbrirMenuReportes.FlatAppearance.BorderSize = 0;
            btnAbrirMenuReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(14, 63, 96);
            btnAbrirMenuReportes.FlatStyle = FlatStyle.Flat;
            btnAbrirMenuReportes.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            btnAbrirMenuReportes.ForeColor = SystemColors.Control;
            btnAbrirMenuReportes.Image = (Image)resources.GetObject("btnAbrirMenuReportes.Image");
            btnAbrirMenuReportes.Location = new Point(140, 308);
            btnAbrirMenuReportes.Name = "btnAbrirMenuReportes";
            btnAbrirMenuReportes.Size = new Size(145, 200);
            btnAbrirMenuReportes.TabIndex = 12;
            btnAbrirMenuReportes.Text = "Generar Reporte";
            btnAbrirMenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAbrirMenuReportes.UseVisualStyleBackColor = true;
            btnAbrirMenuReportes.Click += btnAbrirMenuReportes_Click;
            // 
            // btnEditarCintasAlmacenadas
            // 
            btnEditarCintasAlmacenadas.FlatAppearance.BorderSize = 0;
            btnEditarCintasAlmacenadas.FlatAppearance.MouseOverBackColor = Color.FromArgb(14, 63, 96);
            btnEditarCintasAlmacenadas.FlatStyle = FlatStyle.Flat;
            btnEditarCintasAlmacenadas.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            btnEditarCintasAlmacenadas.ForeColor = SystemColors.Control;
            btnEditarCintasAlmacenadas.Image = Properties.Resources.almacen;
            btnEditarCintasAlmacenadas.Location = new Point(145, 105);
            btnEditarCintasAlmacenadas.Name = "btnEditarCintasAlmacenadas";
            btnEditarCintasAlmacenadas.Size = new Size(145, 200);
            btnEditarCintasAlmacenadas.TabIndex = 8;
            btnEditarCintasAlmacenadas.Text = "Editar Cintas Almacenadas";
            btnEditarCintasAlmacenadas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEditarCintasAlmacenadas.UseVisualStyleBackColor = true;
            btnEditarCintasAlmacenadas.Click += btnEditarCintasAlmacenadas_Click;
            // 
            // btnVerCintasAlmacenadas
            // 
            btnVerCintasAlmacenadas.FlatAppearance.BorderSize = 0;
            btnVerCintasAlmacenadas.FlatAppearance.MouseOverBackColor = Color.FromArgb(14, 63, 96);
            btnVerCintasAlmacenadas.FlatStyle = FlatStyle.Flat;
            btnVerCintasAlmacenadas.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerCintasAlmacenadas.ForeColor = SystemColors.Control;
            btnVerCintasAlmacenadas.Image = Properties.Resources.almacen;
            btnVerCintasAlmacenadas.ImageAlign = ContentAlignment.TopCenter;
            btnVerCintasAlmacenadas.Location = new Point(-4, 108);
            btnVerCintasAlmacenadas.Margin = new Padding(0);
            btnVerCintasAlmacenadas.Name = "btnVerCintasAlmacenadas";
            btnVerCintasAlmacenadas.RightToLeft = RightToLeft.No;
            btnVerCintasAlmacenadas.Size = new Size(145, 200);
            btnVerCintasAlmacenadas.TabIndex = 8;
            btnVerCintasAlmacenadas.Text = "Ver Cintas \nAlmacenadas";
            btnVerCintasAlmacenadas.TextAlign = ContentAlignment.BottomCenter;
            btnVerCintasAlmacenadas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerCintasAlmacenadas.UseVisualStyleBackColor = true;
            btnVerCintasAlmacenadas.Click += btnVerCintasAlmacenadas_Click;
            // 
            // btnImprimirEtiquetas
            // 
            btnImprimirEtiquetas.FlatAppearance.BorderSize = 0;
            btnImprimirEtiquetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(14, 63, 96);
            btnImprimirEtiquetas.FlatStyle = FlatStyle.Flat;
            btnImprimirEtiquetas.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            btnImprimirEtiquetas.ForeColor = SystemColors.ButtonFace;
            btnImprimirEtiquetas.Image = Properties.Resources.etiqueta;
            btnImprimirEtiquetas.Location = new Point(0, 506);
            btnImprimirEtiquetas.Name = "btnImprimirEtiquetas";
            btnImprimirEtiquetas.Size = new Size(288, 174);
            btnImprimirEtiquetas.TabIndex = 8;
            btnImprimirEtiquetas.Text = "Imprimir Etiquetas";
            btnImprimirEtiquetas.TextAlign = ContentAlignment.BottomCenter;
            btnImprimirEtiquetas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnImprimirEtiquetas.UseVisualStyleBackColor = true;
            btnImprimirEtiquetas.Click += btnImprimirEtiquetas_Click;
            // 
            // btnAlmacenarCintas
            // 
            btnAlmacenarCintas.FlatAppearance.BorderSize = 0;
            btnAlmacenarCintas.FlatAppearance.MouseOverBackColor = Color.FromArgb(14, 63, 96);
            btnAlmacenarCintas.FlatStyle = FlatStyle.Flat;
            btnAlmacenarCintas.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            btnAlmacenarCintas.ForeColor = SystemColors.ButtonFace;
            btnAlmacenarCintas.Image = Properties.Resources.delivery;
            btnAlmacenarCintas.Location = new Point(-1, 307);
            btnAlmacenarCintas.Name = "btnAlmacenarCintas";
            btnAlmacenarCintas.Size = new Size(145, 200);
            btnAlmacenarCintas.TabIndex = 7;
            btnAlmacenarCintas.Text = "Almacenar Cintas";
            btnAlmacenarCintas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAlmacenarCintas.UseVisualStyleBackColor = true;
            btnAlmacenarCintas.Click += btnAlmacenarCintas_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(87, 65);
            label5.Name = "label5";
            label5.Size = new Size(201, 32);
            label5.TabIndex = 5;
            label5.Text = "Gestor de Cintas";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // BarraContenido
            // 
            BarraContenido.BackColor = Color.FromArgb(216, 223, 231);
            BarraContenido.Dock = DockStyle.Fill;
            BarraContenido.Location = new Point(288, 0);
            BarraContenido.Name = "BarraContenido";
            BarraContenido.Size = new Size(976, 678);
            BarraContenido.TabIndex = 10;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 678);
            Controls.Add(BarraContenido);
            Controls.Add(BarraMenu);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de Cintas";
            BarraMenu.ResumeLayout(false);
            BarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBAjustes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Panel BarraMenu;
        private Panel BarraContenido;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnImprimirEtiquetas;
        private Button btnAlmacenarCintas;
        private Button btnVerCintasAlmacenadas;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnEditarCintasAlmacenadas;
        private Panel panel4;
        private Button btnAbrirMenuReportes;
        private PictureBox PBAjustes;
    }
}
