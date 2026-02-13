// FOR 1
/*
Console.Write("Digite um numero : ");
int num = int.Parse(Console.ReadLine());


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(num + i);
}


// FOR 2

for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}


// FOR 3

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{3 * i}");
}
*/
// FOR 4
/*
Console.Write("Digite um numero: ");
int num = int.Parse(Console.ReadLine());

for (int i = num; i >=1; i--)
{
    Console.WriteLine(i);
}


// FOR 5

//Exibir a soma dos números pares de 1 a 20

int soma = 0;

for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
        soma += i;
}

Console.WriteLine("Soma dos pares de 1 a 20: " + soma);
*/

// FOR 6

//Leia o valor de 5 produtos,
//calcule o total e aplique
//um desconto de 10% se o total
//for maior que R$100.

double soma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Digite o valor do {i}º produto: ");
    soma += double.Parse(Console.ReadLine());
}

Console.WriteLine($"\nTotal sem desconto: {soma.ToString("C")}");

if (soma > 100)
{
    double desconto = soma * 0.10;
    double totalFinal = soma - desconto;
    Console.WriteLine($"Desconto de 10% aplicado! " + $"Total com desconto: {totalFinal.ToString("C")}");
}
else
{
    Console.WriteLine("Não há desconto para " + "valores abaixo de R$ 100.");
}