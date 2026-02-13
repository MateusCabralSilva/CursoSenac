using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;

namespace sistemaCalculos
{
    internal class ClasseCalculos
    {

        public double triangulo()
        {
            double bz, resultado, altura;
            Console.Clear();
            Console.Write("Digite a base: ");
            bz = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Digite a altura: ");
            altura = int.Parse(Console.ReadLine());

            resultado = (bz * altura) / 2;
            
            Console.Clear();
            return resultado;
        }

        public double media()
        {
            int num1, num3, num2;
            double resultado;
            Console.Clear();
            Console.Write("Digite o 1º numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Digite o 2º numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Digite o 3º numero: ");
            num3 = int.Parse(Console.ReadLine());

            Console.Clear();
            resultado = (num1 + num2 + num3) / 3;
            return resultado;
        }

        public string dobro()
        {
            int numD, numT, numP;
            string resultado;
            Console.Clear();
            Console.Write("Digite o numero saber para o dobro e o triplo: ");
            numP = int.Parse(Console.ReadLine());

            numD = numP * 2;
            numT = numP * 3;

            resultado = $"\nDobro: {numD}\nTriplo: {numT}";
            Console.Clear();
            return resultado;
        }

        public double desconto()
        {
            double preco, desc, precoDesc;
            Console.Clear();
            Console.Write("Digite o preço: R$ ");
            preco = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Digite o desconto : ");
            desc = double.Parse(Console.ReadLine());

            precoDesc = (preco * desc) / 100;

            preco = preco - precoDesc;

            Console.Clear();
            return preco;
        }

        public int tabuada()
        {

            Console.Clear();
            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }

            return num;
        }
    }
}
