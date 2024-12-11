System.Console.WriteLine("Km:");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("M:");
int B = int.Parse(Console.ReadLine());
System.Console.WriteLine("Y:");
int C = int.Parse(Console.ReadLine());

B = (B * 1760)
A = (A * 1000 / 0.9144)

double km = (B * 0.9144 * 1000) + (C * 0.9144 * 1000)

System.Console.WriteLine($"{Math.round(B+A,1)} yard");
System.Console.WriteLine($"{Math.round(km,1)} km");

