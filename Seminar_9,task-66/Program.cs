//                                               З а д а ч а  66 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//-----------------------------------------------------------------


//                                           C O D E -- D r i v e r 

int M=ReadData("Enter M : ");
int N=ReadData("Enter N : ");
int res=SumOfInterval(M,N);
PrintData("the result: ",res);
//                                               M E T H O D S



int ReadData(string msg) //                                      reading the inputs.     
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

int SumOfInterval(int M,int N)
{
    int sum1=0;
    if(M>N)
    {
        while(N<=M)
        {
            sum1+=N;
            N++;
        }
    }
    else if(N>M)
    {
        while(M<=N)
        {
            sum1+=M;
            M++;
        }
    }
    return sum1;
}

void PrintData(string res, int value)                            //print Data
{
    Console.WriteLine(res + value);

}




