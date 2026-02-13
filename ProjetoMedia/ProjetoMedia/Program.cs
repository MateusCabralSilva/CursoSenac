double n1,n2, n3, media;

Console.Write("Nota 1: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
n2 = int.Parse(Console.ReadLine());

Console.Write("Nota 3: ");
n3 = int.Parse(Console.ReadLine());

media = (n1 + n2 + n3) / 3;

if(media >= 7)
{
    Console.WriteLine("Aprovado");
}
if(media>=4 && media<7)
{
    Console.WriteLine("Recuperação");
}
if(media < 4)
{
    Console.WriteLine("Reprovado");
}