//trabalhando com console application

//objetivo:solicitar nome, sobrenome, ano de nasc
//ao usuario e calcular a idade

//1.dearação de variaveis
int valor1, valor2, total;

//solicitar os inuts do usuario
Console.Write("Informe o valor 1: ");
valor1=int.Parse(Console.ReadLine());

Console.Write("Informe o valor 2: ");
valor2 = int.Parse(Console.ReadLine());

//efetuar caculos se tiver
Console.WriteLine("Escolha uma das opções abaixo");
Console.WriteLine("1. SOMA");
Console.WriteLine("2. SUBTRAÇÃO");
Console.WriteLine("3. MULTIPLICAÇÃO");
Console.WriteLine("4. DIVISÃO");


int op = int.Parse(Console.ReadLine());
//exibir resultados
if (op == 1)
{
    total = valor1 + valor2;
    Console.WriteLine("Soma: " + total);

}

if (op == 2)
{
    total = valor1 - valor2;
    Console.WriteLine("Subtração: " + total);

}

if (op == 3)
{
    total = valor1 * valor2;
    Console.WriteLine("Multiplicação: " + total);

}

if (op == 4)
{
    if (valor2 == 0) { 
        Console.WriteLine("Informe um novo valor! \n\\não há divisão por 0 ");
    }else
    {
        total = valor1 / valor2;
        Console.WriteLine("Divisão: " + total);
    }

}


