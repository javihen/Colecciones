using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    public class Producto
    {
        public String nombre;
        public String color;
        public int precio;

        

        public String getNombre()
         {
             return this.nombre;
         }
         public int getPrecio()
         {
             return this.precio;
         }
         public void setNombre(String nombre)
         {
             this.nombre = nombre;
         }
         public void setPrecio(int Valor)
         {
             this.precio = Valor;
         }
    }
}
