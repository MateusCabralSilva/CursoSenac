int num;

Console.Write("======== Tabuada ========\nDigite um numero: ");
num = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}

Console.WriteLine("=========================");