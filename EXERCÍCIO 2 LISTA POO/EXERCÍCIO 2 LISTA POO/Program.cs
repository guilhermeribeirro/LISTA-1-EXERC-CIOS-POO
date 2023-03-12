using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCÍCIO_2_LISTA_POO
{
    public class Calculadora
    {
        private Calculo calculo = new Calculo();
        private double valorA;
        private double valorB;

        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.LerValores ();

        }
        public void LerValores()
        {
            Console.Write("Digite o 1º valor: ");
            valorA = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º valor: ");
            valorB = double.Parse(Console.ReadLine());
        }

        public void ExecutarCalculadora()
        {
            LerValores();

            Console.WriteLine("Escolha a operação de calculo desejada: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Maior valor");
            Console.WriteLine("5 - Somar com outro valor");

            int opcaoescolhida = int.Parse(Console.ReadLine());

            switch (opcaoescolhida)
            {
                case 1:
                    calculo.CalcularSoma(valorA, valorB);
                    break;
                case 2:
                    calculo.CalcularSubtracao(valorA, valorB);
                    break;
                case 3:
                    calculo.CalcularMultiplicacao(valorA, valorB);
                    break;
                case 4:
                    Console.WriteLine("O maior valor é: " + calculo.RetornarMaior(valorA, valorB));
                    break;
                case 5:
                    Console.Write("Digite o valor a ser somado: ");
                    double valorC = double.Parse(Console.ReadLine());
                    calculo.SomarGeral(valorA, valorB, valorC);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            ImprimirResultado();
        }

        public void ImprimirResultado()
        {
            Console.WriteLine("Resultado: " + calculo.Resultado);
        }

     
        }
    }

    public class Calculo
    {
        public double Resultado { get; private set; }

        public void CalcularSoma(double valorA, double valorB)
        {
            Resultado = valorA + valorB;
        }

        public void CalcularSubtracao(double valorA, double valorB)
        {
            Resultado = valorA - valorB;
        }

        public void CalcularMultiplicacao(double valorA, double valorB)
        {
            Resultado = valorA * valorB;
        }

        public double RetornarMaior(double valorA, double valorB)
        {
            return Math.Max(valorA, valorB);
        }

        public void SomarGeral(double valorA, double valorB, double valorC)
        {
            Resultado = valorA + valorB + valorC;
        }
    }

