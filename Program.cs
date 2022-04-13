using System;
using System.Collections.Generic;
using ExResolvido001.Entities;
using System.Globalization;
namespace ExResolvido001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Console.Write("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)?");
                char x = char.Parse(Console.ReadLine());
                Console.Write("Informe o nome do Funcionario:");
                string nome = Console.ReadLine();
                Console.Write("Informe a quantidade de horas trabalhadas:");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuephr = double.Parse(Console.ReadLine());     
                if(x == 'y')
                {
                    Console.Write("Additional charge:");
                    double tx = double.Parse(Console.ReadLine());
                    funcionarios.Add(new FuncionarioTerceiro(nome, horas, valuephr, tx));
                }
                else
                {
                    funcionarios.Add(new Funcionario(nome, horas, valuephr));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Funcionario fun in funcionarios)
            {
                Console.WriteLine($"{fun.Name} - ${fun.Pagamento().ToString("F2",CultureInfo.InvariantCulture)}");
            }
            string a = Console.ReadLine();
        }
    }
}
