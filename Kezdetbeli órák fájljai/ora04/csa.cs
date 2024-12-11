System.Console.WriteLine("Szám:");
int szam = int.Parse(Console.ReadLine());
System.Console.WriteLine("Számrendszer:");
int Tipus = int.Parse(Console.ReadLine());

int ki = 0;



while (szam != 0){
    ki += (szam*Tipus);
    ki*=10
    szam = szam*Tipus;
}

System.Console.WriteLine(ki);