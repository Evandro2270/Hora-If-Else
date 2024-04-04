using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                
                Console.WriteLine("Digite a hora atual: ");
                int hora = int.Parse(Console.ReadLine());


                if (hora < 12)
                {
                    Console.WriteLine("Bom dia!");
                }

                else if (hora < 18)
                {
                    Console.WriteLine("Boa tarde!");
                }

                else {
                    Console.WriteLine("Boa Noite");
                }

              }
        }
    }
}