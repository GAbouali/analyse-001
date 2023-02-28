// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//------------------------------

//                                               " Code Driver "
int r = ReadData("input rows count: ");
int c = ReadData("input colums count: ");
int[,] testranarr = creat2dranarray(r, c);
print2darray(testranarr);
Console.WriteLine("----------------------");
ReverseSortArray(testranarr);
//                                                  " methods "

int ReadData(string msg)                   //reading the inputs.   
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

int[,] creat2dranarray(int r, int c)      //creat 2d random array.  
{
    Random rnd = new Random();
    int[,] arr = new int[r, c];
    int i = 0; int j = 0;
    while (i < r)
    {
        j = 0;
        while (j < c)
        {
            arr[i, j] = rnd.Next(1, 9);
            j++;

        }
        i++;
    }
    return arr;     // random array[minnum,..,..,..,maxnum]
}

void print2darray(int[,] arr)           // printa 2D rray.         
{
    int i = 0; int j = 0;
    while (i < r)
    {
        j = 0;
        while (j < c)
        {
            Console.Write(arr[i, j] + "    ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

void ReverseSortArray(int[,] arr)          // searching for the user inputs.  
{
    int[] array = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[j] = arr[i, j];                                                //we gave value for elements of 1d array
            Array.Sort(array);
            Array.Reverse(array);
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = array[j];   
        }
    }
    printnewarr(arr);

    // Array.Sort(array);
    // printranarray(array);
}


void printnewarr(int[,] arr)           // printa 2D rray.         
{
    int i = 0; int j = 0;
    while (i < r)
    {
        j = 0;
        while (j < c)
        {
            Console.Write(arr[i, j] + "    ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}


// void printranarray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ",");
//     }
//     Console.WriteLine(array[array.Length - 1] + "]");
// }




// // Main Method
// int[] sort1D(Arr1D)
// {



//     // Sort the arr from last to first
//     // Normal compare is m-n
//     Array.Sort<int>(Arr1D, delegate (int m, int n)
//       { return n - m; });

//     // print all element of array
//     foreach (int value in Arr1D)
//     {
//         Console.Write(value + " ");
//     }
// }
