// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("input number, ");
// int num = int.Parse(Console.ReadLine()??"0");
// if(num>=100 && num<1000)
// {
//     int res1 = num%10;
//     Console.WriteLine(res1);
// }
// else if(num<100)
// {
//     Console.WriteLine("no third number, ");

// }
// else if(num>=1000)
// {
//     Console.WriteLine("the number should be contains only 3 numbers, ");

// }



//option2.
Console.WriteLine("input number, ");

// creat variable [array] = read inputs.transform it to array.
char[] digit = Console.ReadLine().ToCharArray();
// check length of array.
if (digit.Length >= 3)
{
    // print index 2 fro the array.
    Console.WriteLine(digit[2]);

}
else
{
    Console.WriteLine("третей цифры нет");
}


