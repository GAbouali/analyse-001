// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07
// //---------------------------------
// //  00 01 02 03
// //  10 11 12 13             
// //  20 21 22 23
// //  30 31 32 33
int len = 4;
int tempVar = 1;

int[,] matrixres=Gen2DArray(len,tempVar);
Print2DArray(matrixres);

int[,] Gen2DArray(int len, int tempVar)
{
    int i = 0;
    int j = 0;
    int[,] Matrix = new int[len, len];
    while (tempVar <= len * len)
    {
        Matrix[i, j] = tempVar; //  <    3
        if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)    // col   1stloop 1 2 3         2ndloop  13    
            j++;
        else if (i < j && i + j >= Matrix.GetLength(0) - 1)  // row   1stloop 4 5 6        2ndloop 14
            i++;
        else if (i >= j && i + j > Matrix.GetLength(1) - 1)  // col 4 1stloop 7 8 9         2ndloop 15
            j--;
        else                                                 // row   1stloop 10 11 12       2ndloop 16
            i--;
        tempVar++;
    }
    return Matrix;

}


void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                Console.Write(" ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
