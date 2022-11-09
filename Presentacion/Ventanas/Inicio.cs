using Presentacion.Paneles;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void ControlFechaHora_Tick(object sender, EventArgs e)
        {
            TxHora.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            TxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            ventas.Text = Convert.ToString(PanelVenta.ventaImpl.ListarVentas().Count);
            clientes.Text = Convert.ToString(PanelCliente.clienteImpl.ListarClientes().Count);
            productos.Text = Convert.ToString(PanelProducto.productoImpl.ListarProductos().Count);
            servicios.Text = Convert.ToString(PanelServicio.servicioImpl.ListarServicios().Count);
            categorias.Text = Convert.ToString(PanelCategoria.categoriaImpl.ListarCategorias().Count);
        }

    }
}