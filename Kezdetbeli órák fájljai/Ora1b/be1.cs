System.Console.WriteLine("Kérem a számot:");
int a = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Kérem a számot:");
int b = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Kérem a számot:");
int c = int.Parse(System.Console.ReadLine());

if (a > b && b > c) {
    System.Console.WriteLine($"{a}, {b}, {c}");
}
else if (b > a && a > c) {
    System.Console.WriteLine($"{b}, {a}, {c}");
}
else if (c > a && a > b) {
    System.Console.WriteLine($"{c}, {a}, {b}");
}
else if (a > c && c > b) {
    System.Console.WriteLine($"{a}, {c}, {b}");
}
else if (b > c && c > a) {
    System.Console.WriteLine($"{b}, {c}, {a}");
}
else if (c > b && b > a) {
    System.Console.WriteLine($"{c}, {b}, {a}");
}