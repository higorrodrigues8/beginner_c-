using System;
using System.IO;
namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            char entrada = ' ';
            while (true)
            {
                Console.WriteLine("Insira: \n |w para escrever dados na agenda | r para ler agenda | x para fechar o programa");
                entrada = Convert.ToChar(Console.ReadLine());

                if (entrada == 'w' || entrada == 'W')
                {
                    Console.WriteLine("Escreva seu nome: ");
                    dynamic nome = Console.ReadLine();
                    Console.WriteLine("Escreva seu telefone: ");
                    dynamic telefone = Console.ReadLine();

                    StreamWriter texto = File.AppendText("arquivo.txt"); //adiciona conteudo ao final da linha
                    texto.WriteLine(nome + ", " + telefone);   //escreve
                    texto.Close();   //fechar arquivo
                    Console.WriteLine("Dados inseridos com sucesso!.");
                    Console.WriteLine("\n\n");
                }
                else if (entrada == 'r' || entrada == 'R')
                {
                    Console.WriteLine("Seus dados são: \n");
                    TextReader leitor = new StreamReader("arquivo.txt"); //cria variavel para ler arquivo
                    Console.WriteLine(leitor.ReadToEnd()); //lê arquivo até o final
                    leitor.Close();
                    Console.WriteLine("\n\n");
                }
                else if(entrada == 'x' || entrada == 'X')
                {

                    Console.WriteLine("\n\n\nPrograma encerrado.");
                    Console.WriteLine("\n\n\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
        }
    }
}
