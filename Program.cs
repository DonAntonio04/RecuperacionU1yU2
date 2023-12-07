namespace RecuperacionU1y2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arreglo arreglo = new Arreglo();
           for(int i = 0; i < 2; i++)
            {
                string nombreProducto;
                bool esNumero;
                do
                {
                    Console.WriteLine($"Ingrese el nombre del producto entre 0 y 10");
                    nombreProducto= Console.ReadLine();
                    esNumero = !nombreProducto.Any(char.IsDigit);    
                    if(!esNumero)
                    {
                        Console.WriteLine("Ingrese el formato correcto");
                    }
                }while(!esNumero );

                int precio;
                bool esLetra;
                do
                {
                    Console.WriteLine("Ingrese el precio del producto");
                    string PRECIO = Console.ReadLine();
                    esLetra = int.TryParse( PRECIO, out precio);
                    if(!esLetra)
                    {
                        Console.WriteLine("Ingrese el precio del producto");
                    }
                }while( !esLetra );

                int posicion;
                bool esNumero2;
                do
                {
                    Console.WriteLine("Ingrese el la posicion del producto precio");
                    string POSICION2 = Console.ReadLine();
                    esNumero2 = int.TryParse( POSICION2, out posicion);
                    if(!esNumero2)
                    {
                        Console.WriteLine("Ingrese el formato correcto");
                    }
                }while(!esNumero2 );


                Producto producto = new Producto(nombreProducto,precio);

                arreglo.Insertar(producto, posicion);
                arreglo.MostrarDatos();
                

                Console.ReadKey();

            }
        }
    }
}