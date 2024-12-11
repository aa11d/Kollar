using System;

System.Console.WriteLine("Áru 1:");
int aru1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Áru 2:");
int aru2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Áru 3:");
int aru3 = int.Parse(Console.ReadLine());

double osszeg = aru1+aru2+aru3;
int minusz = 0;

if (osszeg > 20000){
    minusz = 15;
    osszeg = osszeg * 0.85;
    }
    else
    {
        if (osszeg > 10000){
        minusz = 10;
        osszeg = osszeg * 0.90;
        }
    }
System.Console.WriteLine($"Összesen {osszeg} Ft-ot kell fizetni, a kedvezmény: {minusz}%");

