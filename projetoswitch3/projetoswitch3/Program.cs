int numero;

Console.Write("Digite um numero de 1 a 7: ");
numero = int.Parse(Console.ReadLine());

switch (numero)
{
    case 1:
        Console.WriteLine("Domingo!");
        break;
    case 2:
        Console.WriteLine("Segunda-Feira!");
        break;
    case 3:
        Console.WriteLine("Terça-Feira!");
        break;
    case 4:
        Console.WriteLine("Quarta-Feira!");
        break;
    case 5:
        Console.WriteLine("Quinta-Feira!");
        break;
    case 6:
        Console.WriteLine("Sexta-Feira!");
        break;
    case 7:
        Console.WriteLine("Sábado!");
        break;
    default:
        Console.WriteLine("informe um N° valido!");
        break;
}