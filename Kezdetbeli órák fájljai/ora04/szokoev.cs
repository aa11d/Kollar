System.Console.WriteLine("Év:");
int A = int.Parse(Console.ReadLine());



if (A % 4 == 0 && (A % 100 == 0 && A % 400 == 0)) {
        System.Console.WriteLine("Szökőév");
    }
    else {
        System.Console.WriteLine("Nem Az");
    }

int 1nap = 0;
int 2nap = 0;

int check(int A);

for (int i = 1900; i <= 2100; i++)
{
    if (check(i) == 1){
        1nap++;
    }
    if (check(i) ==2){
        2nap++;
    }
}

System.Console.WriteLine($"Szökő éves napok: {1nap + 2nap}, melyből 1naposak: {1nap} és 2naposak: {2nap}");