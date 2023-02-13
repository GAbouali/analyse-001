//                                            Задача №31                                              notes
//                              Задайте массив из 12 элементов, заполненный                      //
//                              случайными числами из промежутка [-9, 9].                       //
//                              Найдите сумму отрицательных и положительных                    //
//                              элементов массива.
//      Например:
//           Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
//           сумма положительных чисел равна 29, сумма
//           отрицательных равна -20
//
//--------------------------------------------------


int negele = 0;
int posele = 0;
int[] testarr = creat_ran_array(12, -9, 9);
printran_array(testarr);
negposele(testarr);
PrintData("sum pos: ",posele);
PrintData("sum neg: ",negele);

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);

}

// //method to creat random array, 
int[] creat_ran_array(int len, int minValue, int maxValue)
{
    Random rnd = new Random();          //creat project which will give or generate the random elements.
    int[] arr = new int[len];           //creat a massive and resize it.
    for (int i = 0; i < arr.Length-1; i++)    // circle(for), to get every element in the massive.
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

void negposele(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        if (arr[i] < 0)
        {
            negele += arr[i];
        }
        else
        {
            posele += arr[i];

        }

    }
}
