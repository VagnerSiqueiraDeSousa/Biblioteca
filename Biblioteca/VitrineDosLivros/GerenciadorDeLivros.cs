using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VitrineDosLivros
{
    public class GerenciadorDeLivros
    {
        public int TotalDeLivros { get; set; }

        public void Registrar(Livros livros) 
        {
            this.TotalDeLivros += livros.GetTotalDeLeitor();
        }

        public void MotrarStatusLivro(Livros  Livro)
        {
            Console.WriteLine($"Livro: {Livro.Titulo}");
            Console.WriteLine($"Quantidade de exemplares emprestados: {Livro.QuantidadeLivrosEmprestados}");
            Console.WriteLine($"Quantidade de usuários com o livro emprestado: {Livro.QuantidadeUsuarios}");
        }

    }
}
