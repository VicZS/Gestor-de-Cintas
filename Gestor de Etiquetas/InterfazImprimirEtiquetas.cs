using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Printing;
using System.Runtime.InteropServices;  

namespace Gestor_de_Etiquetas
{
    public partial class InterfazImprimirEtiquetas : Form
    {
        public InterfazImprimirEtiquetas()
        {
            InitializeComponent();
        }

        private void ReimprimirEtiqueta_Click(object sender, EventArgs e)
        {
            string etiqueta = etiquetaReimprimir.Text;
            if (string.IsNullOrEmpty(etiqueta))
            {
                MessageBox.Show("Por favor, ingrese un número de etiqueta.");
                return;
            }

            if (etiqueta.Length < 8)
            {
                MessageBox.Show("La etiqueta debe tener al menos 8 caracteres");
                return;
            }

            imprimir(etiquetaReimprimir.Text);

        }

        private void etiquetaReimprimir_TextChanged(object sender, EventArgs e)
        {

        }

        private void imprimir(string contenidoEtiqueta)
        {
            string printerName = "ZDesigner ZT411-203dpi ZPL"; // Cambia esto por el nombre de tu impresora
            string zpl = $@"
        ^XA
        ^LL152
        ^PW609
        ^FO80,15^B3N,N,70,N^FD{contenidoEtiqueta}^FS
        ^FO250,90^A0N,30,40^FD{contenidoEtiqueta}^FS
        ^PQ2
        ^XZ";

            // ^XA: Inicia el comando ZPL.
            // ^LL152: Define la longitud de la etiqueta en puntos (152 puntos).
            // ^PW457: Establece el ancho de la etiqueta en puntos (457 puntos).
            // ^FO20,30: Establece la posición inicial del campo (20 puntos desde la izquierda, 30 puntos desde la parte superior).
            // ^A0N,50,50: Define la fuente (A0), orientación normal (N), altura de 50 puntos y ancho de 50 puntos.
            // ^FD{contenidoEtiqueta}: Especifica el contenido del texto que se imprimirá en la etiqueta.
            // ^FS: Finaliza el campo actual.
            // ^PQ3: Indica que se imprimirán 3 copias de la etiqueta.
            // ^XZ: Finaliza el comando ZPL.


            //MessageBox.Show(zpl);

            bool success = ZebraPrinter.SendZplToPrinter(printerName, zpl);
            if (success)
            {
                MessageBox.Show("Etiqueta Enviada a la Impresora Correctamente.");
            }
            else
            {
                MessageBox.Show("Error al Enviar la Etiqueta a la Impresora.");
            }
        }

        private void btnImprimirEtiquetaSiguiente_Click(object sender, EventArgs e)
        {

        }
    }

    public class ZebraPrinter
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool OpenPrinter(string pPrinterName, out IntPtr phPrinter, IntPtr pDefault);

        [DllImport("winspool.drv", SetLastError = true)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", SetLastError = true)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int level, ref DOCINFOA pDocInfo);

        [DllImport("winspool.drv", SetLastError = true)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", SetLastError = true)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", SetLastError = true)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", SetLastError = true)]
        public static extern bool WritePrinter(IntPtr hPrinter, string data, int buf, out int pcWritten);

        [StructLayout(LayoutKind.Sequential)]
        public struct DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }

        public static bool SendZplToPrinter(string printerName, string zplCommand)
        {
            IntPtr hPrinter;
            DOCINFOA di = new DOCINFOA();
            di.pDocName = "Etiqueta ZPL";
            di.pDataType = "RAW";

            if (OpenPrinter(printerName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                if (StartDocPrinter(hPrinter, 1, ref di))
                {
                    StartPagePrinter(hPrinter);
                    WritePrinter(hPrinter, zplCommand, zplCommand.Length, out int _);
                    EndPagePrinter(hPrinter);
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
                return true;
            }
            return false;
        }
    }

}
