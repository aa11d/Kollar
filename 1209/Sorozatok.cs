using System;

class Sorozatok {
    static double[] tomb;

    static void Beolvas(){
        System.Console.WriteLine("Számok: ");
        string bemenet = Console.ReadLine();
        string[] bemdarab = bemenet.Split(' ');
        tomb = new double[ bemdarab.Length ];
        for (var i = 0; i < tomb.Length; i++)
        {
            tomb[i] = double.Parse(bemdarab[i]);
        }
    }

    static void Kiir() {
        System.Console.Write("A sorozat: ");
        for (var i = 0; i < tomb.Length; i++)
        {
            System.Console.Write($"{tomb[i]:f1} ");
        }
        System.Console.WriteLine();
    }

    static void Feladat1() {
        Beolvas();
        var szorzat = 1.0;
        for (var i = 0; i < tomb.Length; i++)
        {
            if (!(tomb[i]<0))
            {
                szorzat = szorzat*tomb[i];
            }
        }
        System.Console.WriteLine("Eredméyn: "+szorzat);
    }

    static void Feladat2() {
        Beolvas();
        double elotte = tomb[0];
        System.Console.WriteLine("Ezek a számok nagyobbak, mint szomszédjaik: ");
        for (var i = 1; i < tomb.Length-1; i++)
        {
            if (tomb[i]>elotte && tomb[i]>tomb[i+1])
            {
                System.Console.Write(tomb[i]);
            }
            elotte = tomb[i];
        }
    }
    public static void Main()
    {
        //Beolvas();
        //Kiir();
        //Feladat1();
        //Feladat2();
    }
}