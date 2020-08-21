namespace Desafio3e4
{
    public class ContaPoupanca : Conta
    {
        private const double JUROS = 0.05;
        public ContaPoupanca(string Numero, string Titular, double Saldo) : base(Numero, Titular, Saldo)
        { }

        public override double Rendimento()
        {
            var saldo = base.Rendimento();
            return saldo * JUROS;
        }
        public override double CalcularImposto()
        {
            const double PERCENTUAL_DO_IMPOSTO = 0.10;

            return this.Rendimento() * PERCENTUAL_DO_IMPOSTO;
        }
    }
}
