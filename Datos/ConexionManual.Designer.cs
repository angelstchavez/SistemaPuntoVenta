namespace Datos
{
    partial class ConexionManual
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
            this.btnGenerarCadena = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtConexionString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarCadena
            // 
            this.btnGenerarCadena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnGenerarCadena.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarCadena.FlatAppearance.BorderSize = 0;
            this.btnGenerarCadena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(144)))));
            this.btnGenerarCadena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(144)))));
            this.btnGenerarCadena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarCadena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarCadena.ForeColor = System.Drawing.Color.White;
            this.btnGenerarCadena.Location = new System.Drawing.Point(411, 98);
            this.btnGenerarCadena.Name = "btnGenerarCadena";
            this.btnGenerarCadena.Size = new System.Drawing.Size(241, 30);
            this.btnGenerarCadena.TabIndex = 0;
            this.btnGenerarCadena.Text = "Generar cadena de conexión";
            this.btnGenerarCadena.UseVisualStyleBackColor = false;
            this.btnGenerarCadena.Click += new System.EventHandler(this.btnGenerarCadena_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(658, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtConexionString
            // 
            this.txtConexionString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtConexionString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConexionString.ForeColor = System.Drawing.Color.Silver;
            this.txtConexionString.Location = new System.Drawing.Point(14, 66);
            this.txtConexionString.Name = "txtConexionString";
            this.txtConexionString.Size = new System.Drawing.Size(638, 26);
            this.txtConexionString.TabIndex = 2;
            this.txtConexionString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(641, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Se creará un archivo que contendra tu conexion Encryptada y su conexión será más " +
    "segura.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese la cadena de conexión LOCAL";
            // 
            // ConexionManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(784, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConexionString);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGenerarCadena);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 180);
            this.MinimumSize = new System.Drawing.Size(800, 180);
            this.Name = "ConexionManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConexionManual";
            this.Load += new System.EventHandler(this.ConexionManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarCadena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtConexionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}