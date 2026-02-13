bool inicio = false;

static void linha()
{
    Console.WriteLine("===============================================");
}
int opc, clientes = 0, cpct = 10;

string[] nome = new string[cpct];
char[] resposta = new char[cpct];
double[] nota = new double[cpct];

while (inicio != true)
{
    Console.Clear();
    linha();
    Console.WriteLine("SISTEMA DE AVALIAÇÃO - TECHSTORE");
    linha();
    Console.WriteLine("1 - Registrar avaliação\n2 - Exibir todas as avaliações\n3 - Calcular media geral das notas\n4 - Mostrar quantidade de clientes que voltariam\n5 - Exibir melhor e pior nota\n6 - Sair");
    linha();
    opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            Console.Clear();
            if (clientes < 10 )
            {
                Console.WriteLine("===== Registro de clientes =====");
                Console.Write("Nome do cliente: ");
                nome[clientes] = Console.ReadLine();
                do
                {
                    Console.Write("Nota do cliente: ");
                    nota[clientes] = int.Parse(Console.ReadLine());

                    if (nota[clientes] != 1 && nota[clientes] != 2 && nota[clientes] != 3 && nota[clientes] != 4 && nota[clientes] != 5)
                    {
                        Console.WriteLine("\nDigite uma nota de 1 a 5!\n");
                    }
                }
                while (nota[clientes] != 1 && nota[clientes] != 2 && nota[clientes] != 3 && nota[clientes] != 4 && nota[clientes] != 5);
                do
                {
                    Console.Write("Voltaria a comprar novamente? (S/N):");
                    resposta[clientes] = char.Parse(Console.ReadLine().ToUpper());
                    if (resposta[clientes] != 'S' && resposta[clientes] != 'N')
                    {
                        Console.WriteLine("\nResposta não valida digite 'S' ou 'N'\n");
                    }
                }
                while (resposta[clientes] != 'S' && resposta[clientes] != 'N');
                clientes++;

                Console.WriteLine("\nRegistrado!\n\nPressione enter para continuar...");
            }
            else
            {
                Console.WriteLine("===== Registro de clientes =====");
                Console.WriteLine("\nNão há mais espaço no sistema para registro");
            }
                break;
        case 2:
            Console.Clear();
            Console.WriteLine("===== Avaliação dos clientes =====");

            for (int j = 0; j < clientes; j++)
            {
                Console.WriteLine($"CLIENTE {j+1}º \nNome do cliente: {nome[j]}\nNota avaliativa: {nota[j]}\nIndicação se voltaria a comprar novamente: {resposta[j]}\n");
            }

            Console.WriteLine("\n\nPressione enter para continuar...");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("===== Media geral das notas =====");

            double soma = 0;

            for (int j = 0; j < nota.Length; j++)
            {
                soma += nota[j];
            }
            double media = soma / clientes;
            Console.WriteLine($"Média geral das notas: {media:f2}");

            Console.WriteLine("\n\nPressione enter para continuar...");

            break;
        case 4:
            Console.Clear();
            Console.WriteLine("===== Quantidade de clientes =====");

            int contador =0;
            for (int j = 0; j < 10; j++)
            {
                if (resposta[j] == 'S')
                {
                    contador++;
                }
            }
            Console.WriteLine($"\nClientes que voltariam: {contador}");
            Console.WriteLine("\n\nPressione enter para continuar...");

            break;
        case 5:
            Console.Clear();

            Console.WriteLine("===== Melhor e pior nota =====");

            double mNota = nota[0];
            double pNota = nota[0];
            string mClient = nome[0];
            string pClient = nome[0];

            for (int i = 0; i < clientes; i++)
            {
                if (nota[i] > mNota)
                {
                    mNota = nota[i];
                    mClient = nome[i];
                }
                if (nota[i] < pNota)
                {
                    pNota = nota[i];
                    pClient = nome[i];
                }
            }

            Console.WriteLine($"Melhor nota foi {mNota} de {mClient}");
            Console.WriteLine($"Pior nota foi {pNota} de {pClient}");
            Console.WriteLine("\n\nPressione enter para continuar...");
            break;
        case 6:
            inicio = true;
            Console.WriteLine("\nEncerrando...");
            break;
    }

    Console.ReadKey();
}