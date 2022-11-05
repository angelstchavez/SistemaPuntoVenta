using Datos.Repositorios.Registros;
using Entidad.Registros;
using System.Collections.Generic;
using System;

namespace Logica.Implementaciones.Registros
{
    public class VentaImpl : Servicios.Registros.IServicioVenta
    {
        List<Venta> ventas;
        RepositorioVenta repoVentas;

        public VentaImpl()
        {
            repoVentas = new RepositorioVenta("ventas.dat");
            ventas = repoVentas.GetVentas();
        }

        public bool ActualizarVenta(Venta venta)
        {
            try
            {
                foreach (var item in ventas)
                {
                    if (item.Equals(venta.IdVenta))
                    {
                        item.IdVenta = venta.IdVenta;
                        item.Usuario = venta.Usuario;
                        item.TipoDocumento = venta.TipoDocumento;
                        item.NumeroDocumento = venta.NumeroDocumento;
                        item.DocumentoCliente = venta.DocumentoCliente;
                        item.NombreCliente = venta.NombreCliente;
                        item.MontoPago = venta.MontoPago;
                        item.MontoCambio = venta.MontoCambio;
                        item.MontoTotal = venta.MontoTotal;
                        item.Productos = venta.Productos;
                        item.FechaRegistro = venta.FechaRegistro;
                        break;
                    }
                }
                repoVentas.Update(ventas, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool AgregarVenta(Venta ventas)
        {
            try
            {
                repoVentas.GuardarDatos(ventas);
                this.ventas = repoVentas.GetVentas();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool EliminarVenta(Venta venta)
        {
            try
            {
                ventas.Remove(venta);
                repoVentas.Update(ventas, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Venta> ListarVentas() { return ventas; }
    }
}
