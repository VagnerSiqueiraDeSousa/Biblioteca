using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VitrineDosLivros
{
    public abstract class Livros
    {
        public string Titulo { get;  set; }
        public string Autor { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDeOrigem { get; set; }
        public int AnoPublicacao { get; set; }
        public string ISBN { get; set; }

        public int QuantidadeUsuarios { get; set; }
        public int QuantidadeLivrosEmprestados { get; set; }

        public abstract int GetTotalDeLeitor();


        public Livros(string ISBN , string Titular)
        {
            this.ISBN = ISBN;
            this.Titulo = Titular;
            
        }

        public static int TotalDeLivros { get; set; }

    }
}
