//Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("enter number, ");
string? num = Console.ReadLine();

if(num!=null)
{

    int A = int.Parse(num);
    int C = A*(-1);
    string R = string.Empty;

    while(C<A)
    {
        R = R+C+",";
        C = C+1;
    }
    R = R+A;
    Console.WriteLine(R);
}
