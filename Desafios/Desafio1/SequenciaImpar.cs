using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio1
{
    public class SequenciaImpar
    {
        private const char SPLIT_CHAR = ' ';

        public static void Main(string[] _)
        {
            try
            {
                var odds = new List<int>();

                Console.WriteLine("-- Impares de uma sequência --\n");
                Console.WriteLine("Digite o valor inicial");
                int initial = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor final");
                int final = int.Parse(Console.ReadLine());



                for (int i = initial; i <= final; i++)
                {
                    bool isOdd = i % 2 != 0;
                    if (isOdd) odds.Add(i);
                }


                string output = SPLIT_CHAR + string.Join(SPLIT_CHAR, odds);

                Console.WriteLine(output);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor inserido está inválido!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }
    }
}
