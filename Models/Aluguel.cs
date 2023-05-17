using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoAluguel.Models
{
    internal class Aluguel
    {
        public Estudante Estudante { get; set; }
        public Quarto Quarto { get; set; }
        public int NumQuarto { get; set; }

        public Aluguel()
        {
        }

        public Aluguel(Estudante estudante, Quarto quarto)
        {
            Estudante = estudante;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return "Nome: " + Estudante.Nome + "Email: " + Estudante.Email + "Quarto: " + Quarto.NumQuarto + "]";
        }
    }
}
