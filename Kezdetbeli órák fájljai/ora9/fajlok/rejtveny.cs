using System;

class Megoldas
{
    static void Main()
    {

        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'a':
                    System.Console.Write("");
                    break;

                case 'e':
                    System.Console.Write("");
                    break;

                case 'u':
                    System.Console.Write("");
                    break;

                case 'i':
                    System.Console.Write("");
                    break;

                case 'o':
                    System.Console.Write("");
                    break;
                default:
                    System.Console.Write(input[i]);
                    break;

            }

        }

    }
}