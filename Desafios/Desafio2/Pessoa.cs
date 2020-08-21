namespace Desafio2
{
    public class Pessoa
    {
        public Pessoa(string Nome, string Endereco, string Telefone)
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
        }

        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome} \nEndereço: {this.Endereco} \nTelefone: {this.Telefone}";
        }
    }
}
