/*
 * Objetivo: Vai simular um cardápio digital de lanchonete.
 * O programa deve:
 * 1.Mostrar o cardápio com as opções:
﻿﻿ *    .Hambúrguer (R$15,00)
 *    .Batata frita (R$8,00)
 *    .Refrigerante (R$6,00)
 * Ler a opção escolhida pelo usuário.
﻿﻿﻿ * Exibir o valor total do pedido conforme o item escolhido.
 * 4. Exibir a mensagem de erro caso a opção seja inválida.
 * Dica: use switch-case para as opções e if-else para validar o pedido.
*/

int opcao,valor;
valor = 0;

Console.WriteLine("======== Cardapio ========");
Console.WriteLine("1.Hambúrguer (R$15,00)\n2.Batata frita (R$8,00)\n3.Refrigerante (R$6,00)");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Opçao selecionada Hambúrguer");
        valor = 15;
        break;
    case 2:
        Console.WriteLine("Opçao selecionada Batata frita");
        valor = 8;
        break;
    case 3:
        Console.WriteLine("Opçao selecionada Refrigerante");
        valor = 6;
        break;
    default:
        Console.WriteLine("Opçao não valida");
        break;
}

Console.WriteLine("Valor total: "+valor.ToString("C"));