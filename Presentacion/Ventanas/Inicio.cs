using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ControlFechaHora_Tick(object sender, EventArgs e)
        {
            TxHora.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            TxFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
