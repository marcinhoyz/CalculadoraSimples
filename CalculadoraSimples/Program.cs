using System;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char operador;

            Console.WriteLine("DIGITE UM NÚMERO");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE OUTRO NÚMERO");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE UM SINAL DE OPERAÇÃO (+, -, *, /)");
            operador = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("NÃO É POSSÍVEL DIVIDIR POR 0");
                        return;
                    }
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    return;
            }

            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadLine();
        }
    }
}
