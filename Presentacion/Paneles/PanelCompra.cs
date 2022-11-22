using Entidad.Roles;
using Presentacion.Recursos;
using System;
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
            txtProd.Text = "0";
            txtProv.Text = "0";
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

        private void abrirPanelProducto()
        {
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
                    txtProv.Text = mm.producto.IdProducto.ToString();
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
    }
}
