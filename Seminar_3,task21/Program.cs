// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек
//---------------------------------------------------------------------------

// // OPTION 1
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");

// }

// //method to print results(string msg(msg before result), double res(result type is double(3.2,2.1)))
// void printdata(string msg,double res)
// {
//     Console.WriteLine(msg+res);
// }

// //check the length between the two ponts
// double calcul(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double res = 0;
//     res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
//     return res;
// }

// int coordx1 = ReadData("input X1: ");
// int coordx2 = ReadData("input x2: ");
// int coordy1 = ReadData("input Y1: ");
// int coordy2 = ReadData("input Y2: ");
// int coordz1 = ReadData("input z1: ");
// int coordz2 = ReadData("input z2: ");

// //calling methods
// double len=calcul(coordx1, coordx2, coordy1, coordy2, coordz1, coordz2);
// printdata("length: ", len);

//---------------------------------------------------------------------------
//OPTION 2

Console.WriteLine("enter: x1,x2,y1,y2,z1,z2");
string? cord = Console.ReadLine();

if (cord != null)
{
    double res = 0;
    
    char[] array3d = cord.ToCharArray();
    res = Math.Sqrt(Math.Pow(array3d[0] - array3d[1], 2) + Math.Pow(array3d[2] - array3d[3], 2) + Math.Pow(array3d[4] - array3d[5], 2));
    Console.WriteLine(res);
}