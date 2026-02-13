string opcao;

Console.WriteLine("===MENU DE ATENDIMENTO AO CLIENTE ===");
Console.WriteLine("1. - Financeiro: ");
Console.WriteLine("2. - Suporte Técnico: ");
Console.WriteLine("3. - Comercial: ");
Console.Write("\nDigite o número da opção desejada (1 a 3): ");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":

        Console.WriteLine("\n--- Financeiro --- ");
        Console.WriteLine("1. - 2ª vai do boleto ");
        Console.WriteLine("2. - Acerto de dívidas ");
        opcao = Console.ReadLine();
        if (opcao == "1")
        {
            Console.WriteLine("Ligar para (11)96324-6677");
        }
        else
        {
            Console.WriteLine("enviar e - mail para financeiro@cabral.com.br");
        }
        break;

    case "2":
        Console.WriteLine("\n--- SUPORTE TÉCNICO ---");
        Console.WriteLine("1. - Suporte na conexão ");
        Console.WriteLine("2. - Suporte no aplicativo ");
        opcao = Console.ReadLine();

        if (opcao == "2")
        {
            Console.WriteLine("aguardar sua vez para o atendimento");
        }
        else
        {
            Console.WriteLine("solicitar via email: suporte@cabral.com.br");
        }
        break;


    case "3":
        Console.WriteLine("\n--- COMERCIAL ---");
        Console.WriteLine("Estamos com atendimento sobrecarregado, ligue mais tarde!");
        break;

    default:
        Console.WriteLine("\n Opção Inválida. Tente novamente! ");
        break;
}

{
    Console.WriteLine("\nPressione qualquer tecla para encerrar ...");
    Console.ReadKey();
}