using System;

namespace class45_260515
{
    #region 知识点一 基本概念
    //里氏替换的原则是面向对象的七大原则中最重要的原则
    //概念：
    //任何父类出现的地方，子类都可以替代
    //重点：
    //语法表现——父类容器装子类对象，应为子类对象包含父类的所有内容
    //作用：
    //方便进行对象存储和管理
    #endregion

    #region 知识点二 基本实现
    class GameObject
    {
        
    }
    class Player : GameObject
    {
        public void PlayerAtk()
        {
            Console.WriteLine("玩家攻击");
        }
    }
    class Monster : GameObject 
    {
        public void MonsterAtk()
        {
            Console.WriteLine("法师攻击");
        }
    }
    class Boss : GameObject 
    {
        public void BossAtk()
        {
            Console.WriteLine("Boss攻击");
        }
    }

    #endregion

    #region 练习题一 
    //is和as的区别

    //is是用于判断是否是该类的对象  返回值 true或者false
    //as用来将其转换为指定类的对象  返回值 指定对象或者null

    #endregion

    #region 练习题二
    //写一个Monster类，它派生出来Boss和Goblin两个类
    //Boss有技能；小怪有攻击力；
    //随机生成10个小怪，装载到数组中
    //遍历这个数组，调用他们的攻击方法，如果是boss就是放技能

    class Monster1
    { 

    }

    class Boss1 : Monster1 
    {
        public void Skill()
        {
            Console.WriteLine("boss释放技能");
        }
    }

    class Goblin : Monster1
    {
        public void Skill()
        {
            Console.WriteLine("Goblin普通攻击");
        }
    }



    #endregion

    #region 练习题三
    //FPS游戏模拟
    //写一个玩家类，玩家可以拥有各种武器
    //现在有四种武器，冲锋枪，散弹枪，手枪，匕首
    //玩家默认拥有匕首
    //请在玩家类中写一个方法，可以拾取不同的武器替换自己拥有的武器
    

    class Weapon
    {
        
    }
    /// <summary>
    /// 冲锋枪
    /// </summary>
    class SubmachineGun: Weapon
    {
        
    }
    /// <summary>
    /// 散弹枪
    /// </summary>
    class ShortGun: Weapon
    {
        
    }
    /// <summary>
    /// 手枪
    /// </summary>
    class Pistol: Weapon
    {
        
    }
    /// <summary>
    /// 匕首
    /// </summary>
    class Dagger: Weapon
    {
        
    }

    class Players
    {
        private Weapon nowHaveWepon;

        public Players()
        {
            nowHaveWepon = new Dagger();
        }
        public void PickUp(Weapon weapon)
        {
            nowHaveWepon= weapon;
        }

    }

    #endregion
    
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("里氏替换原则");

            GameObject player = new Player();
            //里氏替换原则 用父类容器 装载子类对象
            //Player();本来应该用GameObject();现在用的子类替代了
            GameObject monster = new Monster();
            GameObject boss = new Boss();

            GameObject[] objects = new GameObject[] { new Player(), new Monster(), new Boss() };

            #region 知识点三
            //基本概念
            //is:判断一个对象是否是指定类对象
            //返回值：bool 是为真 不是为假
            //if (player is Player)
            //{
            //    Console.WriteLine("player是Player类");
            //}


            //as：将一个对象转换为指定类对象
            //返回值：指定类对象
            //成功返回执行类型对象，失败返回null
            //Player p = player as Player;

            //基本语法
            //类对象 is 类名 该语句块 会有一个bool返回值 true和false
            //类对象 as 类名 该语句块 会有一个对象返回值 对象和null
            //is和as一般配合着使用
            if (player is Player)
            {
                Player p1 = player as Player;
                p1.PlayerAtk();
                (player as Player).PlayerAtk();
            }

            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] is Player)
                {
                    (objects[i] as Player).PlayerAtk();
                }
                else if (objects[i] is Monster)
                {
                    (objects[i] as Monster).MonsterAtk(); 
                }
                else if (objects[i] is Boss)
                {
                    (objects[i] as Boss).BossAtk();
                }
            }
            #endregion
            Console.WriteLine("练习题二");
            Random r = new Random();
            int randNum;
            Monster1[] monster1 = new Monster1[10];
            for (int i = 0; i < monster1.Length; i++)
            {
                randNum = r.Next(0,101);
                if (randNum < 50)
                {
                    monster1[i] = new Boss1();
                }
                else 
                {
                    monster1[i] = new Goblin();
                }
            }
            for(int i=0;i<monster1.Length;i++)
            {
                if (monster1[i] is Boss1)
                {
                    (monster1[i] as Boss1).Skill();
                }
                else
                {
                    (monster1[i] as Goblin).Skill();
                }
            }
            Players p = new Players();
            SubmachineGun s = new SubmachineGun();
            p.PickUp(s);

            ShortGun sg = new ShortGun();
            p.PickUp(sg);

        }
    }
    //总结
    //里氏替换的作用：方便进行对象的存储和管理
    //使用：is和as
    //is用于判断的
    //as用于转换的
    //is和as一起搭配使用
}
