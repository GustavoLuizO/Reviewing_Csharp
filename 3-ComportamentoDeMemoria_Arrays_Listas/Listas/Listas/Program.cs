using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            //Adicionando Elementos a lista
            //Add - Adiciona ao final da lista
            lista.Add("Hise");
            lista.Add("Jorge");
            lista.Add("Henrique");
            lista.Add("Gustavo");
            lista.Add("Julio");

            //Insert - Adiciona na posição em que voce quer
            lista.Insert(2, "Americo");
            
            //Tamanho da lista - Count 
            Console.WriteLine(lista.Count);

            //Find 
            //Encontrar o primeiro ou o ultimo elemento da lista referente a sua pesquisa 
            string procura1 = lista.Find(item => item.Contains("ise"));
            string procura2 = lista.FindLast(item => item.Contains("vo"));

            //Criando uma lista a partir de outro utilizando expressão lambda
            List<string> lista2 = lista.FindAll(item => item.Length ==5 );

            //Removendo elementos de uma list
            //Remove - Espera uma string referente a lista
            lista.Remove("Hise");

            //Remove todos
            lista.RemoveAll(item => item.Length == 5);

            //Remove um pelo index da lista
            lista.RemoveAt(0);

            //Remove por Range - Remove referente o range das posições que voce colocar
            lista.RemoveRange(0, 5);
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}