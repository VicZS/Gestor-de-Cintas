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

namespace Gestor_de_Etiquetas
{
    public partial class InterfazGenerarReporte : Form
    {
        GestorAlmacen gestor = new GestorAlmacen();
        public InterfazGenerarReporte()
        {
            InitializeComponent();
            ActualizarCBListaContenedores();
        }

        private void btnGenerarExcelDia_Click(object sender, EventArgs e)
        {
            var result = gestor.ObtenerContenedoresPorFecha(DTPGenerarExelDia.Value);

            string nombreArchivo = "Reporte del dia " + DTPGenerarExelDia.Value.ToString("yyyyMMdd");

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

        private void btnGenerarExcelResguardo_Click(object sender, EventArgs e)
        {
            var result = gestor.ObtenerCintasDeContenedor("Resguardo");

            gestor.ExportarCintasDeContenedorAExcel(result, "Resguardo");

            MessageBox.Show($"Reporte generado con éxito");

        }

        private void btnGenerarReporteTodosContenedores_Click(object sender, EventArgs e)
        {
            var result = gestor.ObtenerTodosLosContenedores();

            gestor.ExportarContenedoresAExcel(result, "Todos los Contenedores");

        }

        private void btnGenerarExcelEnUso_Click(object sender, EventArgs e)
        {
            var result = gestor.ObtenerCintasDeContenedor("EnUso");

            gestor.ExportarCintasDeContenedorAExcel(result, "EnUso");

        }

        private void btnGenerarExceldelContenedor_Click(object sender, EventArgs e)
        {
            string nombreContenedor = CBListaContenedores.Text;
            if (string.IsNullOrEmpty(nombreContenedor))
            {
                MessageBox.Show("Por favor, seleccione un contenedor.");
                return;
            }

            var result = gestor.ObtenerCintasDeContenedor(nombreContenedor);

            gestor.ExportarCintasDeContenedorAExcel(result, nombreContenedor);

        }

        private void ActualizarCBListaContenedores()
        {
            CBListaContenedores.Items.Clear();

            foreach (var conetenedor in gestor.ObtenerTodosLosContenedores())
            {

                if (conetenedor.Id.ToString() != "Resguardo" && conetenedor.Id.ToString() != "EnUso")
                {
                    CBListaContenedores.Items.Add(conetenedor.Id.ToString());
                }
            }
        }

        
    }
}
