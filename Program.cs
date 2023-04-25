using Aluguel.Models;
using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quarto[] q;

            byte n = byte.Parse(Console.ReadLine());

            if (n >= 1 && n <= 10)
            {
                for (int i = 0; i < n; i++)
                {
                    q = new Quarto[i];
                    q[i].NumQuarto = i;
                }

                for(int i = 0;i < n; i++)
                {

                }
            }
            else
            {
                Console.WriteLine("");
            }

            if (n == 0)
            {
                Console.WriteLine("Número invalido.");
            }
            else if (n > 10)
            {
                Console.WriteLine("Quartos insuficientes.");
            }
            else
            {
                Estudante[] estudantes = new Estudante[n];

                for (int i = 0; i < n; i++)
                {
                    q = new Quarto[i];
                    q.Num
                }
            }

            Estudante[] estudantes = new Estudante[n];

            for (int i = 0; i < n; i++)
            {
                q = new Quarto[i];
                q.Num
            }
        }
    }
}