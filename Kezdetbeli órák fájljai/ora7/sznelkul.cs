using System;

class szoveg1
{
    static void Main()
    {
        Console.WriteLine("Enter String");
        string str = Console.ReadLine();
        bool elozo = false;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' && elozo == false)
            {
                elozo = true;
                System.Console.Write(str[i]);
            }
            else if(str[i] != ' '){
                System.Console.Write(str[i]);
                elozo = false;
            }
        }
        Console.WriteLine();
    }
}