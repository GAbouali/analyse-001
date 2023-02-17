
//                                                   كيف تستقبل رقم ما, وتحوله الى مصفوفة , وتستخدم نظام الاندكس عليه؟
// Console.WriteLine("input num, ");
// string? num = Console.ReadLine();

// if (num != null)
// {
//     // int res = 0;
//     char[] numarray = num.ToCharArray();
//     Console.WriteLine(numarray[2]);
// }
//                                                                    كيف تنشا مصفوفة وتملأها؟  الاجابة في32 مسالة 
//                                                              انشاء عداد في مسالة 35 ,لعد عناصر المصفوفة (count++) 
//                                         لتوقيف اللوب عند حد معين استخدم (بريك) كما في المثال 33 سطر 61 م


// Console.WriteLine("input num, ");              //print inputs.
// string? num = Console.ReadLine() ?? "0";      //creat V = the 'inputs'
// char[] numarray = num.ToCharArray();         //creat V = transform inputs to an 'array'
// int indx = 0;
// int arraylen = numarray.Length;             // creat V = 'array' length.
// // Console.WriteLine(arraylen);

// while (indx < arraylen)
// {
//     int sum = 0;
//     string outNumLine = string.Empty;
//     // int numinx=numarray[i]+0;
//     outNumLine = outNumLine + numarray[indx];
//     indx++;
//     // // int d=int.Parse(outNumLine ?? "0");
//     sum = sum + numarray[indx] + numarray[indx]-1;

//     Console.WriteLine(sum);
// }


//-------------------------------------------

// int C = Convert.ToInt32(Console.Readlie());     //convert the inputs from user to number>> #057 محول المدخلات الى رقم

// string[array.length-1]="01";                    //get the last element of the array>> #057 الوصول الى اخر عنصر في المصفوفة

// String strng_name = new String(char_array);   //convert char array V to string V .#057, 12:03.

// String strname="sameh"   Char[] chaerarray;    chararray=strname.tochararray();   //convert string V to char array V.#057 14:44
//                                                                              تحويل متغير سترنج الى متغير مصفوفة
// //                                  ****** seminar 6 ******


// // Задача №39 
// // كود تبديل اخر عنصر باول عنصر بالمصفوفة, في نفس المصفوفة
// // if(int i=0;i<main_arr.length;i++)
// //    (main_arr[i] , main_arr[main_arr.length-1-i] - (main_arr[main_arr.length-1-i] , main_arr[i])
// // example: [1,2,3,4] >>> [4,3,2,1]

// // Задача №40
// // يمكن بناء مثلث في حال كان مجموع كل ضلعين اكبر من الضلع الثالث 
// // if(a+b>c&&a+c>b&&b+c>a);

// // Задача №42
// // ملأ سترنج بارقام من نوع انت
// // string result = string.empty;
// // result = result + covert.tostring(num%2);

// // Задача №44
















// // lesson 1
// Console.Write Command
// Program for calculating the quotient of two numbers
// Operators for arithmetic operations in C#
// Commands-assistant programmer in C#. Pseudo-random number generator
// Loop Statement Application

// // lesson 2
// Functions in programming
// Let's look for a maximum of 9 numbers
// max function
// Arrays. Arrangement of arrays inside a computer
// Algorithm, Implementation of the algorithm
// Syntax language
// Method IndexOf

// // lesson 3
// Let's analyze the groups of methods
// Named Arguments
// The fourth group of methods
// Conditional types of methods
// 'for' loop
//  Cycle within a cycle  
//  Order arrays



int a=read_data("c");


int read_data(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


