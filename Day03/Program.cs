using System;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int[,] map =
            {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            }; //10 x 10 Array

            int playerX = 1;
            int playerY = 1;

            while (isRunning)
            {
                string key = Input();
                Process(key);
                Clear();
                Render(map, playerX, playerY);
            }
        }

        static string Input()
        {
            return Console.ReadLine();
        }

        static int Process(string key)
        {
            //여기는 처리 
            if ( key == "u")
            {

            }

            return 0;
        }

        static void Clear()
        {
            Console.Clear();
        }

        static void Render(int[,] _map, int playerX, int playerY)
        {
            for (int y = 0; y < 10; ++y)
            {
                for (int x = 0; x < 10; ++x)
                {
                    if (_map[y, x] == 1)
                    { //맵 데이터에 1이면 출력
                        Console.Write(_map[y, x]);
                    }
                    else if (playerX == x && playerY == y)
                    { //주인공 위치에는 P를 출력
                        Console.Write("P");
                    }
                    else
                    { //맵데이터에 0 이면 공백 출력
                        Console.Write(" ");
                    }
                    Console.Write(" "); // 이쁘게 하기 위해서 출력
                }
                Console.WriteLine();
            }
        }
    }
}
