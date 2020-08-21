namespace Desafio3e4
{
    public abstract class Conta : Imposto
    {
        public Conta(string Numero, string Titular, double Saldo)
        {
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = Saldo;
        }

        public string Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public virtual double CalcularImposto()
        {
            throw new System.NotImplementedException();
        }

        public virtual double Rendimento()
        {
            return this.Saldo;
        }
    }
}
