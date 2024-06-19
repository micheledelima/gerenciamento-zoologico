namespace projeto_interface
{
    public abstract class Animais
    {
        public abstract string NomeDoAnimal { get; set; }

        public abstract int Peso { get; set; }

        public abstract string RegiaoOrigem { get; set; }

        public Animais(string nomeDoAnimal, int peso, string regiaoOrigem)
        {
            NomeDoAnimal = nomeDoAnimal;
            Peso = peso;
            RegiaoOrigem = regiaoOrigem;
        }

        public abstract void MostrarCadastro();
    }
}
