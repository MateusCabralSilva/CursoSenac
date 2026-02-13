// 1

int i=1;
while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}


//2

int i;
Console.Write("Digite um numero: ");
i = int.Parse(Console.ReadLine());

while (i >= 1)
{
    Console.WriteLine(i);
    i--;
}

//3

int num, i=1;
Console.Write("Digite um numero: ");
num = int.Parse(Console.ReadLine());

while (i <= 10)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
    i++;
}

//4

int num,i = 1;

Console.Write("Digite um numero: ");
num = int.Parse(Console.ReadLine());

while (i <= 8)
{
    Console.WriteLine(i + num);
    i++;
}

//5

string nome, email;
int i=1,cpf, idade, telefone;

while (i <= 5)
{
    Console.WriteLine($"\n-------- PESSOA {i}º --------");
    Console.Write("Digite seu Nome: ");
    nome = Console.ReadLine();

    Console.Write("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.Write("Digite seu E-mail: ");
    email = Console.ReadLine();

    Console.Write("Digite seu cpf: ");
    cpf = int.Parse(Console.ReadLine());

    Console.Write("Digite seu telefone: ");
    telefone = int.Parse(Console.ReadLine());

    if (idade >= 60)
    {
        Console.WriteLine("\n-> Dar desconto");
    }

    i++;
}