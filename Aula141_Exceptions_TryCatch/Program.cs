using System;
using System.Globalization;

namespace Aula141_Exceptions_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("DIVISOR - ENTRE COM DOIS NUMEROS PARA OBTER A DIVISAO DO PRIMEIRO PELO SEGUNDO");
            Console.WriteLine();
            Console.Write("Quantas operacoes deseja efetuar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                try
                {
                    Console.WriteLine(i + "a operacao: ");
                    Console.Write("Entre com o primeiro numero: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o segundo numero: ");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.Write($"Resultado da {i}a operacao: ");
                    int result = n1 / n2;
                    Console.WriteLine(result);
                    Console.WriteLine();
                }
                // catch (Exception error)
                catch (DivideByZeroException) // Lanca excecao quando se tenta dividir por 0
                {
                    // Console.WriteLine("Error! " + error.Message + ": Division by 0 is not allowed");
                    Console.WriteLine("Error! Division by 0 is not allowed");
                }
                // catch(FormatException e)
                catch (FormatException)
                {
                    // Console.WriteLine("Format error!);
                    Console.WriteLine("Format error! Not allowed characters");
                }
            }
        }
    }
}
