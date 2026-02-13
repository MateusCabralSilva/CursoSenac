string letra;

Console.Write("Digite uma letra: ");
letra = Console.ReadLine();
letra = letra.ToUpper();

switch (letra)
{
    case "A":
        Console.WriteLine("\nÉ uma vogal!");
        break;
    case "E":
        Console.WriteLine("\nÉ uma vogal!");
        break;
    case "I":
        Console.WriteLine("\nÉ uma vogal!");
        break;
    case "O":
        Console.WriteLine("\nÉ uma vogal!");
        break;
    case "U":
        Console.WriteLine("\nÉ uma vogal!");
        break;
    default:
        Console.WriteLine("\nÉ uma consoante!");
        break;
}