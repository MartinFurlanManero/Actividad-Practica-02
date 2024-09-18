using Facturacion.Datos;
using Facturacion.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Servcios
{
    public interface IArticuloManager
    {
        List<Articulo> GetArticulos();
        public Articulo GetArticuloById(int id);
        public bool DeleteArticulo(int id);
        public bool SaveArticulo(Articulo articulo);
        bool UpdateArticulo(Articulo oArticulo);
    }
}
