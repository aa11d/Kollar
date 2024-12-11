using System;

class Megoldas
{
    static void Main()
    {

        string input = Console.ReadLine();

        for (int i = 0; i < input.Length-1; i++)
        {
            switch (input[i])
            {
                case '1':
                System.Console.Write(input[i]);
                break;
                
                case '2':
                System.Console.Write(input[i]);
                break;
                
                case '3':
                System.Console.Write(input[i]);
                break;

                case '4':
                System.Console.Write(input[i]);
                break;

                case '5':
                System.Console.Write(input[i]);
                break;

                case '6':
                System.Console.Write(input[i]);
                break;

                case '7':
                System.Console.Write(input[i]);
                break;

                case '8':
                System.Console.Write(input[i]);
                break;

                case '9':
                System.Console.Write(input[i]);
                break;

                case '0':
                System.Console.Write(input[i]);
                break;

                default:
                break;
            }
            if (input[i+1] == ' ')
            {
                System.Console.Write(' ');
            }
            
        }

    }
}