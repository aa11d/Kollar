System.Console.WriteLine("Dátum1 nap:");
int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("Dátum2 hó:");
int A2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Dátum2 nap:");
int B = int.Parse(Console.ReadLine());
System.Console.WriteLine("Dátum2 hó:");
int B2 = int.Parse(Console.ReadLine());


string result1 = A.ToString() + A2.ToString();
int numberResult1 = Convert.ToInt32(result1);

string result2 = B.ToString() + B2.ToString();
int numberResult2 = Convert.ToInt32(result2);

/*
if (numberResult1 > numberResult2){
    bool x = true
}
if (numberResult1 < numberResult2){
    x = false
    }
*/
int napok (A2 - B2) * 30 + (A - B);

System.Console.WriteLine("${napok} napok telt el");