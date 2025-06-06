using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gestor_de_Etiquetas;

namespace Gestor_de_Etiquetas
{
    public partial class InterfazVerCintasAlmacenadas : Form
    {
        GestorAlmacen gestor = new GestorAlmacen();
        public InterfazVerCintasAlmacenadas()
        {
            InitializeComponent();
            ActualizarLVListaCisntasAlmacenLocal();
            ActualizarLVListaCintasEnUso();
            ActualizarLVListaContenedoresConCintasReutilizar();
            ActualizarCBContenedorCintasAMostrar();
            ActualizarLVListaTodosContenedores();

            CargarFechasValidas();
        }

        private List<DateTime> fechasValidas;

        private void CargarFechasValidas()
        {
            // Obtener las fechas válidas de los contenedores
            fechasValidas = gestor.ObtenerTodosLosContenedores()
                .Where(c => c.FechaCreacion.HasValue)
                .Select(c => c.FechaCreacion.Value.Date)
                .Distinct()
                .OrderBy(f => f) // Opcional: para ordenarlas cronológicamente
                .ToList();

            // Limpiar el ListView antes de cargar nuevas fechas
            LVListaFechaContenedoresDisponibles.Items.Clear();

            // Agregar cada fecha al ListView con el formato dd/MM/yyyy
            foreach (var fecha in fechasValidas)
            {
                LVListaFechaContenedoresDisponibles.Items.Add(fecha.ToString("dd/MM/yyyy"));
            }
        }


        private void btnBuscarCinta_Click(object sender, EventArgs e)
        {
            string cintaABuscar = TBCintaABuscar.Text;

            var contenedor = gestor.ObtenerContenedorDeCinta(cintaABuscar);

            if (contenedor != null)
            {
                MessageBox.Show($"La cinta '{cintaABuscar}' se encuentra en el contenedor: {contenedor.Id}");
            }
            else
            {
                MessageBox.Show($"La cinta '{cintaABuscar}' no se encontró en ningún contenedor.");
            }
        }


        private void ActualizarLVListaCisntasAlmacenLocal()
        {
            LVListaCintasAlmacenLocal.Items.Clear();

            foreach (var cinta in gestor.ObtenerCintasDeContenedor("Resguardo"))
            {
                string aux = cinta.Id.ToString() + " " + cinta.FechaExtraccion?.ToString("dd/MM/yyyy");
                //MessageBox.Show(aux);
                LVListaCintasAlmacenLocal.Items.Add(aux);
            }
        }

        private void ActualizarLVListaCintasEnUso()
        {
            LVListaCintasEnUso.Items.Clear();
            foreach (var cinta in gestor.ObtenerCintasDeContenedor("EnUso"))
            {
                LVListaCintasEnUso.Items.Add(cinta.Id.ToString());
            }
        }

        private void ActualizarLVListaContenedoresConCintasReutilizar()
        {
            LVListaContenedoresConCintasReutilizar.Items.Clear();
            foreach (var contenedor in gestor.ObtenerContenedoresMayoresA90Dias())
            {
                LVListaContenedoresConCintasReutilizar.Items.Add(contenedor.Id.ToString());
            }
        }

        private void CBContenedorCintasAMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LVListaCintasContenedor.Items.Clear();
            foreach (var cinta in gestor.ObtenerCintasDeContenedor(CBContenedorCintasAMostrar.Text))
            {
                LVListaCintasContenedor.Items.Add(cinta.Id.ToString());
            }
        }


        private void ActualizarCBContenedorCintasAMostrar()
        {
            CBContenedorCintasAMostrar.Items.Clear();
            foreach (var contenedor in gestor.ObtenerTodosLosContenedores())
            {
                CBContenedorCintasAMostrar.Items.Add(contenedor.Id.ToString());
            }
        }

        private void ActualizarLVListaTodosContenedores()
        {
            LVListaTodosContenedores.Items.Clear();

            foreach (var contenedor in gestor.ObtenerTodosLosContenedores())
            {
                LVListaTodosContenedores.Items.Add(contenedor.Id.ToString());
            }
        }

        private void DTPMostrarContenedores_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DTPMostrarContenedores.Value.Date;

            LVListaContenedoresDelDia.Items.Clear();

            foreach (var contenedor in gestor.ObtenerTodosLosContenedores()
                .Where(c => c.FechaCreacion.HasValue && c.FechaCreacion.Value.Date == fechaSeleccionada))
            {
                LVListaContenedoresDelDia.Items.Add(contenedor.Id);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LVListaContenedoresConCintasReutilizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBContenedorCintasAMostrar.Text = LVListaContenedoresConCintasReutilizar.SelectedItems.Count > 0
                ? LVListaContenedoresConCintasReutilizar.SelectedItems[0].Text
                : string.Empty;
        }

        private void LVListaTodosContenedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBContenedorCintasAMostrar.Text = LVListaTodosContenedores.SelectedItems.Count > 0
                ? LVListaTodosContenedores.SelectedItems[0].Text
                : string.Empty;
        }

        private void LVListaContenedoresDelDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBContenedorCintasAMostrar.Text = LVListaContenedoresDelDia.SelectedItems.Count > 0
                ? LVListaContenedoresDelDia.SelectedItems[0].Text
                : string.Empty;
        }

        private void LVListaFechaContenedoresDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVListaFechaContenedoresDisponibles.SelectedItems.Count > 0)
            {
                string fechaTexto = LVListaFechaContenedoresDisponibles.SelectedItems[0].Text;

                if (DateTime.TryParseExact(fechaTexto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                {
                    DTPMostrarContenedores.Value = fecha;
                }
            }
        }
    }
}
