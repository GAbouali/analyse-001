// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

//universal method to read the inputs, transform it from text to numbers,
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//universal method to print the results(outputs for the user)
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
    
}

int pow(int a, int b)

{
    int res = 1;
    while (b > 0)
    {
        b = b - 1;
        res = res * a;
    }
    return res;
}

int plus(int a, int b)
{
    int res1 = a + b;
    return res1;
}

int minus(int a, int b)
{
    int res2 = a - b;
    return res2;
}

int Multi(int a,int b)
{
    int res3=a*b;
    return res3;
}

int division (int a,int b)
{
    int res4=a/b;
    return res4;
}


int a = ReadData("input number a, ");
int b = ReadData("input number b, ");

int res = pow(a, b);
int res1 = plus(a, b);
int res2 = minus(a, b);
int res3 = Multi(a, b);
int res4 = division(a, b);


PrintData("A pow B = ", res);
PrintData("A+B = ", res1);
PrintData("A-B = ", res2);
PrintData("A*B = ", res3);
PrintData("A/B = ", res4);

