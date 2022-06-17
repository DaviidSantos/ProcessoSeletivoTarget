using System;

namespace Questao05
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        Console.Write("Escreva algo: ");
        string Texto = Console.ReadLine();
        string TextoInvertido = "";

        for (int i = Texto.Length - 1; i >= 0; i--)
        {
            char[] VetorTexto = Texto.ToCharArray();
            TextoInvertido += VetorTexto[i];

        }
        Console.WriteLine(TextoInvertido);
        Console.ReadKey();
    }
  }
}