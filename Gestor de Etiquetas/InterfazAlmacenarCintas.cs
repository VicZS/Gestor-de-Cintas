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
                MessageBox.Show("El código escaneado es: " + codigoEscaneado.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }




    }
}
