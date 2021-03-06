﻿using System;

namespace CheckPoint04
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

            if (this is Healer)
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

            Console.WriteLine("바바리안 생성");
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

    class Giant : Army
    {
        public Giant()
        {
            _HP = 200;
            _MP = 0;
            _SPEED = 50;
            _ATTACK = 150;

            Console.WriteLine("자이언트 생성");
        }

        public override void Run()
        {
            base.Run();

            Console.WriteLine("자이언트 달려갑니다.");
        }
        public override void Attack()
        {
            base.Attack();

            Console.WriteLine("자이언트가 주먹으로 내리칩니다!");
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

            Console.WriteLine("힐러 생성");
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

    class UnitControl
    {
        public enum UNIT
        {
            NONE,
            BABARIAN,
            GIANT,
            HEALER,
        }

        const int MAX = 10;
        Army[] arrArmys;
        int indexCnt;

        public UnitControl()
        {
            indexCnt = 0;
            arrArmys = new Army[MAX];
        }

        public string Menu()
        {
            Console.WriteLine("++ 유닛 관리 시스템 ++");
            Console.WriteLine("(1) 생성 (2) 달리기 (3) 공격 (0) 나가기");

            return Console.ReadLine();
        }

        public void CreateUnitMenu()
        {
            Console.Clear();
            Console.WriteLine("++ 유닛 생성 시스템 ++");
            Console.WriteLine("(1) 바바리안 (2) 자이언트 (3) 힐러 (0) 뒤로가기");

            UNIT selUnit = UNIT.NONE;
            string inputStr = Console.ReadLine();

            if (indexCnt >= MAX)
            {
                Console.WriteLine(" ** 유닛 생성 불가 ** (최대 유닛 :  {0}/ 현재 유닛 : {1})", MAX, indexCnt);
                return;
            }

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputStr);
            }
            else
                selUnit = UNIT.NONE;

            switch (selUnit)
            {
                case UNIT.NONE:
                    indexCnt--;
                    break;
                case UNIT.BABARIAN:
                    arrArmys[indexCnt] = new Barbarian();
                    break;
                case UNIT.GIANT:
                    arrArmys[indexCnt] = new Giant();
                    break;
                case UNIT.HEALER:
                    arrArmys[indexCnt] = new Healer();
                    break;
            }

            indexCnt++;
        }
        public void UnitRunMenu()
        {
            Console.Clear();
            Console.WriteLine("========> 유닛 달리기");
            Console.WriteLine("(1) 바바리안 (2) 자이언트 (3) 힐러 (4) 전체 달리기 (0) 뒤로가기");

            UNIT selUnit = UNIT.NONE;
            string inputStr = Console.ReadLine();

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputStr);
                UnitRun(selUnit);
            }
            else if (inputStr.Equals("4"))
                UnitRun();
            else
                Console.Clear();
        }
        public void UnitAttackMenu()
        {
            Console.Clear();
            Console.WriteLine("!!!!!!!! 유닛 공격");
            Console.WriteLine("(1) 바바리안 (2) 자이언트 (3) 힐러 (4) 전체 공격 (0) 뒤로가기");

            UNIT selUnit = UNIT.NONE;
            string inputStr = Console.ReadLine();

            if (inputStr.Equals("1") || inputStr.Equals("2") || inputStr.Equals("3"))
            {
                selUnit = (UNIT)int.Parse(inputStr);
                UnitAttack(selUnit);
            }
            else if (inputStr.Equals("4"))
                UnitAttack();
            else
                Console.Clear();
        }
        private void UnitAttack()
        {
            for (int i = 0; i < indexCnt; i++)
            {
                arrArmys[i].Attack();
            }
        }
        private void UnitAttack(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.BABARIAN:
                    for (int i = 0; i < indexCnt; i++)
                    {
                        if (arrArmys[i] is Barbarian)
                            arrArmys[i].Attack();
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCnt; i++)
                    {
                        if (arrArmys[i] is Giant)
                            arrArmys[i].Attack();
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCnt; i++)
                    {
                        if (arrArmys[i] is Healer)
                            arrArmys[i].Attack();
                    }
                    break;
            }
        }

        private void UnitRun()
        {
            for (int i = 0; i < indexCnt; i++)
            {
                arrArmys[i].Run();
            }
        }
        private void UnitRun(UNIT unit)
        {
            switch (unit)
            {
                case UNIT.BABARIAN:
                    for(int i = 0; i < indexCnt; i++)
                    {
                        if (arrArmys[i] is Barbarian)
                            arrArmys[i].Run();
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCnt; i++)
                    {
                        if (arrArmys[i] is Giant)
                            arrArmys[i].Run();
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCnt; i++)
                    {
                        if (arrArmys[i] is Healer)
                            arrArmys[i].Run();
                    }
                    break;
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            UnitControl control = new UnitControl();
            string selectNum;
            bool isLoop = true;

            while (isLoop)
            {
                selectNum = control.Menu();

                switch (selectNum)
                {
                    case "1": // 생성
                        control.CreateUnitMenu();
                        break;
                    case "2": // 달리기
                        control.UnitRunMenu();
                        break;
                    case "3": // 공격
                        control.UnitAttackMenu();
                        break;
                    default:
                        isLoop = false;
                        break;
                }
            }
        }
    }
}
