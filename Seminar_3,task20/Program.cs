// Задача №20
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21 

//method to read the user inputs, int( returned/output data type) read_dats(method name)_string msg("input X1: ")
// انشاء دالة تاخذ المدخلات , ثم تطبعها, وتحوله من صورة نصية الى صورة رقمية
int read_data(string msg) //
{
    //(msg) is what we ask user ti enter>>"input X1: "
    Console.WriteLine(msg);
    //form msg to number.
    return int.Parse(Console.ReadLine() ?? "0");

}

void printdata(string msg,double res)
{
    Console.WriteLine(msg+res);
}

//check the length between the two ponts
double calcul(int x1, int x2, int y1, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return res;
}

int coordx1 = read_data("input X1: ");
int coordx2 = read_data("input x2: ");
int coordy1 = read_data("input Y1: ");
int coordy2 = read_data("input Y2: ");
double len=calcul(coordx1, coordx2, coordy1, coordy2);
printdata("length: ", len);