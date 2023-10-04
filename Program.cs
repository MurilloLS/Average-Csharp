using System;
using System.Reflection;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarefa: Criar um programa em C# que calcula a média de um conjunto de números inseridos pelo usuário.

            //Solicite ao usuário que insira um conjunto de números separados por vírgulas (por exemplo: "1, 2, 3, 4, 5").
            //Se você quiser tornar o programa mais robusto, pode adicionar validação para garantir que apenas números válidos sejam aceitos.
            //Separe os números inseridos pelo usuário em uma matriz.
            //Calcule a média desses números.
            //Exiba a média para o usuário.
            Show();
        }

        static void Show()
        {
            Console.Clear();
            Console.WriteLine("OLÁ");
            Console.WriteLine("1 - Iniciar");
            Console.WriteLine("2 - Sair");
            short res = short.Parse(Console.ReadLine());
            switch(res)
            {
                case 1: Menu();break;
                case 2: Environment.Exit(0);break;
            }

        }
        static void Menu() 
        {
            Console.Clear();    
            Console.WriteLine("Digite um conjunto de números separados por vírgulas:");
            string entrada = Console.ReadLine();

            // Divida a entrada em números com base nas vírgulas
            string[] numerosComoStrings = entrada.Split(',');
            double soma = 0;
            int totalNumeros = 0;
            Calc(soma, totalNumeros, numerosComoStrings);    
        }
            
        static void Calc(double soma, int totalNumeros, string[] numerosComoStrings)
        {
            Console.Clear();
            foreach (string numeroComoString in numerosComoStrings)
            {
                // Tente converter cada número em double
                if (double.TryParse(numeroComoString.Trim(), out double numero))
                {
                    soma += numero;
                    totalNumeros++;
                }
                else
                {
                    Console.WriteLine($"'{numeroComoString}' não é um número válido e será ignorado.");
                }
            }

            if (totalNumeros > 0)
            {
                double media = soma / totalNumeros;
                Console.WriteLine($"Média dos números digitados: {media}");
            }
            else
            {
                Console.WriteLine("Nenhum número válido foi digitado.");
            }
            Show();
        }
    }
}
