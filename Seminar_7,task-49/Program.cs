//              Задача №49                                                   **notes**
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.
//----------------------------------------------------------

//            code
int r = readdata("input rows count: ");
int c = readdata("input colums count: ");
int[,] testranarr=creat2dranarray(r,c);           //calling the 2nd method.
Console.WriteLine("-the original massive: "); 
print2darray(testranarr);
Console.WriteLine("-the amended massive: "); 
Update2DArr(testranarr);
print2darray(testranarr); 

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
            arr[i,j] = rnd.Next(1,9);
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
            Console.Write(arr[i,j] + "    ");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

void Update2DArr(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i=i+2)        // i+2, loop to jumb on each even index(rows) and change it.
    {
        for (int j = 0; j < arr.GetLength(1); j=j+2)  //// j+2, loop to jumb on each even index(colums) and change it.
        {
            // squares options
            arr[i, j]*=arr[i, j] ;                    
            //arr[i, j]=arr[i, j]*arr[i, j];
            // arr[i, j]=(int)Math.Pow(arr[i, j],2);
        }
    } 
}


