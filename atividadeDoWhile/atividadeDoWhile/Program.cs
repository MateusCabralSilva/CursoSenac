// 1
/*
while (true)
{
    int num;

    Console.Write("Digite um numero: ");
    num = int.Parse(Console.ReadLine());

    if (num < 1)
    {
        Console.WriteLine("Numero negativo");
    }else
    {
        Console.WriteLine("Numero positivo");
    }

    if (num == 0)
    {
        Console.WriteLine("Numero Zero");
    }
}
*/

// 2 

int idade;

do
{
    Console.Write("Digite sua idade (0 a 120): ");
    idade = int.Parse(Console.ReadLine());

    if (idade < 0 || idade > 120)
    {
        Console.WriteLine("Idade inválida! Tente novamente.");
    }

} while (idade < 0 || idade > 120);

Console.WriteLine($"Idade válida: {idade}");


// 3
/*
bool cond=true;
while (cond != false)
{
    int opc;

    Console.WriteLine("\n========== MENU ==========\n1.Exibir data\n2.Exibir hora\n3.Sair");
    Console.Write("Escolha uma opção: ");
    opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
            break;
        case 2:
            DateTime hora = DateTime.Now;
            Console.WriteLine(hora.ToString("HH:mm:ss"));
            break;
        case 3:
            Console.WriteLine("Encerrando...");
            cond = false;
            break;
        default:
            Console.WriteLine("Digite uma opção valida");
            break;
    }
}
*/
// 4
/*
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/

// 5
/*
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}]
*/

// 6
/*
int nt1, nt2, nt3,media;

Console.Write("Digite a 1º nota: ");
nt1 = int.Parse(Console.ReadLine());

Console.Write("Digite a 2º nota: ");
nt2 = int.Parse(Console.ReadLine());

Console.Write("Digite a 3º nota: ");
nt3 = int.Parse(Console.ReadLine());

media = (nt1 + nt2 + nt3) / 3;

if (media >= 6)
{
    Console.WriteLine($"\nNota media: {media}\nAprovado");
}
else
{
    Console.WriteLine($"\nNota media: {media}\nReprovado");
}
*/

// 7
/*
bool cond = true;
int num = 0, n=1;
while (cond != false)
{
    int num2;

    Console.Write($"Digite o {n}º numero: ");
    num2 = int.Parse(Console.ReadLine());
  
    if (num2 == 0)
    {
        cond = false;
        Console.WriteLine($"Foram digitados {num} numeros");
    }
    num++;
    n++;
}
*/

// 8
/*
string opc;

do
{
    int num1, num2;
    string opr;

    Console.Write("Digite o 1º numero: ");
    num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o 2º numero: ");
    num2 = int.Parse(Console.ReadLine());

    Console.Write("Escolha uma operação (+,-,*,/): ");
    opr = Console.ReadLine();

    if (opr == "+")
    {
        Console.WriteLine($"\nResultado: {num1 + num2}");
    }
    if (opr == "-")
    {
        Console.WriteLine($"\nResultado: {num1 - num2}");
    }
    if (opr == "*")
    {
        Console.WriteLine($"\nResultado: {num1 * num2}");
    }
    if (opr == "/")
    {
        Console.WriteLine($"\nResultado: {num1 / num2}");
    }
    Console.Write("Deseja continuar (S/N)?: ");
    opc = Console.ReadLine().ToUpper();
}
while (opc == "S");
Console.WriteLine("Encerrando...");
*/

// 9
/*
using System.Diagnostics;

string opc;

do
{
    string produtos;
    int valor;

    Console.Write("Digite o nome do produto: ");
    produtos = Console.ReadLine();

    bool cond = true;

    while (cond != false)
    {
        Console.Write("Digite o valor do produto: ");
        valor = int.Parse(Console.ReadLine()); 
        
        if (valor <= 0)
        {
            Console.WriteLine("Digite um numero positivo");
        }else
        {
            cond = false;
        }
    }

    Console.Write("Deseja continuar (S/N)?: ");
    opc = Console.ReadLine().ToUpper();
}
while (opc == "S");
Console.WriteLine("Encerrando...");
*/

// 10

string continuar;

do
{
    Console.Write("Quantas notas você deseja inserir? ");
    int quantidade = int.Parse(Console.ReadLine());

    int soma = 0;

    for (int i = 1; i <= quantidade; i++)
    {
        Console.Write($"Digite a nota {i}: ");
        int nota = int.Parse(Console.ReadLine());
        soma += nota;
    }

    int media = soma / quantidade;
    Console.WriteLine($"A média das notas é: {media}");

    if (media >= 7)
    {
        Console.WriteLine("Aluno aprovado!");
    }
    else
    {
        Console.WriteLine("Aluno reprovado!");
    }

    Console.Write("\nDeseja calcular outra média? (s/n): ");
    continuar = Console.ReadLine().ToLower();

} while (continuar == "s");

Console.WriteLine("Encerrando...");