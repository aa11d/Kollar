String be1;
    Console.Write("Kérem az 1 oldalt: ");
    be1 = Console.ReadLine();
    int a = int.Parse(be1);
String be2;
    Console.Write("Kérem a 2dik oldalt: ");
    be2 = Console.ReadLine();
    int b = int.Parse(be2);
String be3;
    Console.Write("Kérem a 3dik oldalt")
    be3 = Console.ReadLine();
    int c = int.Parse(be3);

int legn;
int masd;
int harm;

if (a >= b && a >= c){
    legn = a;
    masd = b;
    harm = c;
}
else if(b >= a && b >= c){
    legn = b;
    masd = a;
    harm = c;
}
else{
    legn = c;
    masd = a;
    harm = b;
}