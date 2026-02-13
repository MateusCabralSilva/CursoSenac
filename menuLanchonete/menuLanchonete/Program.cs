int opc, quantidade=0;
double soma=0;

Console.WriteLine("------ MENU LANCHONETE -----");
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"\nPedido {i}º\n1- Hambúrguer ........ R$ 15,00\n2 - Batata Frita ...... R$ 8,00\n3 - Refrigerante ...... R$ 6,00\n4 - Suco Natural ...... R$ 7,00\n5 - Sorvete ........... R$ 10,00\n6 - Sanduíche Natural ........ R$12,00");
    Console.Write("Escolha uma opção: ");
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            soma = soma + (quantidade * 15);
            break;
        case 2:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            soma = soma + (quantidade * 8);

            break;
        case 3:
            Console.Write("Digite a quantidade: "); 
            quantidade = int.Parse(Console.ReadLine());
            soma = soma + (quantidade * 6);
            break;
        case 4:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            soma = soma + (quantidade * 7);

            break;
        case 5:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            soma = soma + (quantidade * 10);
            break;
        case 6:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            soma = soma + (quantidade * 12);
            break;
        default:
            Console.WriteLine("\nEscolha uma opção valida!");
            i = 3;
            break;
    }
}

Console.WriteLine($"\nValor total: {soma.ToString("C")}");