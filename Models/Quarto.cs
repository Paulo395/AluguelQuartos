using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucaoAluguel.Models
{
    internal class Quarto
    {
        public int NumQuarto { get; set; }
        public bool Ocupado { get; set; }

        public Quarto(int NumQuarto)
        {
            NumQuarto = NumQuarto;
        }

        public override string ToString()
        {
            return "Quarto número " + NumQuarto + " está " + Ocupado + "\n";
        }
    }
}
