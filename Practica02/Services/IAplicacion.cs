using Practica02.Models;

namespace Practica02.Services
{
    public interface IAplicacion
    {
        List<Articulos> GetArticulo();
        bool AgregarEditarArticulo(Articulos articulo);
        bool RegistrarBajaArticulo(int id);
    }
}
