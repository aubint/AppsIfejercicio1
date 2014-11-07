using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsIfejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, suma, diferencia, producto, division;
            Console.WriteLine("SENTENCIA IF EJERCICIO 1");
            
            Console.WriteLine("Ingrese numero 1: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2: ");
            numero2 = double.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("NUMERO 1 MAYOR QUE NUMERO 2");
                suma= numero1+numero2;
                Console.WriteLine("La suma es: "+suma);
                diferencia = numero1 - numero2;
                Console.WriteLine("La diferencia  es: " + diferencia);
            }
            else
            {
                Console.WriteLine("NUMERO 1 MENOR QUE NUMERO 2");
                producto = numero1 * numero2;
                Console.WriteLine("El producto es: " + producto);
                division = numero1 / numero2;
                Console.WriteLine("La division es: " + division);
            }
            Console.ReadKey();

        }
    }
}
