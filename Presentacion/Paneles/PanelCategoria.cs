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
            ContarRegistros();
        }
        #endregion

        #region FUNCIONES
        public void ContarRegistros()
        {
            LogicaCategoria logicaCategoria = new LogicaCategoria();
            List<Categoria> categorias = logicaCategoria.Listar();
            int contCategorias = 0;
            foreach (var item in categorias) { contCategorias++; }
            lblContador.Text = "Registros: " + Convert.ToString(contCategorias);
        }
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
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                string mensaje = string.Empty;

                DialogResult dialogo = MessageBox.Show("¿Desea eliminar este categoria?",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    Categoria Categoria = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new LogicaCategoria().Eliminar(Categoria, out mensaje);

                    if (respuesta)
                    {
                        DatosCategoria.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                        Limpiar();
                        ContarRegistros();
                        MessageBox.Show("Categoria eliminado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Limpiar()
        {
            txtId.Text = "0";
            txtIndice.Text = "-1";
            txtDescripcion.Text = "";
            boxEstado.SelectedIndex = 0;
            txtConsultar.Text = "";
        }
        private void Registrar_Editar_Categoria()
        {
            string mensaje = string.Empty;

            Categoria Categoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtId.Text),
                Descripcion = txtDescripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)boxEstado.SelectedItem).valor) == 1 ? true : false
            };

            if (Categoria.IdCategoria == 0)
            {

                DialogResult dialogo = MessageBox.Show("¿Desea agregar este nueva categoria?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Registrar
                    int IdCategoriaGenerado = logicaCategoria.Registrar(Categoria, out mensaje);

                    if (IdCategoriaGenerado != 0)
                    {
                        DatosCategoria.Rows.Add(new object[] {"",IdCategoriaGenerado,txtDescripcion.Text,
                        ((OpcionCombo)boxEstado.SelectedItem).valor.ToString(),
                        ((OpcionCombo)boxEstado.SelectedItem).texto.ToString()});
                        ContarRegistros();
                        Limpiar();
                        MessageBox.Show("Categoria agregada exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Desea editar este categoria?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Editar
                    bool resultado = new LogicaCategoria().Editar(Categoria, out mensaje);
                    if (resultado)
                    {
                        DataGridViewRow row = DatosCategoria.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["IdCategoria"].Value = Convert.ToInt32(txtId.Text);
                        row.Cells["Descripcion"].Value = txtDescripcion.Text;
                        row.Cells["Estado"].Value = ((OpcionCombo)boxEstado.SelectedItem).valor.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)boxEstado.SelectedItem).texto.ToString();
                        Limpiar();
                        MessageBox.Show("Categoria editada exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LlenarDatos()
        {
            lblContador.Text = "Registros: " + DatosCategoria.Rows.Count.ToString();

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

        #region BOTONES SECUNDARIOS
        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }
        #endregion

        private void TxtConsultar_TextChanged(object sender, EventArgs e)
        {
            FiltrarBusqueda();
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Registrar_Editar_Categoria();
        }

        private void DatosCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatosCategoria.Columns[e.ColumnIndex].Name == "btnSeleccion")
                {
                    int indice = e.RowIndex;

                    if (indice >= 0)
                    {
                        if (e.RowIndex < 0)
                            return;
                        if (e.ColumnIndex == 0)
                        {
                            txtIndice.Text = indice.ToString();
                            txtId.Text = DatosCategoria.Rows[indice].Cells["IdCategoria"].Value.ToString();
                            txtDescripcion.Text = DatosCategoria.Rows[indice].Cells["Descripcion"].Value.ToString();

                            foreach (OpcionCombo oc in boxEstado.Items)
                            {

                                if (oc.texto == Convert.ToString(DatosCategoria.Rows[indice].Cells["EstadoValor"].Value))
                                {
                                    int indiceBoxRol = boxEstado.Items.IndexOf(oc);
                                    boxEstado.SelectedIndex = indiceBoxRol;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.DatosCategoria.Columns[e.ColumnIndex].Name == "EstadoValor")
                {
                    if (Convert.ToString(e.Value) == "Activo")
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(15, 140, 59);
                    }
                    else
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255, 23, 23);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
        }
    }
}
