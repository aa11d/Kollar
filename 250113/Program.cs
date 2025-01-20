using System;
using System.Runtime.CompilerServices;

class Conway {
    static bool[,] field = new bool[40, 40];

    static void Draw() {
        for (int y = 0; y < field.GetLength(1); y++)
        {
            Console.SetCursorPosition(0,y);
            for(int x = 0; x < field.GetLength(0); x++)
            {
                if (field[x, y])
                {
                    Console.Write("■");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }

    static int Szomszed(int x, int y){
        int szomszed = 0;
        for (int dx = -1; dx <= 1; dx++)
        {
            for (int dy = -1; dy <= 1; dy++)
            {
                if (dx!=0 || dy!=0)
                {
                    if (0 <= x+dx && x+dx < field.GetLength(0) &&
                    0 <= y+dy && y+dy < field.GetLength(1))
                    {
                        if (field[x + dx, y + dy])
                        {
                            szomszed++;
                        }
                    }
                }
            }
        }
        return szomszed;
    }
    static void Main() {
        Console.SetWindowSize(82,27);
        const double bio = 0.2;
        Random rnd = new Random();
        for (int x = 0; x < field.GetLength(0); x++)
        {
            for (int y = 0; y < field.GetLength(1); y++)
            {
                if (rnd.NextDouble() < bio)
                {
                    field[x, y] = true;
                }
                else
                {
                    field[x, y] = false;
                }
            }
        }

        for (int nSim = 0; nSim < 10000; nSim++)
        {
            Draw();
            bool[,] nextField = new bool[field.GetLength(0), field.GetLength(1)];
        }
    }
}
