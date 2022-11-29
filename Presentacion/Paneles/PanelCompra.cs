using Entidad.Registros;
using Entidad.Roles;
using Logica.Logica.Registros;
using Presentacion.Properties;
using Presentacion.Recursos;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelCompra : Form
    {

        private Usuario usuarioIngresado;

        public PanelCompra(Usuario usuario = null)
        {
            usuarioIngresado = usuario;
            InitializeComponent();
        }

        private void LLenarDatos()
        {
            boxTipoDocumento.Items.Add(new OpcionCombo() { valor = 1, texto = "Boleta" });
            boxTipoDocumento.Items.Add(new OpcionCombo() { valor = 2, texto = "Factura" });
            boxTipoDocumento.DisplayMember = "Texto";
            boxTipoDocumento.ValueMember = "valor";
            boxTipoDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProd.Text = "0";
            txtIdProv.Text = "0";
        }

        private void AgregarProducto()
        {
            decimal precioVenta = 0;
            decimal precioCompra = 0;
            bool productoExiste = false;

            int id = Convert.ToInt32(txtIdProd.Text);

            if (id == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio compra - Formato incorrecto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Select();
                return;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio venta - Formato incorrecto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Select();
                return;
            }

            foreach (DataGridViewRow fila in DatosCarrito.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProd.Text)
                {
                    productoExiste = true;
                    break;
                }
            }

            if (!productoExiste)
            {

                precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                decimal subTotal = (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioCompra.Text));

                DatosCarrito.Rows.Add(new object[]
                {
                    txtIdProd.Text,
                    txtNombreProd.Text,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    txtCantidad.Text,
                    subTotal.ToString("0.00")
                });

                CalcularTotal();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtCodgProducto.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            txtIdProd.Text = "0";
            txtCodgProducto.Text = "";
            txtNombreProd.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";

        }

        private void abrirPanelProveedor()
        {
            Form form = new Form();
            using (VentProveedor mm = new VentProveedor())
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Opacity = .70d;
                form.BackColor = Color.Black;
                form.WindowState = FormWindowState.Maximized;
                form.TopMost = true;
                form.Location = this.Location;
                form.ShowInTaskbar = false;
                form.Show();
                mm.Owner = form;

                var result = mm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProv.Text = mm.proveedor.IdProveedor.ToString();
                    txtDocumento.Text = mm.proveedor.Documento.ToString();
                    txtRazonSocial.Text = mm.proveedor.RazonSocial.ToString();
                }
                else
                {
                    txtDocumento.Select();
                }
                form.Dispose();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            if (DatosCarrito.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosCarrito.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
                lblTotalPagar.Text = total.ToString("0.00");
            }
            else
            {
                lblTotalPagar.Text = "0";
            }
        }

        private void abrirPanelProducto()
        {
            txtCodgProducto.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);

            Form form = new Form();
            using (VentProducto mm = new VentProducto())
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Opacity = .70d;
                form.BackColor = System.Drawing.Color.Black;
                form.WindowState = FormWindowState.Maximized;
                form.TopMost = true;
                form.Location = this.Location;
                form.ShowInTaskbar = false;
                form.Show();
                mm.Owner = form;

                var result = mm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProd.Text = mm.producto.IdProducto.ToString();
                    txtCodgProducto.Text = mm.producto.Codigo.ToString();
                    txtNombreProd.Text = mm.producto.Nombre.ToString();
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtDocumento.Select();
                }
                form.Dispose();
            }
        }

        private void RegistrarCompra()
        {
            if (Convert.ToInt32(txtIdProv.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (DatosCarrito.Rows.Count < 1)
            {
                {
                    MessageBox.Show("El carrito de compra está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            DataTable detalleVenta = new DataTable();
            detalleVenta.Columns.Add("IdProducto", typeof(string));
            detalleVenta.Columns.Add("PrecioCompra", typeof(decimal));
            detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in DatosCarrito.Rows)
            {
                detalleVenta.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString(),
                });
            }

            LogicaCompra logicaCompra = new LogicaCompra();
            int idCorrelativo = logicaCompra.ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Compra compra = new Compra()
            {
                ObjUsuario = new Usuario() { IdUsuario = usuarioIngresado.IdUsuario },
                ObjProvedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtIdProv.Text) },
                TipoDocumento = ((OpcionCombo)boxTipoDocumento.SelectedItem).texto,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal(lblTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = logicaCompra.Registrar(compra, detalleVenta, out mensaje);

            if (respuesta)
            {
                var resultado = MessageBox.Show("Número de compra generada:\n" + numeroDocumento
                    + "\n¿Desea copiar al portapales?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.OK)
                {
                    Clipboard.SetText(numeroDocumento);
                    MessageBox.Show("Copia generada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdProv.Text = "0";
                    txtDocumento.Text = "";
                    txtRazonSocial.Text = "";
                    DatosCarrito.Rows.Clear();
                    CalcularTotal();
                }
                else
                {
                    txtIdProv.Text = "0";
                    txtDocumento.Text = "";
                    txtRazonSocial.Text = "";
                    DatosCarrito.Rows.Clear();
                    CalcularTotal();
                }

            }
        }

        private void PanelCompra_Load(object sender, System.EventArgs e)
        {
            LLenarDatos();
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            abrirPanelProveedor();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            abrirPanelProducto();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void txtCodgProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto producto = new LogicaProducto().Listar().Where(p => p.Codigo == txtCodgProducto.Text && p.Estado == true).FirstOrDefault();

                if (producto != null)
                {
                    txtCodgProducto.BackColor = System.Drawing.Color.SeaGreen;
                    txtIdProd.Text = producto.IdProducto.ToString();
                    txtNombreProd.Text = producto.Nombre;
                    txtPrecioCompra.Select();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }

        private void DatosProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 6)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    var w = Resources.limpiar.Width;
                    var h = Resources.limpiar.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                    e.Graphics.DrawImage(Resources.limpiar, new Rectangle(x, y, w, h));
                    e.Handled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatosCarrito.Columns[e.ColumnIndex].Name == "BtnEliminar")
                {
                    int indice = e.RowIndex;

                    if (indice >= 0)
                    {

                        DatosCarrito.Rows.RemoveAt(indice);
                        CalcularTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistrarCompra();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea limpiar esta compra?\n(Esta acción no se puede deshacer)", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                LimpiarCampos();
                txtDocumento.Text = "";
                txtNombreProd.Text = "";
                txtRazonSocial.Text = "";
                DatosCarrito.Rows.Clear();
                CalcularTotal();
            }
        }

        private void DatosCarrito_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DatosCarrito.Columns[e.ColumnIndex].Name == "SubTotal")
            {
                e.CellStyle.Font = new Font(this.Font, FontStyle.Bold);
            }
        }
    }
}
