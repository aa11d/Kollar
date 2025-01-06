using System;
using System.Collections.Generic;
using System.Formats.Tar;
class Megoldasok {
    static void Main(string[] args)
    {
        Feladat5();
    }

    static void Feladat1()
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
            if (pontok[i] != 0)
            {
                ossz += pontok[i];
                db++; 
            }
        }
        float atlag = (float)ossz / db;
        System.Console.WriteLine($"Válasz: {atlag:f1}");
    }

    static void Feladat2()
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

        int hossz2 = pontok.Length;
        for (var i = 0; i < pontok.Length; i++)
        {
            if (pontok[i] == 0)
            {
                hossz2--;
            }
        }
        System.Console.WriteLine("Perc: "+hossz2*10);
    }

    static void Feladat3()
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

        int lk = pontok.Max();
        for (var i = 0; i < pontok.Length; i++)
        {
            if (pontok[i] < lk && pontok[i] > 0)
            {
                lk = pontok[i];
            }
        }
        System.Console.WriteLine("LK: "+lk);
    }

    static void Feladat4()
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

        int ut = 0;
        for (var i = 0; i < hossz; i++)
        {
            ut += pontok[i];
        }
        System.Console.WriteLine("Út: "+ut);
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

        int lk = 0;
        int ut = 0;
        bool tf = true;
        for (var i = 0; i < hossz-2; i++)
        {
            for (var l = 0; l < 3; l++)
            {
                if (pontok[l] != 0)
                {
                    ut += pontok[i];
                }
                if (pontok[l] == 0)
                {
                    break;
                    tf = false;
                }
                ut = 0;
            }
            if (tf)
            {
                lk = ut;
            }
        }
        System.Console.WriteLine(lk);
    }
}