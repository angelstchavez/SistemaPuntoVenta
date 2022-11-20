using Datos.Datos.Roles;
using Entidad.Roles;
using Logica.Logica.Roles;
using Presentacion.Properties;
using Presentacion.Recursos;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelCliente : Form
    {
        public PanelCliente()
        {
            InitializeComponent();
        }

        LogicaCliente logicaCliente = new LogicaCliente();

        private void PanelCliente_Load(object sender, EventArgs e)
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

            LogicaCliente logicaCliente = new LogicaCliente();
            List<Cliente> clientes = logicaCliente.Listar();
            //Llenar tabla
            foreach (var item in clientes)
            {
                DatosCliente.Rows.Add(new object[] {"",item.IdCliente,item.Documento,item.NombreCompleto,
                item.Correo,item.Telefono,item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "Inactivo" });
            }
        }

        private void Registrar_Editar_Cliente()
        {
            string mensaje = string.Empty;

            Cliente Cliente = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)boxEstado.SelectedItem).valor) == 1 ? true : false
            };

            if (Cliente.IdCliente == 0)
            {

                DialogResult dialogo = MessageBox.Show("¿Desea agregar este nuevo cliente?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Registrar
                    int IdClienteGenerado = logicaCliente.Registrar(Cliente, out mensaje);

                    if (IdClienteGenerado != 0)
                    {
                        DatosCliente.Rows.Add(new object[] {"",IdClienteGenerado,txtDocumento.Text,txtNombre.Text,
                         txtCorreo.Text,txtTelefono.Text,((OpcionCombo)boxEstado.SelectedItem).valor.ToString(),
                         ((OpcionCombo)boxEstado.SelectedItem).texto.ToString()});

                        Limpiar();
                        MessageBox.Show("Cliente agregado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Desea editar este Cliente?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Editar
                    bool resultado = new LogicaCliente().Editar(Cliente, out mensaje);
                    if (resultado)
                    {
                        DataGridViewRow row = DatosCliente.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["IdCliente"].Value = txtId.Text;
                        row.Cells["Documento"].Value = txtDocumento.Text;
                        row.Cells["NombreCompleto"].Value = txtNombre.Text;
                        row.Cells["Correo"].Value = txtCorreo.Text;
                        row.Cells["Telefono"].Value = txtTelefono.Text;
                        row.Cells["Estado"].Value = ((OpcionCombo)boxEstado.SelectedItem).valor.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)boxEstado.SelectedItem).texto.ToString();

                        Limpiar();
                        MessageBox.Show("Cliente editado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EliminarCliente()
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                string mensaje = string.Empty;

                DialogResult dialogo = MessageBox.Show("¿Desea eliminar este Cliente?",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {


                    Cliente Cliente = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new LogicaCliente().Eliminar(Cliente, out mensaje);

                    if (respuesta)
                    {
                        DatosCliente.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                        Limpiar();
                        MessageBox.Show("Cliente eliminado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            boxEstado.SelectedIndex = 0;
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
            Registrar_Editar_Cliente();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }

        private void DatosCliente_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void DatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatosCliente.Columns[e.ColumnIndex].Name == "btnSeleccion")
                {

                    int indice = e.RowIndex;


                    if (indice >= 0)
                    {
                        if (e.RowIndex < 0)
                            return;
                        if (e.ColumnIndex == 0)
                        {
                            txtIndice.Text = indice.ToString();
                            txtId.Text = DatosCliente.Rows[indice].Cells["IdCliente"].Value.ToString();
                            txtDocumento.Text = DatosCliente.Rows[indice].Cells["Documento"].Value.ToString();
                            txtNombre.Text = DatosCliente.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                            txtCorreo.Text = DatosCliente.Rows[indice].Cells["Correo"].Value.ToString();
                            txtTelefono.Text = DatosCliente.Rows[indice].Cells["Telefono"].Value.ToString();

                            foreach (OpcionCombo oc in boxEstado.Items)
                            {

                                if (oc.texto == Convert.ToString(DatosCliente.Rows[indice].Cells["EstadoValor"].Value))
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

        private void DatosCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.DatosCliente.Columns[e.ColumnIndex].Name == "EstadoValor")
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

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltrarBusqueda();
        }

        private void btnLimpiarConsulta_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            List<Cliente> clientes = logicaCliente.Listar();
            foreach (var item in clientes)
            {
                DatosCliente.Rows.Add(new object[] {"",item.IdCliente,item.Documento,item.NombreCompleto,
                item.Correo,item.Telefono,item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "Inactivo" });
            }
        }
    }
}