Console.WriteLine("enter num A: ");
string? num =Console.ReadLine();

if(num!=null)
{
    int A = int.Parse(num);
    int lastnum =  A%10;
    Console.WriteLine(lastnum);
    
}