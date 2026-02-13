using sistemaCalculos;
using System;

static void linha()
{
    Console.WriteLine("========================================================");
}
bool inicio = false;

while (inicio != true)
{
    Console.Clear();
    int op;

    ClasseCalculos num = new ClasseCalculos();


    linha();
    Console.SetCursorPosition(20, 1);
    Console.WriteLine("Menu de opções");
    linha();

    Console.SetCursorPosition(5, 4);
    Console.WriteLine("1 - Calcular area de um triangulo");

    Console.SetCursorPosition(5, 6);
    Console.WriteLine("2 - Calcular media de 3 numeros");

    Console.SetCursorPosition(5, 8);
    Console.WriteLine("3 - Calcular o dobro e o triplo de um numero");

    Console.SetCursorPosition(5, 10);
    Console.WriteLine("4 - Calcular o valor de um produto com desconto");

    Console.SetCursorPosition(5, 12);
    Console.WriteLine("5 - Calcular a tabuada de um numero");

    Console.SetCursorPosition(5, 14);
    Console.WriteLine("0 - Sair\n");
    linha();

    Console.SetCursorPosition(15, 18);
    Console.WriteLine("Opção[ ]");
    Console.SetCursorPosition(21, 18);

    try
    {
        op = int.Parse(Console.ReadLine());
        if (op == 1)
        {
            Console.WriteLine("Area calculada: " + num.triangulo());
        }
        if (op == 2)
        {
            Console.WriteLine("Media: " + num.media());
        }
        if (op == 3)
        {
            Console.WriteLine(num.dobro();)

        }
        if (op == 4)
        {
            Console.WriteLine("Valor com desconto: " + num.desconto().ToString("C"));
        }
        if (op == 5)
        {
            Console.WriteLine(num.tabuada());

        }
        if (op == 0)
        {
            Console.Clear();
            inicio = true;
            Console.WriteLine("========= Fim de execução =========");
        }
        else if (op != 1 && op != 2 && op != 3 && op != 4 && op != 5 && op != 0)
        {
            Console.WriteLine("========= Opção invalida =========");
        }
    }
    catch (Exception)
    {
        Console.Clear();
        linha();
        Console.WriteLine("\nDigite uma das opções!\n" + "Tente novamente!\n");
        linha();

    }

        Console.ReadKey();
}