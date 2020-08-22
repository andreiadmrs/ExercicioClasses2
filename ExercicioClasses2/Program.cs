using System;
using System.Globalization;

namespace ExercicioClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários.*/
            var primeiroFuncionario = new Funcionario();
            var segundoFuncionario = new Funcionario();

            Console.WriteLine("Digite nome e valor do salário:");
            primeiroFuncionario.nome = Console.ReadLine();
            primeiroFuncionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite outro nome e valor do salário:");
            segundoFuncionario.nome = Console.ReadLine();
            segundoFuncionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (primeiroFuncionario.salario + segundoFuncionario.salario) / 2.0;
                Console.WriteLine("Sálario médio R$" + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
