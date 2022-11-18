using Entidad.Roles;
using Logica.Logica.Roles;
using Presentacion.Recursos;
using System.Collections.Generic;
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
            boxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "ACTIVO"});
            boxEstado.Items.Add(new OpcionCombo() { valor = 2, texto = "INACTIVO" });
            boxEstado.DisplayMember = "Texto";
            boxEstado.ValueMember = "valor";
            boxEstado.SelectedIndex = 0;

            LogicaRol logicaRol = new LogicaRol();
            List<Rol> roles = logicaRol.Listar();

            foreach (var item in roles)
            {
                boxRol.Items.Add(new OpcionCombo() { valor = 0, texto = item.Descripcion} );
            }
            boxRol.DisplayMember = "Texto";
            boxRol.ValueMember = "valor";
            boxRol.SelectedIndex = 0;
        }
    }
    }
