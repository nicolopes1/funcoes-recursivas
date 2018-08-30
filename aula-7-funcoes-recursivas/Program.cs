using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7_funcoes_recursivas
{
    class Program
    {
        private static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq" + numeroArquivo +".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivoComCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivo(numeroArquivo + 1);
            }
        }

          
        static void Main(string[] args)
        {
            LerArquivo(1);
            Console.Read();
        }
    }
}
  