using System;

class Exchanger
{
    static void Main(string[] args)
    {
        Console.Write("Insert your number :");
        UInt32 number = UInt32.Parse(Console.ReadLine());
        UInt32 mask1, mask2, bit1, bit2;
        Console.WriteLine("In bynary system your number looks like :");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.Write("Insert positin k : ");
        int first = int.Parse(Console.ReadLine()) - 1; // 

        Console.Write("Insert position q : ");
        int second = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Insert the count of digits, you want to exchange: ");
        int count = int.Parse(Console.ReadLine());

        bool passed = (second > first) & (count != 0) & ((second + count) <= 32);

        if (passed)
        {


            UInt32 one = 1;
            for (int i = 0; i < count; i++)
            {
                mask1 = Convert.ToUInt32(one << first + i);
                mask2 = Convert.ToUInt32(one << second + i);

                bit1 = (number & mask1) >> (first + i);
                bit2 = (number & mask2) >> (second + i);

                if (bit1 == 0)
                    number = number & (~(one << second + i));                          
                else
                    number = (one << (second + i)) | number;

                if (bit2 == 0)
                    number = number & (~(one << first + i));                   
                else
                    number = (one << (first + i)) | number;
            }
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0')); // Тази програма има и втори вариант на решение с масив, който е закоментиран от тук надолу :)

            //Console.WriteLine("Please, be careful, because counting of bit positions starts form zero ! ");
            //Console.Write("What is yor number : ");
            //int number = int.Parse(Console.ReadLine());
            //string str = Convert.ToString(number, 2).PadLeft(32, '0');
            //char[] mas = str.ToCharArray(); //new char[str.Length];
            //Console.WriteLine(mas);

            //Console.Write("Insert bit position 1 (p): ");
            //int pos1 = int.Parse(Console.ReadLine());

            //Console.Write("Please insert bit position 2 (q) : ");
            //int pos2 = int.Parse(Console.ReadLine());

            //Console.Write("How many bits you want to exchange? ");
            //int fewBits = int.Parse(Console.ReadLine());
            //bool passed = (pos2 > pos1) & (fewBits != 0) & ((pos2 + fewBits) <= mas.Length);
            //if (passed)
            //{

            //    if ((pos1 + fewBits >= mas.Length) || (pos2 + fewBits >= mas.Length))
            //        Console.Write("Total length bigger than array length!!! Error!!! ");
            //    else
            //    {
            //        char smqna;

            //        for (int i = 0; i < fewBits; i++)
            //        {

            //            // tuk za6to se izpolzva [mas.Length-(pos1 + i) - 1]

            //            // nie tursim elementa na pozicia (pos1 + i), no tova e string i se broi ot liavo na diasno, a na pri broinite sistemi
            //            // dvoi4na i t.n. se broi ot diasno na liavo
            //            //zatova izpolzvame dyljinata na stringa (masiva) i poneje se zapo4va broeneto ot 0, a ne ot 1, izvajdame "1"



            //            smqna = mas[mas.Length - (pos1 + i) - 1];
            //            mas[mas.Length - (pos1 + i) - 1] = mas[mas.Length - (pos2 + i) - 1];
            //            mas[mas.Length - (pos2 + i) - 1] = smqna;


            //        }
            //    }

            //    string newstr = new string(mas);
            //    Console.WriteLine(newstr);
            //    Console.WriteLine(Convert.ToUInt32(newstr, 2));
            //}
            ////Console.WriteLine(Convert.ToUInt32(newstr));
            //// 32767 - 15 EDINICI - ZA TESTA
            //else Console.WriteLine("You have entered something wrong, sorry, try again. (q + k shoub be smaller than 32 !!!!)!");
            //МОЖЕ ДА СЕ НАЛОЖИ НАПАСВАНЕ НА КЪДРАВИТЕ СКОБИ ЗА ВТОРИЯ ВАРИАНТ, НО КОДА Е КОРЕКТЕН И РАБОТИ.
        }
    }
}

