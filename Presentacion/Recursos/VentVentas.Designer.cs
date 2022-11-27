namespace Presentacion.Recursos
{
    partial class VentVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.documentoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.montoPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.montoCambio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.montoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DatosVentas = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatosVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar ventas registradas:";
            // 
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultar.ForeColor = System.Drawing.Color.Gray;
            this.txtConsultar.Location = new System.Drawing.Point(817, 12);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(150, 26);
            this.txtConsultar.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(690, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "No.  documento:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = global::Presentacion.Properties.Resources.buscar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.Location = new System.Drawing.Point(973, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 26);
            this.btnConsultar.TabIndex = 45;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // fecha
            // 
            this.fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.Color.DarkOrange;
            this.fecha.Location = new System.Drawing.Point(18, 89);
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Size = new System.Drawing.Size(175, 26);
            this.fecha.TabIndex = 47;
            this.fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Fecha:";
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoDocumento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoDocumento.ForeColor = System.Drawing.Color.DarkOrange;
            this.tipoDocumento.Location = new System.Drawing.Point(18, 155);
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.ReadOnly = true;
            this.tipoDocumento.Size = new System.Drawing.Size(175, 26);
            this.tipoDocumento.TabIndex = 50;
            this.tipoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tipo documento:";
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.DarkOrange;
            this.usuario.Location = new System.Drawing.Point(18, 217);
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Size = new System.Drawing.Size(175, 26);
            this.usuario.TabIndex = 52;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(15, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Usuario:";
            // 
            // documentoCliente
            // 
            this.documentoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.documentoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.documentoCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentoCliente.ForeColor = System.Drawing.Color.DarkOrange;
            this.documentoCliente.Location = new System.Drawing.Point(18, 337);
            this.documentoCliente.Name = "documentoCliente";
            this.documentoCliente.ReadOnly = true;
            this.documentoCliente.Size = new System.Drawing.Size(175, 26);
            this.documentoCliente.TabIndex = 54;
            this.documentoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(15, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Documento cliente:";
            // 
            // montoPago
            // 
            this.montoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.montoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.montoPago.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoPago.ForeColor = System.Drawing.Color.DarkOrange;
            this.montoPago.Location = new System.Drawing.Point(18, 393);
            this.montoPago.Name = "montoPago";
            this.montoPago.ReadOnly = true;
            this.montoPago.Size = new System.Drawing.Size(175, 26);
            this.montoPago.TabIndex = 56;
            this.montoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(15, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Monto total:";
            // 
            // montoCambio
            // 
            this.montoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.montoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.montoCambio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoCambio.ForeColor = System.Drawing.Color.DarkOrange;
            this.montoCambio.Location = new System.Drawing.Point(18, 458);
            this.montoCambio.Name = "montoCambio";
            this.montoCambio.ReadOnly = true;
            this.montoCambio.Size = new System.Drawing.Size(175, 26);
            this.montoCambio.TabIndex = 58;
            this.montoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(15, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 57;
            this.label7.Text = "Monto cambio:";
            // 
            // montoTotal
            // 
            this.montoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.montoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.montoTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.montoTotal.Location = new System.Drawing.Point(18, 519);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Size = new System.Drawing.Size(175, 26);
            this.montoTotal.TabIndex = 60;
            this.montoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(15, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 59;
            this.label8.Text = "Monto pago:";
            // 
            // DatosVentas
            // 
            this.DatosVentas.AllowUserToAddRows = false;
            this.DatosVentas.AllowUserToDeleteRows = false;
            this.DatosVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatosVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DatosVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DatosVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosVentas.DefaultCellStyle = dataGridViewCellStyle5;
            this.DatosVentas.EnableHeadersVisualStyles = false;
            this.DatosVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.DatosVentas.Location = new System.Drawing.Point(212, 74);
            this.DatosVentas.Name = "DatosVentas";
            this.DatosVentas.ReadOnly = true;
            this.DatosVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DatosVentas.RowHeadersWidth = 20;
            this.DatosVentas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DatosVentas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DatosVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DatosVentas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.DatosVentas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosVentas.Size = new System.Drawing.Size(851, 441);
            this.DatosVentas.TabIndex = 61;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 120.5584F;
            this.Producto.HeaderText = "PRODUCTO";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.FillWeight = 120.5584F;
            this.PrecioCompra.HeaderText = "PRECIO";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 120.5584F;
            this.Cantidad.HeaderText = "CANTIDAD";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.FillWeight = 120.5584F;
            this.SubTotal.HeaderText = "SUBTOTAL";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // nombreCliente
            // 
            this.nombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCliente.ForeColor = System.Drawing.Color.DarkOrange;
            this.nombreCliente.Location = new System.Drawing.Point(18, 276);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.ReadOnly = true;
            this.nombreCliente.Size = new System.Drawing.Size(175, 26);
            this.nombreCliente.TabIndex = 64;
            this.nombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(15, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "Nombre cliente:";
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.White;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(33)))), ((int)(((byte)(25)))));
            this.btnReporte.Image = global::Presentacion.Properties.Resources.pdf;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.Location = new System.Drawing.Point(887, 521);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(176, 29);
            this.btnReporte.TabIndex = 66;
            this.btnReporte.Text = "Descargar reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(33)))), ((int)(((byte)(25)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::Presentacion.Properties.Resources.codigo_limpio;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(212, 521);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(179, 29);
            this.btnLimpiar.TabIndex = 67;
            this.btnLimpiar.Text = "Limpiar busqueda";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(209, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 18);
            this.label9.TabIndex = 62;
            this.label9.Text = "Productos vendidos:";
            // 
            // VentVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1075, 559);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DatosVentas);
            this.Controls.Add(this.montoTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.montoCambio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.montoPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.documentoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipoDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentVentas";
            this.Text = "VentVentas";
            this.Load += new System.EventHandler(this.VentVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox documentoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox montoPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox montoCambio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox montoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DatosVentas;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label9;
    }
}