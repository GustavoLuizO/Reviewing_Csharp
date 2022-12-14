using System;

namespace CreateException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Acount acount = new Acount(8021, "Gustavo", 500.00, 600.00);

                Console.Write("Enter amount for withdraw : ");
                acount.WithDraw(Convert.ToDouble(Console.ReadLine()));

                Console.WriteLine("New balance : " + acount.ConsultBalance());
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
