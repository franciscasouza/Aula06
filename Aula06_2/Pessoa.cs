using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06_2
{
    class Pessoa
    {
        private string Nome { get; set; }
        private double SalarioBruto { get; set; }
        private double Imposto { get; set; }

        public Pessoa(string nome, double salB, double imposto)
        {
            this.Nome = nome;
            this.SalarioBruto = salB;
            this.Imposto = imposto;
        }










        public double SalarioLiquido()
        {
            double valorSalario = SalarioBruto - Imposto;

            return valorSalario;
        }



        private double valorPorcentagem;
        public void AumentarSalario(double porcentagem)
        {
            valorPorcentagem = (SalarioBruto * porcentagem / 100) + SalarioLiquido();
        }


        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                $"Salario Bruto: {SalarioBruto:F2}\n" +
                $"Imposto: {Imposto:F2}\n" +
                $"Dados atualizados:{Nome} , R$ {valorPorcentagem:F2}";

        }
    }
}
