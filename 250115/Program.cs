using System;

class Vera{

// pálya mérete és lépések száma
    static int l = 25;
    static int k = 25;
    static int steps = 20;
    static string[,] palya = new string[l, k];

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
                    palya[x, y] = "9";
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
        int randomX = rnd.Next(palya.GetLength(1));
        int randomY = rnd.Next(palya.GetLength(0));
        while (palya[randomX, randomY] == null)
        {
            randomX = rnd.Next(palya.GetLength(1));
            randomY = rnd.Next(palya.GetLength(0));
        }
        if (palya[randomX, randomY] == "N")
        {
            int xMove = Math.Clamp(rnd.Next(-1, 1) + randomX, 0, l-1);
            int yMove = Math.Clamp(rnd.Next(-1, 1) + randomX, 0, k-1);

            palya[randomX, randomY] = null;
            palya[randomX, randomY] = "N";

            if (rnd.Next(100)<20 && VanSzomszed("N", randomX, randomY).Item1)
            {
                xMove = Math.Clamp(rnd.Next(-1, 1) + randomX, 0, l-1);
                yMove = Math.Clamp(rnd.Next(-1, 1) + randomX, 0, k-1);
                palya[randomX,randomY] = "N";
            }
        }
        else if (int.TryParse(palya[randomX, randomY], out int result))
        {
            int xMove = Math.Clamp(rnd.Next(-1, 1) + randomX, 0, l-1);
            int yMove = Math.Clamp(rnd.Next(-1, 1) + randomX, 0, k-1);
            palya[randomX, randomY] = null;
            palya[xMove, yMove] = (result - 1).ToString();

            if (rnd.Next(100)<20 && VanSzomszed("N", randomX, randomY).Item1)
            {
                int eatX = VanSzomszed("N", randomX, randomY).Item2;
                int eatY = VanSzomszed("N", randomX, randomY).Item3;

                palya[eatX, eatY] = "9";
                palya[randomX, randomY] = null;
            }
            if (result == 0)
            {
                
            }
        }
    }

    static (bool,int,int) VanSzomszed(string type, int randomX, int randomY){
        int neighborCount = 0;
        int holX = 0;
        int holY = 0;
        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                if (dx!=0 && dy!=0)
                {
                    if (0 <= randomX + dx && randomX + dx < palya.GetLength(0) &&
                    0 <= randomY + dy && randomY + dy < palya.GetLength(1))
                        {
                            if (palya[randomX + dx, randomY + dy] == type)
                            {
                                neighborCount++;
                                holX = randomX + dx;
                                holY = randomY + dy;
                            }
                        }
                }
            }
        }
        return (neighborCount>1,holX, holY);
    }

//szomszédok ellenőrzése
    static int neigh(){
        return 0;
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