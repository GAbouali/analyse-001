// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
//  2, 3, 7 -> 7 44 5 78 -> 78 22 3 9 -> 22 №

Console.Write("input a: ");
string? inputa = Console.ReadLine();
Console.Write("input b: ");
string? inputb = Console.ReadLine();
Console.Write("input c: ");
string? inputc = Console.ReadLine();

if(inputa!=null && inputb!=null && inputc!=null)
{
    int A = int.Parse(inputa);
    int B = int.Parse(inputb);
    int C = int.Parse(inputc);

    int max = A;

    if(max<B)
    {
        max = B;
        
    }    
    if(max<C)
    {
        max = C;
    }
    Console.WriteLine(max);
}

    
    
        
    


