using System;

class Tombok
{
    static void Feladat01()
    {
        Console.Write("Sorozat: ");
        var bemenet = Console.ReadLine();
        string[] Darabolt = bemenet.Split(' ');
        double[] szamok = new double[Darabolt.Length];
        for (var i = 0; i < szamok.Length; i++)
        {
            szamok[i] = double.Parse(Darabolt[i]);
        }
        foreach (double szam in szamok)
        {
            System.Console.Write(szam+" ");
        }
        System.Console.WriteLine();

        Array.Sort(szamok);

        double median;
        if (szamok.Length % 2 == 1)
        {
            median = szamok[szamok.Length / 2];
        }
        else
        {
            median = (szamok[szamok.Length / 2] + szamok[szamok.Length / 2 -1]) / 2;
        }
        Console.WriteLine($"Medián: {median:f2}");
    }

    static void Feladat02()
    {
        Console.Write("Sorozat: ");
        var bemenet = Console.ReadLine();
        string[] Darabolt = bemenet.Split(' ');
        int[] szamok = new int[Darabolt.Length];
        for (var i = 0; i < szamok.Length; i++)
        {
            szamok[i] = int.Parse(Darabolt[i]);
        }
        foreach (int szam in szamok)
        {
            System.Console.Write(szam+" ");
        }
        System.Console.WriteLine();

        int legkis = szamok.Min();
        for (var i = 0; i < szamok.Length; i++)
        {
            if (szamok[i] == legkis)
            {
                System.Console.Write((i+1) + " ");
            }
        }
        System.Console.WriteLine();
    }

    static void Feladat03()
    {
        Console.Write("Sorozat: ");
        var bemenet = Console.ReadLine();
        string[] Darabolt = bemenet.Split(' ');
        int[] szamok = new int[Darabolt.Length];
        for (var i = 0; i < szamok.Length; i++)
        {
            szamok[i] = int.Parse(Darabolt[i]);
        }
        foreach (int szam in szamok)
        {
            System.Console.Write(szam+" ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Jók: ");
        for (var i = 0; i < szamok.Length; i++)
        {
            if (i % 2 == 0 && szamok[i] % 2 == 0)
            {
                System.Console.Write(szamok[i] + " ");
            }
        }
        System.Console.WriteLine();
    }
    
    static void Feladat04()
    {
        Console.Write("Sorozat: ");
        var bemenet = Console.ReadLine();
        string[] Darabolt = bemenet.Split(' ');
        int[] szamok = new int[Darabolt.Length];
        for (var i = 0; i < szamok.Length; i++)
        {
            szamok[i] = int.Parse(Darabolt[i]);
        }
        foreach (int szam in szamok)
        {
            System.Console.Write(szam+" ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Jók: ");
        for (var i = 0; i < szamok.Length; i++)
        {
            if (i+1 == szamok[i])
            {
                System.Console.Write(szamok[i] + " ");
            }
        }
        System.Console.WriteLine();
    }

    public static void Main()
    {
        //Feladat01();
        //Feladat02();
        //Feladat03();
        Feladat04();
    }
}