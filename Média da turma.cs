using System;
namespace Classes
{
    class Alunos
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\t\t______________________________________________________");
            Console.WriteLine("\t\tCalcula a média de uma turma de 10 alunos!!!");
            int contador; double media, nota, total;
            total = 0; contador = 1;
            while (contador <= 10)
            {
                Console.Write("\n\t\tEntre com a {0}ª nota do aluno: ", contador);
                nota = Double.Parse(Console.ReadLine());
                total = total + nota;
                contador = contador + 1;
            }
            media = total / 10;
            Console.WriteLine("\n\t\tClasse com média igual a:  " + media);
            Console.WriteLine("\t\t______________________________________________________");
            Console.WriteLine("\n\t\t\t\tProgramação Orientada à Objetos I");
            Console.WriteLine();
        }
    }
} 


