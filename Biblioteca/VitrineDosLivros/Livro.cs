using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.VitrineDosLivros
{
    public class Livro : Livros
    {
        public Livro(string ISBN, string Titulo) : base(ISBN, Titulo)
        {

        }

        public override int GetTotalDeLeitor()
        {
            TotalDeLivros++;
            return TotalDeLivros;
            
        }
    }
}
