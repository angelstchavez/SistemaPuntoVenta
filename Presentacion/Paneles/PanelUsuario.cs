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
        LogicaUsuario logicaUsuario = new LogicaUsuario();
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
                boxRol.Items.Add(new OpcionCombo() { valor = item.IdRol, texto = item.Descripcion });
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
            Registrar_Editar_Usuario();
        }
        private void Limpiar()
        {
            txtId.Text = "0";
            txtIndice.Text = "-1";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtConfContraseña.Text = "";
            boxRol.SelectedIndex = 0;
            boxEstado.SelectedIndex = 0;
        }
        private void Registrar_Editar_Usuario()
        {
            string mensaje = string.Empty;

            Usuario usuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombre.Text,
                Correo = txtCorreo.Text,
                Contraseña = txtConfContraseña.Text,
                ObJRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)boxRol.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OpcionCombo)boxEstado.SelectedItem).valor) == 1 ? true : false
            };


            if (usuario.IdUsuario == 0)
            {

                DialogResult dialogo = MessageBox.Show("¿Desea agregar este nuevo usuario?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Registrar
                    int IdUsuarioGenerado = logicaUsuario.Registrar(usuario, out mensaje);

                    if (IdUsuarioGenerado != 0)
                    {
                        DatosUsuario.Rows.Add(new object[] {"",IdUsuarioGenerado,txtDocumento.Text,txtNombre.Text,
                txtCorreo.Text,txtConfContraseña.Text,((OpcionCombo)boxRol.SelectedItem).valor.ToString(),
            ((OpcionCombo)boxRol.SelectedItem).texto.ToString(),
            ((OpcionCombo)boxEstado.SelectedItem).valor.ToString(),
            ((OpcionCombo)boxEstado.SelectedItem).texto.ToString()});

                        Limpiar();
                        MessageBox.Show("Usuario agregado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else
            {
                DialogResult dialogo = MessageBox.Show("¿Desea editar este usuario?",
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {
                    //Editar
                    bool resultado = new LogicaUsuario().Editar(usuario, out mensaje);
                    if (resultado)
                    {
                        DataGridViewRow row = DatosUsuario.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["IdUsuario"].Value = txtId.Text;
                        row.Cells["Documento"].Value = txtDocumento.Text;
                        row.Cells["NombreCompleto"].Value = txtNombre.Text;
                        row.Cells["Correo"].Value = txtCorreo.Text;
                        row.Cells["Clave"].Value = txtConfContraseña.Text;
                        row.Cells["Rol"].Value = ((OpcionCombo)boxRol.SelectedItem).texto.ToString();
                        row.Cells["IdRol"].Value = ((OpcionCombo)boxRol.SelectedItem).valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)boxEstado.SelectedItem).valor.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)boxEstado.SelectedItem).texto.ToString();

                        Limpiar();
                        MessageBox.Show("Usuario editado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void EliminarUsuario()
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                string mensaje = string.Empty;

                DialogResult dialogo = MessageBox.Show("¿Desea eliminar este usuario?",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.No) { }
                else
                {


                    Usuario usuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new LogicaUsuario().Eliminar(usuario, out mensaje);

                    if (respuesta)
                    {
                        DatosUsuario.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                        Limpiar();
                        MessageBox.Show("Usuario eliminado exitosamente.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void FiltroBusqueda()
        {
            try
            {
                string ColumnaFiltro = ((OpcionCombo)boxConsulta.SelectedItem).texto.ToString();

                if (DatosUsuario.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DatosUsuario.Rows)
                    {
                        if (row.Cells[ColumnaFiltro].Value.ToString().Trim().ToUpperInvariant().Contains(txtConsultar.Text.Trim().ToUpper()))
                        { row.Visible = true; }
                        else { row.Visible = false; }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion

        #region BOTONES
        private void BtnAgregar_Click(object sender, System.EventArgs e)
        {
            AgregarUsuario();
        }
        private void BtnEliminar_Click(object sender, System.EventArgs e)
        {
            EliminarUsuario();
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
                            txtDocumento.Text = DatosUsuario.Rows[indice].Cells["Documento"].Value.ToString();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FiltroBusqueda();
        }

        private void btnLimpiarConsulta_Click(object sender, EventArgs e)
        {
            txtConsultar.Text = "";
            foreach (DataGridViewRow row in DatosUsuario.Rows)
            {
                row.Visible = true;
            }
        }

        private void txtConsultar_KeyPress(object sender, KeyPressEventArgs e)
        {
            FiltroBusqueda();
        }

        private void DatosUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DatosUsuario.Columns[e.ColumnIndex].Name == "EstadoValor")
            {
                if(Convert.ToString(e.Value) == "Activo")
                {
                    e.CellStyle.BackColor = Color.FromArgb(15, 140, 59);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(255, 23, 23);
                }
            }
        }
    }
}
