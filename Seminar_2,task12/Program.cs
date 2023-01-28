// напишите программу которая будет принимать на вход два числа,
// и выводить является ли второе число кратным первым, 
// если второе число не кратно первому то программа выводит остаток от деления

Console.WriteLine("input1, ");
int num1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("input2, ");
int num2 = int.Parse(Console.ReadLine()??"0");
int result = num2%num1;
if(result==0)
{
    Console.WriteLine("second number is multiple first, ");
}
else
{
Console.WriteLine("second number is not multiple first "+result);
}