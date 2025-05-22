using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Biblioteca_J
{
    public class Calculadora
    {
        public void multiplicar(out int resultado)
        {
            Console.WriteLine("Ingrese N°1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese N°2: ");
            int n2 = int.Parse(Console.ReadLine());

            resultado = n1 * n2;
        }
        public void dividir(out float resultado)
        {
            Console.WriteLine("Ingrese N°1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese N°2: ");
            int n2 = int.Parse(Console.ReadLine());

            resultado = n1 / n2;
        }
    }
}
