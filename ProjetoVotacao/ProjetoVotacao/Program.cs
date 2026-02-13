/*
 Objetivo: Simulador de Votação
 ﻿﻿Desenvolva um sistema que faça a simulação de votação.
 ﻿﻿O programa deve:
﻿﻿ 1. ler a idade do usuário usar if para verificar se pode votar(idade>=16)
 caso possa votar, solicitar o tipo de eleição (municipal, estadual ou federal)
 utilizar switch case para exibir quais cargos serão votados conforme a eleição:
 ﻿  Municipal: prefeitos e vereadores
 ﻿  Estadual: governadores e deputados estaduais
﻿   Federal: presidente e deputados federais
 Caso o tipo de eleição seja inválido, exibir "Tipo de eleição inválido!" 
*/

int idade,opc;

Console.Write("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade>=16)
{
    Console.WriteLine("1.Municipal: prefeitos e vereadores\n2.Estadual: governadores e deputados estaduais\n3.﻿Federal: presidente e deputados federais");
    opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            Console.WriteLine("Voce votara para prefeitos e vereadores");
            break;
        case 2:
            Console.WriteLine("Voce votara para governadores e deputados estaduais");

            break;
        case 3:
            Console.WriteLine("Voce votara para presidente e deputados federais");

            break;
        default:
            Console.WriteLine("Tipo de eleição inválido!");
            break;
    }
        
}else
{
    Console.WriteLine("Acesso negado, idade não aceita");
}