using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelRegistros : Form
    {
        public PanelRegistros()
        {
            InitializeComponent();
        }

        private void AbrirNuevoPanel(Form formHijo)
        {
            while (Contenedor.Controls.Count > 0) { Contenedor.Controls.RemoveAt(0); }
            Form fh = formHijo;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            Contenedor.Controls.Clear();
            Contenedor.Controls.Add(fh);
            Contenedor.Tag = fh;
            fh.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            AbrirNuevoPanel(new Recursos.VentVentas());
            ventas.BackColor = Color.DarkOrange;
            ventas.ForeColor = Color.Black;
            compras.BackColor = Color.FromArgb(20, 20, 20);
            compras.ForeColor = Color.White;
        }

        private void compras_Click(object sender, EventArgs e)
        {
            AbrirNuevoPanel(new Recursos.VentCompras());
            compras.BackColor = Color.DarkOrange;
            compras.ForeColor = Color.Black;

            ventas.BackColor = Color.FromArgb(20, 20, 20);
            ventas.ForeColor = Color.White;
        }
    }
}
