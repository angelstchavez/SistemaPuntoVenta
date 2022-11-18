namespace Presentacion.Paneles
{
    partial class PanelMantenimiento
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
            this.PagCategorias = new System.Windows.Forms.TabControl();
            this.PagProductos = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PagCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagCategorias
            // 
            this.PagCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagCategorias.Controls.Add(this.PagProductos);
            this.PagCategorias.Controls.Add(this.tabPage2);
            this.PagCategorias.Location = new System.Drawing.Point(12, 12);
            this.PagCategorias.Name = "PagCategorias";
            this.PagCategorias.SelectedIndex = 0;
            this.PagCategorias.Size = new System.Drawing.Size(1076, 612);
            this.PagCategorias.TabIndex = 0;
            // 
            // PagProductos
            // 
            this.PagProductos.Location = new System.Drawing.Point(4, 27);
            this.PagProductos.Name = "PagProductos";
            this.PagProductos.Padding = new System.Windows.Forms.Padding(3);
            this.PagProductos.Size = new System.Drawing.Size(1068, 581);
            this.PagProductos.TabIndex = 0;
            this.PagProductos.Text = "Productos";
            this.PagProductos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Categorias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1100, 636);
            this.Controls.Add(this.PagCategorias);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanelMantenimiento";
            this.Text = "PanelMantenimiento";
            this.Load += new System.EventHandler(this.PanelMantenimiento_Load);
            this.PagCategorias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PagCategorias;
        private System.Windows.Forms.TabPage PagProductos;
        private System.Windows.Forms.TabPage tabPage2;
    }
}