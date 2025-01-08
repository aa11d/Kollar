using System;

class TobbDimTomb {
    static void Main() {
        KetDimTomb();
    }
    static Random rnd = new Random();

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
}