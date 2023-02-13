// Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]
//-------------------------------------------------------------


int[] arraytest = creatranarray(0, 1, 8); //creat V with method(creatranarray) result,or return(array).
printranarray(arraytest);                //calling the method to print data.

int[] creatranarray(int minnum , int maxnum, int len)
{
    Random ran = new Random();
    int[] array = new int[len];
    for (int i = 0; i < array.Length-1; i++)
    {
        array[i] = ran.Next(minnum, maxnum+1);
    }
    return array;
}

void printranarray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+ ",");
    }
    Console.WriteLine(array[array.Length-1]+"]");

}


