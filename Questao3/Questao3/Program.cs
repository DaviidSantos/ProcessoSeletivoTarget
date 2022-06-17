using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;
using System.Linq.Expressions;


namespace Questao3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("C:/Users/55199/Documents/ProcessoSeletivo/Questao3/Questao3/dados.json"))
            {
                string json = r.ReadToEnd();
                List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

                double maiorFaturamento = 0;
                double menorFaturamento = 1000000;
                double mediaMensal = 0;
                int dias = 0;

                foreach (var valor in faturamentos)
                {
                    if (valor.valor > maiorFaturamento)
                    {
                        maiorFaturamento = valor.valor;
                    }
                    else if (valor.valor < menorFaturamento)
                    {
                        menorFaturamento = valor.valor;
                    }

                    mediaMensal += valor.valor;
                }

                mediaMensal = mediaMensal / 30;
                Console.WriteLine(mediaMensal);

                foreach (var valor in faturamentos)
                {
                    if (valor.valor > mediaMensal)
                    {
                        dias++;
                    }
                }

                Console.WriteLine($"O menor faturamento em um dia do mês foi de R$ {menorFaturamento}");
                Console.WriteLine($"O maior faturamento em um dia do mês foi de R$ {maiorFaturamento}");
                Console.WriteLine($"Em {dias} dias o faturamento superou a média de faturamento mensal");
            }
        }
    }
}