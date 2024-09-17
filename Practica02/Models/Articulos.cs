namespace Practica02.Models
{
    public class Articulos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return $"Id: {Codigo}, Nombre: {Nombre}, Precio: {Precio}";
        }
    }
}
