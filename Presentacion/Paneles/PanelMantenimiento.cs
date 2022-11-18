using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelMantenimiento : Form
    {
        public PanelMantenimiento()
        {
            InitializeComponent();
        }

        private void PanelMantenimiento_Load(object sender, System.EventArgs e)
        {
            CargarPaneles();
        }

        private void CargarPaneles()
        {
            PanelCategoria panelCategoria = new PanelCategoria();
            panelCategoria.Dock = DockStyle.Fill;
            PagCategorias.Controls.Add(panelCategoria);
        }
    }
}
