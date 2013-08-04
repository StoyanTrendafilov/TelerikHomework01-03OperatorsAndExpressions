using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert the rectangle's height: ");
        decimal height = decimal.Parse(Console.ReadLine()); // избрал съм decimal, защото не е задължително височината и широчината на правоъгълника да са цели числа.
        Console.Write("PLease, insert the rectangle's width: ");
        decimal width = decimal.Parse(Console.ReadLine()); // може и да се добави един ред, с който да се декларира променлива, която да приема стойност от умножените стойности на височината и широчината, но на мен ми се стори излишно.
        Console.WriteLine("The area of your rectangle is: " + height * width);
    }
}

