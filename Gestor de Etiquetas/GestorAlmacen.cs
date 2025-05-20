using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;

using ClosedXML.Excel;
using System.IO;

namespace Gestor_de_Etiquetas
{
    public class Cinta
    {
        public string Id { get; set; }

        public Cinta() { }

        public Cinta(string id)
        {
            Id = id;
        }
    }

    public class Ajustes
    {
        public string NombreImpresora { get; set; }
        public int NumeroCopias { get; set; }

        public Ajustes()
        {
            NombreImpresora = "ZDesigner ZT411-203dpi ZPL";
            NumeroCopias = 3;
        }
    }

    public class Contenedor
    {
        public string Id { get; set; } // Puede ser null o un valor por defecto
        public DateTime? FechaCreacion { get; set; } // Ya permite null
        public List<Cinta> Cintas { get; set; } = new List<Cinta>(); // Se inicializa con una lista vacía

        public Contenedor() { }

        public Contenedor(string id, List<Cinta> cintas = null, DateTime? fechaCreacion = null)
        {
            Id = id;
            FechaCreacion = fechaCreacion;
            Cintas = cintas ?? new List<Cinta>(); // Asigna una lista vacía si no se pasa ninguna
        }
    }

    public class GestorAlmacen
    {
        private const string RutaBD = "BDCintas.json";

        private List<Contenedor> contenedores;

        public GestorAlmacen()
        {
            contenedores = CargarDatos();
        }

        private List<Contenedor> CargarDatos()
        {
            if (!File.Exists(RutaBD))
                return new List<Contenedor>();

            string json = File.ReadAllText(RutaBD);
            return JsonSerializer.Deserialize<List<Contenedor>>(json) ?? new List<Contenedor>();
        }

        private void GuardarDatos()
        {
            var json = JsonSerializer.Serialize(contenedores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(RutaBD, json);
        }

        private bool IdContenedorExiste(string id) => contenedores.Any(c => c.Id == id);
        private bool IdCintaExiste(string id) => contenedores.SelectMany(c => c.Cintas).Any(cinta => cinta.Id == id);

        // Crear contenedor
        public bool CrearContenedor(string id, DateTime? fechaCreacion = null)
        {
            if (IdContenedorExiste(id))
            {
                //MessageBox.Show($"El Contenedor '{id}' ya existe.");
                return false;
            }

            contenedores.Add(new Contenedor(id, fechaCreacion: fechaCreacion));
            GuardarDatos();
            //MessageBox.Show($"Contenedor '{id}' creado con éxito.");
            return true;
        }

        // Crear cinta
        public bool AgregarCintaAContenedor(string idContenedor, string idCinta)
        {
            if (IdCintaExiste(idCinta))
            {
                //MessageBox.Show($"La Cinta '{idCinta}' ya existe.");
                return false; // La cinta ya existe
            }

            var contenedor = contenedores.FirstOrDefault(c => c.Id == idContenedor);
            if (contenedor == null) return false;

            contenedor.Cintas.Add(new Cinta(idCinta));
            GuardarDatos();
            //MessageBox.Show($"Cinta '{idCinta}' agregada al contenedor '{idContenedor}' con éxito.");
            return true;
        }

        // Eliminar contenedor
        public bool EliminarContenedor(string id)
        {
            var contenedor = contenedores.FirstOrDefault(c => c.Id == id);
            if (contenedor == null) return false;

            contenedores.Remove(contenedor);
            GuardarDatos();
            return true;
        }

        // Eliminar cinta
        public bool EliminarCinta(string idCinta)
        {
            foreach (var cont in contenedores)
            {
                var cinta = cont.Cintas.FirstOrDefault(c => c.Id == idCinta);
                if (cinta != null)
                {
                    cont.Cintas.Remove(cinta);
                    GuardarDatos();
                    return true;
                }
            }
            return false;
        }

        // Actualizar ID contenedor
        public bool ModificarIdContenedor(string idActual, string nuevoId)
        {
            if (IdContenedorExiste(nuevoId)) return false;

            var cont = contenedores.FirstOrDefault(c => c.Id == idActual);
            if (cont == null) return false;

            cont.Id = nuevoId;
            GuardarDatos();
            return true;
        }

        // Actualizar fecha contenedor
        public bool ModificarFechaContenedor(string idContenedor, DateTime? nuevaFecha)
        {
            var cont = contenedores.FirstOrDefault(c => c.Id == idContenedor);
            if (cont == null) return false;

            cont.FechaCreacion = nuevaFecha;
            GuardarDatos();
            return true;
        }

        // Actualizar ID cinta
        public bool ModificarIdCinta(string idActual, string nuevoId)
        {
            if (IdCintaExiste(nuevoId)) return false;

            foreach (var cont in contenedores)
            {
                var cinta = cont.Cintas.FirstOrDefault(c => c.Id == idActual);
                if (cinta != null)
                {
                    cinta.Id = nuevoId;
                    GuardarDatos();
                    return true;
                }
            }
            return false;
        }

        // Obtener todas las cintas de un contenedor
        public List<Cinta> ObtenerCintasDeContenedor(string idContenedor)
        {
            var cont = contenedores.FirstOrDefault(c => c.Id == idContenedor);
            return cont?.Cintas ?? new List<Cinta>(); // Devuelve lista vacía si es null
        }

        // Obtener contenedor de una cinta
        public Contenedor ObtenerContenedorDeCinta(string idCinta)
        {
            return contenedores.FirstOrDefault(c => c.Cintas.Any(cinta => cinta.Id == idCinta)); // Devuelve null si no se encuentra
        }

        //Obtener contenedor de un dia en especifico
        public List<Contenedor> ObtenerContenedoresPorFecha(DateTime fecha)
        {
            return contenedores.Where(c =>
                c.FechaCreacion.HasValue &&
                c.FechaCreacion.Value.Date == fecha.Date
            ).ToList();
        }

        // Obtener contenedores entre fechas
        public List<Contenedor> ObtenerContenedoresEntreFechas(DateTime desde, DateTime hasta)
        {
            return contenedores
                .Where(c => c.FechaCreacion.HasValue && c.FechaCreacion.Value.Date >= desde.Date && c.FechaCreacion.Value.Date <= hasta.Date)
                .ToList(); // Lista vacía si no hay resultados
        }

        // Obtener contenedor creados hace mas de 90 dias
        public List<Contenedor> ObtenerContenedoresMayoresA90Dias()
        {
            DateTime fechaLimite = DateTime.Now.Date.AddDays(-90);
            return contenedores.Where(c =>
                c.FechaCreacion.HasValue &&
                c.FechaCreacion.Value.Date < fechaLimite
            ).ToList();
        }

        // Listar todos los contenedores
        public List<Contenedor> ObtenerTodosLosContenedores()
        {
            return contenedores ?? new List<Contenedor>(); // Lista vacía si contenedores es null
        }

        //Lista de todas las cintas
        public List<Cinta> ObtenerTodasLasCintas()
        {
            return contenedores.SelectMany(c => c.Cintas).ToList();
        }

        //Obtener siguiente cinta
        public string ObtenerSiguienteIdCinta()
        {
            var cintasExistentes = contenedores
                .SelectMany(c => c.Cintas)
                .Select(c => c.Id)
                .ToList();

            if (cintasExistentes.Count == 0)
                return "PUE000L6"; // primera cinta

            // Usamos expresión regular para separar prefijo, número y sufijo
            var idsValidados = cintasExistentes
                .Where(id => id.Length >= 8) // longitud mínima esperada
                .Select(id => new
                {
                    Original = id,
                    Prefijo = id.Substring(0, 3),
                    Numero = int.TryParse(id.Substring(3, 3), out var n) ? n : -1,
                    Sufijo = id.Substring(6)
                })
                .Where(x => x.Numero >= 0)
                .ToList();

            if (idsValidados.Count == 0)
                return "PUE000L6";

            var ultimo = idsValidados
                .OrderByDescending(x => x.Numero)
                .First();

            int siguienteNumero = ultimo.Numero + 1;
            string siguienteId = $"{ultimo.Prefijo}{siguienteNumero.ToString("D3")}{ultimo.Sufijo}";
            return siguienteId;
        }

        //Obtener fecha de creación de un contenedor por ID
        public DateTime? ObtenerFechaCreacionContenedorPorId(string idContenedor)
        {
            var contenedor = contenedores.FirstOrDefault(c => c.Id == idContenedor);
            return contenedor?.FechaCreacion;
        }

        //Crear Excel
        public void ExportarContenedoresAExcel(List<Contenedor> contenedores, string nombreArchivo)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaReportes = Path.Combine(escritorio, "Reportes");

            if (!Directory.Exists(rutaReportes))
                Directory.CreateDirectory(rutaReportes);

            string rutaCompleta = Path.Combine(rutaReportes, $"{nombreArchivo}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Contenedores");

                // Encabezado (opcional)
                ws.Cell(1, 1).Value = "ID Contenedor";
                ws.Cell(1, 2).Value = "Fecha de Creación";
                ws.Cell(1, 3).Value = "ID Cinta";

                int fila = 2;

                foreach (var cont in contenedores)
                {
                    int cantidadCintas = cont.Cintas.Count;
                    int inicioBloque = fila;

                    if (cantidadCintas == 0)
                    {
                        // Sin cintas: solo una fila
                        ws.Cell(fila, 1).Value = cont.Id;
                        ws.Cell(fila, 2).Value = cont.FechaCreacion?.ToString("dd-MM-yy") ?? "";
                        fila++;
                    }
                    else
                    {
                        // Escribir cintas en nuevas filas
                        foreach (var cinta in cont.Cintas)
                        {
                            ws.Cell(fila, 3).Value = cinta.Id;
                            fila++;
                        }

                        // Combinar celdas para contenedor y fecha
                        ws.Range(inicioBloque, 1, fila - 1, 1).Merge().Value = cont.Id;
                        ws.Range(inicioBloque, 2, fila - 1, 2).Merge().Value = cont.FechaCreacion?.ToString("dd-MM-yy") ?? "";

                        // Centrado vertical y horizontal
                        ws.Range(inicioBloque, 1, fila - 1, 2).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Range(inicioBloque, 1, fila - 1, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                        // Borde grueso alrededor del bloque del contenedor
                        ws.Range(inicioBloque, 1, fila - 1, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                    }

                    fila++; // Fila vacía entre contenedores
                }

                // Ajustar ancho automático
                ws.Columns().AdjustToContents();

                try
                {
                    workbook.SaveAs(rutaCompleta);
                }
                catch (IOException)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "No se puede guardar el archivo porque ya está abierto.\nPor favor, cierre el archivo y vuelva a intentarlo.",
                        "Error al guardar",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error
                    );

                    return;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(
                        $"Ocurrió un error inesperado:\n{ex.Message}",
                        "Error",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error
                    );
                }

                MessageBox.Show($"Reporte generado con éxito: {nombreArchivo}.xlsx");
            }
        }

        public void ExportarCintasDeContenedorAExcel(List<Cinta> cintas, string nombreContenedor)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaReportes = Path.Combine(escritorio, "Reportes");

            if (!Directory.Exists(rutaReportes))
                Directory.CreateDirectory(rutaReportes);

            string rutaCompleta = Path.Combine(rutaReportes, $"Contenedor {nombreContenedor}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Cintas");

                ws.Cell(1, 1).Value = "ID Contenedor";
                ws.Cell(1, 2).Value = "Fecha de Creación";
                ws.Cell(1, 3).Value = "ID Cinta";

                int fila = 2;
                int inicioBloque = fila;

                //var fechaCreacion = ObtenerFechaCreacionContenedorPorId(nombreContenedor);
                if (cintas.Count == 0)
                {
                    // Sin cintas: solo una fila
                    ws.Cell(fila, 1).Value = nombreContenedor;
                    ws.Cell(fila, 2).Value = ObtenerFechaCreacionContenedorPorId(nombreContenedor)?.ToString("dd-MM-yy") ?? "";
                    fila++;
                }
                else
                {
                    foreach (var cinta in cintas)
                    {
                        ws.Cell(fila, 3).Value = cinta.Id;
                        fila++;
                    }

                    // Combinar celdas para contenedor y fecha
                    ws.Range(inicioBloque, 1, fila - 1, 1).Merge().Value = nombreContenedor;
                    ws.Range(inicioBloque, 2, fila - 1, 2).Merge().Value = ObtenerFechaCreacionContenedorPorId(nombreContenedor)?.ToString("dd-MM-yy") ?? "";

                    // Centrado vertical y horizontal
                    ws.Range(inicioBloque, 1, fila - 1, 2).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Range(inicioBloque, 1, fila - 1, 2).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Borde grueso alrededor del bloque del contenedor
                    ws.Range(inicioBloque, 1, fila - 1, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                }
                fila++; // Fila vacía entre contenedores

                try
                {
                    ws.Columns().AdjustToContents();
                    workbook.SaveAs(rutaCompleta);
                }
                catch (IOException)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "No se puede guardar el archivo porque ya está abierto.\nPor favor, cierre el archivo y vuelva a intentarlo.",
                        "Error al guardar",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error
                    );

                    return;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(
                        $"Ocurrió un error inesperado:\n{ex.Message}",
                        "Error",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error
                    );
                }

                MessageBox.Show($"Reporte generado con éxito: Contenedor {nombreContenedor}.xlsx");
            }
        }

    }

    public class GestorAjustes
    {
        private const string RutaAjustes = "Ajustes.json";

        // Carga los ajustes desde el archivo, o crea valores por defecto si no existe
        private static Ajustes CargarDesdeArchivo()
        {
            if (!File.Exists(RutaAjustes))
            {
                var ajustesPorDefecto = new Ajustes();
                GuardarEnArchivo(ajustesPorDefecto);
                return ajustesPorDefecto;
            }

            string json = File.ReadAllText(RutaAjustes);
            return JsonSerializer.Deserialize<Ajustes>(json);
        }

        // Guarda los ajustes en el archivo
        private static void GuardarEnArchivo(Ajustes ajustes)
        {
            string json = JsonSerializer.Serialize(ajustes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(RutaAjustes, json);
        }

        // Obtener nombre de impresora
        public static string ObtenerNombreImpresora()
        {
            return CargarDesdeArchivo().NombreImpresora;
        }

        // Cambiar nombre de impresora
        public static void CambiarNombreImpresora(string nuevoNombre)
        {
            var ajustes = CargarDesdeArchivo();
            ajustes.NombreImpresora = nuevoNombre;
            GuardarEnArchivo(ajustes);
        }

        // Obtener número de copias
        public static int ObtenerNumeroCopias()
        {
            return CargarDesdeArchivo().NumeroCopias;
        }

        // Cambiar número de copias
        public static void CambiarNumeroCopias(int nuevoNumero)
        {
            var ajustes = CargarDesdeArchivo();
            ajustes.NumeroCopias = nuevoNumero;
            GuardarEnArchivo(ajustes);
        }

    }

}
