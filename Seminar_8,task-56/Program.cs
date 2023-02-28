// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//--------------------------------------

int row = ReadData("input rows count: ");
int col = ReadData("input colums count: ");
int[,] matrix = Gen2DArray(row, col, 1, 9);
Print2DArray(matrix);
int RowMInSum = MinSumOfRows(matrix);
PrintData("the minimum row sum = ", RowMInSum);

int ReadData(string msg)                                        //reading the inputs.     
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

int[,] Gen2DArray(int row, int col, int min, int max)           // generate 2D random array 
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

void Print2DArray(int[,] arr)                                // printa 2D rray.           
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumOfRows(int[,] arr)                                // searching for the user inputs.  
{
    int MinSum = int.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int RowSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            RowSum += arr[i, j];
        }
        if (RowSum < MinSum)
        {
            MinSum = RowSum;
        }
    }
    return MinSum;
}

void PrintData(string res, int value)                            //print Data
{
    Console.WriteLine(res + value);

}



































