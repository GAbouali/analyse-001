// Задача №18
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных
// координат точек в этой четверти (x и y).


// int q = readdata("input quarter number: ");

// int readdata(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");

// }

// if (q == 1) Console.WriteLine("x > 0 && y > 0");


int qnum = readdata("input quarter number: ");
PrintQuterTest(qnum);

//Метод читает данные от пользователя
int readdata(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");

}

// Метод определяет четверть по координатам точки
void PrintQuterTest(int q)

{
    if (q > 0 && q < 5)
    {
    if (q == 1) Console.WriteLine("x > 0 && y > 0");
    if (q == 2) Console.WriteLine("x > 0 && y < 0");
    if (q == 3) Console.WriteLine("x < 0 && y < 0");
    if (q == 4) Console.WriteLine("x < 0 && y > 0");
    }
    else Console.WriteLine("the number is invalid, ");
}

