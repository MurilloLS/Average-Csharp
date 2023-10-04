using System;

namespace Average
{
    public class Calc
    {
        public static void Calculator(double soma, int totalNumeros, string[] numerosComoStrings, string name)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
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
            Console.ReadKey();
            Final.Finalization(name);

        }
    }
}
