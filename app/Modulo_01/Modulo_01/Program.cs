using System;

namespace Modulo_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int tamanhoArray = 10;
            double[] numeros = new double[tamanhoArray];

            for (int i = 0; i < tamanhoArray; i++)
            {
                Console.Write($"Digite número {i + 1}: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um número pra ver se ele existe");
            int numeroInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanhoArray; i++)
            {
                if (numeroInput == numeros[i])
                {
                    Console.WriteLine($"Encontrado! Posição: {i + 1}");
                    break;
                }
                else
                {
                    Console.WriteLine("Não encontrado!");
                    break;
                }
            }

            if(numeroInput % 2 != 0)
            {
                Console.WriteLine("Número digitado é impar");
            }
            else
            {
                Console.WriteLine("Número digitado é par");
            }
        }
    }
}
