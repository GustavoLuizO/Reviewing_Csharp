using System;

namespace Nulaable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double? valor = null;
            double? valor2 = 5.0;

            //Return Valor ou o valor atribuido ao tipo dele
            Console.WriteLine(valor.GetValueOrDefault());
            Console.WriteLine(valor2.GetValueOrDefault());

            //Tem valor ? 
            Console.WriteLine(valor.HasValue);
            Console.WriteLine(valor2.HasValue);


            if (valor.HasValue)
                Console.WriteLine(valor.Value);//Valor
            
            if (valor2.HasValue)
                Console.WriteLine(valor2.Value);

            double? x = null;
            double y = 10;

            double a = x ?? y;
            Console.WriteLine(a);
        }
    }
}
