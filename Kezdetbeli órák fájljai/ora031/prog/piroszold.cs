Console.WriteLine("Kérem a Zöld golyók számát:");
int z = int.Parse(Console.ReadLine());
Console.WriteLine("Kérem a Piros golyók számát:");
int p = int.Parse(Console.ReadLine());

int csop = (p + z) / 5;
int ar

if (p >= csop){
    int kk = p - csop;
    ar = kk * 24 + z * 28;
}else{
    int kz = csop - p;
    ar = (z - kz) * 28;
}
System.Console.WriteLine($"A legolcsóbbik ár: {ar}");