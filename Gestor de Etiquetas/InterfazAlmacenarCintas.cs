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
        string ContenedorResguardo = "Resguardo";
        string ContenedorEnUso = "EnUso";
        public InterfazAlmacenarCintas()
        {
            InitializeComponent();
            ActualizarCBListaContenedores();
            ActualizarCBCintasEnUso();
            gestor.CrearContenedor(ContenedorResguardo);
            gestor.CrearContenedor(ContenedorEnUso);
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
                    string idContenedor = codigoEscaneado.Text;
                    DateTime fechaHoy = DateTime.Now.Date;

                    // Verifica si el contenedor ya fue creado HOY
                    var contenedoresHoy = gestor.ObtenerContenedoresPorFecha(fechaHoy);
                    var contenedorExistenteHoy = contenedoresHoy.FirstOrDefault(c => c.Id == idContenedor);

                    if (contenedorExistenteHoy != null)
                    {
                        // Ya fue creado hoy
                        ActualizarCBListaContenedores();
                        ActualizarCBCintasEnUso();
                        CBListaContenedores.SelectedItem = idContenedor;
                        LContenedor.Text = "Contenedor: " + idContenedor;
                        MessageBox.Show("El contenedor ya fue creado hoy.");
                        codigoEscaneado.Clear();
                        return;
                    }

                    // Verifica si el contenedor existe en otra fecha
                    var todosLosContenedores = gestor.ObtenerTodosLosContenedores(); // Puedes agregar esta función auxiliar si no existe
                    var contenedorExistente = todosLosContenedores.FirstOrDefault(c => c.Id == idContenedor);

                    if (contenedorExistente != null)
                    {
                        // Ya existe, pero en otra fecha
                        MessageBox.Show("El contenedor ya existe, pero fue creado en otra fecha.");
                        codigoEscaneado.Clear();
                        return;
                    }

                    // No existe → Crear nuevo contenedor
                    if (gestor.CrearContenedor(idContenedor, fechaHoy))
                    {
                        ActualizarCBListaContenedores();
                        ActualizarCBCintasEnUso();
                        CBListaContenedores.SelectedItem = idContenedor;
                        LContenedor.Text = "Contenedor: " + idContenedor;
                        //MessageBox.Show("Contenedor creado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al crear el contenedor.");
                    }

                    codigoEscaneado.Clear();
                    return;
                }


                if (codigoEscaneado.Text.StartsWith("PUE"))
                {
                    if (string.IsNullOrWhiteSpace(CBListaContenedores.Text))
                    {
                        MessageBox.Show("Por favor, seleccione un contenedor.");
                        codigoEscaneado.Clear();
                        return;
                    }

                    if (gestor.ObtenerContenedorDeCinta(codigoEscaneado.Text) == null)
                    {
                        MessageBox.Show("La cinta escaneada no existe en el sistema.");
                        codigoEscaneado.Clear();
                        return;
                    }


                    if (gestor.ObtenerContenedorDeCinta(codigoEscaneado.Text).Id.ToString() == "Resguardo" || gestor.ObtenerContenedorDeCinta(codigoEscaneado.Text).Id.ToString() == "EnUso")
                    {
                        gestor.EliminarCinta(codigoEscaneado.Text);
                        gestor.AgregarCintaAContenedor(CBListaContenedores.Text, codigoEscaneado.Text, null);
                        ActualizarCBListaCintas(CBListaContenedores.Text);
                        ActualizarCBCintasEnUso();
                    }
                    else
                    {
                        var contenedor = gestor.ObtenerContenedorDeCinta(codigoEscaneado.Text);
                        if (contenedor != null)
                        {
                            MessageBox.Show("La cinta ya fue escaneada y se encuentra en el contenedor: " + contenedor.Id);
                        }
                        else
                        {
                            MessageBox.Show("La cinta ya fue escaneada, pero no se encontró su contenedor.");
                        }
                    }

                    codigoEscaneado.Clear();
                    return;
                }

                MessageBox.Show("El código escaneado no es válido.");
                codigoEscaneado.Clear();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CLBListaCintas_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void ActualizarCBListaContenedores()
        {
            CBListaContenedores.Items.Clear();

            foreach (var cont in gestor.ObtenerContenedoresPorFecha(DateTime.Now))
            {
                CBListaContenedores.Items.Add(cont.Id);
            }
        }

        private void CBListaContenedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBListaContenedores.SelectedItem == null)
            {
                return;
            }
            else
            {
                LContenedor.Text = "Contenedor: " + CBListaContenedores.Text;
                ActualizarCBListaCintas(CBListaContenedores.Text);
            }
        }

        private void ActualizarCBListaCintas(string contenedor)
        {
            CLBListaCintas.Items.Clear();
            foreach (var cinta in gestor.ObtenerCintasDeContenedor(contenedor))
            {
                CLBListaCintas.Items.Add(cinta.Id);
            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            if (CLBListaCintas.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos una cinta para eliminar.");
                return;
            }

            // Obtener las cintas seleccionadas (marcadas)
            List<string> cintasSeleccionadas = CLBListaCintas.CheckedItems
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
                        gestor.AgregarCintaAContenedor("Resguardo", idCinta, null);
                    eliminadas++;
                }

                MessageBox.Show($"{eliminadas} cinta(s) eliminada(s) correctamente.");
                ActualizarCBListaCintas(CBListaContenedores.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TBResguardarCinta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(TBResguardarCinta.Text))
                {
                    MessageBox.Show("Por favor, escanee un código.");
                    return;
                }

                if (TBResguardarCinta.Text.Length < 8)
                {
                    MessageBox.Show("El código escaneado no cuenta con los caracteres suficientes");
                    return;
                }

                if (TBResguardarCinta.Text.StartsWith("PUE"))
                {

                    if (gestor.ObtenerContenedorDeCinta(TBResguardarCinta.Text) == null)
                    {
                        MessageBox.Show("La cinta escaneada no existe en el sistema.");
                        TBResguardarCinta.Clear();
                        return;
                    }


                    if (gestor.ObtenerContenedorDeCinta(TBResguardarCinta.Text).Id.ToString() == "EnUso")
                    {
                        gestor.EliminarCinta(TBResguardarCinta.Text);
                        gestor.AgregarCintaAContenedor("Resguardo", TBResguardarCinta.Text, null);
                        ActualizarCBCintasEnUso();

                    }
                    else
                    {
                        var contenedor = gestor.ObtenerContenedorDeCinta(TBResguardarCinta.Text);
                        if (contenedor != null)
                        {
                            MessageBox.Show("La cinta escaneada se encuentra en el contenedor: " + contenedor.Id);
                        }
                        else
                        {
                            MessageBox.Show("La cinta ya fue escaneada, pero no se encontró su contenedor.");
                        }
                    }

                    TBResguardarCinta.Clear();
                    return;
                }

                MessageBox.Show("El código escaneado no es válido.");
                codigoEscaneado.Clear();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ActualizarCBCintasEnUso()
        {
            CLBCintasEnUso.Items.Clear();
            foreach (var cinta in gestor.ObtenerCintasDeContenedor("EnUso"))
            {
                CLBCintasEnUso.Items.Add(cinta.Id);
            }
        }

        private void btnResguardarCinta_Click(object sender, EventArgs e)
        {
            if (CLBCintasEnUso.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos una cinta para resguardar.");
                return;
            }

            // Obtener las cintas seleccionadas (marcadas)
            List<string> cintasSeleccionadas = CLBCintasEnUso.CheckedItems
                .Cast<string>()
                .ToList();

            MessageBox.Show("Cintas seleccionadas: " + string.Join(", ", cintasSeleccionadas));

            // Crear mensaje de confirmación
            string mensaje = "¿Estás seguro que deseas resguardar las siguientes cintas?\n\n";
            mensaje += string.Join("\n", cintasSeleccionadas);

            DialogResult resultado = MessageBox.Show(
                mensaje,
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                int resguardadas = 0;

                foreach (string idCinta in cintasSeleccionadas)
                {
                    gestor.EliminarCinta(idCinta);
                    gestor.AgregarCintaAContenedor("Resguardo", idCinta, DateTime.Now);
                    ActualizarCBCintasEnUso();
                    resguardadas++;
                }

                MessageBox.Show($"{resguardadas} cinta(s) resguardada(s) correctamente.");
                ActualizarCBCintasEnUso();
            }


        }

        private void TBResguardarCinta_TextChanged(object sender, EventArgs e)
        {

        }

        private void CLBCintasEnUso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
