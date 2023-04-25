using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluguel.Models
{
    internal class Quarto
    {
        public int NumQuarto { get; set; }

        public Quarto(int numeroQuarto)
        {
            NumQuarto = numeroQuarto;
        }
    }
}
