// Напишите программу которую выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа
//creating random table.

//option1
// System.Random newsintezator = new System.Random();
// //creating variable , select the size of random
// int num = newsintezator.Next(100,1000);
// Console.WriteLine("input: " + num);
// int digit1 = num/100;
// int digit2 = num%10;
// Console.WriteLine("output: "+digit1+""+digit2);


//option2 (how to build array)
System.Random ns = new System.Random();
//creat V (the random number)
int randomnum = ns.Next(100,1000);
//print this V
Console.WriteLine("input: " + randomnum);
//turn V into a string
string value = randomnum.ToString();
//creat v (type char)=turn this string into an array(لانشاء مصفوفة, يجب تحويلها اولا الي سطر تكست)
char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray[0] + "" + numberArray[2]);