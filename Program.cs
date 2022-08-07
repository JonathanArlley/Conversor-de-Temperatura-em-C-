using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void 
            Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("####### Conversor de temperaturas #######");
            Console.Write("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            //Calculo de C para F
            //(c * 9 / 5) + 32 = F
            f = (c * 9 / 5 ) + 32;

            //Calculo de C para K
            //c + 273,15

            k = c + 273.15;

            Console.WriteLine(c + " graus celsius = " + f + " graus fahrenheit");
            Console.WriteLine(c + " graus celsius = " + k + " graus kelvin");
            Console.WriteLine("--------------------------------------------------");
            Console.ReadKey();
        }
    }
}
