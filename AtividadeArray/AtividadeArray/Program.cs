double[] nt = new double[5];
double soma = 0;

for (int i = 0; i < nt.Length; i++)
{
    Console.Write($"Digite a {i + 1}º nota: ");
    nt[i] = double.Parse(Console.ReadLine());
    soma += nt[i];
}
double media = soma / nt.Length;

if (media >= 8)
{
    Console.WriteLine($"Media: {media:f2} \nSituação: Aprovado");
}
else if (media >= 5 && media < 8)
{
    Console.WriteLine($"Media: {media:f2} \nSituação: Recuperação");
}
else
{
    Console.WriteLine($"Media: {media:f2} \nSituação: Reprovado");
}