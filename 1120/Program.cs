using System;

class Program()
{

    static void Main()
    {
        //Uno();
        //Dos();
        Tres();
    }
    static void Uno()
    {
        
    }

    static void Dos()
    {
        System.Console.Write("Szöveg: ");
        var input = Console.ReadLine();
        char[] lista = { ' ', ',', '.', '-', '!', '?' };
        string[] szavak = input.Split(' ');
        var hany = 0;
        foreach (var item in szavak)
        {
            if (hany%2==0)
            {
                for (int i = item.Length-1; i >= 0; i--)
                {
                    System.Console.Write(item[i]);
                }
                System.Console.Write(" ");
            }
            hany++;
        }
    }

    static void Tres()
    {
        Random rnd = new Random();

        System.Console.Write("Szöveg: ");
        var input = Console.ReadLine();
        char[] lista = { ' ', ',', '.', '-', '!', '?' };
        string[] szavak = input.Split(' ');
        foreach (var item in szavak)
        {
            int elhagy = rnd(0,item.Length);
            for (int i = 0; i < item.Length; i++)
            {
                if (elhagy != i)
                {
                    System.Console.Write(item[i]);
                }
                if (item.Length >= 5)
                {
                    
                }
            }
            System.Console.Write(" ");
        }
    }
}