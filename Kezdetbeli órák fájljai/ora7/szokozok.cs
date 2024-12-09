using System;

class szoveg1 {
    static void Main(){
        System.Console.Write("szöveg: ");
        string szoveg = Console.ReadLine();
        int szokoz = 0;

        for (int i = 0; i < szoveg.Length; i++)
        {
            if (szoveg[i]==' '){
                szokoz++;
            }
        }
        System.Console.WriteLine($"Szóközök: {szokoz}");
    }
}