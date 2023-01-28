/*
 * Author: Daniela Lopez 
 * Course: COMP-003A-L01
 * Purpose: Code demonstrating the basics of programming 
 */

namespace COMP003A.Assignment2
{
internal class Program 
{
static void Main (string[] args)
{
    Console.WriteLine ("****************");
    Console.WriteLine ("Console Section");
    Console.WriteLine ("****************");
    Console.Title = "COMP003A.Assignemt2";
    Console.BackgroundColor = ConsoleColor.DarkBlue; 
    Console.ForegroundColor = ConsoleColor.White; 

    Console.WriteLine ("***************");
    Console.WriteLine ("String Section");
    Console.WriteLine ("***************");
    Console.WriteLine ("Enter First Name: ");
    string firstName = Console.ReadLine ();
    Console.WriteLine ("Enter Middle Name: ");
    string middleName = Console.ReadLine ();
    Console.WriteLine ("Enter Last Name: ");
    string lastName = Console.ReadLine ();
    Console.WriteLine ("Enter Age in 2023: ");
    string inputAge = Console.ReadLine ();
    int yearBorn = 2023 - Convert.ToInt32(inputAge);
    Console.WriteLine ($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}. ");

    Console.WriteLine ("************");
    Console.WriteLine ("Math Section");
    Console.WriteLine ("************");
    string integer1string; 
    int integer1;
    Console.WriteLine ("Enter an integer for integer1");
    integer1string = Console.ReadLine ();
    integer1 = Convert.ToInt32(integer1string);
    string integer2string; 
    int integer2;
    Console.WriteLine ("Enter an integer for integer2");
    integer2string = Console.ReadLine ();
    integer2 = Convert.ToInt32(integer2string);
    Console.WriteLine ($"{integer1} + {integer2} = {integer1 + integer2}");
    Console.WriteLine ($"{integer1} - {integer2} = {integer1 - integer2}");
    Console.WriteLine ($"{integer1} * {integer2} = {integer1 * integer2}");
    Console.WriteLine ($"{integer1} / {integer2} = {integer1 / integer2}");
    Console.WriteLine ($"{integer1} % {integer2} = {integer1 % integer2}");

    Console.WriteLine ("**********************************************");
    Console.WriteLine ("Circle Area & Circumference Calculator Section");
    Console.WriteLine ("**********************************************");
    string radiusString;
    Console.WriteLine ("Enter radius: ");
    double radius = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * Math.Pow(radius, 2);
    double circumference = 2 * Math.PI * radius; 
    Console.WriteLine ($"The area is {area}");
    Console.WriteLine ($"The circumference is {circumference}");


}
}
}