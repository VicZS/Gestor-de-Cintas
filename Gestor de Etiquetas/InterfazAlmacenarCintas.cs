using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gestor_de_Etiquetas;

namespace Gestor_de_Etiquetas
{
    public partial class InterfazAlmacenarCintas : Form
    {
        GestorAlmacen gestor = new GestorAlmacen();
        public InterfazAlmacenarCintas()
        {
            InitializeComponent();
            ActualizarCBListaContenedores();
        }

        private void codigoEscaneado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(codigoEscaneado.Text))
                {
                    MessageBox.Show("Por favor, escanee un código.");
                    return;
                }

                if (codigoEscaneado.Text.Length < 8)
                {
                    MessageBox.Show("El código escaneado no cuenta con los caracteres suficientes");
                    return;
                }




                if (codigoEscaneado.Text.StartsWith("T"))
                {
                    MessageBox.Show("El código escaneado es una cinta: " + DateTime.Now.Date);

                    if (gestor.CrearContenedor(codigoEscaneado.Text, DateTime.Now.Date))
                    {
                        ActualizarCBListaContenedores();
                        CBListaContenedores.SelectedItem = codigoEscaneado.Text;
                        LContenedor.Text = "Contenedor: " + codigoEscaneado.Text;
                        //MessageBox.Show("Contenedor creado exitosamente");
                        codigoEscaneado.Clear();
                        return;
                    }

                    foreach (var cont in gestor.ObtenerContenedoresPorFecha(DateTime.Now))
                    {

                        if (cont.FechaCreacion.HasValue && cont.FechaCreacion.Value.Date == DateTime.Now.Date)
                        {
                            ActualizarCBListaContenedores();
                            CBListaContenedores.SelectedItem = codigoEscaneado.Text;
                            LContenedor.Text = "Contenedor: " + codigoEscaneado.Text;
                            //MessageBox.Show("El contenedor ya fue creado en la dia de hoy");
                            codigoEscaneado.Clear();
                            return;
                        }

                    }

                   
                    MessageBox.Show("El contenedor no es valido ya fue creado en otra fecha");

                    codigoEscaneado.Clear();
                }

                if (codigoEscaneado.Text.StartsWith("PUE"))
                {
                    //MessageBox.Show("El código escaneado es una cinta: " + codigoEscaneado.Text);
                    codigoEscaneado.Clear();
                }


                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CBListaCintas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarCBListaContenedores()
        {
            CBListaContenedores.Items.Clear();

            foreach(var cont in gestor.ObtenerContenedoresPorFecha(DateTime.Now))
            {
                CBListaContenedores.Items.Add(cont.Id);
            }
        }

       




    }
}
