using projetoMenu;
using System.Net.Http.Headers;

static void linha ()
{
    Console.WriteLine("===============================================");
}

bool inicio = false;

while (inicio != true)
{
    Console.Clear();
    int op;
    ClasseConverteString str = new ClasseConverteString();
    ClasseOrdenaNumeros num = new ClasseOrdenaNumeros();
    
    linha();
    Console.SetCursorPosition(15, 1);
    Console.WriteLine("Menu de opções");
    linha();

    Console.SetCursorPosition(10, 4);
    Console.WriteLine("1 - Conversão de strings");

    Console.SetCursorPosition(10, 6);
    Console.WriteLine("2 - Ordenar numeros");

    Console.SetCursorPosition(10, 8);
    Console.WriteLine("3 - Finalizar\n");
    linha();
    Console.SetCursorPosition(15, 11);
    Console.WriteLine("Opção[ ]");
    Console.SetCursorPosition(21, 11);

    //trycatch para tratar erros possiveis
    try
    {
        op = int.Parse(Console.ReadLine());
        if (op == 1)
        {
            Console.WriteLine("A frase convertida: " + str.entrada());
        }
        if (op == 2)
        {
            num.organizar();
        }
        if (op == 3)
        {
            Console.Clear();
            inicio = false;
            Console.WriteLine("========= Fim de execução =========");
        }
        else if (op!=1 && op != 2 && op != 3)
        {
            Console.WriteLine("========= Opção invalida =========");
        }
    }
    catch (Exception)
    {
        Console.Clear();
        linha();
        Console.WriteLine("Digite um dos valores!\n" + "Tente novamente!");
        linha();

    }

    Console.ReadKey();
}