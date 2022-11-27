namespace Presentacion.Paneles
{
    partial class PanelRegistros
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
            this.ventas = new System.Windows.Forms.Button();
            this.compras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contenedor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ventas
            // 
            this.ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ventas.FlatAppearance.BorderSize = 0;
            this.ventas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.ventas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ventas.ForeColor = System.Drawing.Color.White;
            this.ventas.Image = global::Presentacion.Properties.Resources.carpetica;
            this.ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ventas.Location = new System.Drawing.Point(13, 13);
            this.ventas.Margin = new System.Windows.Forms.Padding(4);
            this.ventas.Name = "ventas";
            this.ventas.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ventas.Size = new System.Drawing.Size(120, 45);
            this.ventas.TabIndex = 21;
            this.ventas.Text = " Ventas";
            this.ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ventas.UseVisualStyleBackColor = false;
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // compras
            // 
            this.compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compras.FlatAppearance.BorderSize = 0;
            this.compras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.compras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compras.ForeColor = System.Drawing.Color.White;
            this.compras.Image = global::Presentacion.Properties.Resources.carpetica;
            this.compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compras.Location = new System.Drawing.Point(141, 13);
            this.compras.Margin = new System.Windows.Forms.Padding(4);
            this.compras.Name = "compras";
            this.compras.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.compras.Size = new System.Drawing.Size(120, 45);
            this.compras.TabIndex = 22;
            this.compras.Text = " Compras";
            this.compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.compras.UseVisualStyleBackColor = false;
            this.compras.Click += new System.EventHandler(this.compras_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Contenedor);
            this.panel1.Location = new System.Drawing.Point(13, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 559);
            this.panel1.TabIndex = 23;
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Font = new System.Drawing.Font("Arial", 20F);
            this.Contenedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1073, 557);
            this.Contenedor.TabIndex = 0;
            this.Contenedor.Text = "Seleccione los registros que desea consultar";
            this.Contenedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1100, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.compras);
            this.Controls.Add(this.ventas);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelRegistros";
            this.Text = "PanelRegistros";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.Button compras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Contenedor;
    }
}