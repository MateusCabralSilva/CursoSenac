/*
int[] numeros = { 10, 20, 30, 40, 50 };

Console.WriteLine("Os numeros do array numeros são: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}
*/
/*
int[] numeros = new int[4];
numeros[0] = 5;
numeros[1] = 10;
numeros[2] = 15;
numeros[3] = 20;

Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[numeros.Length-1]);
*/
/*
string[] frutas = { "maçã", "banana", "melancia" };

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"{i}: {frutas[i]}");
}
*/
/*
int[] valores = new int[5];

for (int i = 0; i < valores.Length; i++)
{
    Console.Write($"Digite o {i + 1}º numero: ");
    valores[i] = int.Parse(Console.ReadLine());


}
Console.WriteLine($"Você digitou: {string.Join(", " , valores)}");
*/

int[] num = new int[7];
int soma = 0;

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º numero: ");
    num[i] = int.Parse(Console.ReadLine());
    soma += num[i];
}
Console.WriteLine($"Soma dos elementos do array: {soma}");
