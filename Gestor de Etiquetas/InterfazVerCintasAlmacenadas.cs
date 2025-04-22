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

        private void btnGenerarExcelDia_Click(object sender, EventArgs e)
        {
            var result = gestor.ObtenerContenedoresPorFecha(DTPGenerarExelDia.Value);

            string nombreArchivo = "Reporte del dia " + DateTime.Now.ToString("yyyyMMdd");

            gestor.ExportarContenedoresAExcel(result, nombreArchivo);

            MessageBox.Show($"Reporte generado con éxito: {nombreArchivo}.xlsx");
        }

        private void btnGenerarExcelEntreDias_Click(object sender, EventArgs e)
        {
            var result = gestor.ObtenerContenedoresEntreFechas(DTPGenerarExelDiaInicio.Value, DTPGenerarExelDiaFin.Value);

            string nombreArchivo = "Reporte entre " + DTPGenerarExelDiaInicio.Value.ToString("yyyyMMdd") + " y " + DTPGenerarExelDiaFin.Value.ToString("yyyyMMdd");
            gestor.ExportarContenedoresAExcel(result, nombreArchivo);
            MessageBox.Show($"Reporte generado con éxito: {nombreArchivo}.xlsx");
        }
    }
}
