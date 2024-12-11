using System;

class Program()
{

    static void Main()
    {
        Uno();
    }
    static void Uno()
    {
        System.Console.Write("Szöveg: ");
        var Sor = Console.ReadLine();
        string[] darab = Sor.Split(' ');
        int[] szavaz = new int[darab.Length];
        for (int i = 0; i < szavaz.Length; i++)
        {
            szavaz[i] = int.Parse(darab[i]);
        }
        
    }

}