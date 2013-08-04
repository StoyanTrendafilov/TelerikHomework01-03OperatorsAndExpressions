using System;

class BitChanger
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert your number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Please, insert the bit position,you are want to change, starting from zero(0):");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Plesae, insert the value for the bit, you have want to change (only 0 or 1):");
        int value = int.Parse(Console.ReadLine());

        if (value == 1 || value == 0)
        {
            if (value == 1)
            {
                int result = (((value) << position) | number);
                Console.WriteLine("The number, you will get with the exchange, is : {0}", result);
                Console.WriteLine("\nAnd if you want to check for mistakes : ");
                Console.WriteLine("This is how your number looks like : " + Convert.ToString(number, 2));
                Console.WriteLine("This is how the number we get, looks like : " + Convert.ToString(result, 2));
            }
            if (value == 0)
            {
                int result = (~(1 << position)) & number;
                Console.WriteLine("The number, you will get with the exchange, is : {0}", result);
                Console.WriteLine("\nAnd if you want to check for mistakes : ");
                Console.WriteLine("This is how your number looks like : " + Convert.ToString(number, 2));
                Console.WriteLine("This is how the number we get, looks like : " + Convert.ToString(result, 2));
            }
        }

        else
            Console.WriteLine("You have entered invalid value for your bit, ask google for further\ninfrormation ;)");
    }
}

