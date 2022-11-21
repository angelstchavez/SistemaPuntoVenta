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
    public partial class VentProveedor : Form
    {
        public Proveedor proveedor { get; set; }
        public VentProveedor()
        {
            InitializeComponent();
        }

        private void VentProveedor_Load(object sender, EventArgs e)
        {
            LLenarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LLenarDatos()
        {
            LogicaProveedor logicaProveedor = new LogicaProveedor();
            List<Proveedor> proveedor = logicaProveedor.Listar();
            //Llenar tabla
            foreach (var item in proveedor)
            {
                DatosProveedor.Rows.Add(new object[] { item.IdProveedor, item.Documento, item.RazonSocial });
            }
        }

        private void FiltrarBusqueda()
        {
            if (txtConsultar.Text != "")
            {
                //Tabla
                DatosProveedor.CurrentCell = null;

                foreach (DataGridViewRow row in DatosProveedor.Rows) { row.Visible = false; }

                foreach (DataGridViewRow row in DatosProveedor.Rows)
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
                foreach (DataGridViewRow row in DatosProveedor.Rows)
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

        private void DatosProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = e.RowIndex;
            int index_colum = e.ColumnIndex;

            if (index_row >= 0 && index_colum >= 0)
            {
                proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(DatosProveedor.Rows[index_row].Cells["IdProveedor"].Value.ToString()),
                    Documento = DatosProveedor.Rows[index_row].Cells["Documento"].Value.ToString(),
                    RazonSocial = DatosProveedor.Rows[index_row].Cells["RazonSocial"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
