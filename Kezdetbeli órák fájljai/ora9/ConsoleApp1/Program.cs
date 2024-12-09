using System;
using System.Runtime.Serialization;

class Megoldas {
    static void Main(){
        /*
        for (int num = 9; num < 100; num++)
        {
            int num_u = num % 10;
            if (num_u != 0 && num % num_u != 0)
            {
                System.Console.Write(num+" ");
            }
        }
        */
        /*
        int darab = 9*10*8;
        System.Console.WriteLine(darab);
        */
        /*
        for (int i = 9; i < 99; i++)
        {
            int num1 = i % 10;
            int num2 = i % 100;
            //System.Console.WriteLine(num2/10);

            if (num1 + (num2/10) == 8)
            {
                System.Console.Write(i+" ");
            }
        }
        */
        /*
        System.Console.Write("Szám1: ");
        int szam1 = int.Parse(Console.ReadLine());
        System.Console.Write("Szám2: ");
        int szam2 = int.Parse(Console.ReadLine());
        
        if (szam1 == szam2)
        {
            System.Console.Write("Összeg: 0");
            return;
        }

        int nagyobb = szam2;
        int kisebb = szam1;
        if (szam1 > szam2){
            kisebb = szam2;
            nagyobb = szam1;
        }
        int osszeg = 0;
        for (int i = kisebb+1; i < nagyobb; i++)
        {
            osszeg += i;
        }

        System.Console.Write("Összeg: "+osszeg);
        */
        /*
        System.Console.Write("Szám1: ");
        int szam1 = int.Parse(Console.ReadLine());
        System.Console.Write("Szám2: ");
        int szam2 = int.Parse(Console.ReadLine());
        
        if (szam1 == szam2)
        {
            System.Console.Write("Összeg: 0");
            return;
        }

        int nagyobb = szam2;
        int kisebb = szam1;
        if (szam1 > szam2){
            kisebb = szam2;
            nagyobb = szam1;
        }
        int osszeg = 0;
        for (int i = kisebb+1; i < nagyobb; i++)
        {   
            if (i%2 == 0)
            {
                osszeg += i;
            }
            else if (i%2==1)
            {
                osszeg -= i;
            }
        }

        System.Console.Write("Összeg: "+osszeg);
        */
        /*
        System.Console.Write("Szám1: ");
        int szam1 = int.Parse(Console.ReadLine());
        System.Console.Write("Szám2: ");
        int szam2 = int.Parse(Console.ReadLine());

        int darab = 0;
        for (int i = szam1-1; i < szam2+1; i++)
        {
            if (i % 7 == 0)
            {
                darab++;
            }
        }
        System.Console.Write("Darab: "+darab);
        */
        /*
        System.Console.Write("Szám: ");
        int szam = int.Parse(Console.ReadLine());


        int darab = -1;
        for (int i = 199; i < 501; i++)
        {
            if (i % szam != 0)
            {
                darab+= 1;
            }
        }
        if (szam == 1)
        {
            darab++;
        }
        System.Console.Write("Darab: "+darab);
        */
        /*
        int osszeg = 0;
        for (int i = 10; i < 100; i++)
        {
            if (i % 9 == 0)
            {
                osszeg += i;
            }
        }
        System.Console.Write("Osszeg: "+osszeg);
        */
        /*
        int darab   = 0;
        for (int i = 100; i < 1500; i++)
        {
            if (i % 100 == 19)
            {
                darab++;
            }
        }
        System.Console.Write(darab);
        */

        System.Console.Write("Szám1: ");
        int szam1 = int.Parse(Console.ReadLine());
        System.Console.Write("Szám2: ");
        int szam2 = int.Parse(Console.ReadLine());
        
        for (int i = szam1; i < szam2+1; i++)
        {
            if (!((i%10 == 3 || i%10==9) && i%3!=0))
            {
                
            }
            else
            {
                System.Console.Write(i+" ");
            }
        }

    }
}