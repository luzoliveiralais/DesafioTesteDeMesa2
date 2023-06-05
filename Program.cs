using System;
using DesafiosBNE;


class Program
{
    public static void Main(String[] args)

    {
        bool continuar = true;
        string continua;

        do
        {
            Console.WriteLine("Teste De Mesa 2 - Exercícios propostos pelo Professor Sergio Nauffal");
            Console.WriteLine("Digite o número para visualizar a resposta.");
            Console.WriteLine(@"
1. Crie uma tabela que calcule o rendimento de um investimento.
2. Crie uma tabela que calcule o rendimento de um investimento para 6 meses (taxa a.m.). Mostrar todos os meses.
3. Elabora um programa em C# que leia as entradas e mostre o rendimento final calculado. 
4. Elabora uma tabela de iteração que mostre o rendimento de uma aplicação e um resgate no 5°mês. 
5. Com base no problema 2, apresente uma tabela que mostre o valor a ser investido, sabendo que o valor futuro/rendimento é de R$7390,61.");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            string opcao = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Exercicio1.MostraTabela();
                    Console.WriteLine();
                    Console.WriteLine("Deseja ver outro exercício? Digite 's' para sim ou 'n' para não.");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    continua = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    Console.WriteLine();
                    if (continua == "n")
                    {
                        continuar = false;
                        break;
                    }
                    break;
                case "2":
                    Exercicio2.MostraResultado();
                    Console.WriteLine();
                    Console.WriteLine("Deseja ver outro exercício? Digite 's' para sim ou 'n' para não.");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    continua = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    Console.WriteLine();
                    if (continua == "n")
                    {
                        continuar = false;
                        break;
                    }
                    break;
                case "3":
                    Exercicio3.SetValorPresente();
                    Exercicio3.SetPeridoEmAnos();
                    Exercicio3.MostraResposta();
                    Console.WriteLine();
                    Console.WriteLine("Deseja ver outro exercício? Digite 's' para sim ou 'n' para não.");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    continua = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    Console.WriteLine();
                    if (continua == "n")
                    {
                        continuar = false;
                        break;
                    }
                    break;
                case "4":
                    Exercicio4.MostraResposta();
                    Console.WriteLine();
                    Console.WriteLine("Deseja ver outro exercício? Digite 's' para sim ou 'n' para não.");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    continua = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    Console.WriteLine();
                    if (continua == "n")
                    {
                        continuar = false;
                        break;
                    }
                    break;
                case "5":
                    Exercicio5.MostraResposta();
                    Console.WriteLine();
                    Console.WriteLine("Deseja ver outro exercício? Digite 's' para sim ou 'n' para não.");
#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    continua = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
                    Console.WriteLine();
                    if (continua == "n")
                    {
                        continuar = false;
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválido");
                    break;
            }
        }
        while (continuar == true);
        Console.ReadLine();
    }
}