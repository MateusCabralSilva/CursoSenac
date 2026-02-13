//6
/*
int num,num2, i = 1;

Console.Write("Digite um numero: ");
num = int.Parse(Console.ReadLine());

while (i <= 20)
{
    num2 = num + i;
    if (num2 % 2 == 0)
    {
        Console.WriteLine(num2);
    }
    i++;
}
*/
//7
/*
int nota,i = 1;

Console.Write("Digite um numero (0 a 10): ");
nota = int.Parse(Console.ReadLine());

while (nota <= 10)
{
    Console.WriteLine($"Nota digitada: {nota}");
    Console.Write("Digite outra nota: ");
    nota = int.Parse(Console.ReadLine());
}
Console.WriteLine("Numero não valido! Digite 0 a 10");
*/
//9

Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();

int i = 0;
int totalVogais = 0;

while (i < palavra.Length)
{
    char letra = char.ToLower(palavra[i]);

    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
    {
        totalVogais++;
    }
    i++;
}
Console.WriteLine($"A palavra {palavra} tem {totalVogais} vogais!");

//10
/*
string senha = "", senhaCorreta = "1234", login="", LoginCorr="Mateus";

while (login != LoginCorr)
{
    Console.Write("Digite seu Login: ");
    login = Console.ReadLine();

    if (login != LoginCorr)
    {
        Console.WriteLine("Login incorreto, tente novamente!");
    }
}

while (senha != senhaCorreta)
{
    Console.Write("Digite sua senha: ");
    senha = Console.ReadLine();

    if (senha != senhaCorreta)
    {
        Console.WriteLine("Senha incorreta, tente novamente!");
    }
}
*/
//11
/*
int total=0,valor=0,i=0;

while (i != 1)
{
    Console.Write("Valor do produto (digite 0 para encerrar): ");
    valor = int.Parse(Console.ReadLine());
    total = valor + total;
    if (valor == 0)
    {
        Console.WriteLine($"\nPrograma encerrado\nValor total: {total.ToString("C")}");
        i++;
    }
}
*/