using System;

class Megoldas
{
    static void Main()
    {
        /*
        System.Console.Write("Kisebb: ");
        var input1 = double.Parse(Console.ReadLine());
        
        System.Console.Write("Nagyobb: ");
        var input2 = double.Parse(Console.ReadLine());

        var negyzet1 = input1*input1;
        var negyzet2 = input2*input2;
        var osszeg = 0.0;
        var darab = 0.0;

        for (var i = negyzet1-1; i < negyzet2+1; i++)
        {
            if (i % 13 == 0)
            {
                osszeg+= i;
                darab++;
            }
        }
        if (osszeg != 0)
        {
            System.Console.WriteLine($"Átlag: {osszeg/darab:f1}");
        }
        else
        {
            System.Console.WriteLine("Nincs átlag");
        }
        */
        /*
        System.Console.Write("Szám: ");
        var input1 = int.Parse(Console.ReadLine());

        var szorzat = 1;
        var osszeg = 0;
        int szam;

        for (var i = 0; i < input1.ToString().Length; i++)
        {
            szam = (int) input1.ToString() [i] - (int) '0';
            szorzat = szam*szorzat;
            osszeg += szam;
        }

        System.Console.WriteLine("Szorzat: "+szorzat);
        System.Console.WriteLine("Összeg: "+osszeg);
        */

        System.Console.Write("N: ");
        var input1 = int.Parse(Console.ReadLine());
        int Index_ = 0;
        while (input1 > 0)
        {
            Index_++;
            input1 -= Index_.ToString().Length;
            
        }

        Console.WriteLine(Index_.ToString()[Index_.ToString().Length-1 + input1]);
    }
}
