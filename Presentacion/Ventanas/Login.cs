using Entidad.Roles;
using Logica.Logica.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ValidarCredenciales()
        {
            try
            {
                //LogicaUsuario logicaUsuario = new LogicaUsuario();

                //List<Usuario> test = logicaUsuario.Listar();
                //foreach (var item in logicaUsuario.Listar())
                //{
                //    MessageBox.Show(item.ToString());
                //}

                Usuario usuario = new LogicaUsuario().Validad().Where(u => u.Documento == txtUsuario.Text && u.Contraseña == txtContraseña.Text).FirstOrDefault();

                if(txtUsuario.Text == "")
                {
                    MessageBox.Show("El campo del documento está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                }  else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("El campo de contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtContraseña.Focus();
                }
                else
                {
                    if (usuario != null)
                    {
                        this.Hide();
                        Carga welcome = new Carga();
                        welcome.ShowDialog();
                        Dashboard dashboard = new Dashboard(usuario);
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas, verifique e intentelo nuevamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            ValidarCredenciales();
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

        private void checkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if(checkContraseña.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}