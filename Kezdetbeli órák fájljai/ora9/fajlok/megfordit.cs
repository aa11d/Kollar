using System;

class Megoldas
{
    static void Main()
    {

        string input = Console.ReadLine();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            System.Console.Write(input[i]);
        }
        System.Console.WriteLine();

    }
}