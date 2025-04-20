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
    public partial class InterfazAlmacenarCintas : Form
    {
        public InterfazAlmacenarCintas()
        {
            InitializeComponent();
        }

        private void codigoEscaneado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(string.IsNullOrWhiteSpace(codigoEscaneado.Text))
                {
                    MessageBox.Show("Por favor, escanee un código.");
                    return;
                }

                if (codigoEscaneado.Text.Length < 8)
                {
                    MessageBox.Show("El código escaneado no cuenta con los caracteres suficientes");
                    return;
                }


                MessageBox.Show("El código escaneado es: " + codigoEscaneado.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }




    }
}
