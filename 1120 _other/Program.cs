using System;
using System.Runtime.ConstrainedExecution;

class Megoldas
{
    const int utHossz = 100;
    static int[] magas = new int[utHossz];


    public static void Main()
    {
        Generalas();
        Feliratok();
        Kiiras();
        Feliratok();
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine();
        }
        Tengerszint();
        TengerszintExtra();
        legek();
    }

    static void Generalas()
    {
        Random rnd = new Random();
        magas[0] = rnd.Next(10,30);
        for (int i = 1; i < magas.Length; i++)
        {
            magas[i] = magas[i-1] + rnd.Next(11) - 5;
        }
        for (int j = 0; j < magas.Length; j++)
        {
            if (magas[j] < 0)
            {
                magas[j] = 0;
            }
        }
    }

    static void Kiiras()
    {
        int Maxmagas = magas.Max();
        for (int j = Maxmagas+2; j >= 0; j--)
        {
            System.Console.Write($"{j,3} ");
            for (int i = 0; i < magas.Length; i++)
            {
                if (j > magas[i])
                {
                    System.Console.Write(' ');
                }
                else
                {
                    System.Console.Write('\u2588');
                }
            }
            System.Console.WriteLine(" "+j);
        }
    }

    static void Feliratok()
    {
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
        for (int j = 0; j < magas.Length; j++)
        {                
            System.Console.Write(j%10);
        }
    }

    static void Tengerszint()
    {

    }

    static void TengerszintExtra()
    {
        int elso = 0;
        int utolso = 0;
        for (int i = 0; i < magas.Length; i++)
        {
            if (magas[i] == 0)
            {
                if (i == 0)
                {
                    if (magas[i+1] != 0)
                    {
                        utolso = i;
                        System.Console.Write(elso +"-"+utolso+" ");
                    }
                    if (magas[i] == 0)
                    {
                        elso = i;
                    }
                }
                else
                {
                    if (i == magas.Length-1)
                    {
                        if (magas[i] == 0)
                        {
                            utolso = i;
                            System.Console.Write(elso +"-"+utolso+" ");
                        }
                        if (magas[i-1] != 0)
                        {
                            elso = i;
                        }
                    }
                    else
                    {
                        if (magas[i-1] != 0)
                        {
                            elso = i;
                        }
                        if (magas[i+1] != 0)
                        {
                            utolso = i;
                            System.Console.Write(elso +"-"+utolso+" ");
                        }
                        
                    }
                }
                
                
            }
        }        
    }

    static void legek()
    {
        int legmagasabb = 0;
        int legalacsonyabb = 0;
        for (int i = 0; i < magas.Length; i++)
        {
            if (i > legmagasabb)
            {
                legmagasabb = i;
            }
            if (i < legalacsonyabb)
            {
                legalacsonyabb = i;
            }
        }
        System.Console.WriteLine(legalacsonyabb-legmagasabb);
    }
}
