using System;

System.Console.WriteLine("Kerülete:");
double K = double.Parse(Console.ReadLine());

double R = (K/(2*Math.PI));
System.Console.WriteLine($"A kör sugara: {R}");

double B = Math.Sqrt(2)*R;
System.Console.WriteLine($"A körbe írt négyzet oldala: {B}");

double A = 2*R;
System.Console.WriteLine($"A köré írt negyzet oldala: {A}");