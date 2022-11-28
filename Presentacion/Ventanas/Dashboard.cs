using DocumentFormat.OpenXml.Wordprocessing;
using Entidad.Roles;
using Logica.Logica.Registros;
using Presentacion.Paneles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    /// <summary>
    ///   <br />
    /// </summary>
    public partial class Dashboard : Form
    {
        private static Usuario usuarioActual;

        /// <summary>Initializes a new instance of the <see cref="Dashboard" /> class.</summary>
        /// <param name="usuario">The usuario.</param>
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
        }m

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

        private void abrirPanelAcercaDe()
        {
            Form form = new Form();
            using (PanelAcercaDe mm = new PanelAcercaDe())
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Opacity = .70d;
                form.BackColor = System.Drawing.Color.Black;
                form.WindowState = FormWindowState.Maximized;
                form.TopMost = true;
                form.Location = this.Location;
                form.ShowInTaskbar = false;
                form.Show();

                mm.Owner = form;
                mm.ShowDialog();

                form.Dispose();
            }
        }
        #endregion

        #region BOTONES PRINCIPALES
        private void Btn_01_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelVenta(usuarioActual), "Gestor de ventas");
            BtnRegresar.Visible = true;
        }

        private void Btn_02_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelCompra(usuarioActual), "Gestor de compras");
            BtnRegresar.Visible = true;
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
            AbrirOpcion(new Paneles.PanelCategoria(), "Gestor de categorías");
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
            abrirPanelAcercaDe();
        }

        private void productos_Click(object sender, EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelProducto(), "Gestor de productos");
            BtnRegresar.Visible = true;
        }

        private void registros_Click(object sender, EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelRegistros(), "Gestor de registros");
            BtnRegresar.Visible = true;
        }

        #endregion

        #region BOTONES SECUNDARIOS
        private void BtnProveedor_Click(object sender, System.EventArgs e)
        {
            AbrirOpcion(new Paneles.PanelProveedor(), "Gestor de proveedores");
            BtnRegresar.Visible = true;
        }

        private void BtnCerrarSesion_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desea cerrar el sesión?",
            "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No) { }
            else
            {
                this.Hide();
                Login Login = new Login();
                Login.Show();
            }

        }

        private void BtnRegresar_Click(object sender, System.EventArgs e)
        {
            AbrirNuevoPanel(new Inicio());
            Titulo.Text = "Bandeja principal";
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
