//        Задача 38: 
//   Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//   [3 7 22 2 78] -> 76
//   * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и 
//    последним элементом. Для задачи со звездочкой использовать заполнение массива целыми числами.
//--------------------------------------

int[] testarray=creat_ran_array(8,1,9);
Console.Write("the randome array is : ");
printran_array(testarray);

Array.Sort(testarray);                      //sort array     start
Console.Write("array sorting: ");
for(int i=0;i<testarray.Length;i++)           
{
    Console.Write(testarray[i]+" , ");

}
Console.WriteLine(" ");                   //end

int testdif=min_max_dif(testarray);
PrintData("array max number - array min number = ",testdif);

void PrintData(string msg1, int msg2)
{
    Console.Write(msg1);
    Console.Write(msg2);
}

int[] creat_ran_array(int len, int minValue, int maxValue)
{
    Random rnd = new Random();          //creat project which will give or generate the random elements.
    int[] arr = new int[len];           //creat a massive and resize it.
    for (int i = 0; i < arr.Length; i++)    // circle(for), to get every element in the massive.
    {
        arr[i] = rnd.Next(minValue, maxValue);
    }
    return arr;     // random array[minnum,..,..,..,maxnum]
}

void printran_array(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");


}
//method to find the min,max numbers in array, and find the dif between them.
int min_max_dif(int[] arr)
{
    int dif=0;
    int max=0;
    int min=arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>max)
        {
            max=arr[i];
        }
        if(arr[i]<min) 
        {
            min =arr[i];
        }
    }
    dif=max-min;
    return dif;
}


  