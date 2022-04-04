using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSist.de_Apostas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a quantidade de cartoes");
            int qntcartoes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite a quantidade de numeros");
            int qntnumeros = Convert.ToInt32(Console.ReadLine());

            int cartoes = qntcartoes;
            int numeros = qntnumeros;

            int[,] matriz = new int[cartoes, numeros];

            Console.WriteLine("numeros sorteados");
           
                Random rand = new Random();

                for (cartoes = 0; cartoes < qntcartoes; cartoes++)
                {
                    for (numeros = 0; numeros < qntnumeros; numeros++)
                    {
                        matriz[cartoes, numeros] = rand.Next(1, 60);
                        Console.Write(matriz[cartoes, numeros] + " ");
                    }


                    Console.WriteLine();

                }

                Console.ReadKey();



            






             


             
        }



    }

}





















