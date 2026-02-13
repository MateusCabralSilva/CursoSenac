using projetoMenu;
using System.Net.Http.Headers;

static void linha ()
{
    Console.WriteLine("===============================================");
}

bool sair = false;
ClassAluno aluno = new ClassAluno();
ClassMedia media = new ClassMedia();

while (!sair)
{
    Console.Clear();
    
    linha();
    Console.SetCursorPosition(10, 1);
    Console.WriteLine("Menu Principal - Sistema de Notas");
    linha();
    Console.WriteLine("\n1 - Cadastrar aluno");
    Console.WriteLine("2 - Calcular média");
    Console.WriteLine("3 - Exibir situação do aluno");
    Console.WriteLine("4 - Sair");
    linha();
    Console.WriteLine("\nEscolha uma opção");

    //trycatch para tratar erros possiveis
    try
    {
        int op = int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                aluno.Cadastrar();
                break;
            case 2:
                media.CalcularMedia();
                break;
            case 3:
                media.CalcularMedia();
                break;
            case 4:
                sair = true;
                Console.Clear();
                linha();
                Console.WriteLine("Encerrando o Sistema...");
                linha();
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }
        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
    }
    catch (Exception)
    {
        Console.WriteLine("\nErro: Digite um numero valido");
        Console.ReadLine();

    }

    Console.ReadKey();
}