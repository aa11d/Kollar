using System;

class Hoeses
{

    const int N = 30;
    const int M = 50;

    static Random rnd = new Random();
    
    static string[,] map = new string[N, M];
    static void Main()
    {
        Console.SetWindowSize(M + 2, N + 2);
        Console.CursorVisible = false;
        Gen();
        while (true)
        {
            fall();
            Draw();
            System.Threading.Thread.Sleep(500);
        }
    }





    static void Gen()
    {
        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                if (y == map.GetLength(1) - 1)
                {
                    map[x, y] = "*";
                }
                else
                {
                    map[x, y] = " ";
                }
            }
        }
    }
    static void Draw()
    {
        Console.SetCursorPosition(0, 0);
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Console.Write(map[x, y]);
            }
            Console.WriteLine();
        }
    }


    static void fall()
    {
        double spawn_rate = 0.2;

        for (int x = 0; x < map.GetLength(0); x++)
        {
            if (rnd.NextDouble() < spawn_rate && map[x, 0] == " ")
            {
                map[x, 0] = "*";
            }
        }

        for (int y = map.GetLength(1) - 2; y >= 0; y--)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                if (map[x, y] == "*")
                {
                    int newY = y;
                    int newX = x;

                    if (map[x, y + 1] == " ")
                    {
                        newY = y + 1;
                    }

                    else if (x > 0 && map[x - 1, y + 1] == " ")
                    {
                        newY = y + 1;
                        newX = x - 1;
                    }
                    else if (x < map.GetLength(0) - 1 && map[x + 1, y + 1] == " ")
                    {
                        newY = y + 1;
                        newX = x + 1;
                    }

                    else if (x > 0 && map[x - 1, y] == " ")
                    {
                        newX = x - 1;
                    }
                    else if (x < map.GetLength(0) - 1 && map[x + 1, y] == " ")
                    {
                        newX = x + 1;
                    }

                    if (newX != x || newY != y)
                    {
                        map[newX, newY] = "*";
                        map[x, y] = " ";
                    }
                }
            }
        }
    }

}