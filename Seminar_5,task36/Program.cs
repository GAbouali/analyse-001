//            Задача 36: 
//        Задайте одномерный массив, заполненный случайными числами. 
//        Найдите сумму элементов, стоящих на нечётных позициях.
//      [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю
//---------------------------------------------

int[] testarr = creat_ran_array(8, 1, 9);
printran_array(testarr);
int testsum = sumoddindx(testarr);
PrintData("the sum of odd indexes: ", testsum);
int[] test_pairs=pairs_arr(testarr);
printran_array(test_pairs);

void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

// //method to creat random array, 
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

int sumoddindx(int[] arr)
{
    int sum = 0;
    int i = 1;
    while (i < arr.Length)
    {
        sum += arr[i];
        i = i + 2;
    }
    return sum;
}

int[] pairs_arr(int[] arr)
{
    int[] arrpairs = new int[8];
    int test = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] / arr[test] == 1)
        {
            arrpairs[i]=arr[i]*11;
            test++;
        }
    }
    return arrpairs;
}