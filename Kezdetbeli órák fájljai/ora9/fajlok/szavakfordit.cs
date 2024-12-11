using System;

class Megoldas
{
    static void Main()
    {
        System.Console.WriteLine("Szöveg: ");

        string input = Console.ReadLine();


        for (int i = 0; i < input.Length; i++)
        {
            
            if ( input[i] == ' ')
            {
                for (int j = i - 1; j >= 0 && input[j] != ' '; j--)
                {
                    System.Console.Write(input[j]);
                }
                System.Console.Write(' ');
            }
            
        }

    }
}