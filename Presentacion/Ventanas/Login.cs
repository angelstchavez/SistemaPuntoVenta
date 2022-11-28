using Entidad.Roles;
using Logica.Logica.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Login : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        private void ValidarCredenciales()
        {
            try
            {
                Usuario usuario = new LogicaUsuario().Validar().Where(u => u.Documento == txtUsuario.Text && u.Contraseña == txtContraseña.Text).FirstOrDefault();

                if(txtUsuario.Text == "")
                {
                    MessageBox.Show("El campo del documento está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                }  else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("El campo de contraseña está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.Focus();
                }
                else
                {
                    if (usuario != null)
                    {
                        if(usuario.Estado == false)
                        {
                            MessageBox.Show("Este usuario se encuentra Inactivo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.Hide();
                            Carga welcome = new Carga();
                            welcome.ShowDialog();
                            Dashboard dashboard = new Dashboard(usuario);
                            dashboard.Show();
                        }
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