int idade, plano,valor=0;
string plan="";
double total=0,desconto;
Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade > 0)
{
    Console.WriteLine("====== Planos ======\n1.Mensal\n2.Trimestral\n3.Anual");
    Console.Write("Escolha uma opção: ");
    plano = int.Parse(Console.ReadLine());

    switch (plano)
    {
        case 1:
            plan = "Mensal";
            valor = 100;
            break;
        case 2:
            plan = "Trimestral";
            valor = 270;
            break;
        case 3:
            plan = "Anual";
            valor = 900;
            break;
    }
    if (idade >= 60)
    {
        desconto = valor * 0.20;
        total = valor - desconto;
        Console.WriteLine("Desconto 20% Aplicado");
    }else
    {
        total = valor;
    }

    Console.WriteLine("Plano: "+plan+ "\nIdade: "+idade+"\nTotal: " + total.ToString("C"));
}else
{
    Console.WriteLine("Digite uma idade valida (maior que 0)");
}