namespace Presentacion.Paneles
{
    partial class PanelCategoria
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxContador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(89)))));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(76)))));
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(76)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(203, 31);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(90, 26);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(811, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consulta filtrada:";
            // 
            // TxContador
            // 
            this.TxContador.AutoSize = true;
            this.TxContador.ForeColor = System.Drawing.Color.White;
            this.TxContador.Location = new System.Drawing.Point(12, 80);
            this.TxContador.Name = "TxContador";
            this.TxContador.Size = new System.Drawing.Size(92, 18);
            this.TxContador.TabIndex = 6;
            this.TxContador.Text = "Registros: 0";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(938, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 4;
            // 
            // Datos
            // 
            this.Datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(12, 101);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(1076, 427);
            this.Datos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // txtAgregar
            // 
            this.txtAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAgregar.ForeColor = System.Drawing.Color.White;
            this.txtAgregar.Location = new System.Drawing.Point(15, 31);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(150, 26);
            this.txtAgregar.TabIndex = 9;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Image = global::Presentacion.Properties.Resources.limpiar;
            this.BtnLimpiar.Location = new System.Drawing.Point(171, 31);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(26, 26);
            this.BtnLimpiar.TabIndex = 10;
            this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEliminar.FlatAppearance.BorderSize = 0;
            this.BtEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEliminar.ForeColor = System.Drawing.Color.White;
            this.BtEliminar.Image = global::Presentacion.Properties.Resources.eliminar;
            this.BtEliminar.Location = new System.Drawing.Point(902, 534);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(90, 90);
            this.BtEliminar.TabIndex = 3;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtEliminar.UseVisualStyleBackColor = false;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Image = global::Presentacion.Properties.Resources.editar;
            this.BtnActualizar.Location = new System.Drawing.Point(806, 534);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(90, 90);
            this.BtnActualizar.TabIndex = 2;
            this.BtnActualizar.Text = "Editar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExportarExcel.FlatAppearance.BorderSize = 0;
            this.BtnExportarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnExportarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExportarExcel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportarExcel.ForeColor = System.Drawing.Color.White;
            this.BtnExportarExcel.Image = global::Presentacion.Properties.Resources.excel;
            this.BtnExportarExcel.Location = new System.Drawing.Point(12, 534);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnExportarExcel.Size = new System.Drawing.Size(260, 41);
            this.BtnExportarExcel.TabIndex = 7;
            this.BtnExportarExcel.Text = "Exportar registros en excel";
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // BtnReporte
            // 
            this.BtnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BtnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.White;
            this.BtnReporte.Image = global::Presentacion.Properties.Resources.reportes;
            this.BtnReporte.Location = new System.Drawing.Point(998, 534);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(90, 90);
            this.BtnReporte.TabIndex = 1;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // PanelCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1100, 636);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxContador);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.BtnReporte);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PanelCategoria";
            this.Load += new System.EventHandler(this.PanelCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Label TxContador;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}