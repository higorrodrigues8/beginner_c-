using System;
using System.IO;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic value = Console.ReadLine();
            TextWriter texto = new StreamWriter("arquivo.txt"); //criar um arquivo
            
            texto.WriteLine(value); //escreve valor
            value = Console.ReadLine();
            texto.WriteLine(value); //escreve valor 
            texto.Close(); //fechar arquivo

            StreamWriter textoadd = File.AppendText("arquivo.txt"); //adiciona conteudo ao final da linha
            textoadd.WriteLine(value);   //escreve
            textoadd.Close();   //fechar arquivo
            Console.WriteLine("\n\n");

            TextReader leitor = new StreamReader("arquivo.txt"); //cria variavel para ler arquivo
            Console.WriteLine(leitor.ReadToEnd()); //lê arquivo até o final
            texto.Close();

            Console.WriteLine("\n\n" + value + "\n\n");
        }
    }
} 
