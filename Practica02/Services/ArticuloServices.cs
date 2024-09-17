using Practica02.Models;

namespace Practica02.Services
{
    public class ArticuloServices : IAplicacion
    {
        public static List<Articulos> lstArticulos = new List<Articulos>();
        public bool AgregarEditarArticulo(Articulos articulo)
        {
            bool result = false;

            if (articulo != null)
            {
                lstArticulos.Add(articulo);
                result = true;
            }
            return result;
        }

        public List<Articulos> GetArticulo()
        {
            return lstArticulos;
        }

        public bool RegistrarBajaArticulo(int id)
        {
            var articulo = lstArticulos
                .Find(p => p.Codigo == id);

            if (articulo != null)
            {
                lstArticulos.Remove(articulo);
                return true;
            }
            return false;
        }
    }
}
