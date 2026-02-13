decimal soma = 0;

for (int i = 1; i <= 4; i++)
{
    Console.Write($"Digite a {i}ª Nota: ");
    soma += decimal.Parse(Console.ReadLine());
}

decimal media = soma / 4;
Console.WriteLine($"Media é: {media}");