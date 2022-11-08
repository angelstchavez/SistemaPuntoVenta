using Entidad.Registros;
using Logica.Implementaciones.Registros;
using SpreadsheetLight;
using System;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelServicio : Form
    {
        public PanelServicio()
        {
            InitializeComponent();
        }

        #region LOAD
        ServicioImpl servicioImpl = new ServicioImpl();
        int posicion = 0;
        private void PanelServicio_Load(object sender, EventArgs e)
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
            AgregarServicio();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (servicioImpl.ListarServicios().Count == 0)
                {
                    MessageBox.Show("No hay servicios registrados.", "Mensaje del sistema",
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
                        LocalizarRegistro(servicioImpl.ListarServicios()[posicion]);
                        EliminarServicio();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CargarDatos()
        {
            //Inicio el contador
            TxContador.Text = "Registros: " + servicioImpl.ListarServicios().Count;

            //Cargo los registros en la tabla
            Datos.DataSource = servicioImpl.ListarServicios();
        }
        private void ExportarExcel()
        {
            if (servicioImpl.ListarServicios().Count == 0)
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
                    saveFileDialog1.FileName = string.Format("{0}.pdf", "servicios" + "_" + DateTime.Now.ToString("dd-MM-yyyy"));
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
                Datos.DataSource = servicioImpl.ListarServicios();
            }
        }
        private void EliminarServicio()
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Desea eliminar el servicio "
                + Datos[1, posicion].Value + " del registro?", "Mensaje del sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    servicioImpl.EliminarServicio(servicioImpl.ListarServicios()[posicion]);

                    MessageBox.Show("Servicio eliminado correctamente.", "Mensaje del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Datos.DataSource = null;
                    Datos.DataSource = servicioImpl.ListarServicios();
                    TxContador.Text = "Registros: " + servicioImpl.ListarServicios().Count;
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
        private void LimpiarCampos()
        {
            txtNombreServicio.Text = "";
            txtPrecio.Text = "";
            txtConsultar.Text = "";
        }
        private void CrearServicio()
        {
            //Creamos la categoria
            Servicio servicio = new Servicio();

            //Este valor se toma del campo de texto
            servicio.Nombre = txtNombreServicio.Text.ToUpperInvariant();
            servicio.Precio = decimal.Parse(txtPrecio.Text);

            //categoria.Id = (categoriaImpl.ListarCategorias().Count + 1);

            //Estos valores se ponen por defecto
            Random numeroRandom = new Random();
            servicio.IdServicio = numeroRandom.Next(0, 1000000);
            servicio.FechaRegistro = DateTime.Today.ToShortDateString().ToString();
            servicio.Estado = true;

            //La agregamos al archivo
            servicioImpl.AgregarServicio(servicio);

            //Actualizamos la tabla de registros para que aparezca el registro en la tabla
            Datos.DataSource = null;
            Datos.DataSource = servicioImpl.ListarServicios();
        }
        private void AgregarServicio()
        {
            /* Si el botón dice "Agregar" entonces empieza el proceso de agregación.
                Caso contrario, si NO dice "agregar", entonces significa que el usuario va a editar.
             */
            if (BtnAgregar.Text == "Agregar")
            {
                try
                {
                    //Validamos si hay campos vacios
                    if (txtNombreServicio.Text == "" || txtPrecio.Text == "")
                    {
                        MessageBox.Show("Hay campos vacios.", "Mensaje del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Le preguntamos si quiere agregar el servicio
                        DialogResult resultado = MessageBox.Show("Desea agregar el servicio "
                        + txtNombreServicio.Text.ToUpperInvariant() + " al registro?", "Mensaje del sistema",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        //sI dice que si, empieza el proceso de agregación
                        if (resultado == DialogResult.Yes)
                        {
                            bool categoriaExistente = false;

                            //Validamos si esa categoria ya se encuentra registrada
                            foreach (var item in servicioImpl.ListarServicios())
                            {
                                if (item.Nombre.ToString() == txtNombreServicio.Text.ToUpperInvariant())
                                {
                                    categoriaExistente = true;
                                    break;

                                }
                            }

                            //Si ya existe entonces le avisamos al usuario que ya existe esa categoria.
                            if (categoriaExistente)
                            {
                                MessageBox.Show("El servicio " + txtNombreServicio.Text.ToUpperInvariant()
                                    + " ya se encuentra registrado.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Creamos la categoría
                                CrearServicio();

                                //Reseteamos la configuración
                                LimpiarCampos();

                                MessageBox.Show("Servicio creado exitosamente.", "Mensaje del sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Actualizamos el contador
                                TxContador.Text = "Registros: " + servicioImpl.ListarServicios().Count;
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
        private void LocalizarRegistro(Servicio servicio)
        {
            txtNombreServicio.Text = servicio.Nombre;
        }
        #endregion

        #region EXTRAS
        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = Datos.CurrentRow.Index;
        }

        private void txtConsultar_TextChanged(object sender, EventArgs e)
        {
            FiltrarBusqueda();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
