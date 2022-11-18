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

        #region LOAD
        private void PanelUsuario_Load(object sender, System.EventArgs e)
        {
            txtId.Visible = false;
            LlenarCombobox();
        }
        #endregion

        #region FUNCIONES
        private void LlenarCombobox()
        {
            boxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            boxEstado.Items.Add(new OpcionCombo() { valor = 2, texto = "Inactivo" });
            boxEstado.DisplayMember = "Texto";
            boxEstado.ValueMember = "valor";
            boxEstado.SelectedIndex = 0;

            LogicaRol logicaRol = new LogicaRol();
            List<Rol> roles = logicaRol.Listar();

            foreach (var item in roles)
            {
                boxRol.Items.Add(new OpcionCombo() { valor = 0, texto = item.Descripcion });
            }
            boxRol.DisplayMember = "Texto";
            boxRol.ValueMember = "valor";
            boxRol.SelectedIndex = 0;
        }
        private void AgregarUsuario()
        {
            DatosUsuario.Rows.Add(new object[] {txtId.Text,txtIdentificacion.Text,txtNombre.Text,
                txtCorreo.Text,txtConfContraseña.Text,((OpcionCombo)boxRol.SelectedItem).valor.ToString(),
            ((OpcionCombo)boxRol.SelectedItem).texto.ToString(),
            ((OpcionCombo)boxEstado.SelectedItem).valor.ToString(),
            ((OpcionCombo)boxEstado.SelectedItem).texto.ToString()});

            Limpiar();
            MessageBox.Show("Usuario agregado exitosamente.","Completado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtConfContraseña.Text = "";
            boxRol.SelectedIndex = 0;
            boxEstado.SelectedIndex = 0;
        }
        #endregion

        #region BOTONES
        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            AgregarUsuario();
        }

        private void BtnEditar_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, System.EventArgs e)
        {

        }
        #endregion

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
