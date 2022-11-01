using System;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        #region LOAD
        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            AbrirNuevoPanel(new Inicio());
        }
        #endregion

        #region FUNCIONES
        private void AbrirNuevoPanel(Form formHijo)
        {
            while (Contenedor.Controls.Count > 0) { Contenedor.Controls.RemoveAt(0); }
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(fh);
            Contenedor.Tag = fh;
            fh.Show();
        }
        private void AbrirOpcion(Form panel, string titulo)
        {
            MenuLateral.Visible = false;
            Titulo.Text = titulo;
            AbrirNuevoPanel(panel);
        }
        #endregion

        #region BOTONES PRINCIPALES

        private void Btn_01_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_02_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_03_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_04_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_05_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_06_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_07_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_08_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_09_Click(object sender, System.EventArgs e)
        {

        }
        #endregion

        #region BOTONES SECUNDARIOS
        private void BtnConfiguracion_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, System.EventArgs e)
        {

        }
        #endregion

        #region EXTRAS
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
            "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { e.Cancel = true; }
            else
            {
                e.Cancel = false; Environment.Exit(1);
            }
            #endregion
        }
    }
}
