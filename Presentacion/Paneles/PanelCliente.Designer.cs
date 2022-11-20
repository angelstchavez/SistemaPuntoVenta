namespace Presentacion.Paneles
{
    partial class PanelCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiarConsulta = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.DatosCliente = new System.Windows.Forms.DataGridView();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.boxConsulta = new Presentacion.Recursos.RJComboBox();
            this.boxEstado = new Presentacion.Recursos.RJComboBox();
            this.btnSeleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(614, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "Consultar por:";
            // 
            // txtIndice
            // 
            this.txtIndice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIndice.Location = new System.Drawing.Point(242, 9);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(22, 26);
            this.txtIndice.TabIndex = 22;
            this.txtIndice.Text = "-1";
            this.txtIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndice.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.clientes;
            this.pictureBox1.Location = new System.Drawing.Point(107, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::Presentacion.Properties.Resources.codigo_limpio;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(242, 462);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(29, 29);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtId.Location = new System.Drawing.Point(270, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(22, 26);
            this.txtId.TabIndex = 18;
            this.txtId.Text = "0";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label8.Location = new System.Drawing.Point(19, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Control de clientes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.limpiar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(136, 462);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnEliminar.Size = new System.Drawing.Size(102, 29);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(59)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(59)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::Presentacion.Properties.Resources.salvar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(30, 462);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAgregar.Size = new System.Drawing.Size(102, 29);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label9.Location = new System.Drawing.Point(310, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Lista de clientes registrados:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefono.Location = new System.Drawing.Point(30, 365);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(240, 26);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Location = new System.Drawing.Point(30, 304);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(240, 26);
            this.txtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo:";
            // 
            // btnLimpiarConsulta
            // 
            this.btnLimpiarConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnLimpiarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLimpiarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarConsulta.Image = global::Presentacion.Properties.Resources.codigo_limpio;
            this.btnLimpiarConsulta.Location = new System.Drawing.Point(1060, 11);
            this.btnLimpiarConsulta.Name = "btnLimpiarConsulta";
            this.btnLimpiarConsulta.Size = new System.Drawing.Size(26, 26);
            this.btnLimpiarConsulta.TabIndex = 29;
            this.btnLimpiarConsulta.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(30, 241);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // DatosCliente
            // 
            this.DatosCliente.AllowUserToAddRows = false;
            this.DatosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatosCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DatosCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DatosCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccion,
            this.IdCliente,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Telefono,
            this.Estado,
            this.EstadoValor});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatosCliente.EnableHeadersVisualStyles = false;
            this.DatosCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.DatosCliente.Location = new System.Drawing.Point(314, 43);
            this.DatosCliente.Name = "DatosCliente";
            this.DatosCliente.ReadOnly = true;
            this.DatosCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosCliente.RowHeadersWidth = 20;
            this.DatosCliente.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DatosCliente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DatosCliente.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DatosCliente.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumOrchid;
            this.DatosCliente.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosCliente.Size = new System.Drawing.Size(772, 581);
            this.DatosCliente.TabIndex = 27;
            this.DatosCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosCliente_CellContentClick);
            this.DatosCliente.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DatosCliente_CellPainting);
            // 
            // Datos
            // 
            this.Datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.Datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datos.DefaultCellStyle = dataGridViewCellStyle6;
            this.Datos.EnableHeadersVisualStyles = false;
            this.Datos.GridColor = System.Drawing.Color.Black;
            this.Datos.Location = new System.Drawing.Point(322, 37);
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Datos.RowHeadersWidth = 15;
            this.Datos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Datos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Datos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.Datos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.Datos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datos.Size = new System.Drawing.Size(772, 587);
            this.Datos.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre completo:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.ForeColor = System.Drawing.Color.Gray;
            this.txtDocumento.Location = new System.Drawing.Point(30, 180);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(240, 26);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Documento:";
            // 
            // txtConsultar
            // 
            this.txtConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultar.ForeColor = System.Drawing.Color.Gray;
            this.txtConsultar.Location = new System.Drawing.Point(877, 11);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(177, 26);
            this.txtConsultar.TabIndex = 31;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelLateral.Controls.Add(this.txtIndice);
            this.PanelLateral.Controls.Add(this.pictureBox1);
            this.PanelLateral.Controls.Add(this.btnLimpiar);
            this.PanelLateral.Controls.Add(this.txtId);
            this.PanelLateral.Controls.Add(this.label8);
            this.PanelLateral.Controls.Add(this.btnEliminar);
            this.PanelLateral.Controls.Add(this.btnAgregar);
            this.PanelLateral.Controls.Add(this.label7);
            this.PanelLateral.Controls.Add(this.boxEstado);
            this.PanelLateral.Controls.Add(this.txtTelefono);
            this.PanelLateral.Controls.Add(this.label4);
            this.PanelLateral.Controls.Add(this.txtCorreo);
            this.PanelLateral.Controls.Add(this.label3);
            this.PanelLateral.Controls.Add(this.txtNombre);
            this.PanelLateral.Controls.Add(this.label2);
            this.PanelLateral.Controls.Add(this.txtDocumento);
            this.PanelLateral.Controls.Add(this.label1);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Margin = new System.Windows.Forms.Padding(4);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(300, 636);
            this.PanelLateral.TabIndex = 24;
            // 
            // boxConsulta
            // 
            this.boxConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.boxConsulta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.boxConsulta.BorderSize = 1;
            this.boxConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.boxConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.boxConsulta.ForeColor = System.Drawing.Color.Gray;
            this.boxConsulta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.boxConsulta.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.boxConsulta.ListTextColor = System.Drawing.Color.Gray;
            this.boxConsulta.Location = new System.Drawing.Point(721, 11);
            this.boxConsulta.MinimumSize = new System.Drawing.Size(150, 24);
            this.boxConsulta.Name = "boxConsulta";
            this.boxConsulta.Padding = new System.Windows.Forms.Padding(1);
            this.boxConsulta.Size = new System.Drawing.Size(150, 26);
            this.boxConsulta.TabIndex = 30;
            this.boxConsulta.Texts = "";
            // 
            // boxEstado
            // 
            this.boxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.boxEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.boxEstado.BorderSize = 1;
            this.boxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.boxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.boxEstado.ForeColor = System.Drawing.Color.Gray;
            this.boxEstado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.boxEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.boxEstado.ListTextColor = System.Drawing.Color.Gray;
            this.boxEstado.Location = new System.Drawing.Point(30, 421);
            this.boxEstado.MinimumSize = new System.Drawing.Size(200, 26);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Padding = new System.Windows.Forms.Padding(1);
            this.boxEstado.Size = new System.Drawing.Size(240, 26);
            this.boxEstado.TabIndex = 12;
            this.boxEstado.Texts = "";
            // 
            // btnSeleccion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.btnSeleccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnSeleccion.FillWeight = 19.83354F;
            this.btnSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccion.HeaderText = "";
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "ID";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // Documento
            // 
            this.Documento.FillWeight = 105.2105F;
            this.Documento.HeaderText = "DOCUMENTO";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.FillWeight = 105.2105F;
            this.NombreCompleto.HeaderText = "NOMBRE";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 105.2105F;
            this.Correo.HeaderText = "CORREO";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "TELEFONO";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 89.54315F;
            this.Estado.HeaderText = "ESTADO VALOR";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // EstadoValor
            // 
            this.EstadoValor.FillWeight = 117.497F;
            this.EstadoValor.HeaderText = "ESTADO";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            // 
            // PanelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1100, 636);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLimpiarConsulta);
            this.Controls.Add(this.boxConsulta);
            this.Controls.Add(this.DatosCliente);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.PanelLateral);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelCliente";
            this.Text = "PanelCliente";
            this.Load += new System.EventHandler(this.PanelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.PanelLateral.ResumeLayout(false);
            this.PanelLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private Recursos.RJComboBox boxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarConsulta;
        private Recursos.RJComboBox boxConsulta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView DatosCliente;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
    }
}