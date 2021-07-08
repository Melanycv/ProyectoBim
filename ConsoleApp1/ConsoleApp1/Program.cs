using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0;
            int val2 = 0;
            int total = 0;
            char op = 's';



            while (op == 's')
            {
                Console.Write("Realizaremos el  indice de masa corporal de: Niño, Joven, Adulto ");


                Console.Write("Niño");


                Console.Write("Ingrese su peso en libras actual: ");
                val1 = int.Parse(Console.ReadLine());
                int total1 = (val1 * 703);



                Console.WriteLine("Ingrese su estatura en pulgadas: ");
                val2 = int.Parse(Console.ReadLine());
                int total2 = (val2 * val2);



                Console.WriteLine("Su indice de masa corporal es de: " + total1 / total2);
                Console.Write("Resultados");

                Console.Write("Normal 18.5 > 24.99");
                Console.Write("Preobeso 25.00 > 29.99");
                Console.Write("Obeso Tipo 1: 30.00 > 34.99");
                Console.Write("Obeso Tipo 2: 35.00 > 39.99 ");
                Console.Write("Obeso Tipo 3: > 40");

                Console.Write("IMC");






                Console.Write("joven");


                Console.Write("Ingrese su peso en libras actual: ");
                val1 = int.Parse(Console.ReadLine());
                int total3 = (val1 * 703);



                Console.WriteLine("Ingrese su estatura en pulgadas: ");
                val2 = int.Parse(Console.ReadLine());
                int total4 = (val2 * val2);



                Console.WriteLine("Su indice de masa corporal es de: " + total1 / total2);

                Console.Write("Niño");


                Console.Write("Ingrese su peso en libras actual: ");
                val1 = int.Parse(Console.ReadLine());
                int total5 = (val1 * 703);



                Console.WriteLine("Ingrese su estatura en pulgadas: ");
                val2 = int.Parse(Console.ReadLine());
                int total6 = (val2 * val2);



                Console.WriteLine("Su indice de masa corporal es de: " + total1 / total2);



                Console.WriteLine("Desea realizar otro ['s/n'] ");
                op = char.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Fin");
            Console.ReadKey();



        }
    }
}
