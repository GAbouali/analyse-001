//               Задача №51
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.
//------------------------------------


//            code
int r = readdata("input rows count: ");
int c = readdata("input colums count: ");
int[,] testranarr=creat2dranarray(r,c);           //calling the 2nd method.
Console.WriteLine("-the original massive: "); 
print2darray(testranarr);
int testres=SumOfDiagonal(testranarr);
printdata("sum of diagonal elements = " , testres);

//            methods
int readdata(string msg)                       //reading the inputs.   
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

void printdata(string msg, int res)
{
    Console.WriteLine(msg + res);
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
// option 1 to find result.(my option)
int SumOfDiagonal(int[,] arr)
{
    int res=0;
   for (int i = 0; i < arr.GetLength(0); i=i+1)        
    {
        for (int j = 0; j < arr.GetLength(1); j=j+1) 
        {
            if(i==j)
            {
                res+=arr[i,j];
            }
            
        }
    } 
    return res;
}

// option 2 to find result.(seminar optin)
// int SumOfDiagonal(int[,] arr)
// {
//     int res =0;
////            if rows count>colums count?     so,we take colums count:if no,se we take rows count  
//     int min=arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);

//    for (int i = 0; i < min; i=i+1)
//     {
//     res = res+ arr[i, i];
//     } 
//     return res;
// }

