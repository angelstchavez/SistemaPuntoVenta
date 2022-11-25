namespace Presentacion.Recursos
{
    partial class VentProveedor
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
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.btnLimpiarConsulta = new System.Windows.Forms.Button();
            this.DatosProveedor = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtConsultar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsultar.ForeColor = System.Drawing.Color.Gray;
            this.txtConsultar.Location = new System.Drawing.Point(478, 49);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(177, 26);
            this.txtConsultar.TabIndex = 42;
            this.txtConsultar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsultar_KeyPress);
            // 
            // btnLimpiarConsulta
            // 
            this.btnLimpiarConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnLimpiarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLimpiarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarConsulta.Image = global::Presentacion.Properties.Resources.codigo_limpio;
            this.btnLimpiarConsulta.Location = new System.Drawing.Point(661, 49);
            this.btnLimpiarConsulta.Name = "btnLimpiarConsulta";
            this.btnLimpiarConsulta.Size = new System.Drawing.Size(26, 26);
            this.btnLimpiarConsulta.TabIndex = 41;
            this.btnLimpiarConsulta.UseVisualStyleBackColor = false;
            // 
            // DatosProveedor
            // 
            this.DatosProveedor.AllowUserToAddRows = false;
            this.DatosProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatosProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DatosProveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DatosProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.Documento,
            this.RazonSocial});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatosProveedor.DefaultCellStyle = dataGridViewCellStyle5;
            this.DatosProveedor.EnableHeadersVisualStyles = false;
            this.DatosProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.DatosProveedor.Location = new System.Drawing.Point(12, 82);
            this.DatosProveedor.Name = "DatosProveedor";
            this.DatosProveedor.ReadOnly = true;
            this.DatosProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DatosProveedor.RowHeadersWidth = 20;
            this.DatosProveedor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DatosProveedor.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DatosProveedor.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DatosProveedor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Chocolate;
            this.DatosProveedor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DatosProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosProveedor.Size = new System.Drawing.Size(676, 532);
            this.DatosProveedor.TabIndex = 39;
            this.DatosProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosProveedor_CellDoubleClick);
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "ID";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            // 
            // Documento
            // 
            this.Documento.FillWeight = 60.27807F;
            this.Documento.HeaderText = "DOCUMENTO";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.FillWeight = 177.2175F;
            this.RazonSocial.HeaderText = "RAZÓN SOCIAL";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Chocolate;
            this.label9.Location = new System.Drawing.Point(11, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(439, 35);
            this.label9.TabIndex = 38;
            this.label9.Text = "Lista de proveedores activos:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(350, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Consulta filtrada:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.txtConsultar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnLimpiarConsulta);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 623);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Seleccione con doble clic el proveedor.";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(663, 8);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar.TabIndex = 43;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VentProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(700, 623);
            this.Controls.Add(this.DatosProveedor);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentProveedor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VentProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Button btnLimpiarConsulta;
        private System.Windows.Forms.DataGridView DatosProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.Label label1;
    }
}