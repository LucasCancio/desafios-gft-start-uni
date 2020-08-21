using System;

namespace Desafio2
{
    public class Impressora
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--Imprimindo Informações da Pessoa--\n");
                ImprimirPessoa();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }

        public static void ImprimirPessoa()
        {
            var pessoa = new Pessoa("Lucas Camargo", "Barueri", "(11)93121323");
            Console.WriteLine(pessoa.ToString());
        }
    }
}
