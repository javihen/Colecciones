using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un objeto de tipo (Clase) Producto
            Producto objP = new Producto();
            //Creamos una coleccion usando ArrayList (La coleccion List<> es similar)
            ArrayList aProducto = new ArrayList();
            //Adicionamos 3 objetos
            objP.setNombre("Impresora");
            objP.setPrecio(35);
            aProducto.Add(objP);

            objP.setNombre("Pantalla");
            objP.setPrecio(50);

            aProducto.Add(objP);
            aProducto.Add(objP);
    
            //Con el metodo  .COUNT de la coleccion ArrayList mostramos el numero de elementos
            Console.WriteLine("Existen "+aProducto.Count+" elementos.");
            //Con el metodo .CLEAR() de la coleccion ArrayList Borramos todos los elementos de la coleccion
            aProducto.Clear();

            //Console.WriteLine("Existen " + aProducto.Count + " elementos.");
            //Insertamos un objeto Producto en la posicion 1, usando el metodo INSERT de la coleccion
            Producto objA = new Producto();
            objA.setNombre("mouse");
            objA.setPrecio(154);

            aProducto.Insert(1,objA);

            //Removemos el producto con la propiedad nombre de "mouse" de la coleccion usando el metodo REMOVE()
            foreach(Producto P in aProducto)
            {
                if (P.nombre == "mouse")
                {
                    aProducto.Remove(P);
                }
            }
            //Removemos el elemento en la posicion asignada con el metodo REMOVEAT(posicion)
            aProducto.RemoveAt(1);

            //Ordenamos la coleccion usando el metodo SORT de la coleccion
            aProducto.Sort();

            

            //Uso de la coleccion LIST para añadir elementos de tipo String y poder mostrar de forma dinamica usando "FOREACH"
            //int[] vectorObj = new int[50];// vector

            List<String> producto = new List<string>();//coleccion

             producto.Add("Impresora");
             producto.Add("Mouse");
             producto.Add("Teclado");
             producto.Add("Parlantes");
             producto.Add("Escaner");

             foreach (String p in producto)
             {
                 Console.WriteLine("Producto : "+p);
             }


            Console.ReadKey();

        }
    }
}
