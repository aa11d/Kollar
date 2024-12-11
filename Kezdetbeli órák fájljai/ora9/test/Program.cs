using System;

class Megoldas
{
    static void Main()
    {
        Console.Write("Utca hossza: ");
        int input = int.Parse(Console.ReadLine());
        int oszlopok = 2;

        if (input < 20)
        {
            System.Console.Write(oszlopok);
        }
        else
        {
            while (input != 0)
            {
                oszlopok++;
                input-=20;
                if (input<20){
                    input = 0;
                }
            }
            System.Console.Write(oszlopok);
        }

    }
}