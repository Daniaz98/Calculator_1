// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo a Calculator! \nUm programa em c#.");
        Console.WriteLine("\n");

        Console.WriteLine("Insira o primeiro valor: ");
        double num1 = double.Parse(Console.ReadLine());



        Console.WriteLine("Insira o segundo valor: ");
        double num2 = double.Parse(Console.ReadLine());



        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("A - Adição");
        Console.WriteLine("B - Subtração");
        Console.WriteLine("C - Multiplicação");
        Console.WriteLine("D - Divisão");
        Console.Write("Operação: ");
        string operacao = Console.ReadLine();

        double resultado = 0;

        switch (operacao)
        {
            case "A":
                resultado = Adicao(num1, num2);
                Console.WriteLine($"\nResultado: {num1} + {num2} = {resultado}");
                break;
            case "B":
                resultado = Subtracao(num1, num2);
                Console.WriteLine($"\nResultado: {num1} - {num2} = {resultado}");
                break;

            case "C":
                resultado = Multiplicacao(num1, num2);
                Console.WriteLine($"\nResultado: {num1} * {num2} = {resultado}");
                break;

            case "D":
                if (num2 != 0)
                {
                    resultado = Divisao(num1, num2);
                    Console.WriteLine($"\nResultado: {num1} / {num2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("\nErro. Divisão por zero não é aceito.");
                }
                break;
            default:
                Console.WriteLine("\nEsta não é uma entrada válida!");
                break;

        }



    }


    static double Adicao(double a, double b)
    {
        return a + b;
    }

    static double Subtracao(double a, double b)
    {
        return a - b;
    }

    static double Multiplicacao(double a, double b)
    {
        return a * b;
    }


    static double Divisao(double a, double b)
    {
        return a / b;
    }
}