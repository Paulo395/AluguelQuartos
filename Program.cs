using Aluguel.Models;
using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quarto[] q = new Quarto[10];
            Aluguel[] al;

            byte n = byte.Parse(Console.ReadLine());

            if (n >= 1 && n <= 10)
            {
                /*
                for (int i = 0; i < n; i++)
                {
                    q = new Quarto[i];
                    q[i].NumQuarto = i;
                }*/

                for (int i = 0; i < n; i++)
                {
                    Estudante[] est = new Estudante[n];
                    est[i].CadastroEstudante();

                    al = new Aluguel[i];
                }
            }
            else
            {
                Console.WriteLine("Quantidades insuficientes.");
            }
        }
    }
}