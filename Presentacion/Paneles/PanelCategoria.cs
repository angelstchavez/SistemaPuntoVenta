using Datos.Datos.Roles;
using Entidad.Registros;
using Entidad.Roles;
using Logica.Logica.Registros;
using Logica.Logica.Roles;
using Presentacion.Properties;
using Presentacion.Recursos;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        LogicaCategoria logicaCategoria = new LogicaCategoria();
        private void PanelCategoria_Load(object sender, System.EventArgs e)
        {
            LlenarDatos();
        }
        #endregion

        #region FUNCIONES
        private void ExportarExcel()
        {
            if (DatosCategoria.Rows.Count == 0)
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
                    foreach (DataGridViewColumn column in DatosCategoria.Columns)
                    {
                        sL.SetCellValue(1, iColumn, column.HeaderText.ToString());
                        sL.SetCellStyle(1, iColumn, sLStyle);
                        iColumn++;
                    }

                    //Recorre las filas
                    int irow = 2;
                    foreach (DataGridViewRow row in DatosCategoria.Rows)
                    {
                        sL.SetCellValue(irow, 1, row.Cells[1].Value.ToString());
                        sL.SetCellValue(irow, 2, row.Cells[2].Value.ToString());
                        sL.SetCellValue(irow, 4, row.Cells[4].Value.ToString());
                        irow++;
                    }

                    //Guarda el archivo
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog
                    {
                        Title = "Guardar archivo",
                        CheckPathExists = true,
                        DefaultExt = "xlsx",
                        Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                    };
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
            //if (txtConsultar.Text != "")
            //{
            //    //Tabla
            //    Datos.CurrentCell = null;

            //    foreach (DataGridViewRow row in Datos.Rows) { row.Visible = false; }

            //    foreach (DataGridViewRow row in Datos.Rows)
            //    {
            //        foreach (DataGridViewCell cell in row.Cells)
            //        {
            //            if ((cell.Value.ToString().ToUpperInvariant().IndexOf(txtConsultar.Text.ToUpperInvariant()) == 0))
            //            {
            //                row.Visible = true;
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Datos.DataSource = null;
            //    Datos.DataSource = categoriaImpl.ListarCategorias();
            //}
        }
        private void EliminarCategoria()
        {
            //try
            //{
            //    DialogResult resultado = MessageBox.Show("Desea eliminar la categoría "
            //    + Datos[1, posicion].Value + " del registro?", "Mensaje del sistema",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (resultado == DialogResult.Yes)
            //    {
            //        categoriaImpl.EliminarCategoria(categoriaImpl.ListarCategorias()[posicion]);

            //        MessageBox.Show("Categoría eliminada correctamente.", "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        Datos.DataSource = null;
            //        Datos.DataSource = categoriaImpl.ListarCategorias();
            //        TxContador.Text = "Registros: " + categoriaImpl.ListarCategorias().Count;
            //    }
            //    else
            //    {
            //        LimpiarCampos();
            //        MessageBox.Show("Proceso cancelado.", "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Mensaje del sistema",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void LimpiarCampos()
        {
            txtNombreCategoria.Text = "";
            boxEstado.SelectedIndex = 0;
            txtConsultar.Text = "";
        }
        private void CrearCategoria()
        {
            string mensaje = string.Empty;

            Categoria categoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtId.Text),
                Descripcion = txtNombreCategoria.Text,
                Estado = Convert.ToInt32(((OpcionCombo)boxEstado.SelectedItem).valor) == 1
            };
            int IdCategoriaGenerado = logicaCategoria.Registrar(categoria, out mensaje);

            if (categoria.IdCategoria != 0)
            {
                DatosCategoria.Rows.Add(new object[] {"",IdCategoriaGenerado,txtNombreCategoria.Text,
            ((OpcionCombo)boxEstado.SelectedItem).valor.ToString(),
            ((OpcionCombo)boxEstado.SelectedItem).texto.ToString()});

                LimpiarCampos();
                MessageBox.Show("Categoria agregada exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AgregarCategoria()
        {
            ///* Si el botón dice "Agregar" entonces empieza el proceso de agregación.
            //    Caso contrario, si NO dice "agregar", entonces significa que el Categoria va a editar.
            // */
            //if (BtnAgregar.Text == "Agregar")
            //{
            //    try
            //    {
            //        //Validamos si hay campos vacios
            //        if (txtNombreCategoria.Text == "")
            //        {
            //            MessageBox.Show("Hay campos vacios.", "Mensaje del sistema",
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            txtNombreCategoria.Focus();
            //        }
            //        else
            //        {
            //            //Le preguntamos si quiere agregar la categoría
            //            DialogResult resultado = MessageBox.Show("Desea agregar la categoría "
            //            + txtNombreCategoria.Text.ToUpperInvariant() + " al registro?", "Mensaje del sistema",
            //            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //            //sI dice que si, empieza el proceso de agregación
            //            if (resultado == DialogResult.Yes)
            //            {
            //                bool categoriaExistente = false;

            //                //Validamos si esa categoria ya se encuentra registrada
            //                foreach (var item in categoriaImpl.ListarCategorias())
            //                {
            //                    if (item.Nombre.ToString() == txtNombreCategoria.Text.ToUpperInvariant())
            //                    {
            //                        categoriaExistente = true;
            //                        break;

            //                    }
            //                }

            //                //Si ya existe entonces le avisamos al Categoria que ya existe esa categoria.
            //                if (categoriaExistente)
            //                {
            //                    MessageBox.Show("La categoría " + txtNombreCategoria.Text.ToUpperInvariant()
            //                        + " ya se encuentra registrada.", "Mensaje del sistema",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //                else
            //                {
            //                    //Creamos la categoría
            //                    CrearCategoria();

            //                    //Reseteamos la configuración
            //                    LimpiarCampos();

            //                    MessageBox.Show("Categoría creada exitosamente.", "Mensaje del sistema",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                    //Actualizamos el contador
            //                    TxContador.Text = "Registros: " + categoriaImpl.ListarCategorias().Count;
            //                }
            //            }
            //            else
            //            {
            //                //Si el Categoria se arrepiente, le mandanos este mensaje.
            //                MessageBox.Show("Proceso cancelado.", "Mensaje del sistema",
            //                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                LimpiarCampos();
            //            }

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Mensaje del sistema",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    //ModificarCategoria();
            //}
        }
        private void LlenarDatos()
        {
            TxContador.Text = "Registros: " + DatosCategoria.Rows.Count.ToString();

            boxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            boxEstado.Items.Add(new OpcionCombo() { valor = 2, texto = "Inactivo" });
            boxEstado.DisplayMember = "Texto";
            boxEstado.ValueMember = "valor";
            boxEstado.SelectedIndex = 0;

            LogicaCategoria logicaCategoria = new LogicaCategoria();
            List<Categoria> categorias = logicaCategoria.Listar();

            //Llenar tabla
            foreach (var item in categorias)
            {
                DatosCategoria.Rows.Add(new object[] {"",item.IdCategoria,item.Descripcion,item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "Inactivo" });
            }
        }
        #endregion

        #region BOTONES CRUD

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
        private void TxtConsultar_TextChanged(object sender, EventArgs e)
        {
            FiltrarBusqueda();
        }
        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //posicion = Datos.CurrentRow.Index;
        }
        #endregion

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void DatosCategoria_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    var w = Resources.check.Width;
                    var h = Resources.check.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                    e.Graphics.DrawImage(Resources.check, new Rectangle(x, y, w, h));
                    e.Handled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            CrearCategoria();
        }
    }
}
