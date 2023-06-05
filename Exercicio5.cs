using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosBNE
{
    internal class Exercicio5
    {
        static double valorPresente = 0;
        static double taxaDeJuros = 1.25 / 100;
        static int periodoEmAnos = 2;
        static double rendimento = 7390.61;
        static int contador = 0;
        public static void ZeraContador()
        {
            contador = 0;
        }

        public static void MostraResposta()
        {
            Console.WriteLine($"|\u001b[36m Valor a ser investido \u001b[0m| Período | Taxa de Juros | Rendimentos |");
            while (contador < periodoEmAnos)
            {
                contador++;
                valorPresente = rendimento / (Math.Pow(taxaDeJuros + 1, contador));
            }
            Console.WriteLine($"| \u001b[36m{valorPresente,-21:F2}\u001b[0m | {contador + " anos",-7} | {(taxaDeJuros * 100) + "%",-13} | R$ {rendimento,-8:F2} |");
            ZeraContador();
        }
    }
}
