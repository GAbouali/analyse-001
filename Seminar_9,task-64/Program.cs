
//                                         З а д а ч а  64 
//Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке
//  от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//-------------------------------------------------------------------------------------------------------------

// //                                           C O D E -- D r i v e r 
// int N = ReadData("Enter the number N: ");
// int[] Tes2 = ResultArray(N);
// Console.Write("Numbers from N to 1 = ");
// Print1DArray(Tes2);
// //                                               M E T H O D S

// int ReadData(string msg) //                                      reading the inputs.     
// {
//     //(msg) is what we ask user ti enter>>"input X1: "
//     Console.WriteLine(msg);
//     //form msg to number.
//     return int.Parse(Console.ReadLine() ?? "0");

// }

// int[] ResultArray(int n) //                                      generat an array with the result. 
// {
//     int[] Tes1 = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Tes1[i] = N - i;
//     }
//     return Tes1;
// }

// void Print1DArray(int[] meanArr) //                             print 1D array            
// {
//     Console.Write("[ ");
//     for (int i = 0; i < meanArr.Length - 1; i++)
//     {
//         Console.Write(meanArr[i] + " , ");
//     }
//     Console.Write(meanArr[meanArr.Length - 1] + " ]");
// }

//opt 2 REC
Console.Write("Enter the number N: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}










































