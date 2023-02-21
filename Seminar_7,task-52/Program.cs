// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным
// цветом.
//------------------------------------------------------------------------

//                                               "Code Driver"
int r = ReadData("input rows count: ");
int c = ReadData("input colums count: ");
int[,] testranarr = Creat2DRanArray(r, c);
Print2DArray(testranarr);
double[] tesresult=MeansOfColums(testranarr);
Console.WriteLine("the arithmetic means of colums = ");
Printran1DArray(tesresult);
//  **the arithmetic mean of the Principal and Secondary diagonals.**
double MainDiagonalmean=MeanOfPrincDiag(testranarr);
printdata("the arithmetic mean of Principal diagonal = ",MainDiagonalmean);
double SecDiagonalMean=MeanOfSecondDiag(testranarr);
printdata("the arithmetic mean of Secondary diagonal = ",SecDiagonalMean);

//                                                  "methods"

int ReadData(string msg)                       //reading the inputs.     
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

int[,] Creat2DRanArray(int r, int c)         //creat 2d random array.    
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

void Print2DArray(int[,] arr)               // printa 2D rray.           
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

double[] MeansOfColums(int[,] arr)         // the arithmetic means of colums. 
{
    double[] res = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0);i++)
        {
            res[j] += arr[i, j];
            
        }
        res[j] = res[j] / arr.GetLength(0);
    }
    return res;
}

void Printran1DArray(double[] arr)        //print array with the arithmetic means of colums.  
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");


}

//                                     * * methods to get  the arithmetic mean of the Principal and Secondary diagonals.

void printdata(string msg, double res)
{
    Console.WriteLine(msg + res);
}
// the Principal diagonal method,
double MeanOfPrincDiag(int[,] arr)
{
    int ressum=0;
    double res=0;
    int min=arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);
   for (int i = 0; i < arr.GetLength(0); i=i+1)        
    {
        for (int j = 0; j < arr.GetLength(1); j=j+1) 
        {
            if(i==j)
            {
                ressum+=arr[i,j];
            }
            res=ressum/min;
        }
    } 
    return res;
}
// the Secondary diagonal method.
double MeanOfSecondDiag(int[,] arr)
{
    int ressum=0;
    double res=0;
    int min=arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);
   for (int i = 0; i < arr.GetLength(0); i=i+1)        
    {
        for (int j = 0; j < arr.GetLength(1); j=j+1) 
        {
            if(i==arr.GetLongLength(1)-j-1)
            {
                ressum+=arr[i,j];
            }
            res=ressum/min;
        }
    } 
    return res;
}
