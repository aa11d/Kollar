using System;

class Program()
{
    static int[] szavaz;
    static int[] kapott = new int[11];
    static void Main()
    {
        System.Console.Write("Szöveg: ");
        var Sor = Console.ReadLine();
        string[] darab = Sor.Split(' ');
        int[] szavaz = new int[darab.Length];
        for (int i = 0; i < szavaz.Length; i++)
        {
            szavaz[i] = int.Parse(darab[i]);
            System.Console.Write(szavaz[i]+" ");
        }
        Uno();
    }

    static void Uno()
    {
        for (int i = 1; i < kapott.Length; i++)
        {
            for (int j = 0; j < szavaz.Length; j++)
            {
                if (szavaz[j] == i)
                {
                    kapott[i]++;
                }
            }
        }
        System.Console.WriteLine("0 1 2 3 4 5 6 7 8 9");
        System.Console.WriteLine(kapott);
    }

}