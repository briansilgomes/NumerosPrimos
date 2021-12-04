using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira um número:");
            int numero = int.Parse(Console.ReadLine());
            
            int numerodivisoes = 0;

            for (int contador = 1; contador <= numero; contador++) {

                //int resultado = numero % contador;

                if (numero % contador == 0) {
                    numerodivisoes++;
                }

            }

            if (numerodivisoes == 2){

                Console.WriteLine($"O múmero {numero} é primo!");

            } else {

                Console.WriteLine($"O múmero {numero} não primo!");
            }

            Console.ReadKey();
        }
    }
}
    

