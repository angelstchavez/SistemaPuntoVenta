using Datos.Datos.Registros;
using Entidad.Registros;
using System.Data;

namespace Logica.Logica.Registros
{
    public class LogicaCompra
    {
        private DatosCompra datosCompra = new DatosCompra();

        public int ObtenerCorrelativo()
        {
            return datosCompra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra compra, DataTable detalleCompra, out string mensaje)
        {
            return datosCompra.RegistrarCompra(compra, detalleCompra, out mensaje);
        }
    }
}
