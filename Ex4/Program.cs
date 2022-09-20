using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para calcular o aumento de salário
            de um funcionario x exibindo
            - % de aumneto do salário
            - Aumento em reais
            - Salário Final
            */

            Console.WriteLine("======================================");
            Console.WriteLine("=== Programa de aumento de salário ===");
            Console.WriteLine("======================================");

            Console.WriteLine("Insira o nome do funcionário: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário");
            double SalarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual % de aumento deseja para o funcionário " + Nome + "?");
        }
    }
}
