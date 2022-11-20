using Datos.Datos.Roles;
using Entidad.Roles;
using Logica.Logica.Roles;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelCompra : Form
    {
        public PanelCompra()
        {
            InitializeComponent();
        }

        private void LLenarDatos()
        {
            LogicaCliente logicaCliente = new LogicaCliente();
            List<Cliente> clientes = logicaCliente.Listar();
            //Llenar tabla
            foreach (var item in clientes)
            {
                DatosProductos.Rows.Add(new object[] {"",item.IdCliente,item.Documento,item.NombreCompleto,
                item.Correo,item.Telefono,item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "Inactivo" });
            }
        }

        private void PanelCompra_Load(object sender, System.EventArgs e)
        {
            LLenarDatos();
        }
    }
}
