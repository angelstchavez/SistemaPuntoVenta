using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Presentacion.Paneles
{
    public partial class PanelAcercaDe : Form
    {
        public PanelAcercaDe()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gitCarlos_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Cgarias");
        }

        private void gitAngel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/angelstchavez");
        }

        private void logoUpc_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.unicesar.edu.co/index.php/es/");
        }
    }
}
