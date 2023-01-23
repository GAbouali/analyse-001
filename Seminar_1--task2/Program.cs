// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее. 
// a = 5; b = 7 -> max = 7 a = 2 b = 10 -> max = 10 a = -9 b = -3 -> max = -3

Console.WriteLine("enter num a, ");
string? numA= Console.ReadLine();
Console.WriteLine("enter num b, ");
string? numB= Console.ReadLine();

if(numA!=null && numB!=null)
{
    int A = int.Parse(numA);
    int B = int.Parse(numB);
    string R = string.Empty;
    
    if(A>B)
    {
        R = R+A;
        Console.WriteLine(A);

    }
    else
    {
        R = R+B;
        Console.WriteLine(B);
    }



}



