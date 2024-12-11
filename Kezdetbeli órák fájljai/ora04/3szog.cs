System.Console.WriteLine("Kérem a 3szög paramétereit:");

System.Console.WriteLine("Első oldala:");
double A = double.Parse(Console.Readline());
System.Console.WriteLine("Második oldala:");
double B = double.Parse(Console.Readline());
System.Console.WriteLine("Harmadik oldala:");
double C = double.Parse(Console.Readline());

double K = A + B + C;
double T = Math.Sqrt((K/2)*((K/2)-A)*((K/2)-B)*((K/2)-C));
double R = (2*T)/K;

System.Console.WriteLine($"Területe: {T}");
System.Console.WriteLine($"Kerülete: {K}");
System.Console.WriteLine($"Rbe: {R}");