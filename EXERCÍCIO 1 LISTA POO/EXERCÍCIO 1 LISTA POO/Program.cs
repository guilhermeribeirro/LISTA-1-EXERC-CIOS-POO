using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAluno
{
    class Aluno
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public decimal NotaProva { get; set; }
        public decimal NotaTrabalho { get; set; }
        private decimal NotaFinal { get; set; }

        public void ReceberDados()
        {
            Console.Write("RA: ");
            RA = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Nota da Prova: ");
            NotaProva = decimal.Parse(Console.ReadLine());
            Console.Write("Nota do Trabalho: ");
            NotaTrabalho = decimal.Parse(Console.ReadLine());
        }




        public void CalcularMedia()
        {
            NotaFinal = (NotaProva + NotaTrabalho) / 2;
        }


        public bool CalcularNotaFinal()

        {
            if (NotaFinal >= 7)

                Console.Write("Aprovado");
            return false;


            Console.Write($"Reprovado, faltam {12 - NotaFinal}!");
            return false;

        }

        public void ImprimirNotaFinal()
        {

            Console.Write($"Nota Final: {NotaFinal.ToString("N2")}");

        }

  


        }
    }
