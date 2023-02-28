// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//-------------------------------


int[,] matrixA = Gen2DArrayA(2, 2, 1, 9);
int[,] matrixB=Gen2DArrayB(2, 2, 1, 9);
Console.WriteLine("Matrix A: ");
Print2DArray(matrixA);
Console.WriteLine("Matrix B: ");
Print2DArray(matrixB);
int[,] resultMatrix=Multiplication(matrixA,matrixB);
Console.WriteLine("Matrix A*B: ");
Print2DArray(resultMatrix);

int[,] Gen2DArrayA(int row, int col, int min, int max)           // generate 2D random array 
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

int[,] Gen2DArrayB(int row, int col, int min, int max)           // generate 2D random array 
{
    int[,] arrB = new int[row, col];
    for (int i = 0; i < arrB.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            arrB[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arrB;
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

int[,] Multiplication(int[,] matrixA, int[,] matrixB)       //method to multiple 2D arrays
{
    
    int[,] r = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                r[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return r;
}



























// Main(args);
// void Main(string[] args)
// {
//     Console.WriteLine("Введите размерность первой матрицы: ");
//     int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
//     for (int i = 0; i < A.GetLength(0); i++)
//     {
//         for (int j = 0; j < A.GetLength(1); j++)
//         {
//             Console.Write("A[{0},{1}] = ", i, j);
//             A[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     Console.WriteLine("Введите размерность второй матрицы: ");
//     int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
//     for (int i = 0; i < B.GetLength(0); i++)
//     {
//         for (int j = 0; j < B.GetLength(1); j++)
//         {
//             Console.Write("B[{0},{1}] = ", i, j);
//             B[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }

//     Console.WriteLine("\nМатрица A:");
//     Print(A);
//     Console.WriteLine("\nМатрица B:");
//     Print(B);
//     Console.WriteLine("\nМатрица C = A * B:");
//     int[,] C = Multiplication(A, B);
//     Print(C);

// }

// int[,] Multiplication(int[,] a, int[,] b)
// {
//     if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
//     int[,] r = new int[a.GetLength(0), b.GetLength(1)];
//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < b.GetLength(1); j++)
//         {
//             for (int k = 0; k < b.GetLength(0); k++)
//             {
//                 r[i, j] += a[i, k] * b[k, j];
//             }
//         }
//     }
//     return r;
// }

// void Print(int[,] a)
// {
//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < a.GetLength(1); j++)
//         {
//             Console.Write("{0} ", a[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

