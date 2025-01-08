using System;

class TobbDimTomb {
    static void Main() {
        //KetDimTomb();
        Amoba();
    }
    static Random rnd = new Random();
    static char[,] palya = new char[20, 20];
    static bool elozoX = false;

    static void KetDimTomb() {
        const int sorSz = 6;
        const int oszSz = 12;
        char[,] kart = new char[sorSz, oszSz];

        for (int sor = 0; sor < kart.GetLength(0); sor++)
        {
            for (int oszlop = 0; oszlop < kart.GetLength(1); oszlop++)
            {
                kart[sor, oszlop] = (char) ( (int)'A' + rnd.Next(0,26));
            }
        }

        for (int sor = 0; sor < kart.GetLength(0); sor++)
        {
            for (int oszlop = 0; oszlop < kart.GetLength(1); oszlop++)
            {
                System.Console.Write(kart[sor, oszlop]);
            }
            System.Console.WriteLine();
        }
    }

    static void Amoba() {
        for (int sor = 0; sor < palya.GetLength(0); sor++)
        {
            for (int oszlop = 0; oszlop < palya.GetLength(1); oszlop++)
            {
                palya[sor, oszlop] =' ';
            }
        }

        while (!VanOtos()) {
            PalyaKi();
            Lep();
            if (!VanOtos()) {

            }
        }
    }

    static bool VanOtos() {
        return false;
    }

    static void PalyaKi() {
        System.Console.Write(' ');
        for (int oszlop = 0; oszlop < palya.GetLength(1); oszlop++)
        {
            System.Console.Write(oszlop % 10);
        }
        System.Console.WriteLine();
        for (int sor = 0; sor < palya.GetLength(0); sor++)
        {
            System.Console.Write(sor % 10);
            for (int oszlop = 0; oszlop < palya.GetLength(1); oszlop++)
            {
               System.Console.Write(palya[sor, oszlop]); 
            }
            System.Console.WriteLine();
        }
    }
    static void Lep() {
        if (!elozoX)
        {
        System.Console.Write("X Jön, x: ");
        int inputX = int.Parse(Console.ReadLine());
        System.Console.Write("y: ");
        int inputY = int.Parse(Console.ReadLine());
            if (palya[inputX, inputY] == ' ')
            {
                palya[inputX, inputY] = 'X';
                elozoX = true;
            }
            else {
                System.Console.WriteLine("Foglalt terület! Próbálja újra.  (x: " + inputX + ", y: " + inputY + ")");
            }
        }
        else {
        System.Console.Write("O Jön, x: ");
        int inputX = int.Parse(Console.ReadLine());
        System.Console.Write("y: ");
        int inputY = int.Parse(Console.ReadLine());
        if (palya[inputX, inputY] == ' ')
        {
            palya[inputX, inputY] = 'O';
            elozoX = false;
        }
        else {
            System.Console.WriteLine("Foglalt terület! Próbálja újra.  (x: " + inputX + ", y: " + inputY + ")");
        }
        }
    }
}