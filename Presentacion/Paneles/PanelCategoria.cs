using Entidad.Registros;
using Logica.Implementaciones.Registros;
using SpreadsheetLight;
using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelCategoria : Form
    {
        public PanelCategoria()
        {
            InitializeComponent();
        }

        #region LOAD
        CategoriaImpl categoriaImpl = new CategoriaImpl();
        int posicion = 0;
        private void PanelCategoria_Load(object sender, System.EventArgs e)
        {
            CargarDatos();
        }
        #endregion

        #region FUNCIONES
        private void CargarDatos()
        {
            //Inicio el contador
            TxContador.Text = "Registros: " + categoriaImpl.ListarCategorias().Count;

            //Cargo los registros en la tabla
            Datos.DataSource = categoriaImpl.ListarCategorias();
        }
        private void ExportarExcel()
        {
            if (categoriaImpl.ListarCategorias().Count == 0)
            {
                MessageBox.Show("No existen registros para exportar.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    //Objeto que permite crear el ecxel (Se utilizó una librería externa llamada SpreadSheetLigth)
                    SLDocument sL = new SLDocument();

                    //Le da estilos a el archivo excel
                    SLStyle sLStyle = new SLStyle();
                    sLStyle.Font.FontSize = 12;
                    sLStyle.Font.Bold = true;

                    //Recorre las columnas
                    int iColumn = 1;
                    foreach (DataGridViewColumn column in Datos.Columns)
                    {
                        sL.SetCellValue(1, iColumn, column.HeaderText.ToString());
                        sL.SetCellStyle(1, iColumn, sLStyle);
                        iColumn++;
                    }

                    //Recorre las filas
                    int irow = 2;
                    foreach (DataGridViewRow row in Datos.Rows)
                    {
                        sL.SetCellValue(irow, 1, row.Cells[0].Value.ToString());
                        sL.SetCellValue(irow, 2, row.Cells[1].Value.ToString());
                        sL.SetCellValue(irow, 3, row.Cells[2].Value.ToString());
                        sL.SetCellValue(irow, 4, row.Cells[3].Value.ToString());
                        irow++;
                    }

                    //Guarda el archivo
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Title = "Guardar archivo";
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "xlsx";
                    saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        sL.SaveAs(saveFileDialog1.FileName);
                        MessageBox.Show("¡Archivo exportado con exito!", "Mensaje del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FiltrarBusqueda()
        {
            if (txtConsultar.Text != "")
            {
                //Tabla
                Datos.CurrentCell = null;

                foreach (DataGridViewRow row in Datos.Rows) { row.Visible = false; }

                foreach (DataGridViewRow row in Datos.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value.ToString().ToUpperInvariant().IndexOf(txtConsultar.Text.ToUpperInvariant()) == 0))
                        {
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                Datos.DataSource = null;
                Datos.DataSource = categoriaImpl.ListarCategorias();
            }
        }
        private void EliminarCategoria()
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar la categoría "
                + Datos[1, posicion].Value + " del registro?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    categoriaImpl.EliminarCategoria(categoriaImpl.ListarCategorias()[posicion]);

                    MessageBox.Show("Categoría eliminada correctamente.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Datos.DataSource = null;
                    Datos.DataSource = categoriaImpl.ListarCategorias();
                    TxContador.Text = "Registros: " + categoriaImpl.ListarCategorias().Count;
                }
                else
                {
                    LimpiarCampos();
                    MessageBox.Show("Proceso cancelado.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNombreCategoria.Text = "";
            txtConsultar.Text = "";
        }
        private void CrearCategoria()
        {
            //Creamos la categoria
            Categoria categoria = new Categoria();

            //Este valor se toma del campo de texto
            categoria.Nombre = txtNombreCategoria.Text.ToUpperInvariant();


            //categoria.Id = (categoriaImpl.ListarCategorias().Count + 1);

            //Estos valores se ponen por defecto
            Random numeroRandom = new Random();
            categoria.IdCategoria = numeroRandom.Next(0, 1000000);
            categoria.FechaRegistro = DateTime.Today.ToShortDateString().ToString();
            categoria.Estado = true;

            //La agregamos al archivo
            categoriaImpl.AgregarCategoria(categoria);

            //Actualizamos la tabla de registros para que aparezca el registro en la tabla
            Datos.DataSource = null;
            Datos.DataSource = categoriaImpl.ListarCategorias();
        }
        private void AgregarCategoria()
        {
            /* Si el botón dice "Agregar" entonces empieza el proceso de agregación.
                Caso contrario, si NO dice "agregar", entonces significa que el usuario va a editar.
             */
            if (BtnAgregar.Text == "Agregar")
            {
                try
                {
                    //Validamos si hay campos vacios
                    if (txtNombreCategoria.Text == "")
                    {
                        MessageBox.Show("Hay campos vacios.", "Mensaje del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNombreCategoria.Focus();
                    }
                    else
                    {
                        //Le preguntamos si quiere agregar la categoría
                        DialogResult resultado = MessageBox.Show("Desea agregar la categoría "
                        + txtNombreCategoria.Text.ToUpperInvariant() + " al registro?", "Mensaje del sistema",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        //sI dice que si, empieza el proceso de agregación
                        if (resultado == DialogResult.Yes)
                        {
                            bool categoriaExistente = false;

                            //Validamos si esa categoria ya se encuentra registrada
                            foreach (var item in categoriaImpl.ListarCategorias())
                            {
                                if (item.Nombre.ToString() == txtNombreCategoria.Text.ToUpperInvariant())
                                {
                                    categoriaExistente = true;
                                    break;

                                }
                            }

                            //Si ya existe entonces le avisamos al usuario que ya existe esa categoria.
                            if (categoriaExistente)
                            {
                                MessageBox.Show("La categoría " + txtNombreCategoria.Text.ToUpperInvariant()
                                    + " ya se encuentra registrada.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Creamos la categoría
                                CrearCategoria();

                                //Reseteamos la configuración
                                LimpiarCampos();

                                MessageBox.Show("Categoría creada exitosamente.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Actualizamos el contador
                                TxContador.Text = "Registros: " + categoriaImpl.ListarCategorias().Count;
                            }
                        }
                        else
                        {
                            //Si el usuario se arrepiente, le mandanos este mensaje.
                            MessageBox.Show("Proceso cancelado.", "Mensaje del sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //ModificarCategoria();
            }
        }
        private void LocalizarRegistro(Categoria categoria)
        {
            txtNombreCategoria.Text = categoria.Nombre;
        }
        #endregion

        #region BOTONES CRUD
        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            AgregarCategoria();
        }

        private void BtnActualizar_Click(object sender, System.EventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, System.EventArgs e)
        {
            if (categoriaImpl.ListarCategorias().Count == 0)
            {
                MessageBox.Show("No hay categorias registradas.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (posicion < 0)
                {
                    MessageBox.Show("Seleccione un registro.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LocalizarRegistro(categoriaImpl.ListarCategorias()[posicion]);
                    EliminarCategoria();
                }
            }
        }

        private void BtnReporte_Click(object sender, System.EventArgs e)
        {

        }
        #endregion

        #region BOTONES SECUNDARIOS
        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            txtNombreCategoria.Text = "";
        }
        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }
        #endregion

        #region EXTRAS
        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            FiltrarBusqueda();
        }
        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = Datos.CurrentRow.Index;
        }
        #endregion
    }
}
