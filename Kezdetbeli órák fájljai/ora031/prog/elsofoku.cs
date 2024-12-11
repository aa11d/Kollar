// egyenlet kiírása:
//Console.WriteLine("Az egyenlet a következő: A*X + B = C");

// változók létre hozása:
float a = 0;
float b = 0;
float c = 0;
double x = 0;
double x2 = 0;
int type = 0;


while (a != 0){
    // bekérés
    Console.WriteLine("Milyen az egyenlet? Elsőfokú(1) Másodfokú(2)");
    type = int.Parse(Console.ReadLine());

    Console.WriteLine("Kérem az A értékét:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Kérem az B értékét:");
    b = float.Parse(Console.ReadLine());
    Console.WriteLine("Kérem az C értékét:");
    c = float.Parse(Console.ReadLine());


    // A ellenőrzése és elsőfokú egyenlet kiszámítása
    if (type == 1){
        if (a == 0) {
        Console.WriteLine("Az A értéke nem lehet 0.");
        }
        else {
            x = (c-b)/a;
            Console.WriteLine($"Az x értéke: {x}");
        }
    }


    // A ellenőrzése és másodfokú egyenlet kiszámítása
    if (type == 2){
        if (a == 0) {
            Console.WriteLine("Az A értéke nem lehet 0.");
        }
        else {
            if (((b*b)-4*a*c) < 0){
                Console.WriteLine("Nincs valós gyöke, így nincs eredménye.");
            }
            else{
                x = (b*-1)+Math.Sqrt((b*b)-4*a*c)/2*a;
                x2 = (b*-1)-Math.Sqrt((b*b)-4*a*c)/2*a;
                Console.WriteLine(x);
                Console.WriteLine(x2);
            }
            
        }
    }
}
