using System;

namespace Desafio3e4
{
    public class CaixaEletronico
    {
        static void Main(string[] _)
        {
            try
            {
                string titular = "Lucas Camargo";
                Console.WriteLine($"Bem vindo(a) ao caixa eletrônico, {titular}!!");

                ImprimirExtrato(titular);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }

        public static void ImprimirExtrato(string titular)
        {
            var contaCorrente = new ContaCorrente("01940187-9", titular, 0.10);
            var contaPoupanca = new ContaPoupanca("55462-4", titular, 100.0);

            Console.WriteLine("--EXTRATO--");
            Console.WriteLine($"\n* Conta corrente");
            ImprimirInformacoesConta(contaCorrente);

            Console.WriteLine($"\n* Conta poupança");
            ImprimirInformacoesConta(contaPoupanca);

            Console.WriteLine("\n--FIM DO EXTRATO--");
        }

        public static void ImprimirInformacoesConta(Conta conta)
        {
            ImprimirSaldoEmConta(conta);
            ImprimirImpostoEmConta(conta);
        }

        private static void ImprimirSaldoEmConta(Conta conta)
        {
            Console.WriteLine($"\tSaldo: R${conta.Saldo}");
        }

        private static void ImprimirImpostoEmConta(Conta conta)
        {
            Console.WriteLine($"\tImposto(s): R${conta.CalcularImposto()}");
        }
    }
}
