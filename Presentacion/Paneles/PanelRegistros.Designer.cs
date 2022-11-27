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
            this.registros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Contenedor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registros
            // 
            this.registros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.registros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registros.FlatAppearance.BorderSize = 0;
            this.registros.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.registros.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registros.ForeColor = System.Drawing.Color.White;
            this.registros.Image = global::Presentacion.Properties.Resources.carpetica;
            this.registros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registros.Location = new System.Drawing.Point(13, 13);
            this.registros.Margin = new System.Windows.Forms.Padding(4);
            this.registros.Name = "registros";
            this.registros.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.registros.Size = new System.Drawing.Size(120, 45);
            this.registros.TabIndex = 21;
            this.registros.Text = " Ventas";
            this.registros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.registros.UseVisualStyleBackColor = false;
            this.registros.Click += new System.EventHandler(this.ventas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Presentacion.Properties.Resources.carpetica;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(141, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 22;
            this.button1.Text = " Compras";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ventas_Click);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registros);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelRegistros";
            this.Text = "PanelRegistros";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Contenedor;
    }
}