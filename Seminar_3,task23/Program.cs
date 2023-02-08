// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом
// ---------------------------------------------------------------------------------

//option 1
int num = TakeData("input number N: ");
int i = 1;                                      // the circle engine
int cube = 0;                                  // the cube of N number.
int numDigitsCube = 0;                        // количество цифр в кубе числа
string firstStr = "\u2551 number     \u2551"; // the first row of the table with borders.
string secstr = "\u2551 number cube\u2551";  // the second row of the table with borders.


while (i <= num)
{
    cube = (int)Math.Pow(i, 3);                                                 // count the cube of number.
    numDigitsCube = (int)Math.Log10(cube) + 1;                                 // count how many numbers in the number cube.
    firstStr = firstStr + ((i).ToString()).PadRight(numDigitsCube) + "\u2551"; // add  the first row of table, numbers
    secstr = secstr + cube.ToString() + "\u2551"; // add the second row of the table with the value of the cube of the number and the border of the table cell
    i++;
}

//method to read the inputs from user.
int TakeData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//method to draw the table
void DrawUniLine(string sampleStr, string startSym, string midSym, string stopSym)
{
    Console.Write(startSym); 
    int i = 1;
    while (i < sampleStr.Length - 1)
    {
        if (sampleStr[i] == '\u2551') Console.Write(midSym); 
        else Console.Write("\u2550"); 
        i++;
    }
    Console.WriteLine(stopSym); 
}
//calling meathods and print them.
DrawUniLine(firstStr, "\u2554","\u2566", "\u2557");
Console.WriteLine(firstStr);
DrawUniLine(firstStr, "\u2560", "\u256C", "\u2563");
Console.WriteLine(secstr);
DrawUniLine(firstStr, "\u255A", "\u2569", "\u255D");



