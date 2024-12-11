int[] szamok = new int[20];
Random ra = new Random();

for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = ra.Next(100, 999);
}

int paratlanIndex = 0;

for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] % 2 != 0)
    {
        int temp = szamok[i];
        szamok[i] = szamok[paratlanIndex];
        szamok[paratlanIndex] = temp;
        paratlanIndex++;
    }
}

Console.WriteLine("Rendezett számok (páratlanok az elején):");
foreach (int szam in szamok)
{
    Console.WriteLine(szam);
}