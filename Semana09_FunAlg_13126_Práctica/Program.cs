using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_Biblioteca_J;

namespace Semana09_FunAlg_13126_Práctica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 xD = new Class1();
            //xD.sumar();

            int resultado=0;
            xD.restar(ref resultado);
            Console.WriteLine("La resta es : " + resultado);


            Calculadora C = new Calculadora();

            int r2;
            C.multiplicar(out r2);
            Console.WriteLine("La multiplicación es: " + r2);

            float r3;
            C.dividir(out r3);
            Console.WriteLine("La división es: " + r3);

            Console.ReadKey();  
        }
    }
}
