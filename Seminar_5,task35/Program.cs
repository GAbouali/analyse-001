//      Задача №35
//          Задайте одномерный массив из 123 случайных
//          чисел. Найдите количество элементов массива,
//          значения которых лежат в отрезке [10,99].
// Например:
// Пример для массива из 5, а не 123 элементов. В
// своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
//-----------------------------------------

int[] testarr = creat_ran_array(8, 1, 15);
printran_array(testarr);
search_2digits_num(testarr);
int testcountarr=search_2digits_num(testarr);
PrintData("count: ",testcountarr);

void PrintData(string msg1, int msg2)
{
    Console.Write(msg1);
    Console.Write(msg2);
}
//method to creat random array, 
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

int search_2digits_num(int[] arr)
{
    int countarr = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 99)
        {
            countarr++;
        }
    }
    return countarr;
}