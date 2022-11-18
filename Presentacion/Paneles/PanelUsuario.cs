using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Entidad.Roles;
using Logica.Logica.Roles;
using Presentacion.Properties;
using Presentacion.Recursos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelUsuario : Form
    {
        public PanelUsuario()
        {
            InitializeComponent();
        }

        #region LOAD
        private void PanelUsuario_Load(object sender, System.EventArgs e)
        {
            LlenarDatos();
        }
        #endregion

        #region FUNCIONES
        private void LlenarDatos()
        {
            boxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            boxEstado.Items.Add(new OpcionCombo() { valor = 2, texto = "Inactivo" });
            boxEstado.DisplayMember = "Texto";
            boxEstado.ValueMember = "valor";
            boxEstado.SelectedIndex = 0;

            LogicaRol logicaRol = new LogicaRol();
            List<Rol> roles = logicaRol.Listar();

            //Lennar el box de roles
            foreach (var item in roles)
            {
                boxRol.Items.Add(new OpcionCombo() { valor = 0, texto = item.Descripcion });
            }
            boxRol.DisplayMember = "Texto";
            boxRol.ValueMember = "valor";
            boxRol.SelectedIndex = 0;

            //Lennar el box de consulta
            foreach (DataGridViewColumn item in DatosUsuario.Columns)
            {
                if (item.Visible)
                {
                    boxConsulta.Items.Add(new OpcionCombo() { valor = item.Name, texto = item.HeaderText });
                }
            }
            boxConsulta.DisplayMember = "Texto";
            boxConsulta.ValueMember = "valor";
            boxConsulta.SelectedIndex = 0;

            LogicaUsuario logicaUsuario = new LogicaUsuario();
            List<Usuario> usuarios = logicaUsuario.Listar();

            //Llenar tabla
            foreach (var item in usuarios)
            {
                DatosUsuario.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,
                item.Correo,item.Contraseña,item.ObJRol.IdRol, item.ObJRol.Descripcion,item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "Inactivo" });
            }

        }
        private void AgregarUsuario()
        {
            DatosUsuario.Rows.Add(new object[] {"",txtId.Text,txtIdentificacion.Text,txtNombre.Text,
                txtCorreo.Text,txtConfContraseña.Text,((OpcionCombo)boxRol.SelectedItem).valor.ToString(),
            ((OpcionCombo)boxRol.SelectedItem).texto.ToString(),
            ((OpcionCombo)boxEstado.SelectedItem).valor.ToString(),
            ((OpcionCombo)boxEstado.SelectedItem).texto.ToString()});

            Limpiar();
            MessageBox.Show("Usuario agregado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            txtId.Text = "0";
            txtIndice.Text = "-1";
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtConfContraseña.Text = "";
            boxRol.SelectedIndex = 0;
            boxEstado.SelectedIndex = 0;
        }
        #endregion

        #region BOTONES
        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            AgregarUsuario();
        }

        private void BtnEditar_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }
        #endregion

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        #region EVENTOS CLIC
        private void KeyConfPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
            txtConfContraseña.UseSystemPasswordChar = false;
        }

        private void KeyConfPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            txtConfContraseña.UseSystemPasswordChar = true;
        }
        #endregion

        private void DatosUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void DatosUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (DatosUsuario.Columns[e.ColumnIndex].Name == "btnSeleccion")
                {
                    
                    int indice = e.RowIndex;


                    if (indice >= 0)
                    {
                        if (e.RowIndex < 0)
                            return;
                        if (e.ColumnIndex == 0)
                        {
                            txtIndice.Text = indice.ToString();
                            txtId.Text = DatosUsuario.Rows[indice].Cells["IdUsuario"].Value.ToString();
                            txtIdentificacion.Text = DatosUsuario.Rows[indice].Cells["Documento"].Value.ToString();
                            txtNombre.Text = DatosUsuario.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                            txtCorreo.Text = DatosUsuario.Rows[indice].Cells["Correo"].Value.ToString();
                            txtContraseña.Text = DatosUsuario.Rows[indice].Cells["Clave"].Value.ToString();
                            txtConfContraseña.Text = DatosUsuario.Rows[indice].Cells["Clave"].Value.ToString();

                            foreach (OpcionCombo oc in boxRol.Items)
                            {

                                if (oc.texto == Convert.ToString(DatosUsuario.Rows[indice].Cells["Rol"].Value))
                                {
                                    int indiceBoxRol = boxRol.Items.IndexOf(oc);
                                    boxRol.SelectedIndex = indiceBoxRol;
                                    break;
                                }
                            }

                            foreach (OpcionCombo oc in boxEstado.Items)
                            {

                                if (oc.texto == Convert.ToString(DatosUsuario.Rows[indice].Cells["EstadoValor"].Value))
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
    }
}
