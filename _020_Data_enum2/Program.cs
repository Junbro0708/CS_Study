using System;

/*------------------
 * Name: _020_Data_enum2
 * DESC: enum의 데이터형 활용
------------------- */

namespace _020_Data_enum2
{
    class MainClass
    {
        enum CHAR_STATE
        {
            IDLE, // 0
            WALK, // 1
            RUN, // 2
            DIE, // 3
        }

        enum CLICK_STATE
        {
            NONE, // 0 
            CLICK = 100, // 100 특정 값을 넣으면 100
            DOUBLE_CLICK = 200,
            UP, // 얘는 차례대로 1씩 더해지기 때문에 201이 된다.
        }

        public static void Main(string[] args)
        {
            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("캐릭터 상태 {0} {1}", charState, (int)charState);

            charState = CHAR_STATE.DIE;
            Console.WriteLine("캐릭터 상태 {0} {1}", charState, (int)charState);
        }
    }
}
