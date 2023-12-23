
//1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior


//int numero1, numero2, numero3;

//Console.WriteLine("Informe o primeiro número inteiro:");
//numero1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Informe o segundo número inteiro:");
//numero2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Informe o terceiro número inteiro:");
//numero3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"1º número: {numero1}");
//Console.WriteLine($"2º número: {numero2}");
//Console.WriteLine($"3º número: {numero3}");


//if (numero1 > numero2 && numero1 > numero3)
//{
//    Console.WriteLine($"\nO primeiro número ({numero1}) é o maior");
//}
//else if (numero2 > numero1 && numero2 > numero3)
//{
//    Console.WriteLine($"O segundo número ({numero2}) é o maior");
//}
//else
//{
//    Console.WriteLine($"O terceiro número ({numero3}) é o maior");
//}


//-----------------------------------------------------------------------------------------------------------------


//2- Escreva um programa para calcular a raiz da equação quadrática: ax² + bx + c = 0

//int a, b, c;
//double d, x1, x2;

//Console.WriteLine("Informe o valor de a:\n");
//a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Informe o valor de b:\n");
//b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Informe o valor de c:\n");
//c = Convert.ToInt32(Console.ReadLine());

//d = b * b - 4 * a * c;

//if (d == 0)
//{
//    Console.Write("As duas raízes são iguais.\n");
//    x1 = -b / (2.0 * a);
//    x2 = x1;
//    Console.Write($"Primeira raiz x1= {x1}\n");
//    Console.Write($"Segunda raiz x2= {x2}\n");
//}
//else if (d > 0)
//{
//    Console.Write("Ambas as raízes são reais e diferentes\n");
//    x1 = (-b + Math.Sqrt(d)) / (2 * a);
//    x2 = (-b - Math.Sqrt(d)) / (2 * a);
//    Console.Write($"Primeira raiz x1= {x1}\n");
//    Console.Write($"Segunda raiz x2= {x2}\n");
//}
//else
//    Console.Write("As raízes são imaginárias;\n Sem solução para os números reais. \n\n");



//EXERCICIO 3 - Escreva um programa para exibir os 10 primeiros números inteiros naturais e calcular a sua soma usando os loop while, do -while e for.

//WHILE

//int i = 1, soma = 0;
//Console.Write("Os 10 primeiros números naturais são :\n");
//while (i <= 10)
//{
//    soma = soma + i;
//    Console.Write($"{i} ");
//    i++;
//}
//Console.Write($"\nA soma dos números é : {soma}\n");


//DO-WHILE
//int i = 1, soma = 0;
//Console.Write("Os 10 primeiros números naturais são :\n");
//do
//{
//    soma = soma + i;
//    Console.Write($"{i} ");
//    i++;
//}
//while (i <= 10);
//Console.Write($"\nA soma dos números é : {soma}\n");


//FOR

//int i, soma = 0;
//Console.Write("Os 10 primeiros números naturais são :\n");
//for (i = 1; i <= 10; i++)
//{
//    soma = soma + i;
//    Console.Write($"{i} ");
//}
//Console.Write($"\nA soma dos números é : {soma}\n");



//EXERCICIO 4- Escreva um programa para exibir a tabela de multiplicação de um número inteiro maior que zero recebido via teclado

//while (true)
//{
//    int numero;
//    int contador = 1;
//    Console.Write("\nDigite um número maior que 0 (Digite '999' para sair): \t");
//    numero = Convert.ToInt32(Console.ReadLine());
//    if (numero == 999)
//        break;
//    if (numero > 0)
//    {
//        Console.WriteLine($"\n### Tabuada do {numero} ###\n");
//        while (contador < 11)
//        {
//            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//            contador++;
//        }
//    }
//    else
//    {
//        Console.WriteLine("\nO número deve ser maior que 0. ");
//    }
//}


//5- Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de resposta
//de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.

//string resposta;
//bool condicao = true;
//Console.WriteLine("Qual a instrução para sair de um loop ?");
//Console.WriteLine("a.quit");
//Console.WriteLine("b.continue");
//Console.WriteLine("c.break");
//Console.WriteLine("d.exit");
//while (condicao)
//{
//    Console.WriteLine("\nQual a opção correta ? (Tecle x para sair)");
//    resposta = Console.ReadLine().ToLower();
//    if (resposta == "c")
//    {
//        Console.WriteLine("Resposta Correta !");
//        condicao = false;
//    }
//    else if (resposta == "x")
//    {
//        Console.WriteLine("Programa encerrado..");
//        condicao = false;
//    }
//    else
//    {
//        Console.WriteLine("Resposta Incorreta !!!");
//    }
//}


//6- Crie um programa para escrever os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:

//maneira 1

//for (int i = 10; i <= 20; i += 2)
//{
//    if (i == 16)
//        continue;
//    Console.Write($"i = {i} ");
//}

//maneira 2

//for (int i = 10; i <= 20; i++)
//{
//    if (i % 2 == 1)
//        continue;
//    if (i == 16)
//        continue;
//    Console.Write($"i = {i} ");
//}

//maneira 3

//for (int i = 10; ; i += 2)
//{
//    if (i == 16)
//        continue;
//    if (i > 20)
//        break;
//    Console.Write($"i = {i} ");
//}



// EXERCICIO 7- Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*)

//int i, j, linhas;
//Console.Write("Informe o número de linhas : ");
//linhas = Convert.ToInt32(Console.ReadLine());
//for (i = 1; i <= linhas; i++)
//{
//    for (j = 1; j <= i; j++)
//        Console.Write("*");
//    Console.Write("\n");
//}


// EXERCICIO 8 - Escreva um programa para calcular o fatorial de um número inteiro.

//int i, f = 1, num;
//Console.Write("Cálculo do fatorial de um número:\n");
//Console.Write("\nInforme o número inteiro maior que zero : \t");
//num = Convert.ToInt32(Console.ReadLine());
//for (i = 1; i <= num; i++)
//    f = f * i;
//Console.Write($"\nO fatorial de {num} é: {f}\n");


//EXERCICIO 9- Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

//int numero = 2;
//do
//{
//    int multiplicador = 1;
//    do
//    {
//        Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador} ");
//        multiplicador++;
//    }
//    while (multiplicador <= 10);
//    Console.WriteLine(" ");
//    numero++;
//} while (numero <= 6);
//Console.ReadKey();


//10- Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de um
//aluno.Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a instrução
//switch, break e default em um loop infinito e defina uma condição de saida)

//while (true)
//{
//    Console.WriteLine("\nInforme a nota do aluno (99 sai) ");
//    int x = Convert.ToInt32(Console.ReadLine());
//    if (x == 99)
//        break;
//    Console.Write("\nResultado da avaliação: \t");
//    switch (x)
//    {
//        case 10:
//            Console.WriteLine("A+");
//            break;
//        case 9:
//            Console.WriteLine("A+");
//            break;
//        case 8:
//        case 7:
//            Console.WriteLine("B");
//            break;
//        case 6:
//            Console.WriteLine("C");
//            break;
//        case 5:
//            Console.WriteLine("E");
//            break;
//        default:
//            Console.WriteLine("F");
//            break;
//    }
//}


//EXERCICIO 11 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números inteiros maior que zero.

//int num1;
//int num2;
//string operando;
//float resposta;
//Console.Write("\nInforme o primeiro número: \t");
//num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("\nInforme o operando (+, -, /, *): ");
//operando = Console.ReadLine();
//Console.Write("\nInforme o segundo número: \t ");
//num2 = Convert.ToInt32(Console.ReadLine());
//switch (operando)
//{
//    case "-":
//        resposta = num1 - num2;
//        break;
//    case "+":
//        resposta = num1 + num2;
//        break;
//    case "/":
//        resposta = (float)num1 / num2;
//        break;
//    case "*":
//        resposta = num1 * num2;
//        break;
//    default:
//        resposta = 0;
//        break;
//}
//Console.WriteLine($"\n{num1} {operando} {num2} = {resposta}");
//Console.ReadKey();