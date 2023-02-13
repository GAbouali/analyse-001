// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5
//--------------------------------------------------------------- 


//universal method to read the inputs, transform it from text to numbers,
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//method to print the results(outputs for the user)
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

//option1
int option1(int num)
{
    int res =0;
    while(num>0)
    {
        res++;
        num=num/10;
    }
    return res;
}
//option2
int option2(int num)
{
    int res =0;
    res = num.ToString().Length;
    return res; 
}
//option3
int option3(int num)
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

int number = ReadData("input number: ");

DateTime d1 = DateTime.Now;
int res1 = option1(number);
Console.WriteLine(DateTime.Now - d1);
PrintData("option1: ",res1);

DateTime d2 = DateTime.Now;
int res2 = option2(number);
Console.WriteLine(DateTime.Now - d2);
PrintData("option2: ",res2);

DateTime d3 = DateTime.Now;
int res3 = option3(number);
Console.WriteLine(DateTime.Now - d3);
PrintData("option3: ",res3);
