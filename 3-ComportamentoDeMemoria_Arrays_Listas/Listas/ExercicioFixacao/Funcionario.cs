using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    public class Funcionario
    {
        public int Id { get; }
        public string Name { get; }
        public double Salario { get; private set; }

        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario = Salario + (Salario * porcentagem);
        }

        public override string ToString()
        {
            return Id + " : Nome : " + Name + "Salario : $" + Salario.ToString("0.00");
        }
    }
}
