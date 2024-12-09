using System;

class Utvonal {
    const int utHossz = 100;
    static int[] magas = new int[utHossz];

    static void General() {
        Random rnd = new Random(); // new();
        magas[0] = rnd.Next(10,30);
        for (int i = 1; i < magas.Length; i++)
        {
            magas[i] = magas[i-1] + rnd.Next(11) - 5; // -5, -4, -3, ..., 3, 4, 5
        }
        for (int i = 0; i < magas.Length; i++)
        {
            if(magas[i]<0) magas[i]=0; // a tenger alattiból lesz tenger
        }
    }

    static void Kirajzol() {
        int maxMagas = magas.Max();
        for (int magi = maxMagas+2; magi >= 0; magi--)
        {
           System.Console.Write($"{magi,3} ");
           for (int xi = 0; xi < magas.Length; xi++)
           {
                if( magi>magas[xi] ) Console.Write(' ');
                else Console.Write('\u2588');
           }
           System.Console.WriteLine( " " + magi );
        }


    }

    static void Feliratok() {
        System.Console.Write("    ");
        for (int i = 0; i < magas.Length; i++)
        {
            if( i % 10 == 0 ) Console.Write( i/10 ); // kétjegyűekig jó
            else Console.Write(' ');
        }
        System.Console.WriteLine();
        System.Console.Write("    ");
        for (int i = 0; i < magas.Length; i++)
        {
            Console.Write( i % 10 );
        }
    }

    static void SzarazAtlag() {
        int osszeg = 0;
        int darab = 0;
        for (var i = 0; i < magas.Length; i++)
        {
            if (magas[i]>0)
            {
                osszeg += magas[i];
                darab++;
            }
        }
        double atlag = osszeg / (double)darab;
        System.Console.WriteLine($"Szárazföldek átlaga: {atlag:f1}");
    }

    static void TengerekAtlaga() {
        int eleje = 0,vege;
        int hossz = 0;
        int darab = 0;
        for (var i = 0; i < magas.Length; i++)
        {
            if (magas[i] == 0 && magas[i-1] > 0)
            {
                eleje = i;
            }
            if (magas[i]>0 && magas[i-1] ==0)
            {
                vege = i-1;
                hossz += vege-eleje+1;
                darab++;
            }
        }
        if (magas[magas.Length-1]==0)
        {
            vege = magas.Length-1;
            hossz += vege-eleje+1;
            darab++;
        }
        if (darab>0)
        {
            double atlag = hossz / (double)darab;
        System.Console.WriteLine($"Tengerek hosszának átlaga: {atlag:f1}");
        }
        else
        {
            System.Console.WriteLine("Nem volt tenger");
        }
    }

    static void Main() {
        General();
        Feliratok();
        Kirajzol();
        Feliratok();
        SzarazAtlag();
    }
} // end class
