using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Class63_260602
{
    #region 练习题二
    //制作一个怪物管理器，提供创建怪物
    //移除怪物的方法，每隔怪物都有自己的唯一ID
    /// <summary>
    /// 怪物管理器 
    /// </summary>
    class MonsterMgr
    {
        private static MonsterMgr instance = new MonsterMgr();

        
        private Hashtable monstersTable = new Hashtable();

        private MonsterMgr()
        {
            
        }


        public static MonsterMgr Instance
        {
            get 
            {
                return instance;
            }
        }

        private int monsterID = 0;

        public void AddMonster()
        {
            Monster monster = new Monster(monsterID);
            ++monsterID;

            monstersTable.Add(monster.id,monster);
            Console.WriteLine("创建了怪物{0}",monster.id);

        }

        public void RemoveMonster(int monsterID) 
        {
            if (monstersTable.ContainsKey(monsterID))
            {
                (monstersTable[monsterID] as Monster).Dead();
                monstersTable.Remove(monsterID);
                
            }
        }
    }

    class Monster
    {
        public int id;

        public Monster(int monsterID)
        {
            id = monsterID;
        }


        public void Dead()
        {
            Console.WriteLine("怪物{0}死亡",id);   
        }
    }



    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable");
            #region 知识点一 Hashtable的本质
            //Hashtable（又称散列表） 是基于键的哈希代码组织起来的 键/值对
            //它的主要作用是提高数据查询的效率
            //使用键来访问集合中的元素

            #endregion
            #region 知识点二 申明变量

            Hashtable hashtable = new Hashtable();

            #endregion

            #region 增删查改
            //增
            hashtable.Add(1,123);
            hashtable.Add(2, 123);
            hashtable.Add(123, false);
            //hashtable.Add(1,123);
            //不能出现相同的键值对

            //删
            //1.只能通过键来删除
            hashtable.Remove(1);
            //2.删除不存在的键没有反应
            hashtable.Remove(3);
            //3.或则直接清空
            hashtable.Clear();
            hashtable.Add(1, 123);
            hashtable.Add(2, 123456);
            hashtable.Add(3, 123456789);
            hashtable.Add(4, 123456789123);
            hashtable.Add(5, 123123);


            //查
            //键不能重复，但是值可以重复
            //1.通过键来查看值
            //找不到就返回空
            Console.WriteLine(hashtable[2]);
            Console.WriteLine(hashtable[2]);//找不到就返回空
            //2.查看是否存在
            //更具键检测
            if (hashtable.Contains(2))
            {
                Console.WriteLine("存在键为2的键值对");
            }
            if (hashtable.ContainsKey(2))
            {
                Console.WriteLine("存在键为2的键值对");
            }


            //更具值检测
            if (hashtable.ContainsValue(123456))
            {
                Console.WriteLine("存在值为123456的键值对"); 
            }

            //改
            Console.WriteLine(hashtable[2]);
            hashtable[2] = 100;
            Console.WriteLine(hashtable[2]);


            #endregion


            #region 知识点四 遍历
            //1.遍历所有键 对数
            Console.WriteLine(hashtable.Count);

            //1.遍历所有的键
            foreach (object item in hashtable.Keys)
            {
                Console.Write("键:"+item);
                Console.WriteLine(" 值:" + hashtable[item]);
            }

            
            //2.遍历所有的值
            foreach (object item in hashtable.Values)
            {
                Console.WriteLine("值: "+item);
            }

            //3.键值对一起遍历
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine("键："+item.Key +" 值："+item.Value);
            }
            //4.迭代器遍历法
            IDictionaryEnumerator myEnumerator = hashtable.GetEnumerator();
            bool flag = myEnumerator.MoveNext();
            while (flag)
            {
                Console.WriteLine("键："+ myEnumerator.Key+" 值："+ myEnumerator.Value);
                flag = myEnumerator.MoveNext();
            }


            #endregion

            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();
            MonsterMgr.Instance.AddMonster();

            MonsterMgr.Instance.RemoveMonster(0);
            MonsterMgr.Instance.RemoveMonster(3);
            MonsterMgr.Instance.RemoveMonster(4);
        }
    }
}

