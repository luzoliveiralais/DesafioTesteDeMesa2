using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosBNE
{
    internal class Exercicio4
    {
        static double valorPresente = 2000;
        static double taxaJuros = 2.0 / 100;
        static int periodo = 6;
        static int contador = 0;
        static int contadorDeControle = 0;
        static double resgate = 1000;
        public static void ReiniciaValores()
        {
            valorPresente = 2000;
            taxaJuros = 2.0 / 100;
            periodo = 6;
            contador = 0;
            contadorDeControle = 0;
            resgate = 1000;
        }
        public static void MostraResposta()
        {

            Console.WriteLine($"\u001b[33m  Valor Presente (valor do investimento) = R${valorPresente}  \u001b[0m");
            Console.WriteLine($"\u001b[33m  Período da aplicação = {periodo} meses \u001b[0m");
            Console.WriteLine($"\u001b[33m  Valor do Resgate = {resgate} meses \u001b[0m");
            Console.WriteLine($"\u001b[33m  Resgate realizado no 5º mês \u001b[0m");
            Console.WriteLine();
            Console.WriteLine($"\u001b[36m| Valor Presente | Período | Juros | Rendimentos | Renda Liquida | " +
                $"Rend. Acumulado | Resgate    | Saldo   |\u001b[0m");

            while (contador < periodo)
            {

                contador++;
                contadorDeControle++;
                double rendimento = valorPresente * Math.Pow(taxaJuros + 1, contador);
                double rendimentoLiquido = rendimento - valorPresente;
                double rendaAcumulada = valorPresente + rendimentoLiquido - resgate;
                double saldo = rendaAcumulada;


                if (contador == 5)
                {
                    saldo = rendaAcumulada - rendimentoLiquido;
                    rendaAcumulada = valorPresente + rendimentoLiquido - resgate;
                    //valorPresente = saldo;
                    saldo = rendaAcumulada;
                    Console.WriteLine($"\u001b[36m| R$ {valorPresente,-11:F2} | {contador + "º mês",-7} | {taxaJuros * 100 + "%",-6}" +
                        $"| R$ {rendimento,-8:F2} | R$ {rendimentoLiquido,-10:F2} | R$ {rendaAcumulada,-12:F2} | R$ {resgate,-5:F2} | {saldo,-5:F2} |\u001b[0m");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
                    valorPresente = rendaAcumulada;
                    contador = 0;
                    resgate = 0;
                    continue;
                }

                Console.WriteLine($"\u001b[36m| R$ {valorPresente,-11:F2} | {contador + "º mês",-7} | {taxaJuros * 100 + "%",-6}" +
                $"| R$ {rendimento,-8:F2} | R$ {rendimentoLiquido,-10:F2} | R$ {rendaAcumulada,-12:F2} |            | {saldo,-5:F2} |\u001b[0m");

                if (contadorDeControle == 7)
                {
                    break;
                }
            }
            ReiniciaValores();
        }
    }
}
