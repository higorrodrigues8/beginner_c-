using System;

namespace operadores_logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saiba se você é maior ou menor de idade");
            Console.WriteLine("Insira um caso deseja encerrar o programa");

            dynamic idade = 0;
            char entrada = 'c';
            int i;
            
            int x;
            while (true)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Insira:\n\n| i para maior idade | m para media de notas | t para tabuada  | x para encerrar |");
                entrada = Convert.ToChar(Console.ReadLine());
                
                if (entrada == 'x')
                {
                    Console.WriteLine("Programa encerrado. ");
                    break;
                }
                else if(entrada == 'i')
                {
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Insira sua idade: \t");
                    idade = Convert.ToInt32(Console.ReadLine());
                    if (idade < 18 && idade >= 0)
                    {
                        Console.WriteLine("Você é menor de idade");
                    }
                    else if (idade >= 18 && idade >= 0)
                    {
                        Console.WriteLine("Você é maior de idade");
                    }
                    else
                    {
                        Console.WriteLine("entrada invalida, são permitidos números maiores que 0");
                    }
                }
                else if(entrada == 't')
                {
                    for(i = 0; i < 11; i++)
                    {
                        for(x = 0; x < 11; x++)
                        {
                            Console.WriteLine(x + " * " + i + "= " + x * i);
                            if(x == 10)
                            {
                                Console.WriteLine("\n");
                            }
                        }
                    }
                }
                else if (entrada == 'm')
                {
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Insira a nota do 1° bimestre: ");
                    decimal nota1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Insira a nota do 2° bimestre: ");
                    decimal nota2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Insira a nota do 3° bimestre: ");
                    decimal nota3 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Insira a nota do 4° bimestre: ");
                    decimal nota4 = Convert.ToDecimal(Console.ReadLine());

                    decimal resultado = nota1 + nota2 + nota3 + nota4;

                    if(resultado >= 60)
                    {
                        Console.WriteLine("Aluno aprovado.\n");
                    }
                    if (resultado < 60)
                    {
                        Console.WriteLine("Aluno reprovado.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. ");
                }
               
            }
        }
    }
}
