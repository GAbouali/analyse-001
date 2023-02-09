// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки
//-----------------------------------------------------------------------------------


//opt 1 , the simple one.

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string msg1, int msg2)
// {
//     Console.WriteLine(msg1);
//     Console.WriteLine(msg2);
// }

// int sumsym(int num)
// {
//     int res = 0;
//     while (num > 0)
//     {
//         res = res + num % 10;
//         num = num / 10;

//     }
//     return res;
// }

// int number = ReadData("input number: ");
// int res = sumsym(number);
// PrintData("sumsym: ",res);
//-------------------------------------------------------------



//opt 2, massive.

//test 1 
// Console.WriteLine("input num, ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// int[] numarray = new int[num];
// Console.WriteLine(num);
//-------------------------

//test 2 

Console.WriteLine("input num, ");              //print inputs.
string? num = Console.ReadLine() ?? "0";      //creat V = the 'inputs'
char[] numarray = num.ToCharArray();         //creat V = transform inputs to an 'array'
int indx = 0;
int arraylen = numarray.Length;             // creat V = 'array' length.
// Console.WriteLine(arraylen);

while (indx < arraylen)
{
    // int sum = 0;
    string outNumLine = string.Empty;
    // int numinx=numarray[i]+0;
    outNumLine = outNumLine + numarray[indx];
    indx++;
    // // int d=int.Parse(outNumLine ?? "0");
    // sum = sum + numarray[indx] + numarray[indx - 1];

    Console.WriteLine(outNumLine);
}







