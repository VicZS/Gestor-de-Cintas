using System.Numerics;

namespace Gestor_de_Etiquetas
{
    public partial class Menu : Form
    {
        GestorAlmacen gestor = new GestorAlmacen();
        string ContenedorResguardo = "Resguardo";
        string ContenedorEnUso = "EnUso";
        public Menu()
        {
            InitializeComponent();
            gestor.CrearContenedor(ContenedorResguardo);
            gestor.CrearContenedor(ContenedorEnUso);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cerrarInterface();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cerrarInterface();
        }


        private void btnImprimirEtiquetas_Click(object sender, EventArgs e)
        {
            abrirInterface(new InterfazImprimirEtiquetas());

        }

        private void btnAlmacenarCintas_Click(object sender, EventArgs e)
        {
            abrirInterface(new InterfazAlmacenarCintas());

        }

        private void btnVerCintasAlmacenadas_Click(object sender, EventArgs e)
        {
            abrirInterface(new InterfazVerCintasAlmacenadas());

        }

        private void btnEditarCintasAlmacenadas_Click(object sender, EventArgs e)
        {
            abrirInterface(new InterfazVerCintasAlmacenadasP2());
        }



        private void abrirInterface(object formhija)
        {
            if (this.BarraContenido.Controls.Count > 0)
            {
                this.BarraContenido.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.BarraContenido.Controls.Add(fh);
            this.BarraContenido.Tag = fh;
            fh.Show();

        }

        private void cerrarInterface()
        {
            if (this.BarraContenido.Controls.Count > 0)
            {
                this.BarraContenido.Controls.RemoveAt(0);
            }

        }

        private void btnAbrirMenuReportes_Click(object sender, EventArgs e)
        {
            abrirInterface(new InterfazGenerarReporte());
        }

        private void PBAjustes_Click(object sender, EventArgs e)
        {
            abrirInterface(new InterfazAjustes());
        }
    }
}
