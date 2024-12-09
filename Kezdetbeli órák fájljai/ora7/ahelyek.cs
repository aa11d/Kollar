using System;

class szoveg1 {
    static void Main(){
        System.Console.Write("szöveg: ");
        string szoveg = Console.ReadLine();
        
        System.Console.Write("A betűk helye a szövegben: ");
        for (int i = 0; i < szoveg.Length; i++)
        {
            if (szoveg[i]=='a' || szoveg[i]=='A'){
                System.Console.Write(i+1);
            }
        }
    }
}