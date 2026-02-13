using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMenu
{
    public class ClassMedia
    {
        private static double media;

        public void CalcularMedia()
        {
            Console.Clear();
            Console.WriteLine("=== CALCULO DE MÉDIA ===");
            
            if (string.IsNullOrEmpty(ClassAluno.nome))
            {
                Console.WriteLine("Nenhum aluno cadastrado ainda!");
                return;
            }
            media = (ClassAluno.nota1 + ClassAluno.nota2) / 2;
            Console.WriteLine($"A media do aluno {ClassAluno.nome} é {media:F2}");
        }
        public void MostrarSituacao()
        {
            Console.Clear();
            Console.WriteLine("=== Situação do aluno ===");

            if (string.IsNullOrEmpty (ClassAluno.nome))
            {
                Console.WriteLine("Cadastre um aluno primeiro!");
                return;
            }

            if (media >= 6)
            {
                Console.WriteLine($"Aluno {ClassAluno.nome} APROVADO com média {media:f2}!");
            }else
            {
                Console.WriteLine($"Aluna {ClassAluno.nome} REPROVADO com média {media:f2}!");
            }
        }
    }
}
