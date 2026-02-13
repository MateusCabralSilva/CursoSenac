string senha = "", senhaCorreta = "1234";

while (senha !=senhaCorreta)
{
    Console.Write("Digite sua senha: ");
    senha = Console.ReadLine();

    if (senha != senhaCorreta)
    {
        Console.WriteLine("Senha incorreta, tente novamente!");
    }
}
Console.WriteLine("Acesso Liberado!"); 