using projeto_interface.Interfaces;

namespace projeto_interface.TiposAnimais
{
    public class Anfibios : Animais, INadar
    {
        public Anfibios(string nomeDoAnimal, int peso, string regiaoOrigem) : base(nomeDoAnimal, peso, regiaoOrigem)
        {
        }

        public override string NomeDoAnimal { get; set; }

        public override int Peso { get; set; }

        public override string RegiaoOrigem { get; set; }
        public int LimiteProfundidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void MostrarCadastro()
        {
            Console.WriteLine($"Anfibio: {NomeDoAnimal} - Peso: {Peso} - Região de Origem: {RegiaoOrigem}. " +
                $"Sou um {NomeDoAnimal} e como sou um anfibio minha pele é impermeavel");
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
