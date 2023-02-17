//                                    Задача №32 
//                       Напишите программу замена элементов массива:
//                       положительные элементы замените на
//                        соответствующие отрицательные, и наоборот.
//      Пример:
//      [-4, -8, 8, 2] -> [4, 8, -8, -2] 
//-----------------------------------

//calling the methods
int[] testarr= creat_ran_array(12,-9,9);
printran_array(testarr);
invarr(testarr);
printran_array(testarr);

// //method to creat random array, 
int[] creat_ran_array(int len, int minValue, int maxValue)
{
    Random rnd = new Random();          //creat project which will give or generate the random elements.
    int[] arr = new int[len];           //creat a massive and resize it.
    for (int i = 0; i < arr.Length; i++)    // circle(for), to get every element in the massive.
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;     // random array[minnum,..,..,..,maxnum]
}

//method to print the random array.
void printran_array(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");


}

void invarr(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        arr[i]=arr[i]*-1;
    
    }
}

//if you want to creat a new array with result.
// int[] newarr(int[] arr)
// {
//     int[] nnewarray=new int[arr.Length];        //creat new arrray
//     for (int i = 0; i < arr.Length-1; i++)
//     {
//         arr[i]=arr[i]*-1;                       // fill the array
    
//     }
//     return newarr;
// }