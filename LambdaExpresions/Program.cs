// See https://aka.ms/new-console-template for more information
Console.WriteLine("---example 1---");


// args => expresion
// number => number * number

//Func<int, int> FuncHandler = number => number * number;

Func<int, int> Square = number => number * number;

Console.WriteLine(Square(5));


//static int Square(int number)
//{
//    return number * number;
//}

Console.WriteLine("---example 2---");

//
const int factor = 5;

Func<int, int> multipler = n => n * factor;
var result = multipler(10);
Console.WriteLine(result);