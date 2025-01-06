using System;
using System.Collections.Generic;
using System.IO.Compression;
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

        int lk = 1000000000;
        int ut = 0;
        bool tf = true;
        for (var i = 0; i < hossz-2; i++)
        {
            tf = true;
            for (var l = 0; l < 3; l++)
            {
                if (pontok[i+l] != 0)
                {
                    ut += pontok[i+l];
                }
                if (pontok[l+i] == 0)
                {
                    tf = false;
                    break;
                }
            }
            if (tf)
            {
                if(ut < lk ) 
                    lk = ut;
            }
            ut = 0;
        }
        System.Console.WriteLine(lk);
    }

    static void Feladat6()
    {
        System.Console.Write("Pontok: ");
        var Sor = Console.ReadLine();
        string[] pontok_s = Sor.Split(' ');
        int hossz = pontok_s.Length;
        int[] pontok = new int[hossz];
        for (int i = 0; i < pontok.Length; i++)
        {
            pontok[i] = int.Parse(pontok_s[i]);
        }

        int db = 0;
        for (var i = 0; i < hossz; i++)
        {
            if (pontok[i] >= 5 && pontok[i] <= 10)
            {
                db++;
            }
        }
        System.Console.WriteLine($"Válasz: {db}");
    }

    static void Feladat7()
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

        int db = 1;
        int num = 0;
        for (var i = 0; i < hossz; i++)
        {
            if (num < pontok[i])
            {
                num = pontok[i];
                db++;
            }
        }
        System.Console.Write("Válasz: ");
        for (var i = 0; i < hossz; i++)
        {
            if (num == pontok[i])
            {
                System.Console.Write(i+1+"");
            }
        }
        
    }

    static void Feladat8()
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

        int num = 0;
        for (var i = 0; i < hossz; i++)
        {
            if (pontok[i] > 1)
            {
                num += pontok[i];
            }
        }
        if (num != 0)
        {
            System.Console.WriteLine("Válasz: "+num);
        }
        else{
            System.Console.Write("Válasz: Nem volt");
        }
    }

static void Feladat9()
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

        int num = pontok.Max();
        int db = -1;
        for (var i = 0; i < hossz; i++)
        {
            if (pontok[i] == num)
            {
                db = i+1;
            }
            if (db > -1)
            {
                break;
            }
        }
        System.Console.Write("Válasz: "+db);
    }

    static void Feladat10()
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

        int lk = 0;
        int db = 0;
        int ut = 0;
        for (var i = 0; i < hossz; i++)
        {
            for (var l = 0; l < hossz-(i+1); l++)
            {
                ut += pontok[i+l];
                db++;
                if (ut >= 20)
                {
                    if (lk < db)
                    {
                        lk = db;
                    }
                }
            }
            db = 0;
        }
        System.Console.WriteLine(lk);
    }
}