using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMenu
{
    public class ClassAluno
    {
        public static string nome;
        public static double nota1, nota2;

        public void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("=== CADASTRO DE ALUNO ===");
            Console.Write("Nome do Aluno: ");
            nome = Console.ReadLine();

            Console.Write("Primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nAluno {nome} castro com sucesso!");
        }
    }
}
