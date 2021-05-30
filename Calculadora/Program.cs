using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static private double Soma(double a, double b)
        {
            return a + b;
        }

        static private double Subtracao(double a, double b)
        {
            return a - b;
        }

        static private double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        static private double Divisao(double a, double b)
        {
            return a / b;
        }

        static void Terminou()
        {
            Console.WriteLine("Fechando Programa...");
        }

        static void Main(string[] args)
        {
            double resultado;
            string resposta;

            Console.WriteLine("Deseja Sair? S-Sim N-Não");
            resposta = Console.ReadLine();

            while (resposta == "N" || resposta == "n")
            {
                Console.WriteLine("Digite o primeiro número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a operação desejada: ");
                string operacao = Console.ReadLine();

                if (operacao == "+")
                {
                    resultado = Soma(num1, num2);
                    Console.WriteLine("O resultado é: " + resultado);
                }
                else if (operacao == "-")
                {
                    resultado = Subtracao(num1, num2);
                    Console.WriteLine("O resultado é: " + resultado);
                }
                else if (operacao == "*")
                {
                    resultado = Multiplicacao(num1, num2);
                    Console.WriteLine("O resultado é: " + resultado);
                }
                else if (operacao == "/")
                {
                    resultado = Divisao(num1, num2);
                    Console.WriteLine("O resultado é: " + resultado);
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                    Console.ReadLine();
                }
                Console.WriteLine("Deseja Sair? S-Sim N-Não");
                resposta = Console.ReadLine();
            }
            Terminou();
            Console.ReadLine();
        }
    }
}
