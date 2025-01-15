using System;

class Vera{

// pálya mérete és lépések száma
    static int l = 25;
    static int k = 25;
    static int steps = 20;
    static string[,] palya = new string[k, l];

//random generálás
    static Random rnd = new Random();

//Első lépés legenerálása
    static void generate(){
        int NChance = 10;
        int RChance = 90;

        for (int x = 0; x < palya.GetLength(0); x++)
        {
            for (int y = 0; y < palya.GetLength(1); y++)
            {
                int spawn = rnd.Next(100);
                if (spawn <= NChance && palya[x, y] == null)
                {
                    palya[x, y] = "N";
                }
                else if (spawn >= RChance && palya[x, y] == null)
                {
                    palya[x, y] = "R";
                }
            }
        }
    }

//Pálya kiíratása
    static void draw(){
        for(int y = 0; y < palya.GetLength(1); y++){
            for(int x = 0; x < palya.GetLength(0); x++){
                if (palya[x, y] == null)
                {
                    System.Console.Write("#");
                }
                else {
                    Console.Write(palya[x, y]);
                }
            }
            Console.WriteLine();
        }
        System.Console.WriteLine();
        for (int i = 0; i < k; i++)
        {
            System.Console.Write("#");
        }
        System.Console.WriteLine();
    }

//Mozgás
    static void move(){

    }

//szomszédok ellenőrzése
static int[,] neigh(){
    int[,] neighborCount = new int[k, l];

    for (int x = 0; x < k; x++)
    {
        for (int y = 0; y < l; y++)
        {
            int count = 0;
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0) continue; // Skip the cell itself

                    int nx = x + dx;
                    int ny = y + dy;

                    if (nx >= 0 && nx < k && ny >= 0 && ny < l && palya[nx, ny] != null)
                    {
                        count++;
                    }
                }
            }
            neighborCount[x, y] = count;
        }
    }

    return neighborCount;
}

    static void Main(){
        generate();
            for (int s = 0; s < steps; s++)
            {
                move();
                draw();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }