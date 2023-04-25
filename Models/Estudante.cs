using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel.Models
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public void CadastroEstudante()
        {
            Console.Write("Digite o seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o seu email: ");
            Email = Console.ReadLine();
        }
    }
}
