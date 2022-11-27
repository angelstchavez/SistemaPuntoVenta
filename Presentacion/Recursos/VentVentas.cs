using Entidad.Registros;
using Logica.Logica.Registros;
using System;
using System.Windows.Forms;

namespace Presentacion.Recursos
{
    public partial class VentVentas : Form
    {
        public VentVentas()
        {
            InitializeComponent();
        }

        private void ConsultarVenta()
        {
            Venta venta = new LogicaVenta().ObtenerVenta(txtConsultar.Text);
            if (venta.IdVenta != 0)
            {

                fecha.Text = venta.FechaRegistro;
                tipoDocumento.Text = venta.TipoDocumento;
                usuario.Text = venta.ObjUsuario.NombreCompleto;
                nombreCliente.Text = venta.NombreCliente;
                documentoCliente.Text = venta.DocumentoCliente;
                montoPago.Text = venta.MontoPago.ToString("0.00");
                montoCambio.Text = venta.MontoCambio.ToString("0.00");
                montoTotal.Text = venta.MontoTotal.ToString("0.00");

                DatosVentas.Rows.Clear();

                foreach (DetalleVenta item in venta.ListDatalleVenta)
                {
                    DatosVentas.Rows.Add(new object[]
                    {
                        item.ObjProducto.Nombre,
                        item.PrecioVenta,
                        item.Cantidad,
                        item.SubTotal
                    });
                }

                MessageBox.Show("Venta: " + txtConsultar.Text + " encontrada con exito.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsultar.Text = "";
            }
            else
            {
                MessageBox.Show("No se entontró una venta con el documento: " + txtConsultar.Text,
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarConsulta()
        {
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
    }
}
