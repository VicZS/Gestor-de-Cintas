namespace Gestor_de_Etiquetas
{
    partial class InterfazAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazAyuda));
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(27, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(903, 556);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // InterfazAyuda
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(216, 223, 231);
            ClientSize = new Size(976, 678);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterfazAyuda";
            Text = "InterfazAyuda";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}