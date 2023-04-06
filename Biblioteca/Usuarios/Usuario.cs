using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Usuarios
{
    public class Usuario
    {
        public string NomeLeitor { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public static int TotalDeLeitor { get; private set; }


        public Usuario(string cpf)
       {
            this.Cpf = cpf;
            TotalDeLeitor++;
       }

    }
}
