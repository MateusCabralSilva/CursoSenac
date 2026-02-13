int nasc, idade, contador=1;
string nome, cidade;


while (contador <=5)
{
    Console.WriteLine($"\n-------- PESSOA {contador}º --------");
    Console.Write("Digite seu Nome: ");
    nome = Console.ReadLine();

    Console.Write("Ano de Nascimento: ");
    nasc = int.Parse(Console.ReadLine());

    Console.Write("Digite sua Cidade: ");
    cidade = Console.ReadLine();

    idade = DateTime.Now.Year - nasc;

    Console.WriteLine($"----- Dados Pessoa {contador}º -----\nNome: {nome}\nCidade: {cidade}\nIdade: {idade}\n---------------------------");

    contador++;
}
