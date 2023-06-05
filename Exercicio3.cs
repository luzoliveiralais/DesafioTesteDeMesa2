using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosBNE
{
    internal class Exercicio3
    {
        public static double rendimento = 0;
        public static double taxaDeJurosPorcentagem = 2.0;
        public static double taxaDeJuros = taxaDeJurosPorcentagem / 100;
        public static double valorPresente;
        public static int periodoEmAnos;
        public static int contador = 0;

        public static void SetValorPresente()
        {
            Console.WriteLine("Qual o valor do capital que deseja aplicar ?");
            valorPresente = Convert.ToDouble(Console.ReadLine());
        }

        public static void SetPeridoEmAnos()
        {
            Console.WriteLine("Deseja aplicar esse valor por quantos anos ?");
            periodoEmAnos = Convert.ToInt32(Console.ReadLine());
        }
        public static void ZeraContador()
        {
            contador = 0;
        }
        public static void MostraResposta()
        {
            Console.WriteLine();
            Console.WriteLine($"\u001b[36mValor Presente (valor do investimento) = R${valorPresente:F2}  \u001b[0m");
            Console.WriteLine($"\u001b[36mPeríodo da aplicação (em anos) = {periodoEmAnos} anos  \u001b[0m");
            Console.WriteLine();

            Console.WriteLine($"\u001b[36m| Valor Aplicado | Taxa de Juros | Período (a.a.) | Rendimentos     |\u001b[0m");


            while (contador < periodoEmAnos)
            {
                contador++;
                rendimento = valorPresente * Math.Pow(taxaDeJuros + 1, contador);
            }

            Console.WriteLine($"\u001b[36m| R${valorPresente,-12} | {taxaDeJurosPorcentagem + "%",-13} | " +
                $"{periodoEmAnos + " anos",-14} | R$ {rendimento,-11:F2}  |\u001b[0m");
            Console.WriteLine();

            ZeraContador();
        }
    }
}
