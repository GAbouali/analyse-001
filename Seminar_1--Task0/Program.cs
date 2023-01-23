// Задача №0
// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя). 

//request the required data.
Console.WriteLine("input number, ");
//read the intered data from console.
string? inputnum = Console.ReadLine();
//get sure that data isnt empty.
if(inputnum!=null)
{
    //classify the interd data.
    int number = int.Parse(inputnum);

//get the square of this number.
    int result = number*number;
//output data on the console.
Console.WriteLine(result);

}



