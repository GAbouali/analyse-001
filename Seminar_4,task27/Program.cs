// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// * Сделать оценку времени алгоритма через вещественные числа и строки
//-----------------------------------------------------------------------------------











//opt 1 , the simple one.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int sumsym(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;

    }
    return res;
}

int number = ReadData("input number: ");
int res = sumsym(number);
PrintData("sumsym: ",res);
//-------------------------------------------------------------



//opt 2, massive.

//test 1 
// Console.WriteLine("input num, ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// int[] numarray = new int[num];
// Console.WriteLine(num);
//-------------------------
//                            *** mr/Nikita reply *******


// char[] numarray = num.ToCharArray() - у вас массив символов, 
//в строке outNumLine = outNumLine + numarray[indx] вы пытаетесь прибавить символ к строке. Это некорректно. 
//Тем более по заданию вам надо найти сумму ЦИФР в числе. Т.е. если вы используете массив символов, 
//то сначала надо каждый символ преобразовать в число (т.е. int). GetNumericValue - получить числовое 
//значение символа. Например, int number = (int)Char.GetNumericValue(numarray[indx]). 
//Можете сделать массив из int и потом его просуммировать, можете сразу суммировать в цикле sum += number;


//                          //test 2 (my attempt)
// Console.WriteLine("input num, ");              //print inputs.
// string? num = Console.ReadLine() ?? "0";      //creat V = the 'inputs'
// char[] numarray = num.ToCharArray();         //creat V = transform inputs to an 'array'
// int indx = 0;
// int arraylen = numarray.Length;             // creat V = 'array' length.
// // Console.WriteLine(arraylen);
// while (indx < arraylen)
// {
//     // int sum = 0;
//     string outNumLine = string.Empty;
//     // int numinx=numarray[i]+0;
//     outNumLine = outNumLine + numarray[indx];
//     indx++;
//     // // int d=int.Parse(outNumLine ?? "0");
//     // sum = sum + numarray[indx] + numarray[indx - 1];

//     Console.WriteLine(outNumLine);
// }


//-------------------------------

//                                 *******mr/Andrey reply*****

// //Connecting the library
// using System.Numerics;

// // The method reads data from the user
// string ReadDataStr(string msg)
// {
// Console.WriteLine(msg);
// return Console.ReadLine() ?? "0";
// }

// // The method outputs the result to the user
// void PrintData(string msg, double res)
// {
// Console.WriteLine(msg + res);
// }

// // The method determines the action sign of the expression
// string MathOperator(string str)
// {
// string res = "";
// if (str.Contains("+")) res = "+";
// if (str.Contains("-")) res = "-";
// if (str.Contains("")) res = "";
// if (str.Contains("/")) res = "/";
// if (str.Contains("ˆ")) res = "ˆ";
// return res;
// }

// // Method for getting the number A and the number B
// int NumbersAandB(string str, string znak, int indx)
// {
// int res = 0;
// string strWoSp = str.Replace(" ", ""); // removing all spaces
// string[] numbers = strWoSp.Split(znak); // Divide the string with a split and write it to the array
// res = int.Parse(numbers[indx]);
// return res;
// }

// // Method for calculating the sum
// int Summa(int num1, int num2)
// {
// int res = 0;
// res = num1 + num2;
// return res;
// }

// // Method for calculating the difference
// int Subtraction(int num1, int num2)
// {
// int res = 0;
// res = num1 - num2;
// return res;
// }

// // Method of calculating the product
// long Multiplication(long num1, long num2)
// {
// long res = 0;
// res = num1 * num2;
// return res;
// }

// // Method for calculating the division
// double Divide(double num1, double num2)
// {
// double res = 0.0;
// res = num1 / num2;
// return res;
// }

// // Calculation method exponentiation
// long Power(long num1, long num2)
// {
// long res = 1;
// // res = Math.Pow(num1, num2);
// for (long i = 1; i <= num2; i++)
// res = res * num1;
// return res;
// }

// // ___________________________________________________//
// // Main code

// // Entering data:
// string mathExpress = ReadDataStr("Enter example:");

// // Write the action operator to the variable;
// string mathOperator = MathOperator(mathExpress);

// //If we calculate the sum:
// if (mathOperator == "+")
// {
// int numberA = NumbersAandB(mathExpress, MathOperator(mathExpress), 0);
// int numberB = NumbersAandB(mathExpress, MathOperator(mathExpress), 1);
// int result = Summa(numberA, numberB);
// PrintData("Solution is equal to: ", result);
// }

// //If we calculate the difference:
// if (mathOperator == "-")
// {
// int numberA = NumbersAandB(mathExpress, MathOperator(mathExpress), 0);
// int numberB = NumbersAandB(mathExpress, MathOperator(mathExpress), 1);
// int result = Subtraction(numberA, numberB);
// PrintData("Solution is equal to: ", result);
// }

// //If we calculate the product:
// if (mathOperator == "*")
// {
// long numberA = NumbersAandB(mathExpress, MathOperator(mathExpress), 0);
// long numberB = NumbersAandB(mathExpress, MathOperator(mathExpress), 1);
// long result = Multiplication(numberA, numberB);
// PrintData("Solution is equal to: ", result);
// }

// //If we solve division:
// if (mathOperator == "/")
// {
// double numberA = NumbersAandB(mathExpress, MathOperator(mathExpress), 0);
// double numberB = NumbersAandB(mathExpress, MathOperator(mathExpress), 1);
// double result = Divide(numberA, numberB);
// PrintData("Solution is equal to: ", result);
// }

// //If we raise to a power:
// if (mathOperator == "ˆ")
// {
// long numberA = Convert.ToInt64(NumbersAandB(mathExpress, MathOperator(mathExpress), 0));
// long numberB = Convert.ToInt64(NumbersAandB(mathExpress, MathOperator(mathExpress), 1));
// long result = Power(numberA, numberB);
// PrintData("Solution is equal to: ", result);
// }








