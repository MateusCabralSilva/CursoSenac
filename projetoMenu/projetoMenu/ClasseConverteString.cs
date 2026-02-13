using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoMenu
{
    public class ClasseConverteString
    {
        private string nome,nomeAlterado;

        public string entrada()
        {
            Console.Clear();
            Console.WriteLine("Digite um nome ou frase: ");
            nome = Console.ReadLine();
            nomeAlterado = nome.ToUpper();
            return nomeAlterado;
        }
    }
}
