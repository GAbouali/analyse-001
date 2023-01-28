// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("input number, ");
//creat a variable
int num = int.Parse(Console.ReadLine()??"0");
if(num>100 && num<1000)
{
    int res1 = num/10;
    int res2 = res1%10;
    Console.WriteLine(res2);


}
else
{
    Console.WriteLine("the number should be contains 3 numbers only, ");

}