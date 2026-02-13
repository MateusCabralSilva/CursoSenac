int horas,tipo,preco=0;
double desconto,total;

Console.Write("Digite quantas horas ficou na vaga: ");
horas = int.Parse(Console.ReadLine());
if (horas > 0)
{
    Console.WriteLine("===== Tipo de veiculo =====");
    Console.WriteLine("1.Carro\n2.Moto\n3.caminhonete");
    Console.Write("Escolha um opção: ");
    tipo = int.Parse(Console.ReadLine());

    switch (tipo)
    {
        case 1:
            preco = 5;
            break;
        case 2:
            preco = 3;
            break;
        case 3:
            preco = 7;
            break;
    }

    total = horas * preco;

    if (horas > 4)
    {
        desconto = total * 0.10;
        total = total - desconto;
        Console.WriteLine("Desconto aplicado por ter ficado mais que 4 horas");
    }

    Console.WriteLine("Total: " + total.ToString("C"));
}else
{
    Console.WriteLine("Digite Horas validas (maior que 0)");
}