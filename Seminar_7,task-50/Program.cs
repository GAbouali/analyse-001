
// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
//--------------------------------------------------
//                                               " Code Driver "
int r = ReadData("input rows count: ");
int c = ReadData("input colums count: ");
int s=ReadData("input a number to search: ");
int[,] testranarr=creat2dranarray(r,c);
print2darray(testranarr);
SearchResult(testranarr);



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

void SearchResult(int[,] arr)          // searching for the user inputs.  
{   
    bool res=false;
   for (int i = 0; i < arr.GetLength(0); i++)        
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            if(arr[i,j]==s)
            {
                Console.Write("the number been found in index: "+"["+i+","+j+"]");
                res=true;
            }
        } 
        
    } 
    if(res==false)
        {
            Console.WriteLine("the number is not in the Matrix, ");
        }
}




//                                                    " ???????? "
// i could not solve the * task!



