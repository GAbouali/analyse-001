//     Задача №37
//     Найдите произведение пар чисел в одномерном
//     массиве. Парой считаем первый и последний
//     элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
//-------------------------------------------


int[] test_crat=creat_ran_array(8,1,9);
printran_array(test_crat);
int[] test_productarr=creat_productarr(test_crat);
printran_array(test_productarr);

void printran_array(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");


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

int[] creat_productarr(int[] arr)
{
    int[] productarr = new int[arr.Length / 2];
    int len = arr.Length - 1;
    for (int i = 0; i < productarr.Length; i++)
    {
        productarr[i]=arr[i]*arr[len];
        len=len-1;
    }
    return productarr;

}