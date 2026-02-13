double valorCompra,desconto,total=0;
int pagamento;
string opcao,frete;
opcao = "";

Console.Write("Digite o valor da compra: ");
valorCompra = double.Parse(Console.ReadLine());

if (valorCompra >0){
    Console.WriteLine("======= Meio de Pagamento =======\n1.Cretito\n2.Débito\n3.pix");
    Console.Write("Escolha a opção: ");
    pagamento = int.Parse(Console.ReadLine());

    switch (pagamento)
    {
        case 1:
            opcao = "Credito +3% taxa";
            desconto = valorCompra * 0.03;
            total = desconto + valorCompra;
            break;
        case 2:
            opcao = "Débito 0% taxa";
            total = valorCompra;
            break;
        case 3:
            opcao = "Pix 5% desconto";
            desconto = valorCompra * 0.05;
            total = valorCompra - desconto;
            break;
    }

    if (valorCompra >= 300)
    {
        frete = "Grátis";
    }else
    {
        frete = "R$ 25,00";
        total = total + 25;
    }

    Console.WriteLine("Pagamento: "+opcao+"\nFrete: "+frete+"\nTotal: "+ total.ToString("C"));
}else
{
    Console.WriteLine("Digite um valor valido (maior que 0)");
}

