using System;

class Hoeses
{

    const int N = 30;
    const int M = 50;
    
    static string[,] map = new string[N, M];
    static void Main(string[] args)
    {
        Gen();
        Draw();
    }

    static void Gen(){
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                map[x, y] = "*";
                if (y == N-1)
                {
                    map[x, y] = "H";
                }
            }
        }
    }

    static void Draw(){
        for (int y = 0; y < map.GetLength(1); y++)
        {
            for (int x = 0; x < map.GetLength(0); x++)
            {
                Console.Write(map[x, y]);
            }
            Console.WriteLine();
        }
    }
}