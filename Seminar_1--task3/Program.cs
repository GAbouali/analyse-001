// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Enter day number: ");
string? day = Console.ReadLine();

//check that input isnt empty.
if(day!=null)
{
    //make the program to treat with the input as a number.
    int dayname = int.Parse(day);

    //creatin an array.
    string[] weekday = new string[7];
    weekday[0] = "monday";
    weekday[1] = "tuseday";
    weekday[2] = "wednesday";
    weekday[3] = "thursday";
    weekday[4] = "friday";
    weekday[5] = "saturday";
    weekday[6] = "sunday";

    Console.WriteLine(weekday[dayname-1]);

}


