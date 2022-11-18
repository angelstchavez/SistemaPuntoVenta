using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using SpreadsheetLight;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelReporte : Form
    {
        public PanelReporte()
        {
            InitializeComponent();
            OcultarTaablasAuxiliares();
            CargarDatos();
        }

        #region IMPLEMENTACIONES
        //VentaImpl ventaImpl = new VentaImpl();
        //CategoriaImpl categoriaImpl = new CategoriaImpl();
        //ProductoImpl productoImpl = new ProductoImpl();
        //ServicioImpl servicioImpl = new ServicioImpl();
        //ClienteImpl clienteImpl = new ClienteImpl();
        //UsuarioImpl usuarioImpl = new UsuarioImpl();
        #endregion

        #region FUNCIONES
        private void OcultarTaablasAuxiliares()
        {
            DatosVentas.Visible = false;
            DatosCategorias.Visible = false;
            DatosProductos.Visible = false;
            DatosServicios.Visible = false;
            DatosClientes.Visible = false;
            DatosUsuarios.Visible = false;
        }
        private void CargarDatos()
        {
            //DatosVentas.DataSource = ventaImpl.ListarVentas();
            //DatosCategorias.DataSource = categoriaImpl.ListarCategorias();
            //DatosProductos.DataSource = productoImpl.ListarProductos();
            //DatosServicios.DataSource = servicioImpl.ListarServicios();
            //DatosClientes.DataSource = clienteImpl.ListarClientes();
            //DatosUsuarios.DataSource = usuarioImpl.ListarUsuarios();
            ValidarDatos();
        }
        private void ValidarDatos()
        {
            //if (ventaImpl.ListarVentas().Count <= 0)
            //{
            //    pnlVentas.Enabled = false;
            //    btnExlVentas.BackColor = Color.FromArgb(30, 30, 30);
            //    btnPdfVentas.BackColor = Color.FromArgb(30, 30, 30);
            //}
            //else
            //{
            //    pnlVentas.Enabled = true;
            //    btnExlVentas.BackColor = Color.FromArgb(12, 112, 47);
            //    btnPdfVentas.BackColor = Color.FromArgb(191, 33, 25);
            //}

            //if (categoriaImpl.ListarCategorias().Count <= 0)
            //{
            //    pnlCategorias.Enabled = false;
            //    btnExlCategorias.BackColor = Color.FromArgb(30, 30, 30);
            //    btnPdfCategorias.BackColor = Color.FromArgb(30, 30, 30);
            //}
            //else
            //{
            //    pnlCategorias.Enabled = true;
            //    btnExlCategorias.BackColor = Color.FromArgb(12, 112, 47);
            //    btnPdfCategorias.BackColor = Color.FromArgb(191, 33, 25);
            //}

            //if (productoImpl.ListarProductos().Count <= 0)
            //{
            //    pnlProductos.Enabled = false;
            //    btnExlProductos.BackColor = Color.FromArgb(30, 30, 30);
            //    btnPdfProductos.BackColor = Color.FromArgb(30, 30, 30);
            //}
            //else
            //{
            //    pnlProductos.Enabled = true;
            //    btnExlProductos.BackColor = Color.FromArgb(12, 112, 47);
            //    btnPdfProductos.BackColor = Color.FromArgb(191, 33, 25);
            //}

            //if (servicioImpl.ListarServicios().Count <= 0)
            //{
            //    pnlServicios.Enabled = false;
            //    btnExlServicios.BackColor = Color.FromArgb(30, 30, 30);
            //    btnPdfServicios.BackColor = Color.FromArgb(30, 30, 30);
            //}
            //else
            //{
            //    pnlServicios.Enabled = true;
            //    btnExlServicios.BackColor = Color.FromArgb(12, 112, 47);
            //    btnPdfServicios.BackColor = Color.FromArgb(191, 33, 25);
            //}

            //if (clienteImpl.ListarClientes().Count <= 0)
            //{
            //    pnlClientes.Enabled = false;
            //    btnExlClientes.BackColor = Color.FromArgb(30, 30, 30);
            //    btnPdfClientes.BackColor = Color.FromArgb(30, 30, 30);
            //}
            //else
            //{
            //    pnlClientes.Enabled = true;
            //    btnExlClientes.BackColor = Color.FromArgb(12, 112, 47);
            //    btnPdfClientes.BackColor = Color.FromArgb(191, 33, 25);
            //}

            //if (usuarioImpl.ListarUsuarios().Count <= 0)
            //{
            //    pnlUsuarios.Enabled = false;
            //    btnExlUsuarios.BackColor = Color.FromArgb(30, 30, 30);
            //    btnPdfUsuarios.BackColor = Color.FromArgb(30, 30, 30);
            //}
            //else
            //{
            //    pnlUsuarios.Enabled = true;
            //    pnlUsuarios.Enabled = false;
            //    btnExlUsuarios.BackColor = Color.FromArgb(12, 112, 47);
            //    btnPdfUsuarios.BackColor = Color.FromArgb(191, 33, 25);
            //}
        }
        private void ExportarCategorias_PDF()
        {
            //if (categoriaImpl.ListarCategorias().Count == 0)
            //{
            //    MessageBox.Show("No existen registros para exportar.", "Mensaje del sistema",
            //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    try
            //    {
            //        SaveFileDialog savefile = new SaveFileDialog();
            //        savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("CAT_" + "dd-MM-yyyy"));



            //        //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            //        string PaginaHTML_Texto = Properties.Resources.PlantillaCategorias.ToString();
            //        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CATEGORIA", "CATEGORÍAS");
            //        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", "");
            //        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            //        string filas = string.Empty;

            //        foreach (DataGridViewRow row in DatosCategorias.Rows)
            //        {
            //            filas += "<tr>";
            //            filas += "<td>" + row.Cells["IdCategoria"].Value.ToString() + "</td>";
            //            filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
            //            filas += "<td>" + row.Cells["FechaRegistro"].Value.ToString() + "</td>";
            //            filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
            //            filas += "</tr>";
            //        }
            //        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);

            //        if (savefile.ShowDialog() == DialogResult.OK)
            //        {
            //            using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
            //            {
            //                //Creamos un nuevo documento y lo definimos como PDF
            //                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

            //                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
            //                pdfDoc.Open();
            //                pdfDoc.Add(new Phrase(""));

            //                //Agregamos la imagen del banner al documento
            //                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo, System.Drawing.Imaging.ImageFormat.Png);
            //                img.ScaleToFit(60, 60);
            //                img.Alignment = iTextSharp.text.Image.UNDERLYING;

            //                //img.SetAbsolutePosition(10,100);
            //                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
            //                pdfDoc.Add(img);


            //                //pdfDoc.Add(new Phrase("Hola Mundo"));
            //                using (StringReader sr = new StringReader(PaginaHTML_Texto))
            //                {
            //                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
            //                }

            //                pdfDoc.Close();
            //                stream.Close();

            //                MessageBox.Show("Reporte generado exitosamente.", "Mensaje del sistema",
            //                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
        private void ExportarExcel(DataGridView Datos, string nombreArchivo)
        {
            //if (categoriaImpl.ListarCategorias().Count == 0)
            //{
            //    MessageBox.Show("No existen registros para exportar.", "Mensaje del sistema",
            //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    try
            //    {

            //        //Objeto que permite crear el ecxel (Se utilizó una librería externa llamada SpreadSheetLigth)
            //        SLDocument sL = new SLDocument();

            //        //Le da estilos a el archivo excel
            //        SLStyle sLStyle = new SLStyle();
            //        sLStyle.Font.FontSize = 12;
            //        sLStyle.Font.Bold = true;

            //        //Recorre las columnas
            //        int iColumn = 1;
            //        foreach (DataGridViewColumn column in Datos.Columns)
            //        {
            //            sL.SetCellValue(1, iColumn, column.HeaderText.ToString());
            //            sL.SetCellStyle(1, iColumn, sLStyle);
            //            iColumn++;
            //        }

            //        //Recorre las filas
            //        int irow = 2;
            //        foreach (DataGridViewRow row in Datos.Rows)
            //        {
            //            sL.SetCellValue(irow, 1, row.Cells[0].Value.ToString());
            //            sL.SetCellValue(irow, 2, row.Cells[1].Value.ToString());
            //            sL.SetCellValue(irow, 3, row.Cells[2].Value.ToString());
            //            sL.SetCellValue(irow, 4, row.Cells[3].Value.ToString());
            //            irow++;
            //        }

            //        //Guarda el archivo
            //        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //        saveFileDialog1.Title = "Guardar archivo";
            //        saveFileDialog1.CheckPathExists = true;
            //        saveFileDialog1.DefaultExt = "xlsx";
            //        saveFileDialog1.FileName = string.Format("{0}.pdf", nombreArchivo + "_" + DateTime.Now.ToString("dd-MM-yyyy"));
            //        saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //        {
            //            sL.SaveAs(saveFileDialog1.FileName);
            //            MessageBox.Show("¡Archivo exportado con exito!", "Mensaje del sistema",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }
        #endregion

        #region BOTONES EXCEL
        private void btnExlVentas_Click(object sender, EventArgs e)
        {
            ExportarExcel(DatosVentas,"ventas");
        }

        private void btnExlCategorias_Click(object sender, EventArgs e)
        {
            ExportarExcel(DatosCategorias, "categorias");
        }

        private void btnExlProductos_Click(object sender, EventArgs e)
        {
            ExportarExcel(DatosProductos, "productos");
        }

        private void btnExlServicios_Click(object sender, EventArgs e)
        {
            ExportarExcel(DatosServicios, "servicios");
        }

        private void btnExlClientes_Click(object sender, EventArgs e)
        {
            ExportarExcel(DatosClientes, "clientes");
        }

        private void btnExlUsuarios_Click(object sender, EventArgs e)
        {
            ExportarExcel(DatosUsuarios, "usuarios");
        }

        #endregion

        #region BOTONES PDF
        private void btnPdfCategorias_Click(object sender, EventArgs e)
        {
            ExportarCategorias_PDF();
        }
        #endregion
    }
}
