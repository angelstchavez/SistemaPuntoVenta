using Entidad.Registros;
using Entidad.Roles;
using Logica.Logica.Registros;
using Logica.Logica.Roles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Recursos
{
    public partial class VentProducto : Form
    {
        public Producto producto { get; set; }
        public VentProducto()
        {
            InitializeComponent();
        }

        private void VentProducto_Load(object sender, EventArgs e)
        {
            LLenarDatos();
        }

        private void LLenarDatos()
        {
            LogicaProducto logicaProducto = new LogicaProducto();
            List<Producto> productos = logicaProducto.Listar();
            //Llenar tabla
            foreach (var item in productos)
            {
                if (item.Estado == true && item.Stock > 1)
                {
                    DatosProducto.Rows.Add(new object[] { item.IdProducto, item.Codigo, item.Nombre, item.ObjCategoria.Descripcion, item.Stock, item.PrecioCompra, item.PrecioVenta });
                }
            }
        }

        private void FiltrarBusqueda()
        {
            if (txtConsultar.Text != "")
            {
                //Tabla
                DatosProducto.CurrentCell = null;

                foreach (DataGridViewRow row in DatosProducto.Rows) { row.Visible = false; }

                foreach (DataGridViewRow row in DatosProducto.Rows)
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
                foreach (DataGridViewRow row in DatosProducto.Rows)
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

        private void DatosProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index_row = e.RowIndex;
            int index_colum = e.ColumnIndex;

            if (index_row >= 0 && index_colum >= 0)
            {
                producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(DatosProducto.Rows[index_row].Cells["IdProducto"].Value.ToString()),
                    Codigo = DatosProducto.Rows[index_row].Cells["Codigo"].Value.ToString(),
                    Nombre = DatosProducto.Rows[index_row].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(DatosProducto.Rows[index_row].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(DatosProducto.Rows[index_row].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(DatosProducto.Rows[index_row].Cells["PrecioVenta"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
