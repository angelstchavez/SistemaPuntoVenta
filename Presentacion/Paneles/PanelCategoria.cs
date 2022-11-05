using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelCategoria : Form
    {
        public PanelCategoria()
        {
            InitializeComponent();
        }

        #region LOAD
        //CategoriaImpl categoriaImpl = new CategoriaImpl();
        //int posicion = 0;
        private void PanelCategoria_Load(object sender, System.EventArgs e)
        {

        }
        #endregion

        #region FUNCIONES

        #endregion

        #region BOTONES CRUD
        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, System.EventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnReporte_Click(object sender, System.EventArgs e)
        {

        }
        #endregion

        #region BOTONES SECUNDARIOS
        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            txtAgregar.Text = "";
        }
        #endregion

        #region EXTRAS

        #endregion
    }
}
