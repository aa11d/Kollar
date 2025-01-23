using System;

class Program
{
    static string[,] szoveg = new string[30, 30];
    static char[] karakterek = {' ','!','?',',',':',';', '-', '_', '[', ']', '{', '}', '<', '>', '/', '\\', '|', '@', '#', '$', '%', '^', '&', '*', '('};
    static string[] szavak;
    static Random rand = new Random();

    static void Main()
    {
        System.Console.WriteLine("Mondat:");
        string input = Console.ReadLine();
        System.Console.WriteLine();
        szavak = input.Split(karakterek);

        elso();
        Draw();
    }

    static void elso()
    {
        if (szavak.Length == 0) return;

        char[] karak = szavak[0].ToCharArray();
        int randY = rand.Next(0, 30);
        int len = karak.Length;
        int randX = rand.Next(0, 30 - len + 1);

        for (int i = 0; i < len; i++)
        {
            szoveg[randY, randX + i] = karak[i].ToString();
        }
    }

    static void Draw()
    {
        for (int y = 0; y < szoveg.GetLength(0); y++)
        {
            for (int x = 0; x < szoveg.GetLength(1); x++)
            {
                System.Console.Write(szoveg[y, x] ?? " ");
            }
            System.Console.WriteLine();
        }
    }
}
