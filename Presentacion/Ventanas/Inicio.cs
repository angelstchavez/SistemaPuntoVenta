using Datos.Datos.Roles;
using Entidad.Registros;
using Entidad.Roles;
using Logica.Logica.Registros;
using Logica.Logica.Roles;
using Presentacion.Paneles;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ControlFechaHora_Tick(object sender, EventArgs e)
        {
            TxHora.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            TxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            RecorerRegistros();
        }

        private void RecorerRegistros()
        {
            try
            {
                //Logicas
                LogicaUsuario logicaUsuario = new LogicaUsuario();
                LogicaCliente logicaCliente = new LogicaCliente();
                LogicaCategoria logicaCategoria = new LogicaCategoria();
                LogicaProveedor logicaProveedor = new LogicaProveedor();

                //Registros
                List<Usuario> usuarios = logicaUsuario.Listar();
                List<Cliente> clientes = logicaCliente.Listar();
                List<Categoria> categorias = logicaCategoria.Listar();
                List<Proveedor> proveedores = logicaProveedor.Listar();

                //Contadores
                int contUsuarios = 0;
                int contClientes = 0;
                int contCategorias = 0;
                int contProveedores = 0;

                //Recorrido por los registros
                foreach (var item in usuarios) { contUsuarios++; }
                foreach (var item in clientes) { contClientes++; }
                foreach (var item in categorias) { contCategorias++; }
                foreach (var item in proveedores) { contProveedores++; }

                //Textos
                lblClientes.Text = Convert.ToString(contClientes);
                lblUsuarios.Text = Convert.ToString(contUsuarios);
                lblCategorias.Text = Convert.ToString(contCategorias);
                lblProveedores.Text = Convert.ToString(contProveedores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}