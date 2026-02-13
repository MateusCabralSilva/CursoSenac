string nome,cidade,uf, tel;
int anoNasc,idade;

int anoatual=DateTime.Now.Year;
Console.Write("Digite seu nome: ");
nome=Console.ReadLine();

Console.Write("Digite sua cidade: ");
cidade = Console.ReadLine();

Console.Write("Digite sua UF: ");
uf = Console.ReadLine();

Console.Write("Digite seu ano de nascimento: ");
anoNasc = int.Parse(Console.ReadLine());

Console.Write("Digite seu telefone: ");
tel = Console.ReadLine();

idade = anoatual - anoNasc;

Console.WriteLine("Ola! "+nome+" \nReside na cidade: "+cidade+"-UF: "+uf+"\nE tem "+idade+" anos!");

if (idade >= 18)
{
    Console.WriteLine("Acesso liberado");
}else
{
    Console.WriteLine("Entrada somente com os pais");
}
