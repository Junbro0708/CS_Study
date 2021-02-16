using System;

namespace _084_override2
{
    class Army
    {
        protected int _HP;
        protected int _MP;
        protected int _SPEED;
        protected int _ATTACK;

        public virtual void Run()
        {
            Console.Write("{0}의 속도로 ", _SPEED);
        }
        public virtual void Attack()
        {
            Console.WriteLine();

            if(this is Healer)
            {
                Console.Write("[마법 공격력 - {0}]으로", _ATTACK - _MP);
            }
            else
            {
                Console.Write("[공격력 - {0}]으로", _ATTACK);
            }
        }
    }
    class Barbarian : Army
    {
        public Barbarian()
        {
            _HP = 100;
            _MP = 0;
            _SPEED = 100;
            _ATTACK = 100;
        }

        public override void Run()
        {
            base.Run();

            Console.WriteLine("바바리안 달려갑니다.");
        }
        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("바바리안이 칼로 공격합니다!");
        }
    }
    class Healer : Army
    {
        public Healer()
        {
            _HP = 50;
            _MP = 100;
            _SPEED = 200;
            _ATTACK = 10;
        }

        public override void Run()
        {
            base.Run();

            Console.WriteLine("힐러가 날아갑니다.");
        }

        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("힐러가 마법 공격을 합니다!");
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Army[] arrArmy = new Army[10];

            arrArmy[0] = new Barbarian();
            arrArmy[1] = new Barbarian();
            arrArmy[2] = new Healer();

            for(int i = 0; i < arrArmy.Length; i++)
            {
                if(arrArmy[i] != null)
                {
                    arrArmy[i].Run();
                    System.Threading.Thread.Sleep(1000);
                }
            }

            System.Threading.Thread.Sleep(1000);

            for (int i = 0; i < arrArmy.Length; i++)
            {
                if (arrArmy[i] != null)
                {
                    arrArmy[i].Attack();
                    System.Threading.Thread.Sleep(1000);
                }
            }

        }
    }
}
