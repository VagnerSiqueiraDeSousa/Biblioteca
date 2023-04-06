using Biblioteca;
using Biblioteca.Usuarios;
using Biblioteca.VitrineDosLivros;

Usuario leitor1 = new Usuario("123456");
leitor1.NomeLeitor = "Joaquim";
leitor1.Email = "Joaquim@ficticio.com";

Usuario leitor2 = new Usuario("3221655");
leitor2.NomeLeitor = "Manoel";
leitor2.Email = "manoel@ficticio.com";

Livro livro1 = new Livro("9781234567809 ", "Como a onda do Mar");
livro1.Autor = "Tiririca Souza";
livro1.NumeroDePaginas = 900;
livro1.EstiloLiterario = "Romance";
livro1.AnoPublicacao = 2023;
livro1.PaisDeOrigem = "Brasil";

Livro livro2 = new Livro("97888888809 ", "Programação C Sharp");
livro2.Autor = "Mark";
livro2.NumeroDePaginas = 500;
livro2.EstiloLiterario = "Tecnologia";
livro2.AnoPublicacao = 2023;
livro2.PaisDeOrigem = "Brasil";

GerenciadorDeLivros gerenciador = new GerenciadorDeLivros();
gerenciador.Registrar(livro1);
gerenciador.Registrar(livro2);


Console.WriteLine("Nome do Leitor: " + leitor1.NomeLeitor);
Console.WriteLine("Nome do livro: " + livro1.Titulo);
Console.WriteLine("ISBN: " + livro1.ISBN);

Console.WriteLine("Nome do Leitor: " + leitor2.NomeLeitor);
Console.WriteLine("Nome do livro: " + livro2.Titulo);
Console.WriteLine("ISBN: " + livro2.ISBN);


Console.WriteLine("Total de leitores: " + Usuario.TotalDeLeitor);
Console.WriteLine("Total de livros: " + Livros.TotalDeLivros);
Console.WriteLine("Total de livros em uso: " + gerenciador.TotalDeLivros);

