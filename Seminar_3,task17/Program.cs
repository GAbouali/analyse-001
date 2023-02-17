// Задача №17
// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой
// находится эта точка.
// Например:
// x=34; y=-30 -> 4
// x=2; y=4-> 1
// x=-34; y=-30 -> 3

// int x=readdata("input x: ");
// int y=readdata("input y: ");

// //how to creat methoed?
// creat V, select the type of input data(int),
// int readdata(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine()??"0");

// }

int coordx = ReadData("input X: ");
int coordy = ReadData("input Y: ");
PrintQuterTest(coordx,coordy);
//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
return int.Parse(Console.ReadLine() ?? "0");

}

// Метод определяет четверть по координатам точки
void PrintQuterTest(int x,int y)
{
if (x > 0 && y > 0) Console.WriteLine("Точка в четверти 1");
if (x > 0 && y < 0) Console.WriteLine("Точка в четверти 2");
if (x < 0 && y < 0) Console.WriteLine("Точка в четверти 3");
if (x < 0 && y > 0) Console.WriteLine("Точка в четверти 4");
} 
