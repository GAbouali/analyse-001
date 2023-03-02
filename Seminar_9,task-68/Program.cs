//                                              З а д а ч а  66
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//---------------------------------------------------------

//                                           C O D E -- D r i v e r 

int m = ReadData("ُEnter number M : ");
int n = ReadData("Enter number N : ");
int functionAkkerman = AckermanFunctions(m, n);
Console.Write("ackerman functions = " + functionAkkerman);


//                                               M E T H O D S

int AckermanFunctions(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFunctions(m - 1, 1);
  else return AckermanFunctions(m - 1, AckermanFunctions(m, n - 1));
}

int ReadData(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


