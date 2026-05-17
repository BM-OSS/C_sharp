using System;
namespace class66_260605
{

    



    class Program



    {
        static void Main(string[] args)
        {
            Console.WriteLine("常用泛型数据结构——list");

            #region 知识点一 list的本质
            //List是一个C#为我们封装好的类,
            //它的本质是一个可变类型的泛型数组
            //List类帮助我们实现了很多方法,
            //比如泛型数组的增删查改
            #endregion

            #region 知识点二 申明
            //引用民命空间
            //using System.Collections.Generic
            List<int> list = new List<int>();

            List<string> list2 = new List<string>();

            #endregion

            #region 知识点三 增删查改
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            List<string> listStr = new List<string>();
            listStr.Add("123456");

            list2.AddRange(listStr);


            //查找
            if (list.Contains(1))
            {
                Console.WriteLine("存在元素1");
            }
            #endregion


            #region 练习题一
            //请描述List和ArrayList的区别
            //List内部分装是一个泛型数组
            //ArrayList内部封装是object数组

            #endregion

            #region 练习题二
            //建立一个整形List，为它添加10~1
            //删除List中第五个元素
            //遍历剩余元素并打印


            List<int> lists = new List<int>();
            
            for (int i = 10; i > 0; i--)
            {
                lists.Add(i);
            }

            lists.RemoveAt(4);
            for (int i = 0; i < lists.Count; i++)
            {
                Console.WriteLine(lists[i]);
            }
            Console.WriteLine("************");
            foreach (int i in lists)
            {
                Console.WriteLine(i);
            }
            #endregion


            #region 练习题三
            //一个Monster基类，Boss和Gablin类继承它。
            //在怪物类的构造函数中，将其存储到一个怪物List中
            //遍历列表可以让Boss和Gablin对象产生不同攻击

            Boss b = new Boss();
            Gablin g = new Gablin();
            Boss b2 = new Boss();
            Gablin g2 = new Gablin();
            for (int i = 0; i < Monster.monster.Count; i++)
            {
                Monster.monster[i].Atk();
            }





            #endregion


        }
    }

    abstract class Monster
    {
        public static List<Monster> monster = new List<Monster>();


        public Monster()
        {
            monster.Add(this);
        }

        public abstract void Atk();

    }

    class Boss : Monster
    {
        public override void Atk()
        {
            Console.WriteLine("Boss的攻击");
        }
    }

    class Gablin : Monster
    {
        public override void Atk()
        {
            Console.WriteLine("哥布林的攻击");
        }
    }
}