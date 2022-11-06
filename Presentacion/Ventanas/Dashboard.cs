using System;
using System.Diagnostics;
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
            BtnRegresar.Visible = false;
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
            AbrirOpcion(new Paneles.PanelVenta(), "Realizar venta");
            BtnRegresar.Visible = true;
        }

        private void Btn_02_Click(object sender, System.EventArgs e)
        {

        }

        private void Btn_03_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelReporte(), "Gestor de reportes");
            BtnRegresar.Visible = true;
        }

        private void Btn_04_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelCategoria(), "Gestor de categorias");
            BtnRegresar.Visible = true;
        }

        private void Btn_05_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelProducto(), "Gestor de productos");
            BtnRegresar.Visible = true;
        }

        private void Btn_06_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelServicio(), "Gestor de servicios");
            BtnRegresar.Visible = true;
        }

        private void Btn_07_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelCliente(), "Gestor de clientes");
            BtnRegresar.Visible = true;
        }

        private void Btn_08_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelUsuario(), "Gestor de usuarios");
            BtnRegresar.Visible = true;
        }

        private void Btn_09_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelProveedor(), "Gestor de proveedores");
            BtnRegresar.Visible = true;
        }
        #endregion

        #region BOTONES SECUNDARIOS
        private void BtnConfiguracion_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelConfiguracion(), "Configuración del sistema");
            BtnRegresar.Visible = true;
        }

        private void BtnCerrarSesion_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, System.EventArgs e)
        {
            AbrirNuevoPanel(new Inicio());
            Titulo.Text = "Bajdeja principal";
            BtnRegresar.Visible = false;
            MenuLateral.Visible = true;
        }
        #endregion

        #region BOTONES REDES SOCIALES
        private void lnkGmail_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gmail.com");
        }

        private void lnkTelegram_Click(object sender, EventArgs e)
        {
            Process.Start("http://web.telegram.org");
        }

        private void lnkSkype_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.skype.com");
        }

        private void lnkWhatsapp_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.whatsapp.com");
        }

        private void lnkFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com");
        }

        private void lnkInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.instagram.com");
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
         
        }
        #endregion
    }
}
