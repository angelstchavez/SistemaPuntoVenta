using Datos.Datos.Roles;
using Entidad.Registros;
using Entidad.Roles;
using Logica.Logica.Registros;
using Logica.Logica.Roles;
using Presentacion.Properties;
using Presentacion.Recursos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelProducto : Form
    {
        public PanelProducto()
        {
            InitializeComponent();
        }

        LogicaProducto logicaProducto = new LogicaProducto();

        private void PanelProducto_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void LlenarDatos()
        {
            boxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            boxEstado.Items.Add(new OpcionCombo() { valor = 2, texto = "Inactivo" });
            boxEstado.DisplayMember = "Texto";
            boxEstado.ValueMember = "valor";
            boxEstado.SelectedIndex = 0;

            LogicaCategoria logicaCategoria = new LogicaCategoria();
            List<Categoria> categorias = logicaCategoria.Listar();

            //Lennar el box de roles
            foreach (var item in categorias)
            {
                if (item.Estado == true)
                {
                    boxCategoria.Items.Add(new OpcionCombo() { valor = item.IdCategoria, texto = item.Descripcion });
                }

            }
            boxCategoria.DisplayMember = "Texto";
            boxCategoria.ValueMember = "valor";
            boxCategoria.SelectedIndex = 0;

            LogicaProducto logicaProducto = new LogicaProducto();
            List<Producto> productos = logicaProducto.Listar();

            //Llenar tabla
            foreach (var item in productos)
            {
                DatosProducto.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.ObjCategoria.IdCategoria,
                    item.ObjCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ? 1: 0,
                    item.Estado == true ? "Activo" : "Inactivo"
                });
            }
        }

        private void Limpiar()
        {
            txtId.Text = "0";
            txtIndice.Text = "-1";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            boxCategoria.SelectedIndex = 0;
            boxEstado.SelectedIndex = 0;
        }

        private void FiltroBusqueda()
        {
            try
            {
                if (txtConsultar.Text != "")
                {
                    //Tabla
                    DatosProducto.CurrentCell = null;

                    foreach (DataGridViewRow row in DatosProducto.Rows) { row.Visible = false; }

                    foreach (DataGridViewRow row in DatosProducto.Rows)
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
                    foreach (DataGridViewRow row in DatosProducto.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            row.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Agregar_Editar_Producto()
        {
            string mensaje = string.Empty;

            Producto Producto = new Producto()
            {
                IdProducto = Convert.ToInt32(txtId.Text),
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                ObjCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)boxCategoria.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OpcionCombo)boxEstado.SelectedItem).valor) == 1 ? true : false
            };

            if (Producto.IdProducto == 0)
            {
                DialogResult dialogo = MessageBox.Show("¿Desea agregar este nuevo producto?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Registrar
                    int IdProductoGenerado = logicaProducto.Registrar(Producto, out mensaje);

                    if (IdProductoGenerado != 0)
                    {
                        DatosProducto.Rows.Add(new object[]
                        {
                            "",
                            IdProductoGenerado,
                            txtCodigo.Text,
                            txtNombre.Text,
                            ((OpcionCombo)boxCategoria.SelectedItem).valor.ToString(),
                            ((OpcionCombo)boxCategoria.SelectedItem).texto.ToString(),
                            txtDescripcion.Text,
                            "0",
                            "0.00",
                            "0.00",
                            ((OpcionCombo)boxEstado.SelectedItem).valor.ToString(),
                            ((OpcionCombo)boxEstado.SelectedItem).texto.ToString()
                        });

                        Limpiar();
                        MessageBox.Show("Producto agregado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Desea editar este Producto?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Editar
                    bool resultado = new LogicaProducto().Editar(Producto, out mensaje);
                    if (resultado)
                    {
                        DataGridViewRow row = DatosProducto.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["IdProducto"].Value = txtId.Text;
                        row.Cells["Codigo"].Value = txtCodigo.Text;
                        row.Cells["Nombre"].Value = txtNombre.Text;
                        row.Cells["Descripcion"].Value = txtDescripcion.Text;
                        row.Cells["IdCategoria"].Value = ((OpcionCombo)boxCategoria.SelectedItem).valor.ToString();
                        row.Cells["Categoria"].Value = ((OpcionCombo)boxCategoria.SelectedItem).texto.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)boxEstado.SelectedItem).valor.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)boxEstado.SelectedItem).texto.ToString();

                        Limpiar();
                        MessageBox.Show("Producto editado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EliminarProducto()
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                string mensaje = string.Empty;

                DialogResult dialogo = MessageBox.Show("¿Desea eliminar este producto?",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    Producto producto = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new LogicaProducto().Eliminar(producto, out mensaje);

                    if (respuesta)
                    {
                        DatosProducto.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                        Limpiar();
                        MessageBox.Show("Producto eliminado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltroBusqueda();
        }

        private void btnLimpiarConsulta_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            foreach (DataGridViewRow row in DatosProducto.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_Editar_Producto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DatosProducto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatosProducto.Columns[e.ColumnIndex].Name == "btnSeleccion")
                {
                    int indice = e.RowIndex;

                    if (indice >= 0)
                    {
                        if (e.RowIndex < 0)
                            return;
                        if (e.ColumnIndex == 0)
                        {
                            txtIndice.Text = indice.ToString();
                            txtId.Text = DatosProducto.Rows[indice].Cells["IdProducto"].Value.ToString();
                            txtCodigo.Text = DatosProducto.Rows[indice].Cells["Codigo"].Value.ToString();
                            txtNombre.Text = DatosProducto.Rows[indice].Cells["Nombre"].Value.ToString();
                            txtDescripcion.Text = DatosProducto.Rows[indice].Cells["Descripcion"].Value.ToString();
                            boxCategoria.Text = DatosProducto.Rows[indice].Cells["Categoria"].Value.ToString();

                            foreach (OpcionCombo oc in boxCategoria.Items)
                            {

                                if (oc.texto == Convert.ToString(DatosProducto.Rows[indice].Cells["Categoria"].Value))
                                {
                                    int indiceBoxRol = boxCategoria.Items.IndexOf(oc);
                                    boxCategoria.SelectedIndex = indiceBoxRol;
                                    break;
                                }
                            }

                            foreach (OpcionCombo oc in boxEstado.Items)
                            {

                                if (oc.texto == Convert.ToString(DatosProducto.Rows[indice].Cells["EstadoValor"].Value))
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

        private void DatosProducto_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.DatosProducto.Columns[e.ColumnIndex].Name == "Nombre")
                {
                    e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);
                }

                if (this.DatosProducto.Columns[e.ColumnIndex].Name == "EstadoValor")
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

                if (this.DatosProducto.Columns[e.ColumnIndex].Name == "Stock")
                {
                    e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);

                    if (Convert.ToInt32(e.Value) <= 0)
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255, 23, 23);
                    }
                    else if (Convert.ToInt32(e.Value) > 0 && Convert.ToInt32(e.Value) <= 10)
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.DarkOrange;

                    }
                    else
                    {
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(15, 140, 59);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosProducto_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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
    }
}
