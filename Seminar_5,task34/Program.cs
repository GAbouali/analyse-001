//                              Задача 34:                                                notes
//       Задайте массив заполненный случайными положительными трёхзначными числами.       evencount++; المتغير يجمع كل قيمة تقع بداخله,
//       Напишите программу, которая покажет количество чётных чисел в массиве.
//       [345, 897, 568, 234] -> 2
//      * Отсортировать массив методом пузырька
//-------------------

int evencount = 0;
//calling methods,
int[] resarray = creat_ran_array(5, 100, 999);
printran_array(resarray);

Array.Sort(resarray);                      //sort array     start
Console.Write("array sorting: ");
for(int i=0;i<resarray.Length;i++)           
{
    Console.Write(resarray[i]+" , ");

}
Console.WriteLine(" ");                   //end

even_elements(resarray);
PrintData("even elements are : ", evencount);

void PrintData(string msg, int value)
{
    Console.WriteLine(msg + value);

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

//method to print the random array.
void printran_array(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");


}

void even_elements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            evencount++;
        }
    }
}

//