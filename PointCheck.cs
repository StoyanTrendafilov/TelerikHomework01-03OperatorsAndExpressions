using System;

class PointCheck
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert you (X) size: ");
        decimal X = decimal.Parse(Console.ReadLine());
        Console.Write("Please, insert your (Y) size: ");
        decimal Y = decimal.Parse(Console.ReadLine());
        bool inside = (X * X + Y * Y) <= 25; // Използваме питагоровата теорема, защото ако точката се намира в кръга, то хипотенузата на 
        if (inside) // правоъгълен триъгълник, с размери на катетите X и Y трябва да е по-малка или равна на радиуса на окръжността, за да
            Console.WriteLine("Your point is inside cirkle with radius five.");//може точка с координати X и Y да се намира в нея. 
        else //                                                                     Надявам се обяснението е добро :)
            Console.WriteLine("Try another coordinates.");
    }
}

