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
                if(item.Estado == true)
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
                DatosCategoria.Rows.Add(new object[] {
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
                    DatosCategoria.CurrentCell = null;

                    foreach (DataGridViewRow row in DatosCategoria.Rows) { row.Visible = false; }

                    foreach (DataGridViewRow row in DatosCategoria.Rows)
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
                    foreach (DataGridViewRow row in DatosCategoria.Rows)
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

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltroBusqueda();
        }

        private void btnLimpiarConsulta_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            foreach (DataGridViewRow row in DatosCategoria.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DatosUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatosUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void DatosUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}
