using Entidad.Registros;
using Logica.Logica.Registros;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Recursos
{
    /// <summary>
    ///   <br />
    /// </summary>
    public partial class VentVentas : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VentVentas" /> class.
        /// </summary>
        public VentVentas()
        {
            InitializeComponent();
        }

        private void ConsultarVenta()
        {
            Venta venta = new LogicaVenta().ObtenerVenta(txtConsultar.Text);
            if (venta.IdVenta != 0)
            {
                txtDocumento.Visible = true;
                txtDocumento.Text = "VENTA: " + txtConsultar.Text;

                fecha.Text = venta.FechaRegistro;
                tipoDocumento.Text = venta.TipoDocumento;
                usuario.Text = venta.ObjUsuario.NombreCompleto;
                nombreCliente.Text = venta.NombreCliente;
                documentoCliente.Text = venta.DocumentoCliente;
                montoPago.Text = venta.MontoPago.ToString();
                montoCambio.Text = venta.MontoCambio.ToString();
                montoTotal.Text = venta.MontoTotal.ToString();

                fecha.BackColor = Color.FromArgb(64, 64, 64);

                DatosVentas.Rows.Clear();

                foreach (DetalleVenta detalleVenta in venta.ListDatalleVenta)
                {
                    DatosVentas.Rows.Add(new object[]
                    {
                        detalleVenta.ObjProducto.Nombre,
                        detalleVenta.SubTotal / detalleVenta.Cantidad,
                        detalleVenta.Cantidad,
                        detalleVenta.SubTotal
                    });
                }

                MessageBox.Show("Venta: " + txtConsultar.Text + " encontrada con exito.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConsultar.Text = "";
            }
            else
            {
                MessageBox.Show("No se entontró una venta con el documento: " + txtConsultar.Text,
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LimpiarConsulta()
        {
            txtDocumento.Visible = false;
            txtDocumento.Text = "";
            txtConsultar.Select();
            txtConsultar.Text = "";
            fecha.Text = "";
            tipoDocumento.Text = "";
            usuario.Text = "";
            nombreCliente.Text = "";
            documentoCliente.Text = "";
            montoPago.Text = "";
            montoCambio.Text = "";
            montoTotal.Text = "";
            DatosVentas.Rows.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtConsultar.Text == "")
            {
                MessageBox.Show("No ha ingresado el número de documento a consultar.",
                     "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsultar.Select();
            }
            else
            {
                ConsultarVenta();
            }
        }

        private void VentVentas_Load(object sender, EventArgs e)
        {
            txtConsultar.Select();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarConsulta();
        }

        private void txtConsultar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { ConsultarVenta(); }
        }
    }
}
