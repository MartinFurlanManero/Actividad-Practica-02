using Facturacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Datos
{
    public interface IFacturaRepositorio
    {
        bool Save(Factura factura);
        List<Factura> GetAll();
        Factura? GetById(int id);
    }
}
