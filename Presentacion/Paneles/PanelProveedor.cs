using Datos.Datos.Roles;
using Entidad.Roles;
using Logica.Logica.Roles;
using Presentacion.Properties;
using Presentacion.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelProveedor : Form
    {
        public PanelProveedor()
        {
            InitializeComponent();
        }

        LogicaProveedor logicaProveedor = new LogicaProveedor();

        private void PanelProveedor_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        private void LlenarDatos()
        {
            boxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            boxEstado.Items.Add(new OpcionCombo() { valor = 2, texto = "Inactivo" });
            boxEstado.DisplayMember = "Texto";
            boxEstado.ValueMember = "valor";
            boxEstado.SelectedIndex = 0;

            LogicaProveedor logicaProveedor = new LogicaProveedor();
            List<Proveedor> proveedor = logicaProveedor.Listar();
            //Llenar tabla
            foreach (var item in proveedor)
            {
                DatosProveedor.Rows.Add(new object[] {"",item.IdProveedor,item.Documento,item.RazonSocial,item.Telefono,item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "Inactivo" });
            }
        }

        private void Registrar_Editar_Proveedor()
        {
            string mensaje = string.Empty;

            Proveedor Proveedor = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                RazonSocial = txtRazonSocial.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)boxEstado.SelectedItem).valor) == 1
            };

            if (Proveedor.IdProveedor == 0)
            {

                DialogResult dialogo = MessageBox.Show("¿Desea agregar este nuevo proveedor?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Registrar
                    int IdProveedorGenerado = logicaProveedor.Registrar(Proveedor, out mensaje);

                    if (IdProveedorGenerado != 0)
                    {
                        DatosProveedor.Rows.Add(new object[] {"",IdProveedorGenerado,txtDocumento.Text,txtRazonSocial.Text,
                            txtTelefono.Text,((OpcionCombo)boxEstado.SelectedItem).valor.ToString(),
                         ((OpcionCombo)boxEstado.SelectedItem).texto.ToString()});

                        Limpiar();
                        MessageBox.Show("Proveedor agregado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Desea editar este proveedor?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Editar
                    bool resultado = new LogicaProveedor().Editar(Proveedor, out mensaje);
                    if (resultado)
                    {
                        DataGridViewRow row = DatosProveedor.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["IdProveedor"].Value = txtId.Text;
                        row.Cells["Documento"].Value = txtDocumento.Text;
                        row.Cells["RazonSocial"].Value = txtRazonSocial.Text;
                        row.Cells["Telefono"].Value = txtTelefono.Text;
                        row.Cells["Estado"].Value = ((OpcionCombo)boxEstado.SelectedItem).valor.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)boxEstado.SelectedItem).texto.ToString();

                        Limpiar();
                        MessageBox.Show("Proveedor editado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EliminarProveedor()
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                string mensaje = string.Empty;

                DialogResult dialogo = MessageBox.Show("¿Desea eliminar este proveedor?",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {


                    Proveedor Proveedor = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new LogicaProveedor().Eliminar(Proveedor, out mensaje);

                    if (respuesta)
                    {
                        DatosProveedor.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                        Limpiar();
                        MessageBox.Show("Proveedor eliminado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Limpiar()
        {
            txtId.Text = "0";
            txtIndice.Text = "-1";
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            boxEstado.SelectedIndex = 0;
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite numeros.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Registrar_Editar_Proveedor();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DatosProveedor_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    var w = Resources.check.Width;
                    var h = Resources.check.Height;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                    e.Graphics.DrawImage(Resources.check, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite numeros.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void DatosProveedor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatosProveedor.Columns[e.ColumnIndex].Name == "btnSeleccion")
                {

                    int indice = e.RowIndex;


                    if (indice >= 0)
                    {
                        if (e.RowIndex < 0)
                            return;
                        if (e.ColumnIndex == 0)
                        {
                            txtIndice.Text = indice.ToString();
                            txtId.Text = DatosProveedor.Rows[indice].Cells["IdProveedor"].Value.ToString();
                            txtDocumento.Text = DatosProveedor.Rows[indice].Cells["Documento"].Value.ToString();
                            txtRazonSocial.Text = DatosProveedor.Rows[indice].Cells["RazonSocial"].Value.ToString();
                            txtTelefono.Text = DatosProveedor.Rows[indice].Cells["Telefono"].Value.ToString();

                            foreach (OpcionCombo oc in boxEstado.Items)
                            {

                                if (oc.texto == Convert.ToString(DatosProveedor.Rows[indice].Cells["EstadoValor"].Value))
                                {
                                    int indiceBoxRol = boxEstado.Items.IndexOf(oc);
                                    boxEstado.SelectedIndex = indiceBoxRol;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosProveedor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.DatosProveedor.Columns[e.ColumnIndex].Name == "EstadoValor")
                {
                    if (Convert.ToString(e.Value) == "Activo")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(15, 140, 59);
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.FromArgb(255, 23, 23);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarConsulta_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            List<Proveedor> Proveedors = logicaProveedor.Listar();
            foreach (var item in Proveedors)
            {
                DatosProveedor.Rows.Add(new object[] {"",item.IdProveedor,item.Documento,
                item.RazonSocial,item.Telefono,item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "Inactivo" });
            }
        }
    }
}
