using System;

class PointChecker
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert you X value: ");
        decimal coordinateX = decimal.Parse(Console.ReadLine());
        coordinateX = coordinateX - 1m;
        //Console.WriteLine( coordinateX ); // Закоментираните ползвах за мое улеснение по време на писането. 
        Console.Write("Please, insert your Y value: "); // Спокойно може да се изтрият, ако дразнят някой, 
        decimal coordinateY = decimal.Parse(Console.ReadLine());// но все пак тук се учим ;).
        coordinateY = coordinateY - 1m;
        bool insideCircle = ((coordinateX * coordinateX) + (coordinateY * coordinateY)) <= 9;
        //Console.WriteLine( insideCircle );
        coordinateX = coordinateX + 1m;
        coordinateY = coordinateY + 1m;
        //Console.WriteLine(coordinateX);
        bool insideRectangle = ((coordinateX >= -1) && (coordinateX <= 5) && (coordinateY <= 1) && (coordinateY >= -1));
        //Console.WriteLine( insideRectangle );
        bool insideWantedArea = (insideCircle && (!insideRectangle));
        if (insideWantedArea)
            Console.WriteLine("The point with coordinates, you have enteres, is inside wanter area!");
        else
            Console.WriteLine("The point witho coordinates, you have enteres, is NOT inside wanted area!");
    }
}

