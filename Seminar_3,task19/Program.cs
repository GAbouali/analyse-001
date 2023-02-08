// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

// //method to read the inputs.
// int read_data(string msg)
// {
//     //(msg) is what we ask user ti enter>>"input X1: "
//     Console.WriteLine(msg);
//     //transform the inputs to numbers.
//     return int.Parse(Console.ReadLine() ?? "0");

// }
// //method to print the results(outputs for the user)
// void printdata(string msg,bool res)
// {

//     Console.WriteLine(msg+res);
// }
// //method to test the inputs, if its palindrome or not?
// bool palintest(int n)
// {
//     bool res = false;
//     int d1 = n / 10000;
//     int d2 = (n / 1000) % 10;
//     int d3 = (n / 10) % 10;
//     int d4 = n % 10;
//     res = ((d1 == d4) && (d2 == d3))?true:false;
//     return res;
// }

// //calling the method(read_data)
// int num = read_data("input number: ");
// //calling the method(palintest)
// bool result = palintest(num);

// printdata("Is the number palindrome?, ", result);
//-----------------------------------------------------------------

//option 2 with *
//Method of reading user data
string ReadData(string line)
{
    // Output• message
    Console.Write(line);
    // Reading the line
    string inputLine = Console.ReadLine() ?? "";
    // Returning the value
    return inputLine;
}

// Method to accepts a string, outputs to the console
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Method that returns a dictionary of four-digit palindromes
Dictionary<int, int> FillPalindroms()
{
    Dictionary<int, int> palindroms = new Dictionary<int, int>();
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            int key = j * 10 + i;
            int value = i * 1000 + j * 100 + j * 10 + i;
            palindroms.Add(key, value);
        }
    }
    return palindroms;
}
//method to test the inputs, if its palindrome or not?
bool CheckIfPalindrom(int inputNumber, Dictionary<int, int> palindroms)
{
    // Делаем из исходного пятизначного числа четырёхзначное, убирая третью цифру
    int fourDigitNumber = (inputNumber / 1000) * 100 + inputNumber % 100;
    // Проверка на вхождение в словарь палиндромов
    return palindroms.ContainsValue(fourDigitNumber);
}

int inputNumber = 0;
string inputLine = ReadData("Введите пятизначное число: ");
if (int.TryParse(inputLine, out inputNumber))
{
    if (inputNumber > 9999 && inputNumber < 100000)
    {
        Dictionary<int, int> fourDigitPalindroms = FillPalindroms();
        PrintResult(CheckIfPalindrom(inputNumber, fourDigitPalindroms) ? "Это палиндром" : "Это не палиндром");
    }
    else
    {
        PrintResult("Это не пятизначное число");

    }



}





