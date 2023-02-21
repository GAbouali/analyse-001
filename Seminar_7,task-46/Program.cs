//              Задача №46                                                  **notes**
// Задайте двумерный массив размером m×n,                           method creat 2D random array.
// заполненный случайными целыми числами.                           method printa 2D rray.
//              Например:                                           colors
// m = 3, n = 4.
// -1 4 8 19
// 5 -2 33 -2
// -77 3 8 1
//----------------------------




//            code
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

int r = readdata("input rows count: ");
int c = readdata("input colums count: ");
int[,] testranarr=creat2dranarray(r,c);           //calling the 2nd method.
print2darray(testranarr);                        //calling method to print array.

//            methods
int readdata(string msg)                       //reading the inputs.   
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

int[,] creat2dranarray(int r, int c)         //creat 2d random array.  
{
    Random rnd = new Random();          
    int[,] arr = new int[r,c];    
    int i = 0; int j = 0;  
    while(i<r)
    {
        j=0;
        while(j<c)
        {
            arr[i,j] = rnd.Next(11,99);
            j++;
        }
        i++;
    }
    return arr;     // random array[minnum,..,..,..,maxnum]
}

void print2darray(int[,] arr)               // printa 2D rray.         
{
   
    int i = 0; int j = 0; 
    while(i<r)
    {
        j=0;
        while(j<c)
        {
            Console.ForegroundColor = (ConsoleColor)(new System.Random().Next(0,16));
            Console.Write(arr[i,j] + " | ");
            Console.ResetColor(); 
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

// void PrintTwoDimArray(int[,] inputArray)
// {
//     int i = 0; int j = 0;

//     while (i < inputArray.GetLength(0))
//     {
//         j = 0;
//         while (j < inputArray.GetLength(1))
//         {
//             Console.ForegroundColor = col[new System.Random().Next(0,16)]; 
//             //col[new System.Random().Next(0,16)]; 
//             Console.Write(inputArray[i, j] + " ");
//             Console.ResetColor(); 
//             j++;
//         }
//         //Console.Write("\n");
//         Console.WriteLine();
//         i++;
//     }
// }



