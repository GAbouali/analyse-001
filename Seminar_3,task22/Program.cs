// Задача №22
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.
// Например:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// OPTION1

int read_data(string msg)
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

void printdata(string msg1, string msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

string linebuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t";
    }
    return s;
}

int num = read_data("input N: ");

string line1 = linebuilder(num, 1);
string line2 = linebuilder(num, 2);
printdata(line1,line2);
