using System;

namespace questao04
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        double[] faturamentoEstados = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
        double faturamentoTotal = 0;
        double porcentagem = 0;

        for (int i = 0; i < faturamentoEstados.Length; i++)
        {
            faturamentoTotal += faturamentoEstados[i];
        }

        for (int i = 0; i < faturamentoEstados.Length; i++)
        {
            porcentagem = (faturamentoEstados[i] / faturamentoTotal) * 100;
            if (i == 0)
            {
                Console.WriteLine($"SP : {porcentagem}%");
            }
            else if (i == 1)
            {
                Console.WriteLine($"RJ : {porcentagem}%");
            }
            else if (i == 2)
            {
                Console.WriteLine($"MG : {porcentagem}%");
            }
            else if (i == 3)
            {
                Console.WriteLine($"ES : {porcentagem}%");
            }
            else if (i == 4)
            {
                Console.WriteLine($"Outros : {porcentagem}%");
            }
        }
        Console.ReadKey();
    }
  }
}