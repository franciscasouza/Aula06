using System;

namespace Aula06_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite o nome da Pessoa: ");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite o Salario Bruto da Pessoa: ");

            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do Imposto: ");

            double imposto = double.Parse(Console.ReadLine());


            Pessoa p = new Pessoa(nome, salario, imposto);
            


            p.SalarioLiquido();

            Console.WriteLine("Digite a porcentagem recebida");
            double porcentagem = double.Parse(Console.ReadLine());

            p.AumentarSalario(porcentagem);

            Console.WriteLine("---------------------");


            Console.WriteLine(p);




            Console.ReadLine();
        }
    }
}
