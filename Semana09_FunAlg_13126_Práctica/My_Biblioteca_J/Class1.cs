using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Biblioteca_J
{
    public class Class1
    {
       public void sumar()
       {
            Console.WriteLine("Ingrese N°1: ");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese N°2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma es: " + (n1 + n2));
       }
        public void restar(ref int resultado)
        {
            Console.WriteLine("Ingrese N°1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese N°2: ");
            int n2 = int.Parse(Console.ReadLine());

            resultado = n1 - n2;
        }
       
    }
}
