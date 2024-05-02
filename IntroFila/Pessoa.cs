namespace IntroFila
{
    internal class Pessoa
    {
        string nome;
        Pessoa? proximo;

        public Pessoa(string nome)
        {
            this.nome = nome;
            this.proximo = null;
        }

        public void setNext(Pessoa aux)
        {
            this.proximo = aux;
        }

        public Pessoa? getNext()
        {
            return this.proximo;
        }

        public override string? ToString()
        {
            return $"Nome: {this.nome}";
        }
    }
}
