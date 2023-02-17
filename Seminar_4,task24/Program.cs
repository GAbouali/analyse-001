// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36
//---------------------------------------------------------------------------
// // option 1
// int read_data(string msg)
// {
//     //(msg) is what we ask user ti enter>>"input X1: "
//     Console.WriteLine(msg);
//     //transform the inputs to numbers.
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// int a = read_data("input A: ");

// int i = 0;
// int sum = 0; 

// while(i<a)
// {
//     i=i+1;
//     sum=i+sum;   
// }
// Console.WriteLine(sum);

//option2 (1.creat mothods__2.calling methods )
int read_data(string msg)
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //transform the inputs to numbers.
    return int.Parse(Console.ReadLine() ?? "0");
}
//method to print the results(outputs for the user)
void printdata(string msg, int res)
{

    Console.WriteLine(msg + res);
}
// method the solution process.
int sumsimple(int numbera)

{
    int sum = 0;
    for (int i = 0; i <= numbera; i++)
    {
        sum += i;
    }
    return sum;
}

int sumgauss(int numbera)
{
    return(numbera*(numbera+1)/2);
}

int numbera = read_data("input number: ");

DateTime d1=DateTime.Now; //to check the speed of method process
int res = sumsimple(numbera);
Console.WriteLine(DateTime.Now - d1);  //to check the speed of method process

DateTime d2=DateTime.Now;//to check the speed of method process
int res2=sumgauss(numbera);
Console.WriteLine(DateTime.Now - d2);  //to check the speed of the method process {test results : sum gauss is more quick}


printdata("summary from 1 to a(sumsimple): ", res);
printdata("summary from 1 to a(sumguass): ", res2);