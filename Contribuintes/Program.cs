using Contribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Numero de pagadores: ");
            int payers = int.Parse(Console.ReadLine());
            List<Pessoa> list = new List<Pessoa>(); ; 

            for (int i = 1; i <= payers; i++)
            {
                System.Console.WriteLine($"Pagador #{payers} : ");
                Console.WriteLine("Fisica ou Juridica (f/j)? ");
                string resposta = Console.ReadLine();
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());
                if (resposta == "f")
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(nome, renda, gastosSaude));
                }
                else
                {
                    Console.Write("Número de funcionários");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, renda, funcionarios));
                }
                
            }

            Console.WriteLine("Impostos a pagar :");
            double total = 0;
            foreach (Pessoa pessoa in list)
            {
                Console.WriteLine($"{pessoa.Nome} : $ {pessoa.Impostos().ToString("F2")}");
                total += pessoa.Impostos();
            }
            Console.WriteLine($"Total de impostos : ${total}");
        }
    }
}