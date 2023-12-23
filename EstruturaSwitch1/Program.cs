Console.WriteLine("## Instrução Switch 1\n");


//EXEMPLO 1

//int compra = 600;
//Console.WriteLine($"Valor da compra {compra:c}");
//Console.WriteLine("Informe o nº de parcelas (1 a 3)");
//var numeroParcelas = Convert.ToInt32(Console.ReadLine());

//switch (numeroParcelas)
//{
//    case 1:
//        Console.WriteLine($"\nPrestação {compra / numeroParcelas:c}");
//        break;

//    case 2:
//        Console.WriteLine($"\nPrestação {compra / numeroParcelas:c}");
//        break;

//    case 3:
//        Console.WriteLine($"\nPrestação {compra / numeroParcelas:c}");
//        break;

//    default:
//        Console.WriteLine("\nValor inválido: informe 1, 2 ou 3");
//        break;
//}


//EXEMPLO 2

//Console.WriteLine("Informe o numero inteiro");
//var numero = Convert.ToInt32(Console.ReadLine());
//switch(numero % 2)
//{
//    case 0:
//        Console.WriteLine($"\n{numero} é par");
//        break;

//    case 1:
//        Console.WriteLine($"\n{numero} é impar");
//        break;
//}


//EXEMPLO 3

//Console.WriteLine("Informe o nome do mês");
//var mes = Console.ReadLine().ToLower();

//switch (mes)
//{
//	case "janeiro":
//    case "março":
//    case "maio":
//    case "julho":
//    case "agosto":
//    case "outubro":
//    case "dezembro":
//        Console.WriteLine("Este mês tem 31 dias");
//        break;

//    case "fevereiro":
//        Console.WriteLine("Este mês tem 28 ou 29 dias");
//        break;

//    default:
//        Console.WriteLine("Este mes tem 30 dias");
//		break;
//}


//EXEMPLO 4 - SWITCH ANINHADO

int cargo = 0;
int funcao = 0;

Console.WriteLine("Você é gerente(1) ou programador(2)?");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é junior(1) ou Senior(2)?");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("Bem vindo gerente");
        break;

        case 2:
        Console.WriteLine("Bem vindo programador");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Voce é Junior");
                break;
            case 2:
                Console.WriteLine("Voce é senior");
                break;
            default:
                Console.WriteLine("Função desconhecida");
                break;
        }
        break;

    default:
        Console.WriteLine("Cargo desconhecido");
        break;
}


Console.WriteLine("Fim do processamento");
Console.ReadKey();

