using System;

class Megoldas
{
    static void Main()
    {
/*
        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();

        char[] karakter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        int ossz = 0;
        for (int i = 0; i < szoveg.Length; i++)
        {
            for (int j = 0; j < karakter.Length; j++)
            {
                if (karakter[j] == szoveg[i])
                {
                    ossz++;
                }
            }
        }
        System.Console.WriteLine("Darab: "+ossz);
*/
/*
        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();
        string test = szoveg.ToLower();
        char[] karakter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        bool tf = false;
        for (int i = 0; i < test.Length; i++)
        {
            for (int j = 0; j < karakter.Length; j++)
            {
                if (karakter[j] != test[i])
                {
                    tf = false;
                }
                else
                {
                    System.Console.Write("_");
                    tf = true;
                    break;
                }
            }
            if (tf == false)
            {
                System.Console.Write(szoveg[i]);
            }
*/
/*
        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();
        string test = szoveg.ToLower();
        char[] karakter = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        int darab = 0;
        for (int i = 0; i < test.Length; i++)
        {
            for (int j = 0; j < karakter.Length; j++)
            {
                if (karakter[j] == test[i])
                {
                    darab++;
                }
            }
        }
        System.Console.WriteLine("Darab: "+darab);
*/

        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();
        string test = szoveg;
        char[] karakter = {'j','J'};

        bool tf = false;
        int darab = 0;
        for (int i = 0; i < test.Length; i++)
        {
            for (int j = 0; j < karakter.Length; j++)
            {
                if (karakter[j] == test[i])
                {
                    darab++;
                }
                if (tf)
                {
                    szoveg = "L";
                    szoveg += test[i];
                    if (szoveg == "Ly")
                    {
                        darab++;
                        tf = false;
                    }
                    else
                    {
                        tf = false;
                    }
                }
                if (test[i] == 'L' || test[i] == 'l')
                {
                    tf = true;
                }

            }
        }
        System.Console.WriteLine("Darab "+darab);

/*
        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();

        for (int i = 0; i < szoveg.Length; i++)
        {
            if (szoveg[i] >= '0' && '9'>=szoveg[i])
            {
                System.Console.Write(" ");
            }
            else
            {
                System.Console.Write(szoveg[i]);
            }
        }  
*/
/*
        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();
        string test = szoveg.ToLower();

        string pr = "";
        for (int i = 0; i < test.Length; i++)
        {
            if (test[i]<='z' && test[i]>= 'a' || test[i] != ' ')
            {
                pr += szoveg[i];
            }
            if (test[i] == ' ' || test.Length == i+1)
            {
                System.Console.WriteLine(pr);
                pr = "";
            }
        }
*/
/*
        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();
        string test = szoveg.ToLower();

        string pr = "";
        for (int i = 0; i < test.Length; i++)
        {
            if (test[i]<='z' && test[i]>= 'a' || test[i] != ' ')
            {
                pr += szoveg[i];
            }
            if (test[i] == ' ' || test.Length == i+1)
            {
                pr = pr.Remove(pr.Length-1);
                System.Console.Write(pr+" ");
                pr = "";
            }
        }
*/

        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();

        string monog = "";
        monog += szoveg[0];
        for (int i = 1; i < szoveg.Length; i++)
        {
            if (szoveg[i-1] == ' ')
            {
                monog += szoveg[i];

            }
        }
        System.Console.WriteLine("Monogram: "+monog);

/*
        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();

        for (int i = 0; i < szoveg.Length; i++)
        {
            if (szoveg[i] >= '0' && '9'>=szoveg[i])
            {
                System.Console.Write(szoveg[i]+" ");
            }
        }  
*/

        System.Console.Write("Szöveg: ");
        string szoveg = Console.ReadLine();
        string test = szoveg.ToLower();

        int pr = 0;
        for (int i = 0; i < test.Length; i++)
        {
            if (test[i] != ' ')
            {
                pr++;
            }
            if (test[i] == ' ' || test.Length == i+1)
            {
                System.Console.Write(pr+" ");
                pr = 0;
            }
        }
    }
}