Console.WriteLine("## Instrução For ##");


//EXEMPLO 1
//int resultado, numero;

//Console.WriteLine("Informe o número inteiro: \t");
//numero = Convert.ToInt32(Console.ReadLine());

//if (numero > 0)
//{ 

    //for(int i = 1; i <=10; i++) //i+=2 para ir de 2 em 2 numeros
    //{
    //    resultado = numero * i;
    //    Console.WriteLine($"{numero} X {i} = {resultado}");
    //}
//}

//else
//{
//    Console.WriteLine("Numero invalido");
//}



//EXEMPLO 2

//for (int i = 0, j = 0; i+j <= 20; i++, j++)
//{
//    Console.WriteLine($"i = {i} e j = {j}");
//}



//EXEMPLO 3 - LOOPS ANINHADOS - cartesiano

for(int x = 0; x < 5; x++)
{
    for(int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y}) ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento . . .");
Console.ReadKey();