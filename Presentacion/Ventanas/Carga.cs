using System;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }
        private void Carga_Load(object sender, EventArgs e)
        {
            //Muestra el año actual
            //TxAño.Text = DateTime.Now.Year.ToString() + ".";
            this.Opacity = 0.0;
            Mostrar.Start();
        }

        private void Mostrar_Tick(object sender, EventArgs e)
        {
            //Mostrar gradualmente la ventana
            if (this.Opacity < 1) { this.Opacity += 0.05; }
            //
            BarraCarga.Value += 1;

            if (BarraCarga.Value == 100) { Mostrar.Stop(); Ocultar.Start(); }
        }

        private void Ocultar_Tick(object sender, EventArgs e)
        {
            //Desaparecer gradualmente la ventana
            this.Opacity -= 0.1;
            if (this.Opacity == 0) { Ocultar.Stop(); this.Close(); }
        }
    }
}
