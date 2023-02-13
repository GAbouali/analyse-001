// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// * Ввести с клавиатуры длину массива и диапазон значений

// # 29 اكتب برنامجًا يأخذ مجموعة من 8 عناصر ويطبعها على الشاشة.
//* أدخل من لوحة المفاتيح طول المصفوفة ونطاق قيم العنصر
//-------------------------------------

int[] testrray=creatranarray(1,9,8);

printranarray(testrray);

int[] creatranarray(int minnum , int maxnum, int len)
{
    Random ran = new Random();
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
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


