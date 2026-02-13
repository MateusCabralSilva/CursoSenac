int distancia,rota;
double preco=0,desconto,total;
string bagagem, ad,rotaN;
ad = "";
rotaN = "";

Console.Write("Digite a distancia em KM: ");
distancia = int.Parse(Console.ReadLine());
if (distancia > 0)
{
    Console.WriteLine("======= Rota =======\n1.Nacional\n2.Internacional");
    Console.Write("Digite a rota: ");
    rota = int.Parse(Console.ReadLine());

    Console.Write("Despachar Bagagem? (S/N): ");
    bagagem = Console.ReadLine();
    bagagem = bagagem.ToUpper();

    switch (rota)
    {
        case 1:
            preco = 0.50;
            rotaN = "Nacional";
            break;
        case 2:
            preco = 1.20;
            rotaN = "Internacional";
            break;
    }
    total = distancia * preco;

    if (rota > 2000)
    {
        desconto = total * 0.08;
        total = total - desconto;
        Console.WriteLine("Desconto aplicado por ter uma distancia maior que 2000Km");
    }



    switch (bagagem)
    {
        case "S":
            total = total + 120;
            ad = "Despache de bagagem";
            break;
        case "N":
            ad = "Nenhum adicional";
            break;
    }

    Console.WriteLine("Rota: " + rotaN + "\nDistancia: " + distancia + "Km \nItens Adicionais: " + ad + "\nTotal: " + total.ToString("C"));
}else
{
    Console.WriteLine("Digite um KM valido (maior que 0)");
}