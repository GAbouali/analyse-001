// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("input number, ");
int day = int.Parse(Console.ReadLine()??"0");
if(day>=1 && day<=5)
{
    Console.WriteLine(day+" is a weekday. no, its not a weekend, ");
}
else if(day>=6 && day<=7)
{
    Console.WriteLine(day+" is a weekday.yes, its a weekend, ");
    
}
else{
    Console.WriteLine(day + " is not a weekday,");
}