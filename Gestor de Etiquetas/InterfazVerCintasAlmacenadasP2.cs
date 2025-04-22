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

            try
            {
                gestor.CrearContenedor(nombreNuevoContenedor, fechaCreacion);
                //MessageBox.Show($"Contenedor '{nombreNuevoContenedor}' creado con éxito.");
                TBCrearContenedor.Clear();
                CargarContenedoresEnComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear contenedor: {ex.Message}");
            }

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
                MessageBox.Show("Por favor, selecciona un contenedor e ingresa un ID de cinta.");
                return;
            }

            try
            {
                gestor.AgregarCintaAContenedor(nombreContenedorDondeSeAgregara, nombreCinta);
               // MessageBox.Show("Cinta agregada con éxito.");
                TBAgregarCinta.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar cinta: {ex.Message}");
            }

        }

        private void CargarContenedoresEnComboBox()
        {
            CBListaContenedores.Items.Clear();
            foreach (var cont in gestor.ObtenerTodosLosContenedores())
            {
                CBListaContenedores.Items.Add(cont.Id);
            }
        }


    }
}
