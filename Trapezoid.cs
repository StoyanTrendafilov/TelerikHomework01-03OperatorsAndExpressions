using System;

class Trapezoid
{
    static void Main(string[] args)
    {
        Console.Write("Please, inserrt your trapezoid's side A : ");
        decimal sideA = decimal.Parse(Console.ReadLine());
        Console.Write("Please, insert your trapezoid's side B : ");
        decimal sideB = decimal.Parse(Console.ReadLine());
        Console.Write("Please, insert your trapezoid's height : ");
        decimal height = decimal.Parse(Console.ReadLine());
        Console.WriteLine(" The area of your trapezoid, is : " + ((sideA + sideB) * height) / 2); // Формула за лице на трапец
    }
}

