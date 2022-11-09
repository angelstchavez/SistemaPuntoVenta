namespace Presentacion.Ventanas
{
    partial class Inicio
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
            this.TxFecha = new System.Windows.Forms.Label();
            this.TxHora = new System.Windows.Forms.Label();
            this.ControlFechaHora = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ventas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.clientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.productos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.servicios = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.categorias = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxFecha
            // 
            this.TxFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxFecha.AutoSize = true;
            this.TxFecha.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TxFecha.Location = new System.Drawing.Point(714, 584);
            this.TxFecha.Name = "TxFecha";
            this.TxFecha.Size = new System.Drawing.Size(150, 32);
            this.TxFecha.TabIndex = 6;
            this.TxFecha.Text = "00/00/0000";
            // 
            // TxHora
            // 
            this.TxHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxHora.AutoSize = true;
            this.TxHora.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxHora.ForeColor = System.Drawing.Color.White;
            this.TxHora.Location = new System.Drawing.Point(566, 531);
            this.TxHora.Name = "TxHora";
            this.TxHora.Size = new System.Drawing.Size(306, 56);
            this.TxHora.TabIndex = 5;
            this.TxHora.Text = "00:00:00 PM";
            // 
            // ControlFechaHora
            // 
            this.ControlFechaHora.Enabled = true;
            this.ControlFechaHora.Tick += new System.EventHandler(this.ControlFechaHora_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ventas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.cierre;
            this.pictureBox2.Location = new System.Drawing.Point(168, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // ventas
            // 
            this.ventas.AutoSize = true;
            this.ventas.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.ventas.ForeColor = System.Drawing.Color.White;
            this.ventas.Location = new System.Drawing.Point(17, 37);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(41, 45);
            this.ventas.TabIndex = 12;
            this.ventas.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ventas registradas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.clientes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(230, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.hombre;
            this.pictureBox3.Location = new System.Drawing.Point(168, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // clientes
            // 
            this.clientes.AutoSize = true;
            this.clientes.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.clientes.ForeColor = System.Drawing.Color.White;
            this.clientes.Location = new System.Drawing.Point(14, 37);
            this.clientes.Name = "clientes";
            this.clientes.Size = new System.Drawing.Size(41, 45);
            this.clientes.TabIndex = 13;
            this.clientes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Clientes registrados";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.productos);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(449, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Presentacion.Properties.Resources.producto;
            this.pictureBox6.Location = new System.Drawing.Point(168, 68);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // productos
            // 
            this.productos.AutoSize = true;
            this.productos.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.productos.ForeColor = System.Drawing.Color.White;
            this.productos.Location = new System.Drawing.Point(16, 37);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(41, 45);
            this.productos.TabIndex = 14;
            this.productos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(19, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Productos registrados";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.servicios);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(672, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 10;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Presentacion.Properties.Resources.servicio;
            this.pictureBox7.Location = new System.Drawing.Point(168, 68);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            // 
            // servicios
            // 
            this.servicios.AutoSize = true;
            this.servicios.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.servicios.ForeColor = System.Drawing.Color.White;
            this.servicios.Location = new System.Drawing.Point(20, 37);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(41, 45);
            this.servicios.TabIndex = 15;
            this.servicios.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Servicios registados";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel5.Controls.Add(this.pictureBox8);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(672, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 16;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Presentacion.Properties.Resources.reporte;
            this.pictureBox8.Location = new System.Drawing.Point(168, 68);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 45);
            this.label5.TabIndex = 15;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(25, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "reportes generados";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(449, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.usuario;
            this.pictureBox4.Location = new System.Drawing.Point(168, 68);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 45);
            this.label7.TabIndex = 14;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(19, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Usuarios registrados";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.categorias);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(230, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 14;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Presentacion.Properties.Resources.categoria;
            this.pictureBox5.Location = new System.Drawing.Point(168, 68);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // categorias
            // 
            this.categorias.AutoSize = true;
            this.categorias.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.categorias.ForeColor = System.Drawing.Color.White;
            this.categorias.Location = new System.Drawing.Point(16, 37);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(41, 45);
            this.categorias.TabIndex = 13;
            this.categorias.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(19, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Categorias registradas";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(12, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.dinero;
            this.pictureBox1.Location = new System.Drawing.Point(168, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(17, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 45);
            this.label11.TabIndex = 12;
            this.label11.Text = "$0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(17, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ganancias registradas";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(884, 636);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxFecha);
            this.Controls.Add(this.TxHora);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxFecha;
        private System.Windows.Forms.Label TxHora;
        private System.Windows.Forms.Timer ControlFechaHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label servicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label categorias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}