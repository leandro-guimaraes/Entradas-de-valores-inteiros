using System;

namespace Recebe_Valores_Inteiros
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" ");
            Console.WriteLine("Escolha quantas entradas serâo: ");
            Console.Write("-> ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[] vet = new int[N];
            int[] vetcopia = new int[N];
            int[] vetcont = new int[N];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Digite um valor inteiro: ");
                Console.Write("-> ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                vetcopia[i] = vet[i];
                vetcont[i]++;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet.Length; j++)
                {
                    if (i != j)
                    {
                        if (vet[i] == vetcopia[j])
                        {
                            vetcont[i]++;
                        }
                    }
                }
            }

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"O elemento {vet[i]}, que está na posição {i} aparece {vetcont[i]} vezes.");
            }









        }
    }
}
