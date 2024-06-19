using projeto_interface.Interfaces;

namespace projeto_interface.TiposAnimais
{
    public class Aves : Animais, IVoar
    {
        public Aves(string nomeDoAnimal, int peso, string regiaoOrigem) : base(nomeDoAnimal, peso, regiaoOrigem)
        {
        }

        public override string NomeDoAnimal { get; set; }

        public override int Peso { get; set; }

        public override string RegiaoOrigem { get; set; }



        public override void MostrarCadastro()
        {
            Console.WriteLine($"Ave: {NomeDoAnimal} - Peso: {Peso} - Região de Origem: {RegiaoOrigem}. " +
                $"Sou um {NomeDoAnimal} e como sou uma ave, vou mostrar minhas penas para você");
        }

        public void LevantarVoo()
        {
            Console.WriteLine($"{NomeDoAnimal} vai lanvantar voo.");
        }

        public void Pousar()
        {
            Console.WriteLine($"{NomeDoAnimal} agora vai pousar");
        }
    }
}
