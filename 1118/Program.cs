using System;

class Megoldas
{
    static void Véletlenszavak()
    {
        Random rnd = new Random();
        string s = "";

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < rnd.Next(4,11); j++)
            {
                s += (char)(rnd.Next(26)+(int)'A');
            }
            s +=" ";
        }
        System.Console.WriteLine("Szöveg: "+s);
    }

    static void Main(){
        Véletlenszavak();
    }
}