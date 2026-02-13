int numero;

Console.Write("Digite um numero inteiro: ");
numero = int.Parse(Console.ReadLine());

while (numero != 0) // != diferente
{
    Console.WriteLine($"Você digitou: {numero}");
    Console.Write("informe outro numero: ");
    numero = int.Parse(Console.ReadLine());
}
Console.WriteLine("Programa encerrado!");