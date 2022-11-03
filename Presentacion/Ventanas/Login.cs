using System;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IniciarSesion()
        {
            this.Hide();
            Carga welcome = new Carga();
            welcome.ShowDialog();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            IniciarSesion();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
            "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { e.Cancel = true; }
            else
            {
                e.Cancel = false; Environment.Exit(1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}