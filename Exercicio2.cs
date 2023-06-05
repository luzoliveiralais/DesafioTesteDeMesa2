using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosBNE
{
    internal class Exercicio2
    {
        static double valorPresente = 3800;
        static double taxaDeJurosPorcentagem = 1.25;
        static double taxaDeJuros = taxaDeJurosPorcentagem / 100;
        static int periodoEmMeses = 6;
        static double jurosAcumulado = 0;
        static double rendimentoAcumulado;
        static int contador = 0;


        public static void ZeraContador()
        {
            contador = 0;
        }
        public static void MostraResultado()
        {
            Console.WriteLine($"\u001b[36m  Valor Presente (valor do investimento) = R${valorPresente}  \u001b[0m");
            Console.WriteLine();
            Console.WriteLine($"\u001b[36m| Período | Taxa de Juros | Rendimentos | Juros Acumulados | Rend. Acumulado |\u001b[0m");
            while (contador < periodoEmMeses)
            {
                contador++;
                double rendimento = valorPresente * Math.Pow(taxaDeJuros + 1, contador);
                rendimentoAcumulado = rendimento;
                jurosAcumulado = rendimento - valorPresente;

                Console.WriteLine($"\u001b[36m| {contador + "º mês",-7} | {taxaDeJurosPorcentagem + "%",-14}" +
                    $"| R$ {rendimento,-8:F2} | R$ {jurosAcumulado,-13:F2} | R$ {rendimentoAcumulado,-12:F2} |\u001b[0m");

            }
            ZeraContador();
        }
    }
}
