using Datos.Datos.Roles;
using Entidad.Roles;
using Logica.Logica.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Recursos
{
    /// <summary>
    ///   <br />
    /// </summary>
    public partial class VentCliente : Form
    {

        /// <summary>Gets or sets the cliente.</summary>
        /// <value>The cliente.</value>
        public Cliente cliente { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VentCliente" /> class.
        /// </summary>
        public VentCliente()
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
                if (item.Estado == true)
                {
                    DatosCliente.Rows.Add(new object[] { item.Documento, item.NombreCompleto });
                }
            }
        }

        private void FiltrarBusqueda()
        {
            if (txtConsultar.Text != "")
            {
                //Tabla
                DatosCliente.CurrentCell = null;

                foreach (DataGridViewRow row in DatosCliente.Rows) { row.Visible = false; }

                foreach (DataGridViewRow row in DatosCliente.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value.ToString().ToUpperInvariant().IndexOf(txtConsultar.Text.ToUpperInvariant()) == 0))
                        {
                            row.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in DatosCliente.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarBusqueda();
        }

        private void DatosCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = e.RowIndex;
            int index_colum = e.ColumnIndex;

            if (index_row >= 0 && index_colum >= 0)
            {
                cliente = new Cliente()
                {
                    Documento = DatosCliente.Rows[index_row].Cells["Documento"].Value.ToString(),
                    NombreCompleto = DatosCliente.Rows[index_row].Cells["NombreCompleto"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentCliente_Load(object sender, EventArgs e)
        {
            LLenarDatos();
        }
    }
}
