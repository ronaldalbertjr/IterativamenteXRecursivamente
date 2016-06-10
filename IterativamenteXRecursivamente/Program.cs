using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativamenteXRecursivamente
{
    class Program
    {
        static int number = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a posição você quer dos numeros de fibonacci? ");
            number = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Fibonacci Iterativo: ");
            foreach(int i in FibonacciIterativo(number))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Fibonacci Recursivo: ");
            Console.WriteLine(FibonacciRecursivo(number));
            Console.ReadKey();
        }
        static int[] FibonacciIterativo(int number)
        {
            int[] e = new int[number];
            for(int i = 0; i < e.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    e[i] = 1;
                }
                else
                {
                    e[i] = e[i-1] + e[i-2];
                }
            }
            return e;

        }
        static int FibonacciRecursivo(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            else
            {
                return FibonacciRecursivo(number - 1) + FibonacciRecursivo(number - 2);
            }
        }
    }
}
