using System;

class Megoldas
{
    static void Main()
    {

        char elozo = ' ';
        string input = ' ' + Console.ReadLine() + ' ';

        for (int i = 1; i < input.Length - 1; i++)
        {
            if (input[i - 1] == ' ' || input[i + 1] == ' ')
            {
                elozo = input[i];
                System.Console.Write(elozo.ToString().ToUpper());
            }
            else
            {
                System.Console.Write(input[i]);
            }

        }

    }
}