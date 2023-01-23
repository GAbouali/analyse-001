// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4 // 8 -> 2, 4, 6, 8
//request the required data.
Console.WriteLine("enter number, ");

//read the intered data from console.
string? num = Console.ReadLine();

//get sure that data isnt empty.
if(num!=null)
{
    //classify the interd data.
    int A = int.Parse(num);
    int C = A/A+1;
    string R = string.Empty;

while(C<=A && C % 2 == 0)
    {
        R = R+C+",";
        C = C+2;
    } 
    
    
    Console.WriteLine(R);
}

    

    
    

