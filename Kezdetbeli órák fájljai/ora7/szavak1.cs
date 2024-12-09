using System;

class szoveg1
{
    static void Main()
    {
        Console.WriteLine("Enter String");
        string str = Console.ReadLine();
        bool elozo = false;
        string szoveg1 = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' && elozo == false)
            {
                elozo = true;
                szoveg1 += str[i];
            }
            else if(str[i] != ' '){
                szoveg1 += str[i];
                elozo = false;
            }
        }

        int szavak = 0;
        for (int i = 1; i < szoveg1.Length; i++)
        {
            if (szoveg1[i] == ' ')
            {
                szavak++;
            }
        }
        System.Console.WriteLine($"Szavak száma: {szavak}");
    }
}