using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosBNE
{
    internal class Exercicio1
    {
        static double valorPresente = 1000; //C = Capital
        static double taxaDeJurosPorcentagem = 5.3;
        static double taxaDeJuros = taxaDeJurosPorcentagem / 100; //i = taxa de juros
        static int periodoMes = 10; //t = tempo
        static double valorFuturo = valorPresente * Math.Pow(taxaDeJuros + 1, periodoMes);  //M = montante - valor final da trasação = C + J 


        public static void MostraTabela()
        {
            Console.WriteLine($"\u001b[36m| Valor Presente | Taxa de Juros | Período  | Rendimento |\u001b[0m");
            Console.WriteLine($"\u001b[36m| R$ {valorPresente,-11} | {taxaDeJurosPorcentagem + " %",-13} | {periodoMes + " meses",-4} | R$ {valorFuturo,-8:F2}|\u001b[0m");
        }
    }
}
