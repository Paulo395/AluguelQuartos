using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoAluguel.Models
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public Estudante()
        {

        }

        public Estudante CadastroEstudante()
        {
            Console.Write("Digite o seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o seu email: ");
            Email = Console.ReadLine();

            Estudante e = new Estudante(Nome, Email);

            return e;
        }

        public override string ToString()
        {
            return "Lista de Alunos:\nAluno: " + Nome + "\nEmail: " + Email + "\n";
        }
    }
}
