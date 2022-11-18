using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelUsuario : Form
    {
        public PanelUsuario()
        {
            InitializeComponent();
        }

        private void PanelUsuario_Load(object sender, System.EventArgs e)
        {
            LlenarCombobox();
        }

        private void LlenarCombobox()
        {
            boxEstado.Items.Add(new Recursos.OpcionCombo() { valor = 1, texto = "ACTIVO"});
            boxEstado.Items.Add(new Recursos.OpcionCombo() { valor = 2, texto = "INACTIVO" });
            boxEstado.DisplayMember = "Texto";
            boxEstado.ValueMember = "valor";
            boxEstado.SelectedIndex = 0;
        }
    }
}
