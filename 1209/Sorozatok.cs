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

//Kérjük be valós számok egy sorozatát, és adjuk meg a pozitív elemek szorzatát! Ha nins pozitív elem, akkor adjunk eredményként 1-et!
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

//Kérjük be valós számok egy sorozatát, és adjuk meg, hogy hány esetben fordul elő, hogy egy szám nagyobb a szomszédjainál. Legelső és legutolsó számot ne vegyük figyelembe!
    static void Feladat2() {
        Beolvas();
        int darab = 0;
        double elotte = tomb[0];
        System.Console.WriteLine("Ezek a számok nagyobbak, mint szomszédjaik: ");
        for (var i = 1; i < tomb.Length-1; i++)
        {
            if (tomb[i]>elotte && tomb[i]>tomb[i+1])
            {
                System.Console.Write(tomb[i]);
            }
            elotte = tomb[i];
            darab++;
        }
        System.Console.WriteLine("Darab: "+darab);
    }
//Kérjük be valós számok egy sorozatát, és adjuk meg, hogy hány szám van a legkisebb és legnagyobb szám között.
    static void Feladat3() {
        Beolvas();
        int db = 0;
        double legkisebb = tomb[0];
        double legnagyobb = tomb[0];
        int legkis = 0;
        int legnagy = 0;
        for (var i = 0; i < tomb.Length; i++)
        {
            if (legkisebb > tomb[i])
            {
                legkis = i;
                legkisebb = tomb[i];
            }
            if (legnagyobb < tomb[i])
            {
                legnagy = i;
                legnagyobb = tomb[i];
            }
        }
        if (legkis<legnagy)
        {
        for (var i = legkis; i < legnagy; i++)
        {
            db++;
        }   
        }
        else
        {
        for (var i = legnagy; i < legkis; i++)
        {
            db++;
        } 
        }
        System.Console.WriteLine("Darab: "+db);

    }
    public static void Main()
    {
        //Beolvas();
        //Kiir();
        //Feladat1();
        //Feladat2();
    }
}
