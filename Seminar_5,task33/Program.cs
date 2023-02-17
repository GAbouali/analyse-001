//          Задача №33
//         Задайте массив. Напишите программу, которая
//        определяет, присутствует ли заданное число вмассиве.
//       Например:
//       4; массив [6, 7, 19, 345, 3] -> нет
//      -3; массив [6, 7, 19, 345, 3] -> да
//----------------------------------------.


int num =read_data("input number: ");
int[] testarr=creat_ran_array(12,-9,9);
printran_array(testarr);
searchnum(testarr,num);
bool testsearch=searchnum(testarr,num);
PrintData("Has the user number been found in the array? >> ",testsearch);

int read_data(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg1, bool msg2)
{
    Console.Write(msg1);
    Console.Write(msg2);
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
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");


}

bool searchnum(int[] arr, int num)
{
    bool res=false;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            res=true; break;
        }
        
    }
    return res;
}