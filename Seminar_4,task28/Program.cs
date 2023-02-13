// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// Например:
// 4 -> 24
// 5 -> 120
//-------------------------------------------------------
using System.Numerics;

//universal method to read the inputs, transform it from text to numbers,
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//universal method to print the results(outputs for the user)
void PrintData(string msg1, BigInteger msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

BigInteger calcfact(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++) 
    {
        res = res * i;

    }
    return res;
}

//calling methods.
int number = ReadData("input number: ");
BigInteger fact = calcfact(number);
PrintData("factor = ", fact);