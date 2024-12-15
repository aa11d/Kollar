using System;
using System.Linq.Expressions;

class Program
{

    const int utHossz = 100;
    static int[] magas = new int[utHossz];

    static void Main(string[] args)
    {
        Generalas();
        Feliratok();
        Kirajzol();
        Feliratok();
        System.Console.WriteLine();
        Tengerszint();
        System.Console.WriteLine();
        TengerszintExtra();
    }

    static void Generalas(){
        Random rnd = new Random();
        magas[0] = rnd.Next(10,30);
        for (int i = 1; i < magas.Length; i++)
        {
            magas[i] = magas[i-1] + rnd.Next(11) - 5;
        }
        for (int j = 0; j < magas.Length; j++)
        {
            if(magas[j]<0){
                magas[j]=0;
            }
        }
    }
    static void Kirajzol(){
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
    static void Feliratok(){
        System.Console.Write("    ");
        for (int i = 0; i < magas.Length; i++)
        {
            if (i % 10 == 0)
            {
                System.Console.Write(i/10);
            }
            else
            {
                System.Console.Write(' ');
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("     ");
        for (int i = 0; i < magas.Length; i++)
        {
            System.Console.Write(i%10);
        }
    }
    static void Tengerszint(){
        for (int i = 0; i < magas.Length; i++)
        {
            if (magas[i] == 0)
            {
                System.Console.Write(i+1 + " ");
            }
        }
    }
    static void TengerszintExtra()
    {
        int elso = -1;
        for (int i = 0; i < magas.Length; i++)
        {
            if (magas[i] == 0 && elso == -1)
            {
                elso = i;
            }
            else if (magas[i] > 0 && elso != -1)
            {
                System.Console.Write($"{elso}-{i - 1} ");
                elso = -1;
            }
        }

        // Handle the case when the sequence of zeros ends at the last element
        if (elso != -1)
        {
            System.Console.Write($"{elso}-{magas.Length - 1} ");
        }

        System.Console.WriteLine();
    }

    static void Legek()
    {
        int legnagyobb = magas.Max();
        int legkisebb = magas.Min();
        int indexN = -1;
        int indexK = -1;
        
        for (int i = 0; i < magas.Length; i++)
        {
            if (magas[i] == legnagyobb && indexN == -1)
            {
                indexN = i;
            }
            if (magas[i] == legkisebb && indexK == -1)
            {
                indexK = i;
            }
            if (indexN!= -1 && indexK!= -1)
            {
                break;
            }
        }
        System.Console.WriteLine($"A legnagyobb és a legkisebb közötti távolság: {Math.Abs(indexN - indexK)}");
    }
}