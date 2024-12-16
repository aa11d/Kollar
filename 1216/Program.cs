using System;

class Megoldasok
{
    static void Main(string[] args)
    {
        Feladat5();
    }

    static void Feladat1()
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

        int ossz = 0;
        for (var i = 0; i < pontok.Length; i++)
        {
            ossz += pontok[i];
        }

        System.Console.WriteLine("Út: "+ossz);
    }

    static void Feladat2()
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

        int ossz = 0;
        for (var i = 0; i < pontok.Length; i++)
        {
            if (pontok[i] < 5)
            {
                ossz+= pontok[i];
            }
        }
        System.Console.WriteLine("Válasz: "+ossz);
    }

    static void Feladat3()
    {
        System.Console.Write("Befutott: ");
        var Sor = Console.ReadLine();
        string[] pontok_s = Sor.Split(' ');
        int hossz = pontok_s.Length;
        int[] pontok = new int[hossz];
        for (int i = 0; i < pontok.Length; i++)
        {
            pontok[i] = int.Parse(pontok_s[i]);
        }

        int db = 0;
        for (var i = 0; i < pontok.Length; i++)
        {
            if (pontok[i] < 4 && pontok[i] >= 1)
            {
                db++;
            }
        }
        System.Console.WriteLine("Válasz: "+db);
    }

    static void Feladat4()
    {
        System.Console.Write("Befutott: ");
        var Sor = Console.ReadLine();
        string[] pontok_s = Sor.Split(' ');
        int hossz = pontok_s.Length;
        int[] pontok = new int[hossz];
        for (int i = 0; i < pontok.Length; i++)
        {
            pontok[i] = int.Parse(pontok_s[i]);
        }

        int elso = -1;
        for (var i = 0; i < pontok.Length; i++)
        {
            if (pontok[i] > 9)
            {
                elso = i;
                break;
            }
        }
        if (elso != -1)
        {
            System.Console.WriteLine("Válasz: "+elso);
        }
        else
        {
            System.Console.WriteLine("Válasz: Nem volt");
        }
    }

    static void Feladat5()
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

        int db = 0;
        for (var i = 0; i < pontok.Length; i++)
        {
            if (pontok[i] == 0)
            {
                db++;
            }
        }
        System.Console.WriteLine("DB: "+db);
    }

    static void Feladat6()
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

        int db = 0;
        for (var i = 0; i < pontok.Length; i++)
        {
            if (pontok[i] < 8)
            {
                db++;
            }
        }
        System.Console.WriteLine("DB: "+db);
    }

    static void Feladat7()
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

        int ossz = 0;
        int db = 0;
        for (var i = 0; i < pontok.Length; i++)
        {
            if (pontok[i] > 0)
            {
                ossz += pontok[i];
                db++;
            }
        }
        float atlag = (float)ossz / db;
        System.Console.WriteLine($"Válasz: {atlag:f1}");
    }
}