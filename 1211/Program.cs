using System;

class Program
{
    public static void Main()
    {
        tres();
    }

    static void uno()
    {
        System.Console.Write("Pont: ");
        var Sor = Console.ReadLine();
        string[] pontok_s = Sor.Split(' ');
        int hossz = pontok_s.Length;
        int[] pontok = new int[hossz];
        for (int i = 0; i < pontok.Length; i++)
        {
            pontok[i] = int.Parse(pontok_s[i]);
        }

        int darab = 0;
        for (int i = 1; i < pontok.Length-1; i++)
        {
            if ((pontok[i]>pontok[i-1]) && (pontok[i]>pontok[i+1]))
            {
                darab++;
            }
        }
        System.Console.WriteLine("Válasz: "+darab);
    }

    static void dos()
    {
        System.Console.Write("KM: ");
        var Sor = Console.ReadLine();
        string[] pontok_s = Sor.Split(' ');
        int hossz = pontok_s.Length;
        int[] pontok = new int[hossz];
        for (int i = 0; i < pontok.Length; i++)
        {
            pontok[i] = int.Parse(pontok_s[i]);
        }

        int idoszak = 0;
        if (pontok[0]>10)
            {
                idoszak++;
            }
        for (int i = 1; i < pontok.Length; i++)
        {
            if (pontok[i-1]>10)
            {
                continue;
            }
            if (pontok[i]>10)
            {
                idoszak++;
            }
            
        }
        System.Console.WriteLine("DB: "+idoszak);
    }

    static void tres()
    {
        System.Console.Write("KM: ");
        var Sor = Console.ReadLine();
        string[] pontok_s = Sor.Split(' ');
        int hossz = pontok_s.Length;
        int[] pontok = new int[hossz];
        for (int i = 0; i < pontok.Length; i++)
        {
            pontok[i] = int.Parse(pontok_s[i]);
        }

        int hossz = 100;
        int temp = 0;
        for (int i = 0; i < pontok.Length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                temp += pontok[j];
            }
            if (!(pontok[0] == 0 || pontok[1] == 0 ||pontok[2] == 0))
            {
                if (temp < hossz)
                {
                    hossz = temp;
                }
            }
            temp = 0;
            
        }
    }
}