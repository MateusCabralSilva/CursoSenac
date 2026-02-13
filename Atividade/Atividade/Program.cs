int opc, quantidade = 0;
double soma = 0;
string produto="";

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("------ Eletronic Store -----");
    Console.WriteLine($"\n1 - Processador Ryzen 5 5600G ........ R$ 899,00\n2 - Placa Mãe B550m Aorus Elite ...... R$ 799,00\n3 - Placa de Video RTX 5070 ...... R$ 4.799,00\n4 - Memória HyperX Fury de 8GB ...... R$ 259,00\n5 - SSD Kingston NV3 M.2 ........... R$ 314,00");
    Console.WriteLine($"\nPedido {i}º");
    Console.Write("Escolha uma opção: ");
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Clear();
            soma = soma + (quantidade * 899);
            produto = produto + "\nProcessador Ryzen 5 5600G";
            break;
        case 2:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Clear();
            soma = soma + (quantidade * 799);
            produto = produto + "\nPlaca Mãe B550m Aorus Elite";

            break;
        case 3:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Clear();
            soma = soma + (quantidade * 4799);
            produto = produto + "\nPlaca de Video RTX 5070";

            break;
        case 4:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Clear();
            soma = soma + (quantidade * 259);
            produto = produto + "\nMemória HyperX Fury de 8GB";

            break;
        case 5:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Clear();
            soma = soma + (quantidade * 314);
            produto = produto + "\nSSD Kingston NV3 M.2";
            break;
        default:
            Console.WriteLine("\nEscolha uma opção valida!");
            i = 3;
            break;
    }
}  
Console.WriteLine("\n------ Detalhe do pedido ------");
Console.WriteLine(produto);
Console.WriteLine();
if (soma >= 3000)
{
    double desconto = soma * 0.05;
    soma = soma - desconto;
    Console.WriteLine("Desconto de 5% aplicado ");
}

Console.WriteLine($"Valor total: {soma.ToString("C")}");
