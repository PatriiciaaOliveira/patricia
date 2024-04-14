using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patricia
{
    internal static class Program
    {
        private static string arquivoCSV = "dados.csv";

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o e-mail:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            string senha1 = Console.ReadLine();

            // Verificar se o arquivo CSV já existe
            if (!File.Exists(arquivoCSV))
            {
                // Se não existir, criar o arquivo e adicionar o cabeçalho
                using (StreamWriter sw = File.CreateText(arquivoCSV))
                {
                    sw.WriteLine("Nome,Email,Senha");
                }
            }

            // Escrever os dados no arquivo CSV
            using (StreamWriter sw = File.AppendText(arquivoCSV))
            {
                sw.WriteLine($"{nome},{email},{senha1}");
            }

            Console.WriteLine("Cadastro realizado com sucesso!");

            Application.Run(new frm_Menu());
        }
    }
}