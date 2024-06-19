// See https://aka.ms/new-console-template for more information
using projeto_interface.TiposAnimais;

Console.WriteLine("Demonstração de Animais:");

var sapoCururu = new Anfibios("Sapo Cururu", 1, "America do Sul");
sapoCururu.MostrarCadastro();
sapoCururu.Mergulhar(1);
sapoCururu.Subir(1);

Console.WriteLine("---------------");

var linceDoCanada = new Mamifero("Lince do canada", 50, "Canada");
linceDoCanada.MostrarCadastro();

Console.WriteLine("---------------");

var bemTeVi = new Aves("Bem-Te-Vi", 1, "America Latina");
bemTeVi.MostrarCadastro();
bemTeVi.LevantarVoo();
bemTeVi.Pousar();

Console.WriteLine("---------------");

var jacarePapoAmarelo = new Repteis("Jacaré-de-papo-amarelo", 80, "America do Sul");
jacarePapoAmarelo.MostrarCadastro();

Console.WriteLine("---------------");

var salmao = new Peixes("Salmão", 1, "Noruega, Canadá e Alasca");
salmao.MostrarCadastro();
salmao.Mergulhar(3);
salmao.Subir(3);



