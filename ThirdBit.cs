using System;

class ThirBit
{
    static void Main(string[] args)
    {
        Console.Write("Please, insert your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The number, you have entered as decmial, looks like \"{0}\" in binary system.", Convert.ToString(number, 2));
        bool isForthBitOne = ((number & (1 << 4) >> 4) == 1);
        int bit = ((number & (1 << 4)) >> 4);
        Console.WriteLine("Your third bit is (we start counting form 0) : " + bit);
        Console.WriteLine("It is \"{0}\", that your thid bit is \"1\" ", isForthBitOne);

        // Zakomentiraniqt wariant po-dolu e za prowerka bez da se polzwa bulewa komanda, s pomo6tta na cikyl.

        //int position = 3;
        //int mask = 1 << position;// 0000 0001 stawa 0000 1000
        //int chekirano = number & mask;// tuk trqbwa wschki bitowe na 4isloto chekirano da stanat 0 s izklu4enie na tretiqt, kato broeneto zapo4ne ot nula
        //int bit = chekirano >> position;//prawim 4etwyrtiqt bit pyrwi
        //Console.WriteLine("The third bit of your number is : " + bit);//za moe udobstwo - po-lesna prowerka dali ima gre6ka :)
        //if (bit == 0)
        //    Console.WriteLine("The third bit of your number in decimal way of look is 0");
        //else
        //    Console.WriteLine("The third bit of your number in decimal way of look is 1");
    }
}
