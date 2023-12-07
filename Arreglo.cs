using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionU1y2
{
     public class Arreglo
     {
        Producto[] producto = new Producto[10];
       
        public void Insertar(Producto valor,int posicion )
        {
            if(posicion < - 1 || posicion > producto.Length)
            {
                Console.WriteLine("Ingrese el formato correcto");
            }
            Console.WriteLine($"El producto con el nombre {valor.Nombre} y el precio {valor.Precio} se ingreso correctamente");
            producto[posicion] = valor;
        }
        public void OrdenerCreciente()
        {
            for(int i= 0; i<producto.Length - 1 ;i++)
            {
                for(int j = 0; j< producto.Length - i - j; j++)
                {
                    if (producto[j]?.Precio < producto[j + 1]?.Precio)
                    {
                        Producto temp = producto[j];
                        producto[j] = producto[j + 1];
                        producto[j + 1] = temp;
                    }
                }
            }
        }
        public void MostrarDatos()
        {
            for(int i = 0; i < producto.Length;i++)
            {
                Console.WriteLine($"Posicion{i}: {producto[i]}");
            }
        }
        //public void BuscarPrecio(int precio)
        //{
        //   if(producto.Precio)
            
        //}
    }
    
}
