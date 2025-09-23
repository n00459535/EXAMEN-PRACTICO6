using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_PRACTICO6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Elaborar un algoritmo que lea n números enteros y muestre cuántos son impares y positivos
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("¿Cuántos números vas a ingresar? ");
            int n = int.Parse(Console.ReadLine());
            int contador = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Ingrese el número {i}: ");
                Console.ResetColor();
                int num = int.Parse(Console.ReadLine());

                if (num > 0 && num % 2 != 0)
                {
                    contador++;
                }
            }
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("Cantidad de números impares y positivos: " + contador);
            Console.ResetColor();
        

        }
    }
}
