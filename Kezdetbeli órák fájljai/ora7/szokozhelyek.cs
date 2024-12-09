using System;

class szoveg1
{
    static void Main()
    {
        Console.WriteLine("Enter String");
        string str = Console.ReadLine();
        bool elozo = false;
        string szoveg = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' && elozo == false)
            {
                elozo = true;
                szoveg += str[i];
            }
            else if(str[i] != ' '){
                szoveg += str[i];
                elozo = false;
            }
        }


        int szokoz = 0;
        for (int i = 0; i < szoveg.Length; i++)
        {
            if (szoveg[i]==' '){
                szokoz++;
            }
        }
        System.Console.WriteLine($"Szóközök: {szokoz}");
    }
}