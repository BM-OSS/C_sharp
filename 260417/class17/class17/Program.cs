using System;

namespace class17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数");
            #region 知识点一 产生随机数对象
            //固定写法
            //Random
            //Random 随机变量名 = new Random();
            Random r=new Random();
            #endregion

            #region 知识点二 生成随机数
            int i = r.Next();//生成一个非负数的随机数
            Console.WriteLine(i);

            i = r.Next(100);//生成一个0~99的随机数 左边始终包含 右边不包含
            Console.WriteLine(i);

            i = r.Next(5, 100);//生成一个 5到99的随机数 左包含 右不包含
            Console.WriteLine(i);
            #endregion

            #region 练习题一
            //唐老狮打小怪兽
            //唐老师攻击力为8~12之间的一个值
            //小怪兽的防御力为10，血量为20
            //在控制台上通过打印信息表现唐老狮打小怪兽过程
            //描述小怪兽的掉血情况
            //伤害计算公式：攻击力小于防御力时，减血为0，否则减血为攻击力和防御力的差值

            int monsterDef = 10;
            int monsterHp = 20;
            int teatcherTangAtk = 0;
            Random x = new Random();
            while (true)
            {
                teatcherTangAtk = x.Next(8,13);
                if (teatcherTangAtk > monsterDef)
                {
                    monsterHp -= teatcherTangAtk - monsterDef;
                    Console.WriteLine("唐老狮的攻击力为{0}，对怪兽造成了{1}伤害，怪兽剩余血量为{2}",teatcherTangAtk,teatcherTangAtk-monsterDef,monsterHp);
                }
                else 
                {
                    Console.WriteLine("唐老狮攻击力为{0}，不足以对怪兽造成伤害",teatcherTangAtk);
                }
                Console.ReadKey(true);
                Console.WriteLine("按任意键继续");
                Console.WriteLine();
                if (monsterHp < 0)
                {
                    break;
                }
            }
            Console.WriteLine("唐老狮击败了怪兽");
            #endregion
        }
    }
}
