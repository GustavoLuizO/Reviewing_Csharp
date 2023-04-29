namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printServiceInteger = new PrintService<int>();

            printServiceInteger.AddValeu(1);
            printServiceInteger.AddValeu(2);
            printServiceInteger.AddValeu(3);

            Console.WriteLine("Primeiro valor : {0}", printServiceInteger.First());
            Console.WriteLine("Valores : ");
            printServiceInteger.Print();


            Console.WriteLine();
            PrintService<string> printServiceString = new PrintService<string>();
            printServiceString.AddValeu("Americo");
            printServiceString.AddValeu("Henrique");
            printServiceString.AddValeu("Lucio");

            Console.WriteLine("Primeiro valor : {0}", printServiceString.First());
            Console.WriteLine("Valores : ");
            printServiceString.Print();
        }
    }
}