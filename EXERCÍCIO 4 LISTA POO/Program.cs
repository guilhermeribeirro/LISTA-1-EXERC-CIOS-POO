using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCÍCIO_4_LISTA_POO
{ 

    class Aluno
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public double NotaProva { get; set; }
        public double NotaTrabalho { get; set; }
        public double NotaFinal
        {
            get
            {
                return (NotaProva * 0.7) + (NotaTrabalho * 0.3);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Determine a quantidade de alunos: ");
            int quantidadeDeAlunos = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[quantidadeDeAlunos];

            for (int i = 0; i < quantidadeDeAlunos; i++)
            {
                Console.WriteLine($"Aluno {i + 1}");
                Console.Write("RA: ");
                int ra = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Nota da prova: ");
                double notaProva = double.Parse(Console.ReadLine());
                Console.Write("Nota do trabalho: ");
                double notaTrabalho = double.Parse(Console.ReadLine());

                Aluno aluno = new Aluno();
                aluno.RA = ra;
                aluno.Nome = nome;
                aluno.NotaProva = notaProva;
                aluno.NotaTrabalho = notaTrabalho;

                alunos[i] = aluno;
            }

            Console.WriteLine("Lista de Alunos:");
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"RA: {aluno.RA}, Nome: {aluno.Nome}, Nota Final: {Math.Round((aluno.NotaFinal))}");
            }
        }
    }

}
