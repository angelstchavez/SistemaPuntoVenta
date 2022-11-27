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
    public partial class PanelVenta : Form
    {
        private Usuario usuarioIngresado;

        public PanelVenta(Usuario usuario = null)
        {
            usuarioIngresado = usuario;
            InitializeComponent();
        }

        private void PanelVenta_Load(object sender, EventArgs e)
        {
            LLenarDatos();
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

        private bool StockValidado()
        {
            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtCantidad.Text))
            { return false; }
            else { return true; }
        }

        private void abrirPanelCliente()
        {
            Form form = new Form();
            using (VentCliente mm = new VentCliente())
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
                    txtDocumento.Text = mm.cliente.Documento.ToString();
                    txtNombreCompleto.Text = mm.cliente.NombreCompleto.ToString();
                }
                else
                {
                    txtDocumento.Select();
                }
                form.Dispose();
            }
        }

        private void RealizarVenta()
        {
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Ingrese el documento del cliente o en su defecto escoja un cliente registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDocumento.Focus();
                return;
            }

            if (txtNombreCompleto.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del cliente o en su defecto escoja un cliente registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreCompleto.Focus();
                return;
            }

            if (DatosCarrito.Rows.Count < 1)
            {
                MessageBox.Show("La venta no tiene productos registrados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtxPago.Text == "")
            {
                MessageBox.Show("¡REGISTRE EL INGRESO DE LA VENTRA!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtxPago.Select();
                return;
            }

            DataTable detalleCompra = new DataTable();
            detalleCompra.Columns.Add("IdProducto", typeof(string));
            detalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            detalleCompra.Columns.Add("Cantidad", typeof(int));
            detalleCompra.Columns.Add("SubTotal", typeof(decimal));

            foreach (DataGridViewRow row in DatosCarrito.Rows)
            {
                detalleCompra.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString(),
                });
            }

            LogicaVenta logicaVenta = new LogicaVenta();
            int idCorrelativo = logicaVenta.ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Venta venta = new Venta()
            {
                ObjUsuario = new Usuario() { IdUsuario = usuarioIngresado.IdUsuario },
                TipoDocumento = ((OpcionCombo)boxTipoDocumento.SelectedItem).texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txtDocumento.Text,
                NombreCliente = txtNombreCompleto.Text,
                MontoTotal = Convert.ToDecimal(lblTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = logicaVenta.Registrar(venta, detalleCompra, out mensaje);

            if (respuesta)
            {
                var resultado = MessageBox.Show("Número de venta generada:\n" + numeroDocumento
                    + "\n\n¿Desea copiar al portapales?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resultado == DialogResult.OK)
                {
                    Clipboard.SetText(numeroDocumento);
                    MessageBox.Show("Copia generada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdProv.Text = "0";
                    txtDocumento.Text = "";
                    //txtRazonSocial.Text = "";
                    DatosCarrito.Rows.Clear();
                    CalcularTotal();
                }
                else
                {
                    txtIdProv.Text = "0";
                    txtDocumento.Text = "";
                    //txtRazonSocial.Text = "";
                    DatosCarrito.Rows.Clear();
                    CalcularTotal();
                }
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirPanelProducto()
        {
            txtCodgProducto.BackColor = Color.FromArgb(12, 12, 12);

            Form form = new Form();
            using (VentProducto mm = new VentProducto())
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

                    if (mm.producto.Stock == Convert.ToInt32("0"))
                    {
                        MessageBox.Show("Este producto no tiene stock.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        txtIdProd.Text = mm.producto.IdProducto.ToString();
                        txtCodgProducto.Text = mm.producto.Codigo.ToString();
                        txtNombreProd.Text = mm.producto.Nombre.ToString();
                        txtPrecioVenta.Text = mm.producto.PrecioCompra.ToString();
                        txtStock.Text = mm.producto.Stock.ToString();
                        txtCantidad.Select();
                    }
                }
                else
                {
                    txtDocumento.Select();
                }
                form.Dispose();
            }
        }

        private void AgregarProducto()
        {
            try
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

                if (!decimal.TryParse(txtCantidad.Text, out precioCompra))
                {
                    MessageBox.Show("Ingrese la cantidad de productos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCantidad.Select();
                    return;
                }

                if (!StockValidado())
                {
                    MessageBox.Show("La cantidad ingresada supera el stock disponible.\n" +
                        "Verifique nuevamente la cantidad del producto a ingresar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCantidad.Select();
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

                    LogicaVenta logicaVenta = new LogicaVenta();
                    bool respuesta = logicaVenta.RestarStock
                        (
                        Convert.ToInt32(txtIdProd.Text),
                        Convert.ToInt32(txtCantidad.Text)
                        );

                    if (respuesta)
                    {

                        precioCompra = Convert.ToDecimal(txtPrecioVenta.Text);
                        decimal subTotal = (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioVenta.Text));

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void LimpiarCampos()
        {
            txtCodgProducto.BackColor = Color.FromArgb(12, 12, 12);
            txtIdProd.Text = "0";
            txtCodgProducto.Text = "";
            txtNombreProd.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtCantidad.Text = "";
            txtxPago.Text = "";
            txtCambio.Text = "";
        }

        private void CalcularCambio()
        {
            if (lblTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en el carrito de compra.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal pagaCon = 0;
            decimal total = Convert.ToDecimal(lblTotalPagar.Text);

            if (txtxPago.Text.Trim() == "") { txtxPago.Text = "$0"; }
            if (decimal.TryParse(txtxPago.Text.Trim(), out pagaCon))
            {
                if (pagaCon < total)
                {
                    txtCambio.Text = "$0,00";
                }
                else
                {
                    decimal cambio = pagaCon - total;
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            abrirPanelCliente();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            abrirPanelProducto();
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
                    txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                    txtStock.Text = producto.Stock.ToString();
                    txtCantidad.Select();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
        }

        private void DatosCarrito_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void DatosCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatosCarrito.Columns[e.ColumnIndex].Name == "BtnEliminar")
                {
                    int indice = e.RowIndex;

                    if (indice >= 0)
                    {
                        LogicaVenta logicaVenta = new LogicaVenta();
                        bool respuesta = logicaVenta.SumarStock
                            (
                            Convert.ToInt32(DatosCarrito.Rows[indice].Cells["IdProducto"].Value.ToString()),
                            Convert.ToInt32(DatosCarrito.Rows[indice].Cells["Cantidad"].Value.ToString())
                            );

                        if (respuesta)
                        {
                            DatosCarrito.Rows.RemoveAt(indice);
                            CalcularTotal();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtxPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtxPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RealizarVenta();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Desea limpiar esta venta?\n(Esta acción no se puede deshacer)", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                LimpiarCampos();
                txtDocumento.Text = "";
                txtNombreCompleto.Text = "";
                DatosCarrito.Rows.Clear();
                CalcularTotal();
            }
        }
    }
}
