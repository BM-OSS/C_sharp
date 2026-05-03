using System;

namespace Class38_260508
{
    #region 知识点一 索引器基本概念
    //让对象可以像数组一样通过索引访问其中元素，
    //使程序看起来更加直观，更加容易编写



    #endregion
    #region 知识点二 索引器语法
    //访问修饰符 返回值 this[参数类型 参数名，参数类型 参数名]
    //{
    //  内部写法和规则和索引器相同
    //  get{}
    //  set{}
    //}

    class Person
    {
        private string name;
        private int age;
        private Person[] friends;
        private int[,] array;
        
        #region 知识点五 索引器可以重载
        //重载的概念是——函数行相同 参数类型和数量不同，顺序不同
        //public int this[int i, int j]
        //{
        //    get 
        //    {
        //        return array[i, j];
        //    }
        //    set
        //    {
        //        array[i, j] = value;
        //    }

        //}

        public string this[string str]
        {
            get
            {
                switch (str)
                {
                    case "name":
                        return this.name;
                    case "age":
                         return age.ToString();

                }
                return "";
            }
        }

        #endregion
        public Person this[int i,float j]
        {
            get
            {
                return friends[i];
            }
            set 
            { }
        }


        public Person this[int index]
        {
            
            get
            {
                //可以写逻辑的，根据需求来处理这里面的内容
                #region 知识点四 索引器中可以写逻辑
                if (friends == null|| friends.Length - 1 < index)
                {
                    return null;
                }

                #endregion

                return friends[index];
            }
            set
            {
                //value代表传入的值
                //可以写逻辑的，根据需求来处理这里面的内容
                if (friends == null)
                {
                    friends = new Person[] { value };

                }
                else if (index > friends.Length - 1)
                {
                    //自己定义的规则，如果索引越界，就默认把最后一个朋友顶掉
                    friends[friends.Length - 1] = value;
                }
                friends[index] = value;
            }
        }

    }


    #endregion

    //总结
    //索引器对我们来说主要作用
    //可以让我们以中括号的形式范围定义类中的元素，
    //规则自己定，访问时和数组一样
    //比较实用于在类中有数组变量时使用
    //可以方便的访问和进行逻辑处理

    //注意：结构体里面也是支持索引器



    #region 练习题一
    //自定义一个整形数组类，该类中有一个整形数组变量
    //为它封装增删查改的方法
    class IntArray
    {
        private int[] array;
        //房间容量
        private int capacity;
        //当前放了几个房间
        private int length;

        public IntArray()
        {

            capacity = 5;
            length = 0;
            array = new int[capacity];
        }

        //增
        public void Add(int value)
        {
            //增加数组就涉及扩容
            //扩容就涉及“搬家”
            if (length < capacity)
            {
                array[length] = value;
                ++length;
            }
            //扩容+“搬家”
            else
            {
                capacity *= 2;
                //创建新房子
                int[] tempArray =new int[capacity];
                //先将老东西搬进新房子
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i]=array[i];
                }
                //老的房子地址指向新的房子的地址
                array= tempArray;

                array[length] = value;
                ++length;
            }
        }

        //删
        public void Remove(int value)
        {
            //先找到传入值 在那个位置
            for (int i = 0; i < length; i++)
            {
                if (array[i] == value)
                {
                    RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine("没有在数组中找到{0}",value);

        }
        public void RemoveAt(int index)
        {
            if (index > length - 1)
            {
                Console.WriteLine("当前数组只有{0},你越界了", length); ;
                return;
            }
            for (int i = index; i < length-1; i++)
            {
                array[i] = array[i + 1];
            }
            --length;
        }

        //查改
        public int this[int index]
        {
            get 
            {
                if (index >= length||index<0)
                {
                    Console.WriteLine("出现越界");
                    return 0;
                }
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public int Length
        {
            get 
            { 
                return length; 
            }
        }

    }


    #endregion

    class Promgram
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("索引器");
            #region 知识点三 索引器的使用
            Person p = new Person();
            p[0] = new Person();
            Console.WriteLine(p[0]);

            //p[0, 0] = 10;
            #endregion


            #region 练习题一
            IntArray array = new IntArray();
            array.Add(100);
            array.Add(200);
            array.Add(300);
            array.Add(400);
            array.Add(500);
            array.Add(600);
            array.Add(700);

            Console.WriteLine(array.Length);

            array.RemoveAt(2);
            array.Remove(200);

            Console.WriteLine(array.Length);

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.WriteLine(array[5]);
            Console.WriteLine(array[6]);
            #endregion
        
        }

    }

}
