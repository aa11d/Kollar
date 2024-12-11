using System;

double R = 32;

double ma = R*2;
double sz = R*4;

double kore = 2 * ma * Math.PI;
double R2 = (kore/(2*Math.PI));

System.Console.WriteLine($"Magassága: {ma}, szélessége: {sz}, köré írható kör kerülete: {kore}, átmérője: {R2}");