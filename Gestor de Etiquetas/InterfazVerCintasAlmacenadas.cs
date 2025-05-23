using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                LVListaCintasAlmacenLocal.Items.Add(cinta.Id.ToString());
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

        private void DTPMostrarContenedores_ValueChanged(object sender, EventArgs e)
        {
            LVListaContenedoresDelDia.Items.Clear();
            foreach (var contenedor in gestor.ObtenerContenedoresPorFecha(DTPMostrarContenedores.Value))
            {
                LVListaContenedoresDelDia.Items.Add(contenedor.Id.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
