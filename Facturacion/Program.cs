
using Facturacion.Dominio;
using Facturacion.Servcios;

ArticuloManager manager = new ArticuloManager();

//Insertar Articulos
var articulo = new Articulo()
{
    Codigo = 3,
    Nombre = "Pancho",
    Precio = 1500
};
if (manager.SaveArticulo(articulo))
    Console.WriteLine("Articulo Creado Exitosamente");
else Console.WriteLine("No se ha creado el Articulo");

////Eliminar Articulo
//if (manager.DeleteArticulo(2))
//    Console.WriteLine("Articulo Eliminado");
//else Console.WriteLine("No se ha podido eliminar el Articulo");

//Listar Articulos
List<Articulo> lst = manager.GetArticulos();
if (lst.Count < 0)
    Console.WriteLine("Sin articulos en la BD");
else foreach (var oArticulo in lst)
    {
        Console.WriteLine(oArticulo);
    }

////Insertar Factura

Factura factura = new Factura
{
    Cliente = "Roberto",
    FormaPago = new FormaPago() { Id = 1 }, 
    Detalles = new List<DetalleFactura>
    {
        new DetalleFactura { Articulo = new Articulo { Codigo = 1 }, Cantidad = 4 },
        new DetalleFactura { Articulo = new Articulo { Codigo = 2 }, Cantidad = 2 }
    },
    Fecha = DateTime.Now
};

// Crear una instancia del servicio y llamar al método Save
FacturaManager servicio = new FacturaManager();
bool resultado = servicio.SaveFactura(factura);

// Mostrar el resultado por consola
if (resultado)
{
    Console.WriteLine("La factura se guardó correctamente.");
}
else
{
    Console.WriteLine("Hubo un error al guardar la factura.");
}

//Listar Facturas
List<Factura> lista = servicio.GetFacturas();
if (lista.Count < 0)
    Console.WriteLine("Sin articulos en la BD");
else foreach (var oFactura in lista)
    {
        Console.WriteLine(oFactura);
    }
