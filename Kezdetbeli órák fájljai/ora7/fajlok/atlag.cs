int[] szamok = new int[20];
Random ra = new Random();
int gond = 0;
for (int i = 0; i < szamok.Length; i++)
{
    gond = ra.Next(100,999);
    szamok[i] = gond;
}
int ossz = 0;
for (int i = 0; i < szamok.Length; i++)
{
    ossz += szamok[i];
}

int atlag = ossz / szamok.Length;

System.Console.WriteLine($"Átlag: {atlag}");
//System.Console.WriteLine($"Számok: \n{szamok}");