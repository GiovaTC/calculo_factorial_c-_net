using System;
using System.Numerics; //necesario para BigInteger

namespace FactorialDesde32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero n (n >= 32):");
            if (!int.TryParse(Console.ReadLine(), out int n) || n < 32)
            {
                Console.WriteLine("Entrada invalida. Debe ingresar un numero entero mayor o igual a 32.");
                return;
            }

            Console.WriteLine($"\nFactoriales desde 32 hasta {n}:\n");

            for (int i = 0; i <= n; i++)
            {
                if (i < 32) continue;

                BigInteger factorial = CalcularFactorial(i);
                Console.WriteLine($"{i}! = {factorial}");
            }

            

        }

        static BigInteger CalcularFactorial(int numero)
        {
            BigInteger resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
