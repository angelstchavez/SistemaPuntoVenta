using DocumentFormat.OpenXml.Wordprocessing;
using Entidad.Roles;
using Logica.Logica.Registros;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class Dashboard : Form
    {
        private static Usuario usuarioActual;

        public Dashboard(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        #region LOAD
        private void Dashboard_Load(object sender, System.EventArgs e)
        {
            ValidadControles();
            AbrirNuevoPanel(new Inicio());
            BtnRegresar.Visible = false;
            lblUsuario.Text = usuarioActual.NombreCompleto;
        }
        #endregion

        #region FUNCIONES
        private void ValidadControles()
        {
            LogicaPermiso logicaPermiso = new LogicaPermiso();
            List<Permiso> permisos = logicaPermiso.Listar(usuarioActual.IdUsuario);

            //Recorremos los elementos del menú lateral
            foreach (var elemento in MenuLateral.Controls)
            {
                //Si el elemento del menú lateral es un botón entonces ejecuta el bloque de codigo
                if (elemento is Button boton)
                {
                    bool encontrado = permisos.Any(m => m.NombreMenu == boton.Name);
                    if (encontrado) { boton.Visible = true; }
                    else { boton.Visible = false; }
                }
            }
        }
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
            AbrirOpcion(new Paneles.PanelMantenimiento(), "Mantenimiento");
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

        private void Btn_09_Click(object sender, EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelReporte(), "Gestor de reportes");
            BtnRegresar.Visible = true;
        }
        private void Btn_010_Click(object sender, EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelAcercaDe(), "Acerca de");
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
        private void LnkGmail_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gmail.com");
        }

        private void LnkTelegram_Click(object sender, EventArgs e)
        {
            Process.Start("http://web.telegram.org");
        }

        private void LnkSkype_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.skype.com");
        }

        private void LnkWhatsapp_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.whatsapp.com");
        }

        private void LnkFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.facebook.com");
        }

        private void LnkInstagram_Click(object sender, EventArgs e)
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
