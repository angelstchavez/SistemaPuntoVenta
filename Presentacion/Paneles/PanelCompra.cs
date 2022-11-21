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
        }

        private void PanelCompra_Load(object sender, System.EventArgs e)
        {
            LLenarDatos();
        }
    }
}
