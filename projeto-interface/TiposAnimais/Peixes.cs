using projeto_interface.Interfaces;

namespace projeto_interface.TiposAnimais
{
    public class Peixes : Animais, INadar
    {
        public Peixes(string nomeDoAnimal, int peso, string regiaoOrigem) : base(nomeDoAnimal, peso, regiaoOrigem)
        {
        }

        public override string NomeDoAnimal { get; set; }

        public override int Peso { get; set; }

        public override string RegiaoOrigem { get; set; }

        public int LimiteProfundidade { get; set; }

        public override void MostrarCadastro()
        {
            Console.WriteLine($"Peixe: {NomeDoAnimal} - Peso: {Peso} - Região de Origem: {RegiaoOrigem}. " +
                $"Precisa dar a quantidade exata de comida para meu peso: {Peso}, se não passo mal ):");
        }

        public void Mergulhar(int metros)
        {
            Console.WriteLine($"Eu {NomeDoAnimal}, consigo mergulhar a {metros} metros");
        }

        public void Subir(int metros)
        {
            Console.WriteLine($"Eu {NomeDoAnimal}, consigo subir a {metros} metros");
        }
    }
}
