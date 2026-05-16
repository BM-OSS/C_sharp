using System;
using System.ComponentModel.DataAnnotations;

namespace class65_060604
{
    #region 知识点一 什么是泛型约束
    //泛型约束一共有6种
    //关键字：where

    //1值类型约束
    //语法：where 泛型字母:struct

    //2引用类型约束
    //语法：where 泛型字母:class

    //3存在无参公共构造函数
    //语法：where 泛型字母:new()

    //4某个接口或者基类
    //语法：where 泛型字母:接口名

    //5继承自某个类型本身或者派生类型
    //语法：where 泛型字母:另一个泛型字母

    #endregion

    #region 知识点二 值类型约束
    class Test<T> where T : struct //约束后就只能填结构体了
    {
        public T value;

        public void TestFun<K>(K v ) where K : struct 
        {
            Console.WriteLine( v );
        }
    }

    class Test1<T> where T : class
    {
        public T value;

        public void TestFun<K>(K v) where K : class
        {
            Console.WriteLine(v);
        }
    }

    //公共无参构造函数约束
    class Test3<T> where T : new()
    {
        public T value;

        public void TestFun<K>(K v) where K : class
        {
            Console.WriteLine(v);
        }
    }
    class Test1:Test2
    {
        
    }
    class Test2
    {
        public Test2()
        {
            
        }
        public Test2(int a)
        {
            
        }
        private Test2(string str)
        {
            
        }
    }

    //类约束
    class Test4<T> where T : Test1
    {
        public T value;

        public void TestFun<K>(K v) where K : class
        {
            Console.WriteLine(v);
        }
    }

    //接口约束
    interface IMove:IFly
    {
        
    }

    interface IFly
    {
        
    }

    class Test4 : IMove
    {
        
    }

    class Test5<T> where T : IFly
    {
        public T value;
        public void TestFun<K>(K k) where K : IFly
        {
            
        }
    }

    //另一个泛型约束
    //T和U是继承关系或则，是其派生类型
    class Test6<T,U> where T : U
    {
        public T value;
        public void TestFun<K,V>(K k) where K : V
        {

        }
    }



    #endregion

    #region 知识点三 约束的组合使用
    class Test7<T> where T : class, new()
    {
        
    }
    #endregion

    #region 知识点四 多个泛型有约束
    class Test8<T, K> where T : class, new() where K : struct
    {
        
    }






    #endregion

    //泛型约束：让类型有一定限制
    //class
    //struct
    //new()
    //类名
    //接口名
    //另一个泛型字母

    //注意：
    //1.可以组合使用
    //2.多个泛型约束 用where连接即可


    #region 练习题一
    //用泛型实现一个单例模式基类


    class SingleBass<T>where T: new()
    {
        private static T instance = new T();
        public static T Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }
    }

    class GameMgr : SingleBass<GameMgr>
    {
        public int value = 10;

    }


    class Test
    {
        //单例模式，创建一个静态私有的相同类的对象
        private static Test instance;
        public int value = 10;

        //再私有化一个相同的类
        private Test()
        {
            
        }

        public static Test Instance
        {
            get 
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }




    }




    #endregion


    #region 练习题二

    //利用泛型知识点，仿造ArrayList实现一个不确定数组类型的类
    //实现增删查改方法

    class ArrayList<T>
    {
        private T[] array;

        //记录存了多少次
        private int count;


        public ArrayList()
        {
            count = 0;
            //一开始的容量就是16
            array = new T[16];
        }

        public void Add(T value)
        {
            //是否需要扩容
            if (count >= Capacity)
            {
                //每次搬家扩容两倍
                T[] temp = new T[Capacity * 2];
                for (int i = 0; i < Capacity; i++)
                {
                    temp[i] = array[i];

                }
                //重新指向地址
                array = temp;
            }


            //不需要扩容 直接加
            array[count] = value;
            ++count;
        }

        public void Remove(T value)
        {
            //这个地方 不是小于数组的容量
            //是小于 具体存了几个值
            int index = -1;
            for (int i = 0; i < Count; i++)
            {
                //不能用==去判断，因为不是所有的运算符都重载了
                if (array[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                for (; index < Count - 1; index++)
                {
                    array[index] = array[index + 1];
                }
                //把最后一个数数组元素给置空
                array[Count - 1] = default(T);
                --count;
                //上面的代码（for循环）可以通过调用下面的函数实现
                //Remove(index);
            }

        }

        public void RemoveAt(int index)
        {
            //判断索引和不和法
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("索引不合法，超出边界");
                return;
            }
            //通过for循环将index后面的每一个数组都前移
            for (; index < Count - 1; index++)
            {
                array[index] = array[index + 1];
            }
            //把最后一个数数组元素给置空
            array[Count - 1] = default(T);
            --count;

        }


        public T this[int index]
        {
            get 
            {
                if (index < 0 || index >= Count)
                {
                    Console.WriteLine("索引不合法，超出边界");
                    return default;
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    Console.WriteLine("索引不合法，超出边界");
                    return;
                }
                array[index] = value;
            }
        }
        /// <summary>
        /// 获取数组的容量
        /// </summary>
        public int Capacity
        {
            get 
            {
                return array.Length;
            }
            set 
            {

            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }

    }




    #endregion




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型约束");


            Test<int> t1 = new Test<int>();
            t1.TestFun<float>(1.3f);

            Test1<Random> t2 = new Test1<Random>();

            t2.TestFun<object>(new Object());

            Test3<Test1> t3 = new Test3<Test1>();
            Test3<Test2> t4 = new Test3<Test2>();
            Test4<Test1> t5 = new Test4<Test1>();


            Test5<IMove> tt = new Test5<IMove>();
            tt.value = new Test4();


            Test6<Test4,IFly> t6 = new Test6<Test4,IFly>();


            
            GameMgr.Instance.value = 10;


            ArrayList<int> array = new ArrayList<int>();
            Console.WriteLine(array.Count);
            Console.WriteLine(array.Capacity);
            array.Add(1);
            array.Add(34);
            array.Add(26);
            array.Add(99);
            array.Add(35);
            Console.WriteLine(array.Count);
            Console.WriteLine(array.Capacity);

            Console.WriteLine(array[1]);
            Console.WriteLine(array[-1]);
            array.Remove(34);
            Console.WriteLine(array.Count);
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("*********************");
            Console.WriteLine(array[0]);
            array[0] = 93;
            Console.WriteLine(array[0]);
            
        }
    }
}