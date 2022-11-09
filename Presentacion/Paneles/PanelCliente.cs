using Entidad.Roles;
using Logica.Implementaciones.Roles;
using SpreadsheetLight;
using System;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelCliente : Form
    {
        public PanelCliente()
        {
            InitializeComponent();
        }

        #region LOAD
        public static ClienteImpl clienteImpl = new ClienteImpl();
        int posicion = 0;
        private void PanelCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        #endregion

        #region BOTONES
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (clienteImpl.ListarClientes().Count == 0)
            {
                MessageBox.Show("No hay clientes registrados.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (posicion < 0)
                {
                    MessageBox.Show("Seleccione un registro.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LocalizarRegistro(clienteImpl.ListarClientes()[posicion]);
                    EliminarCliente();
                }
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {

        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        #endregion

        #region FUNCIONES
        private void CrearCliente()
        {
            //Creamos la categoria
            Cliente cliente = new Cliente();

            //Este valor se toma del campo de texto
            cliente.Nombres = txtNombres.Text.ToUpperInvariant();
            cliente.Apellidos = txtApellidos.Text.ToUpperInvariant();
            cliente.NumeroDocumento = txtDocumento.Text.ToUpperInvariant();
            cliente.Correo = txtCorreo.Text.ToUpperInvariant();
            cliente.Telefono = txtTelefono.Text.ToUpperInvariant();
            //categoria.Id = (categoriaImpl.ListarCategorias().Count + 1);

            //Estos valores se ponen por defecto
            Random numeroRandom = new Random();
            cliente.Id = numeroRandom.Next(0, 1000000);
            cliente.FechaRegistro = DateTime.Today.ToShortDateString().ToString();
            cliente.Estado = true;

            //La agregamos al archivo
            clienteImpl.AgregarCliente(cliente);

            //Actualizamos la tabla de registros para que aparezca el registro en la tabla
            Datos.DataSource = null;
            Datos.DataSource = clienteImpl.ListarClientes();
        }
        private bool ValidarCamposVacios()
        {
            if (txtNombres.Text == "")
            {
                MessageBox.Show("El campo de nombres está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombres.Focus();
                return true;
            }
            else if (txtApellidos.Text == "")
            {
                MessageBox.Show("El campo de apellidos está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellidos.Focus();
                return true;
            }
            else if (txtDocumento.Text == "")
            {
                MessageBox.Show("El campo de documento está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumento.Focus();
                return true;
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("El campo de correo está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                return true;
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("El campo de teléfono está vacio.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Focus();
                return true;
            }
            else
            {
                //No hay campos vacíos
                return false;
            }
        }
        private void AgregarCliente()
        {
            /* Si el botón dice "Agregar" entonces empieza el proceso de agregación.
                Caso contrario, si NO dice "agregar", entonces significa que el usuario va a editar.
             */
            if (BtnAgregar.Text == "Agregar")
            {
                try
                {
                    //Validamos si hay campos vacios
                    if (ValidarCamposVacios() == true)
                    { 

                    }
                    else
                    {
                        //Le preguntamos si quiere agregar la categoría
                        DialogResult resultado = MessageBox.Show("Desea agregar el cliente "
                        + txtNombres.Text.ToUpperInvariant() + " " + txtApellidos.Text.ToUpperInvariant() + " al registro?", "Mensaje del sistema",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        //sI dice que si, empieza el proceso de agregación
                        if (resultado == DialogResult.Yes)
                        {
                            bool clienteExistente = false;

                            //Validamos si ese cliente ya se encuentra registrado
                            foreach (var item in clienteImpl.ListarClientes())
                            {
                                if (item.NumeroDocumento.ToString() == txtDocumento.Text.ToUpperInvariant())
                                {
                                    clienteExistente = true;
                                    break;

                                }
                            }

                            //Si ya existe entonces le avisamos al usuario que ya existe esa categoria.
                            if (clienteExistente)
                            {
                                MessageBox.Show("El cliente " + txtNombres.Text.ToUpperInvariant() + " " + txtApellidos.Text.ToUpperInvariant()
                                    + " ya se encuentra registrada.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Creamos la categoría
                                CrearCliente();

                                //Reseteamos la configuración
                                LimpiarCampos();

                                MessageBox.Show("Cliente creado exitosamente.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Actualizamos el contador
                                TxContador.Text = "Registros: " + clienteImpl.ListarClientes().Count;
                            }
                        }
                        else
                        {
                            //Si el usuario se arrepiente, le mandanos este mensaje.
                            MessageBox.Show("Proceso cancelado.", "Mensaje del sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //ModificarCategoria();
            }
        }
        private void LimpiarCampos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDocumento.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }
        private void CargarDatos()
        {
            //Inicio el contador
            TxContador.Text = "Registros: " + clienteImpl.ListarClientes().Count;

            //Cargo los registros en la tabla
            Datos.DataSource = clienteImpl.ListarClientes();
        }
        private void EliminarCliente()
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el cliente "
                + Datos[1, posicion].Value + " del registro?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    clienteImpl.EliminarCliente(clienteImpl.ListarClientes()[posicion]);

                    MessageBox.Show("Cliente eliminado correctamente.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Datos.DataSource = null;
                    Datos.DataSource = clienteImpl.ListarClientes();
                    TxContador.Text = "Registros: " + clienteImpl.ListarClientes().Count;
                }
                else
                {
                    LimpiarCampos();
                    MessageBox.Show("Proceso cancelado.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportarExcel()
        {
            if (clienteImpl.ListarClientes().Count == 0)
            {
                MessageBox.Show("No existen registros para exportar.", "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    //Objeto que permite crear el ecxel (Se utilizó una librería externa llamada SpreadSheetLigth)
                    SLDocument sL = new SLDocument();

                    //Le da estilos a el archivo excel
                    SLStyle sLStyle = new SLStyle();
                    sLStyle.Font.FontSize = 12;
                    sLStyle.Font.Bold = true;

                    //Recorre las columnas
                    int iColumn = 1;
                    foreach (DataGridViewColumn column in Datos.Columns)
                    {
                        sL.SetCellValue(1, iColumn, column.HeaderText.ToString());
                        sL.SetCellStyle(1, iColumn, sLStyle);
                        iColumn++;
                    }

                    //Recorre las filas
                    int irow = 2;
                    foreach (DataGridViewRow row in Datos.Rows)
                    {
                        sL.SetCellValue(irow, 1, row.Cells[0].Value.ToString());
                        sL.SetCellValue(irow, 2, row.Cells[1].Value.ToString());
                        sL.SetCellValue(irow, 3, row.Cells[2].Value.ToString());
                        sL.SetCellValue(irow, 4, row.Cells[3].Value.ToString());
                        irow++;
                    }

                    //Guarda el archivo
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Title = "Guardar archivo";
                    saveFileDialog1.CheckPathExists = true;
                    saveFileDialog1.DefaultExt = "xlsx";
                    saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        sL.SaveAs(saveFileDialog1.FileName);
                        MessageBox.Show("¡Archivo exportado con exito!", "Mensaje del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FiltrarBusqueda()
        {
            if (txtConsultar.Text != "")
            {
                //Tabla
                Datos.CurrentCell = null;

                foreach (DataGridViewRow row in Datos.Rows) { row.Visible = false; }

                foreach (DataGridViewRow row in Datos.Rows)
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
                Datos.DataSource = null;
                Datos.DataSource = clienteImpl.ListarClientes();
            }
        }
        private void LocalizarRegistro(Cliente cliente)
        {
            txtNombres.Text = cliente.Nombres;
            txtApellidos.Text = cliente.Apellidos;
            txtDocumento.Text = cliente.NumeroDocumento;
            txtCorreo.Text = cliente.Correo;
            txtTelefono.Text = cliente.Telefono;
        }
        #endregion

        #region EXTRAS
        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            FiltrarBusqueda();
        }
        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = Datos.CurrentRow.Index;
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
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite numeros.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
        #endregion
    }
}
