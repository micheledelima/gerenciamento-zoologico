namespace projeto_interface.TiposAnimais
{
    public class Mamifero : Animais
    {
        public Mamifero(string nomeDoAnimal, int peso, string regiaoOrigem) : base(nomeDoAnimal, peso, regiaoOrigem)
        {
        }

        public override string NomeDoAnimal { get; set; }

        public override int Peso { get; set; }

        public override string RegiaoOrigem { get; set; }

        public override void MostrarCadastro()
        {
            Console.WriteLine($"Mamifero: {NomeDoAnimal} - Peso: {Peso} - Região de Origem: {RegiaoOrigem}. " +
                $"Eu sou um {NomeDoAnimal}, por ser mamifero, preciso que escove meus pelos");
        }
    }
}
