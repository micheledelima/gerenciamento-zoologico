using projeto_interface.Interfaces;

namespace projeto_interface.TiposAnimais
{
    public class Repteis : Animais
    {
        public Repteis(string nomeDoAnimal, int peso, string regiaoOrigem) : base(nomeDoAnimal, peso, regiaoOrigem)
        {
        }

        public override string NomeDoAnimal { get; set; }

        public override int Peso { get; set; }

        public override string RegiaoOrigem { get; set; }

        public override void MostrarCadastro()
        {
            Console.WriteLine($"Reptil: {NomeDoAnimal} - Peso: {Peso} - Região de Origem: {RegiaoOrigem}. " +
                $"{NomeDoAnimal} - Gosta de pegar sol porque ele é um reptil");
        }
    }
}
