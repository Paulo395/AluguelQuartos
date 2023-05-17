using System;
using System.Linq;
using SolucaoAluguel.Models;

namespace SolucaoAluguel // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Quarto> listaQ = new List<Quarto>();
            List<Estudante> listaE = new List<Estudante>();
            List<Aluguel> listaAl = new List<Aluguel>();

            Console.Write("Quantos estudantes iram alugar um quarto: ");
            byte n = byte.Parse(Console.ReadLine());

            if (n >= 1 && n <= 10)
            {
                for (int i = 0; i < n; i++)
                {
                    listaE.Add(new Estudante().CadastroEstudante());
                    listaQ.Add(new Quarto(i));
                    listaAl.Add(new Aluguel(listaE[i], listaQ[i]));
                }

            }
            else
            {
                Console.WriteLine("Quantidade de quartos insuficiente!");
            }
            foreach (var item in listaAl) Console.WriteLine(item);

        }
    }
    //public static bool ValorValido(int num)
    //{
    //    if (num > 0 && num <10 ) return true;
    //    return false;
    //}
}