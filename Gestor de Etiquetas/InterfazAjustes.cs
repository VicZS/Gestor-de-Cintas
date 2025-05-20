using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_Etiquetas
{
    public partial class InterfazAjustes : Form
    {
        public InterfazAjustes()
        {
            InitializeComponent();
        }

        private void btnCrearBackup_Click(object sender, EventArgs e)
        {
            CrearBackup();
        }

        public void CrearBackup()
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string backupFolderPath = Path.Combine(desktopPath, "Backups");

                if (!Directory.Exists(backupFolderPath))
                {
                    Directory.CreateDirectory(backupFolderPath);
                }

                string originalFileName = "BDCintas.json";
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(originalFileName);
                string extension = Path.GetExtension(originalFileName);
                string datePart = DateTime.Now.ToString("yyyy-MM-dd");

                // Construye el nombre base con la fecha
                string baseFileName = $"{fileNameWithoutExt}_{datePart}";
                string destinationFilePath = Path.Combine(backupFolderPath, baseFileName + extension);

                // Si ya existe, agrega letras A, B, C...
                char suffix = 'A';
                while (File.Exists(destinationFilePath))
                {
                    destinationFilePath = Path.Combine(backupFolderPath, $"{baseFileName}_{suffix}{extension}");
                    suffix++;
                    if (suffix > 'Z') throw new Exception("Demasiados backups con el mismo nombre.");
                }

                File.Copy(originalFileName, destinationFilePath, true);
                MessageBox.Show($"Backup creado exitosamente: {Path.GetFileName(destinationFilePath)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el backup: " + ex.Message);
            }
        }

        private void btnCargarBackup_Click(object sender, EventArgs e)
        {
            if (LSeleccionaArchivo.Text == "Seleccionar Archivo...")
            {
                MessageBox.Show("Por favor, selecciona un archivo de backup.");
            }
            else
            {
                try
                {
                    string sourceFilePath = LSeleccionaArchivo.Text;
                    string destinationFilePath = "BDCintas.json";

                    File.Copy(sourceFilePath, destinationFilePath, true);
                    MessageBox.Show("Backup cargado exitosamente.");
                    LSeleccionaArchivo.Text = "Seleccionar Archivo...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el backup: " + ex.Message);
                }

            }
        }

        private void LSeleccionaArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos JSON (*.json)|*.json";
            openFileDialog1.Title = "Selecciona un archivo de backup";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LSeleccionaArchivo.Text = openFileDialog1.FileName;
            }
        }
    }
}
