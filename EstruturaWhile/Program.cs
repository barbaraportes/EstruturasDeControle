Console.WriteLine("## Instrução While ##\n");

//EXEMPLO 1

//var i = 1;

//while (i <= 10)
//{
//    Console.WriteLine($"i = {i}");
//    i++;
//}



//EXEMPLO 2

//var i = 10;

//while (i > 0)
//{
//    Console.WriteLine($"i = {i}");
//    i--;
//}



//EXEMPLO 3 - Tabuada de um numero

//int numero;

//int contador = 1;

//Console.WriteLine("\nDigite um numero maior que 0\t");

//numero = Convert.ToInt32(Console.ReadLine());

//if (numero > 0)
//{
//    Console.WriteLine($"\n## Tabuada do {numero} ##\n");
//    while (contador < 11)
//    {
//        Console.WriteLine($"{numero} X {contador} = {numero*contador}");
//        contador++;
//    }
//}
//else
//{
//    Console.WriteLine("Numero deve ser maior que 0");
//}


// EXEMPLO 4 - SAINDO DO LOOP COM BREAK

//while(true)
//{
//    Console.WriteLine("\nInforme um numero inteiro: (para sair digite 999)");
//    int numero = Convert.ToInt32(Console.ReadLine());

//    if (numero == 999)
//    {
//        break;
//    }

//    if (numero % 2 == 0)
//    {
//        Console.WriteLine($"{numero} é par");
//    }
//    else
//    {
//        Console.WriteLine($"{numero} é impar");
//    }

//}


//EXEMPLO 5 - COORDENADAS DO PLANO CARTESIANO (X,Y)

int x = 0;
while(x < 5)
{
    int y = 0;

    while(y < 5)
    {
        Console.Write($"({x}, {y}) ");
        y++;
    }

    x++;
    Console.WriteLine();
}





Console.WriteLine("\nFim do processamento . . .");
Console.ReadKey();