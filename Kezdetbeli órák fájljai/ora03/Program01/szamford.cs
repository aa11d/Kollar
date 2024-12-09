using System;

System.Console.WriteLine("Pozitív szám:");
int be1 = int.Parse(Console.ReadLine());

int left = be1;
int rev = 0;
while(Convert.ToBoolean(left))
{
   int r = left % 10;   
   rev = rev * 10 + r;
   left = left / 10;
}



Console.WriteLine($"Eredeti: {ki1}");
Console.WriteLine($"Fordított: {ki2}");