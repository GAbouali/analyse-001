// №47 Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
//-----------------------------------------------------------------------------------
//                                                " Code Driver "

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
int r = ReadData("input rows count: ");
int c = ReadData("input colums count: ");
double[,] TestRanArr=Creat2DRanaArray(r,c);          
Console.WriteLine("-the original matrix: "); 
Print2DArray(TestRanArr);

//                                                  " methods "

int ReadData(string msg)                       //reading the inputs.   
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

double[,] Creat2DRanaArray(int r, int c)         //creat 2d random array.  
{
    Random rnd = new Random();          
    double[,] arr = new double[r,c];    
    int i = 0; int j = 0;  
    while(i<r)
    {
        j=0;
        while(j<c)
        {
            arr[i,j] = rnd.Next(-10,9)+new Random().NextDouble();
            j++;
            
        }
        i++;
    }
    return arr;     // random array[minnum,..,..,..,maxnum]
}

void Print2DArray(double[,] arr)               // printa 2D rray.         
{
    int i = 0; int j = 0; 
    while(i<r)
    {
        j=0;
        while(j<c)
        {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];   //calling color method
            Console.Write(arr[i,j] + "  ");
            Console.ResetColor();                                             //calling color metho
            j++;
        }
        Console.WriteLine();
        i++;
    }
}





//                                                      " ??? "
// how can i get the result in this form 6,1 not 6.165444128912456?