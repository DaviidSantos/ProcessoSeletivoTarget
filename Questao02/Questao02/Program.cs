using System;

namespace Questao02
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        int numeroDesejado;
        int fib = 1;
        int aux = 0;
        int n = 0;
        bool encontrado = false;

        Console.Write("Informe o número a ser verificado na sequência de Fibonacci: ");
        numeroDesejado = Convert.ToInt16(Console.ReadLine());

        while (fib < numeroDesejado)
        {
            fib += aux;
            aux = n;
            n = fib;

            if (fib == numeroDesejado)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado == true)
        {
            Console.WriteLine("Número pertence a sequência de Fibonacci!");
        }
        else
        {
            Console.WriteLine("Número não pertence a sequência de Fibonacci!");
        }
    }
  }
}