/*
int numero;

do
{
    Console.Write("Digite um Nº qualquer: ");
    numero = int.Parse(Console.ReadLine());
}
while (numero<0);
Console.WriteLine($"Nº válido: {numero}");
*/

// 2
/*
int senha; 
do
{
    Console.Write("Digite a senha: ");
    senha = int.Parse(Console.ReadLine());

    if (senha!=1234)
    {
        Console.WriteLine("Senha incorreta!\nTente novamente!");
    }
}
while (senha!=1234);
Console.WriteLine("\nAcesso permitido!");

*/
// 3
/*
using System.Collections.Concurrent;

int opcao;
do
{
    Console.WriteLine("---- MENU ----");
    Console.WriteLine("1 - Boas vindas!");
    Console.WriteLine("2 - Mostrar Data Atual");
    Console.WriteLine("3 - Sair do sistema");
    Console.Write("Escolha: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Seja Bem-Vindo(a)!");
            break;
        case 2:
            Console.WriteLine($"Data atual: {DateTime.Now.ToLongDateString()}");
            break;
        case 3:
            Console.WriteLine("Encerrando o sistema...");
            opcao = 3;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

}
while (opcao!=3);

*/

// 4
//*
double soma = 0;
string resp;

do
{
    Console.Write("Digite um Nº: ");
    //vai receber o valor e atribuir de forma acumulativa
    soma += double.Parse(Console.ReadLine());

    Console.Write("Deseja continuar (S/N)?: ");
    resp = Console.ReadLine().ToUpper();
}
while (resp=="S");
Console.WriteLine($"Resultado da soma: {soma}");
//*/