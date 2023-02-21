//             Задача №48
// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.
//            Пример:
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
//-------------------------------------------------------------------------------------------------------------------
//             code
int r=ReadData("input Rows count: ");
int c=ReadData("input Colums count: ");
int[,] Res2DArray=Creat2DArray(r,c);
print2darray(Res2DArray);

//            methods
int ReadData(string msg)                       //reading the inputs.   
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

int[,] Creat2DArray(int r, int c)         //creat 2d random array.  
{       
    int[,] arr = new int[r,c];    
    int i = 0; int j = 0;  
    while(i<r)
    {
        j=0;
        while(j<c)
        {
            arr[i,j] = i+j;
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
            Console.Write(arr[i,j] + " | ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}


