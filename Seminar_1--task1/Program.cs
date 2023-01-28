// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.

Console.WriteLine("inter first number: ");
string? input1 = Console.ReadLine();

Console.WriteLine("inter first number: ");
string? input2 = Console.ReadLine();

if(input1!=null && input2!=null )
{
    int number1 = int.Parse(input1);
    int number2 = int.Parse(input2);

    if(number1 == number2*number2)
    {
        Console.WriteLine("first num is the square of first number, ");
    }
    else
    {

         Console.WriteLine("first num isnt the square of first number, ");

    }
}

