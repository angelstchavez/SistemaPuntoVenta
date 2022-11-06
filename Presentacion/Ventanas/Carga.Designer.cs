namespace Presentacion.Ventanas
{
    partial class Carga
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
            this.components = new System.ComponentModel.Container();
            this.Mostrar = new System.Windows.Forms.Timer(this.components);
            this.Ocultar = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraCarga = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TxAño = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mostrar
            // 
            this.Mostrar.Interval = 20;
            this.Mostrar.Tick += new System.EventHandler(this.Mostrar_Tick);
            // 
            // Ocultar
            // 
            this.Ocultar.Interval = 20;
            this.Ocultar.Tick += new System.EventHandler(this.Ocultar_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.oficina;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BarraCarga
            // 
            this.BarraCarga.Location = new System.Drawing.Point(12, 320);
            this.BarraCarga.Name = "BarraCarga";
            this.BarraCarga.Size = new System.Drawing.Size(300, 15);
            this.BarraCarga.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "COMPUNET SYSTEM, ";
            // 
            // TxAño
            // 
            this.TxAño.AutoSize = true;
            this.TxAño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxAño.ForeColor = System.Drawing.Color.White;
            this.TxAño.Location = new System.Drawing.Point(270, 338);
            this.TxAño.Name = "TxAño";
            this.TxAño.Size = new System.Drawing.Size(52, 18);
            this.TxAño.TabIndex = 5;
            this.TxAño.Text = "0000. ";
            // 
            // Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(323, 370);
            this.Controls.Add(this.TxAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraCarga);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Carga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga";
            this.Load += new System.EventHandler(this.Carga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Mostrar;
        private System.Windows.Forms.Timer Ocultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar BarraCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxAño;
    }
}