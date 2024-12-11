Random ra = new Random();
int gond = ra.Next(1,100+1);

System.Console.WriteLine("Tipped:");
int tipp = int.Parse(Console.ReadLine());
/* while (tipp != gond)
{
    if (tipp < gond)
        System.Console.WriteLine("Nagyobbra gondoltam");
    
    else
    
        System.Console.WriteLine("Kisebbre gondoltam");
    System.Console.WriteLine("Tipped:");
    tipp = int.Parse(Console.ReadLine());
}
*/
do
{
    if (tipp < gond)
        System.Console.WriteLine("Nagyobbra gondoltam");
    else
        System.Console.WriteLine("Kisebbre gondoltam");
    System.Console.WriteLine("Tipped:");
    tipp = int.Parse(Console.ReadLine());
} while (tipp != gond);