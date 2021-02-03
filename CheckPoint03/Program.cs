using System;
using System.Threading;

namespace CheckPoint03
{
    class MainClass
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

        static void UpdateView(int[,] _map, char[] _tile)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write("{0} ", _tile[tileIndex]);
                }
                Console.WriteLine();
            }
        }

        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void UpdateGo(int[] _arrIndexX, int[,] _map)
        {
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                    int temp = _map[i + 1, _arrIndexX[i]];
                    _map[i + 1, _arrIndexX[i] + 1] = temp;
                    _map[i + 1, _arrIndexX[i]] = 0;

                    _arrIndexX[i]++;
            }
        }

        static bool UpdateRandomGo(int[] _arrIndexX, int[,] _map, Random _rnd)
        {
            bool _isFinish = false;

            for (int i = 0; i < _arrIndexX.Length; i++)
            {

                if (_arrIndexX[i] > 19)
                {
                    _isFinish = true;
                    break;
                }
            }
            int rndIndex = _rnd.Next(0, 5);

            int temp = _map[rndIndex + 1, _arrIndexX[rndIndex]];
            _map[rndIndex + 1, _arrIndexX[rndIndex] + 1] = temp;
            _map[rndIndex + 1, _arrIndexX[rndIndex]] = 0;

            _arrIndexX[rndIndex]++;

            return _isFinish;
        }

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            //              0    1    2    3    4    5    6    7
            char[] tile = {' ', '-', '|', '1', '2', '3', '4', '5'};

            int[,] map = new int[MAP_X, MAP_Y]
            {
                //0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18 19 20 21
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, // 0
                { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 1
                { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 2
                { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 3
                { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 4
                { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, // 5
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }  // 0
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;

            while (true)
            {       
                UpdateGo(arrIndexX, map);
                isFinish = UpdateRandomGo(arrIndexX, map, rnd);
                UpdateView(map, tile);

                if (isFinish)
                {
                    Console.WriteLine();
                    for (int i = 0; i < arrIndexX.Length; i++)
                    {

                        if (arrIndexX[i] > 19)
                        {
                            Console.WriteLine("\n달리기 결과 : {0}번 우승!", i + 1);
                            break;
                        }
                    }
                    Console.Write("다시 시작하려면 0을 입력하세요. ");
                    string InpurStr = Console.ReadLine();

                    if(InpurStr == "0")
                    {
                        // 귀찬스키
                    }
                    else
                    {
                        Console.WriteLine("게임을 종료합니다.");
                        break;
                    }
                }

                ClearView();
            }
        }
    }
}
