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
    public static void Main()
    {
        Beolvas();
        Kiir();
    }
}