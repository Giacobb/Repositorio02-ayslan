using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contagem_de_frases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas frases você quer inserir : ");
            int quantidade = int.Parse(Console.ReadLine());

            string[] palavras = new string[quantidade];
            int pares = 0, impares = 0;



            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite a frase {i + 1} : ");
                palavras[i] = Console.ReadLine();
            }
            for (int i = 0; i < quantidade; i++)
            {
                int totalpalavras = palavras[i].Split(' ').Length;

                if
                    (totalpalavras % 2 == 0)
                    pares++;
                else
                    impares++;
            }

            Console.WriteLine($"Total de frases com números par de palavras : {pares}");
            Console.WriteLine($"Total de frases com números impar de palavras : {impares}");

            Console.ReadKey();







        }
    }
}
