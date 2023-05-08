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

            Estudante e = new Estudante();
            Quarto[] quartos = new Quarto[10];


            Console.Write("Quantos estudantes iram alugar um quarto: ");
            byte n = byte.Parse(Console.ReadLine());

            if (n >= 1 && n <= 10)
            {
                for (int i = 0; i < n; i++)
                {
                    listaE.Add(e.CadastroEstudante());

                    while (true)
                    {
                        Console.Write("Digite o quarto que deseja alugar: ");
                        byte q = byte.Parse(Console.ReadLine());

                        if (q >= 1 && q <= 10)
                        {
                            if (quartos[q].Ocupado == false)
                            {
                                Console.WriteLine("O quarto pode ser alugado!");
                                quartos[q].NumQuarto = q;
                                quartos[q].Ocupado = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("O quarto não pode ser alugado!\nEscolha outra opção");
                            }
                        }
                    }
                    Aluguel arrayAl = new Aluguel(listaE[i], listaQ[i]);
                }
            }
            else
            {
                Console.WriteLine("Quantidade de quartos insuficiente!");
            }
        }
    }
}