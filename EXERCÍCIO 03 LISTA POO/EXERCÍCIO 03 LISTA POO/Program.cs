using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EXERCÍCIO_03_LISTA_POO
{



    public class ManipularArquivo
    {
        public string Conteudo { get; set; }
        public string EnderecoNomeArquivo { get; set; }
        public bool SalvarDadosNoArquivo()
        {
            try
            {
                File.WriteAllText(EnderecoNomeArquivo, Conteudo);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Infelizemente deu ERRO ao salvar dados no arquivo: {ex.Message}");
                return false;
            }
        }

        public string PesquisarConteudoNoArquivo(string conteudoPesquisado)
        {
            try
            {
                string conteudoArquivo = File.ReadAllText(EnderecoNomeArquivo);
                if (conteudoArquivo.Contains(conteudoPesquisado))
                {
                    return conteudoArquivo;
                }
                else
                {
                    return "O Conteúdo declarado não foi encontrado no arquivo.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Infelizemente deu ERRO ao salvar dados no arquivo: {ex.Message}");
                return "";
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ManipularArquivo manipulararquivo = new ManipularArquivo();

            Console.WriteLine("Informe o endereço e nome do arquivo a ser salvo:");
            manipulararquivo.EnderecoNomeArquivo = Console.ReadLine();

            Console.WriteLine("Informe o conteúdo a ser salvo no arquivo:");
            manipulararquivo.Conteudo = Console.ReadLine();

            bool resultadoSalvar = manipulararquivo.SalvarDadosNoArquivo();
            if (resultadoSalvar)
            {
                Console.WriteLine("Dados salvos com sucesso!");
            }

            Console.WriteLine("Informe o conteúdo a ser pesquisado no arquivo:");
            string conteudoPesquisado = Console.ReadLine();
            string resultadoPesquisa = manipulararquivo.PesquisarConteudoNoArquivo("O conteúdo é:"+conteudoPesquisado);
            Console.WriteLine(resultadoPesquisa);

            Console.ReadKey();
        }
    }
}

