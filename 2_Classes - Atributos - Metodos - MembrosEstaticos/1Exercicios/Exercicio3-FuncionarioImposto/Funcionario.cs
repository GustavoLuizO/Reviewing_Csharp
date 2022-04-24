using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3_FuncionarioImposto
{
    public class Funcionario
    {
        private string Nome;
        private double SalarioBruto;
        private double Imposto;

        public string Nome1 { get => Nome; set => Nome = value; }
        public double SalarioBruto1 { get => SalarioBruto; set => SalarioBruto = value; }
        public double Imposto1 { get => Imposto; set => Imposto = value; }


        public double SalarioLiquid()
        {
            return (SalarioBruto - Imposto);
        }

        public void AumentarSalario(double porcentagem)
        {
            double porcentagemdecimal = porcentagem / 100;
            double aumento = SalarioBruto * porcentagemdecimal;
            SalarioBruto += aumento;
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquid().ToString("0.00");
        }
    }
}
