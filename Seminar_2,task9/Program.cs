//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа.
//option 1

System.Random numsintezator = new System.Random();
int rndnum = numsintezator.Next(10,100);
Console.WriteLine(rndnum);

int digit1 = rndnum/10; 
int digit2 = rndnum%10;


if(digit1>digit2)
{
    Console.WriteLine("first number is bigger: "+ digit1);
}
else{
    Console.WriteLine("second number is bigger: "+ digit2);
}


