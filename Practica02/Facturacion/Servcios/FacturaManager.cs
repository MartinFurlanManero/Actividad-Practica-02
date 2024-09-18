using Facturacion.Datos;
using Facturacion.Datos.Implementaciones;
using Facturacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Servcios
{
    public class FacturaManager
    {
        private IFacturaRepositorio _repositorio;

        public FacturaManager()
        {
            _repositorio = new FacturaRepositorio();
        }

        public List<Factura> GetFacturas()
        {
            return _repositorio.GetAll();
        }

        public Factura? GetFacturaById(int id)
        {
            return _repositorio.GetById(id);
        }

        public bool SaveFactura(Factura factura)
        {
            return _repositorio.Save(factura);
        }
    }
}
