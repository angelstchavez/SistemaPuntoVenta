using Logica.Implementaciones.Registros;
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
    public partial class PanelProducto : Form
    {
        public PanelProducto()
        {
            InitializeComponent();
        }

        public static ProductoImpl productoImpl = new ProductoImpl();

        private void PanelProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
