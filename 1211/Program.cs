using System;

class Program()
{
    public static void Main()
    {
        uno();
    }

    static void uno()
    {
        System.Console.Write("Pont: ");
        var Sor = Console.ReadLine();
        int[] pontok = Int32.Parse(Sor.Split(' '));
        int darab = 0;
        for (int i = 1; i < pontok.Length; i++)
        {
            if (pontok[i]>pontok[i-1] && pontok[i]>pontok[i+1])
            {
                darab++;
            }
        }
        System.Console.WriteLine("Válasz: "+darab);
    }

}