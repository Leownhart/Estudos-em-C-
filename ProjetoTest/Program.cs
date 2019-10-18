using System;
using System.Globalization;

namespace ProjetoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp = 0;
  
                do
                {
                    Console.Write("Olá, Informe o nome do aluno(a) : ");
                    string nome = Console.ReadLine();

                    Console.WriteLine(" ---- Informe as notas do aluno ----");

                    Console.Write("Nota 1ª: ");
                    double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Nota 2ª: ");
                    double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Nota 3ª: ");
                    double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    double media = (n1 + n2 + n3) / 3;

                    Console.WriteLine($"A média entre as notas de {nome} é : [{media.ToString("F2", CultureInfo.InvariantCulture)}]");

                    if (media == 5)
                    {
                        Console.WriteLine("<----Aluno está de recuperação---->");
                    }
                    else if (media < 5)
                    {
                        Console.WriteLine("<----Aluno está reprovado---->");
                    }
                    else if (media > 5)
                    {
                        Console.WriteLine("<----Aluno aprovado---->");
                    }

                    DateTime t1 = DateTime.Now;
                    Console.WriteLine($" Hórario do Cálculo (({t1}))");

                    Console.Write("Deseja cálcular a média de um aluno ? 1 = Sim / 0 = Não : ");
                    resp = int.Parse(Console.ReadLine());

                } while (resp == 1);
        }
    }
}
