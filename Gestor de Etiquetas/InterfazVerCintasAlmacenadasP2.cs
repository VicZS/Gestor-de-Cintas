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
    public partial class InterfazVerCintasAlmacenadasP2 : Form
    {
        GestorAlmacen gestor = new GestorAlmacen();
        public InterfazVerCintasAlmacenadasP2()
        {
            InitializeComponent();
            CargarContenedoresEnComboBox();
            ActualizarCBListaContenedoresEliminar();
            ActualizarCLBListaCintasEliminar();
        }

        private void InterfazVerCintasAlmacenadasP2_Load(object sender, EventArgs e)
        {

        }


        private void btnCrearContenedor_Click(object sender, EventArgs e)
        {
            string nombreNuevoContenedor = TBCrearContenedor.Text;
            DateTime fechaCreacion = DTPCrearContenedor.Value;

            if (string.IsNullOrWhiteSpace(nombreNuevoContenedor))
            {
                MessageBox.Show("El nombre del contenedor no puede estar vacío.");
                return;
            }

            if (nombreNuevoContenedor.Length < 8)
            {
                MessageBox.Show("El nombre del contenedor no cuenta con los caracteres suficientes");
                return;
            }

            if (nombreNuevoContenedor.StartsWith("T"))
            {
               
                var todosLosContenedores = gestor.ObtenerTodosLosContenedores(); 
                var contenedorExistente = todosLosContenedores.FirstOrDefault(c => c.Id == nombreNuevoContenedor);

                if (contenedorExistente != null)
                {
             
                    MessageBox.Show("El contenedor ya existe");
                    TBCrearContenedor.Clear();
                    return;
                }

                // No existe → Crear nuevo contenedor
                if (gestor.CrearContenedor(nombreNuevoContenedor, fechaCreacion))
                {
                    ActualizarCBListaContenedoresEliminar();
                    ActualizarCLBListaCintasEliminar();
                    CargarContenedoresEnComboBox();
                    TBCrearContenedor.Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Error al crear el contenedor.");
                }
                
            }

            TBCrearContenedor.Clear();
            MessageBox.Show("El codigo del contenedor no es válido.");
            return;

        }

        private void label9_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnAgregarCinta_Click(object sender, EventArgs e)
        {
            string nombreContenedorDondeSeAgregara = CBListaContenedores.Text;
            string nombreCinta = TBAgregarCinta.Text;

            if (string.IsNullOrWhiteSpace(nombreContenedorDondeSeAgregara) || string.IsNullOrWhiteSpace(nombreCinta))
            {
                MessageBox.Show("Por favor, selecciona un contenedor y/o ingresa un ID de cinta.");
                return;
            }

            if (TBAgregarCinta.Text.StartsWith("PUE"))
            {

                if (gestor.ObtenerContenedorDeCinta(TBAgregarCinta.Text) == null)
                {
                    MessageBox.Show("La cinta no se encuentra en ningún contenedor, se agregará al contenedor seleccionado.");

                    gestor.AgregarCintaAContenedor(CBListaContenedores.Text, TBAgregarCinta.Text);
                    ActualizarCBListaContenedoresEliminar();
                    ActualizarCLBListaCintasEliminar();
                    CargarContenedoresEnComboBox();
                    
                    TBAgregarCinta.Clear();
                    return;
                }
                else
                {
                    string contenedorActual = gestor.ObtenerContenedorDeCinta(TBAgregarCinta.Text).Id;
                    string mensaje = "¿Estás seguro que deseas mover la cinta de contenedor?\n Contenedor actual: ";
                    mensaje += string.Join("\n", contenedorActual.ToString());

                    DialogResult resultado = MessageBox.Show(
                        mensaje,
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        MessageBox.Show("La cinta se moverá al contenedor seleccionado.");
                        gestor.AgregarCintaAContenedor(CBListaContenedores.Text, TBAgregarCinta.Text);
                        ActualizarCBListaContenedoresEliminar();
                        ActualizarCLBListaCintasEliminar();
                        CargarContenedoresEnComboBox();

                        TBAgregarCinta.Clear();
                        return;
                    }

                }

                TBAgregarCinta.Clear();
                return;
            }

            MessageBox.Show("El codigo de la cinta no es válido.");
            return;

        }

        private void CargarContenedoresEnComboBox()
        {
            CBListaContenedores.Items.Clear();
            foreach (var cont in gestor.ObtenerTodosLosContenedores())
            {
                CBListaContenedores.Items.Add(cont.Id);
            }
        }

        private void CBListaContenedoresEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActualizarCBListaContenedoresEliminar()
        {
            CBListaContenedoresEliminar.Items.Clear();
            foreach (var cont in gestor.ObtenerTodosLosContenedores())
            {
                if (cont.Id != "EnUso" && cont.Id != "Resguardo")
                    CBListaContenedoresEliminar.Items.Add(cont.Id);
            }
        }
        private void ActualizarCLBListaCintasEliminar()
        {
            CLBListaCintasEliminar.Items.Clear();

            foreach (var cinta in gestor.ObtenerTodasLasCintas())
            {
                CLBListaCintasEliminar.Items.Add(cinta.Id);
            }

        }

        private void btnEliminarContenedorSeleccionado_Click(object sender, EventArgs e)
        {

            // Crear mensaje de confirmación
            string mensaje = "¿Estás seguro que deseas eliminar el siguiente contenedor? \n\n";
            mensaje += string.Join("\n", CBListaContenedoresEliminar.Text);

            DialogResult resultado = MessageBox.Show(
                mensaje,
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                gestor.EliminarContenedor(CBListaContenedoresEliminar.Text);
                ActualizarCBListaContenedoresEliminar();
                ActualizarCLBListaCintasEliminar();
                CargarContenedoresEnComboBox();
            }

        }

        private void btnEliminarCintaSeleccionada_Click(object sender, EventArgs e)
        {


            if (CLBListaCintasEliminar.CheckedItems.Count == 0 && TBCintaEliminar.Text == "")
            {
                MessageBox.Show("Por favor, selecciona al menos una cinta o buscar una cinta para eliminarla.");
                return;
            }

            if (CLBListaCintasEliminar.CheckedItems.Count > 0)
            {
                // Obtener las cintas seleccionadas (marcadas)
                List<string> cintasSeleccionadas = CLBListaCintasEliminar.CheckedItems
                    .Cast<string>()
                    .ToList();

                MessageBox.Show("Cintas seleccionadas: " + string.Join(", ", cintasSeleccionadas));

                // Crear mensaje de confirmación
                string mensaje = "¿Estás seguro que deseas eliminar las siguientes cintas?\n\n";
                mensaje += string.Join("\n", cintasSeleccionadas);

                DialogResult resultado = MessageBox.Show(
                    mensaje,
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    int eliminadas = 0;

                    foreach (string idCinta in cintasSeleccionadas)
                    {
                        if (gestor.EliminarCinta(idCinta))
                            eliminadas++;
                    }

                    MessageBox.Show($"{eliminadas} cinta(s) eliminada(s) correctamente.");
                    ActualizarCBListaContenedoresEliminar();
                    ActualizarCLBListaCintasEliminar();
                    CargarContenedoresEnComboBox();

                }
                return;
            }






        }

        private void TBCintaEliminar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(TBCintaEliminar.Text))
                {
                    MessageBox.Show("Por favor, escanee un código.");
                    return;
                }

                if (TBCintaEliminar.Text.Length < 8)
                {
                    MessageBox.Show("El código escaneado no cuenta con los caracteres suficientes");
                    return;
                }

                if (TBCintaEliminar.Text.StartsWith("PUE"))
                {

                    string mensaje = "¿Estás seguro que deseas eliminar las siguientes cintas?\n\n";
                    mensaje += string.Join("\n", TBCintaEliminar.Text);

                    DialogResult resultado = MessageBox.Show(
                        mensaje,
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {

                        gestor.EliminarCinta(TBCintaEliminar.Text);
                        MessageBox.Show($"Cinta eliminada correctamente.");
                        ActualizarCBListaContenedoresEliminar();
                        ActualizarCLBListaCintasEliminar();
                        CargarContenedoresEnComboBox();

                    }
                   

                    TBCintaEliminar.Clear();
                    return;
                }

                MessageBox.Show("El código escaneado no es válido.");
                TBCintaEliminar.Clear();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
