using System;

class Megoldas
{
    static void ABetus()
    {

        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();

        for (int i = 0; i < szoveg.Length; i++)
        {
            if (szoveg[i]== 'a' || szoveg[i]== 'A')
            {
                System.Console.Write((i+1)+" ");
            }
        }
        System.Console.WriteLine();
    }

    static void Szavak()
    {
        System.Console.WriteLine("A szöveg: ");
        string sz = Console.ReadLine();
        int szavakszama = 0;
        string szTrim = sz.Trim(' ');
        int holTartunk = szTrim.IndexOf(' ')
        if (holTartunk > 0)
        {
            while (holTartunk>0)
            {
                szavakszama++;
                while (holTartunk < szTrim.Length && szTrim[holTartunk] == ' ')
                {
                holTartunk++;
                }
                holTartunk = szTrim.IndexOf(' ',holTartunk);
            }
            
        }
        else
        {
            if (szTrim.Length>0)
            {
                szavakszama = 1;
            }
        }
        System.Console.WriteLine($"Szavak száma: {szavakszama}");
    }

    static void Nevelok()
    {
        string[] darabok;
        System.Console.Write("Szöveg: ");
        string sz = Console.ReadLine();
        darabok = sz.Split(' ');
        for (int i = 0; i < darabok.Length; i++)
        {
            System.Console.WriteLine(darabok[i],"Sikítás");
        }
    }

    static void aazAAZ()
    {
        string[] darabok;
        System.Console.Write("Szöveg: ");
        string sz = Console.ReadLine();
        darabok = sz.Split(' ');
        int hatnevelok = 0;
        for (int i = 0; i < darabok.Length; i++)
        {
            if (darabok[i]='a' || darabok[i]='az' || darabok[i]='A' || darabok[i]='Az')
            {
                hatnevelok++;
            }
        }
        System.Console.WriteLine("Hat. név. száma: "+hatnevelok);
    }

    static void szabalyok()
    {
        string[] darabok;
        System.Console.Write("Szöveg: ");
        string sz = Console.ReadLine();
        char[] elvalaszto = {' ','.',',','!','?',';'};
        darabok = sz.Split(elvalaszto);
        int hatnevelok = 0;
        for (int i = 0; i < darabok.Length; i++)
        {
            if (darabok[i]='a' || darabok[i]='az' || darabok[i]='A' || darabok[i]='Az')
            {
                hatnevelok++;
            }
        }
        System.Console.WriteLine("Hat. név. száma: "+hatnevelok);
    }
}