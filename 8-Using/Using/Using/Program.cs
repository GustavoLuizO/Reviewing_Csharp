using System;
using System.IO;

namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gusta\Documents\GitHubRepositorios\Reviewing_Csharp\8-Using\Using\Using\text.txt";

            try
            {
                //Ao final da execução, o using fecha os argumentos que estão referenciados.
                //Ou seja, o fs e o sr já são fechado, não precisando dar o close em ambos.
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                            Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (IOException erro)
            {
                Console.WriteLine("An error occurred. " + erro.Message);
            }

        }
    }
}
