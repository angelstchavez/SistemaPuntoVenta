using Entidad.Registros;
using Entidad.Roles;
using Logica.Logica.Registros;
using Presentacion.Properties;
using Presentacion.Recursos;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelCompra : Form
    {

        private Usuario usuario;

        public PanelCompra(Usuario usuario = null)
        {
            MessageBox.Show(usuario.NombreCompleto);
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
            txtProv.Text = "0";
        }

        private void AgregarProducto()
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool productoExiste = false;

            if (txtIdProd.Text == "0")
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

            foreach (DataGridViewRow fila in DatosProductos.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProd.Text)
                {
                    productoExiste = true;
                    break;
                }
            }

            if (!productoExiste)
            {
                decimal subTotal = (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioCompra.Text));

                DatosProductos.Rows.Add(new object[]
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
            txtCodgProducto.BackColor = Color.FromArgb(12, 12, 12);
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
                    txtProv.Text = mm.proveedor.IdProveedor.ToString();
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

            if (DatosProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in DatosProductos.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
                lblTotalPagar.Text = "$" + total.ToString("0.00");
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
                    txtCodgProducto.BackColor = Color.SeaGreen;
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
    }
}
