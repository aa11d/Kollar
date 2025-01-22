using System;

class Hoeses
{

    const int N = 30;
    const int M = 50;

    static Random rnd = new Random();
    
    static string[,] map = new string[N, M];
    static void Main()
    {
        Console.SetWindowSize(N+1,M+1);
        Gen();
        Draw();
        fall();
        Console.ReadLine();
    }

    static void Gen(){
        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                map[x,y] = " ";
                if (y == N-1)
                {
                    map[x,y] = "*";
                }
            }
        }
    }

    static void Draw(){
        for (int y = 0; y < map.GetLength(1); y++)
        {
            Console.SetCursorPosition(0,y);
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Console.Write(map[x, y]);
            }
            Console.WriteLine();
        }
    }

    static void fall(){
        double spawn_rate = 0.1;
        double spawn = rnd.NextDouble();
        int fall = rnd.Next(1,4);
        for (int i = 0; i < map.GetLength(1); i++)
        {
            if (spawn < spawn_rate)
            {
                map[0, i] = "*";
            }
            spawn = rnd.NextDouble();
        }
        Draw();

        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                if (fall == 1 && map[x-1, y-1] == " ")
                {
                    map[x,y] = " ";
                    map[x-1, y-1] = "*";
                }
                else if (fall == 2 && map[x, y-1] == " ")
                {
                    map[x,y] = " ";
                    map[x,y-1] = "*";
                }
                else if (fall == 3 && map[x-1, y] == " ")
                {
                    map[x,y] = " ";
                    map[x-1, y] = "*";
                }
            }
        }
    }
}