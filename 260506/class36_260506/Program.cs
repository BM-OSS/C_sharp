using System;


namespace class36_260506
{

    #region 知识点一 构造函数
    //基本概念
    //在实例化对象时 会调用的初始化函数
    //如果不写 默认存在一个无参构造函数

    //构造函数的写法
    //1.没有返回值
    //2.函数名和类名必须要相同
    //3.没有特殊需求时，一般是public
    class Person
    {
        public string name;
        public int age;

        //类中是允许自己申明无参构造函数的
        //结构体中是不允许的
        public Person()
        {
            name = "唐老狮";
            age = 18;
        }
        public Person(int age)
        {
            this.age = age;
        }
        //函数重载
        public Person(string name)
        {
            this.name = name;
        }

        public Person(int age, string name):this(age)//重载函数遇到“：this(参数)”的情况表示要先调用另一个重载函数了函数
        {
            this.age = age;
            this.name = name;
        }

    }


    //4.构造函数可以被重载
    //5.this代表当前调用该函数的对象自己

    //注意:
    //如果不自己实现无参构造函数而实现了有参构造函数
    //会失去默认的无参构造

    #endregion

    #region 知识点二 构造函数特殊写法
    //可以通过this 重用构造函数代码
    //访问修饰符 构造函数名(参数列表)：this（参数1，参数2）


    #endregion

    #region 知识点三 析构函数
    //基本概念
    //当引用类型的堆内存被回收时，会调用该函数
    //对于需要手动管理内存的语言（c++），需要在析构函数中做一些内存回收处理
    //但是C#中在自动垃圾回收机制GC
    //所以我们几乎不会怎么使用析构函数 除非想在某个对象被垃圾回收时做一些特殊处理
    //注意：
    //在Unity开发中析构函数几乎不会使用

    //基本语法
    //~类名（）
    //{
    //
    //}
    #endregion

    #region 知识点四垃圾回收机制
    //垃圾回收，英文简写GC
    //垃圾回收的过程是在遍历堆（Heap）上动态分配的所有对象
    //通过之别他们是否被引用来确定那些对象是垃圾，那些对象是仍要使用的
    //所谓的垃圾就是没有被任何变量，对象引用的内容
    //垃圾就需要被回收释放

    //垃圾回收有很多种算法，比如
    //引用计数（Reference Collector）
    //标记清除（Mark Sweep）
    //标记整理（Mark Compact）
    //复制集合（Copy Collection）

    //注意：
    //GC只负责堆（Heap）内存的垃圾回收
    //引用类型都是存在堆（Heap）中的，所以他的分配和释放都通过垃圾回收机制来管理

    //栈（Stack）上的内存是由系统自动管理的
    //值类型在栈（Stack）中分配内存的，他们有自己的生命周期，不用对他们进行管理，会自动分配和释放

    //C#中内存回收机制的大概原理
    //0代内存   1代内存   2代内存
    //代的概念：
    //代是垃圾回收机制使用的一种算法（分代算法）
    //新分配的对象都会被配置在第0代内存中
    //每次分配都有可能会进行垃圾回收以释放内存（0代内存满时）


    //在一次内存回收过程开始时，垃圾回收器会认为堆中全是垃圾，会进行一下两步
    //1.标记对象 从根（静态字段、方法参数）开始检查引用对象，标记后为可达对象，标记为不可达对象
    // 不可达对象认为是垃圾
    //2.搬迁对象压缩堆（挂起指向托管代码线程）释放未标记的对象 搬迁可达对象 修改引用地址

    //大对象总被认为是二代内存 目的是减少性能损耗，提高性能
    //不会对大对象进行搬迁压缩 850000字节（83kb）以上的对象为大对象



    #endregion

    #region 练习题一
    //对人类构造函数进行重载，用人类创建若干个对象
    class Person1
    {
        public int age;
        public float height;
        public string name;
        public string homeAddress;

        public Person1(string name, float height, int age, string homeAddress)
        {
            this.name = name;
            this.height = height;
            this.age = age;
            this.homeAddress = homeAddress;
        }
        public Person1(string name, float height)
        {
            this.name=name;
            this.height = height;
        }

    }



    #endregion
    class Student
    {
        public string name;
        public int age;
        public Student(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
    }



    #region 练习题二
    //对班类的构造函数进行重载，用班级类创建若干个对象
    class Class
    {
        public string name;
        public int capacity;
        public Student[] students;

        public Class(string name,int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public Class(string name,int capacity, Student[] students):this(name,capacity)
        {
            this.name = name;
            this.capacity = capacity;
            this.students = students;

        }

    }



    #endregion


    #region 练习题三
    //写一个Ticket类，有一个距离变量（在构造函数对象时赋值，不能为负数），有一个价格特征
    //有一个方法GetPrice可以读取到价格，并且根据距离distance计算价格price（1元/公里）
    //0~100公里 不打折
    //101~200公里 打9.5折
    //201~300公里 打9折
    //300公里以上 打8折
    //有一个显示方法，可以显示这张票的信息
    //例如：100公里100块钱
    class Ticket
    {
        public uint distance;
        public float price;

        public Ticket(uint distance)
        {
            this.distance = distance;
            price = GetPrice(distance);

        }

        private float GetPrice(uint distance)
        {
            if (distance >= 300)
            {
                return distance * 0.8f;
            }
            else if (distance < 300 && distance >= 201)
            {
                return distance * 0.9f;
            }
            else if (distance <=200 && distance >= 101)
            {
                return distance * 0.95f;
            }
            else 
            {
                return distance ;
            }
            
        }

        public void PriceInfo()
        {
            Console.WriteLine("一共行驶{0}距离，花费{1}元钱",distance,price);
        }

    }


    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("构造函数和析构函数");

            Person p = new Person(18,"唐老狮");
            Console.WriteLine(p.age);
            

            //手动触发垃圾回收的方法
            //一般情况下 我们不会频繁的调用 
            //都是在 Loading过场景时才调用
            GC.Collect();

            //基本语法
            //不写返回值
            //函数名和类名相同
            //访问修饰符根据需求而定
            //一般为public


            //注意
            //可以重载构造函数
            //可以用this语法重构代码
            //可以在函数中用this区分同名参数和成员变量
            //有参构造函数会顶掉默认的无参构造函数

            //析构函数
            //当对象被垃圾回收时 调用的，主要是用来回收资源或者特殊处理内存的

            //基本语法
            //不写返回值
            //不写修饰符
            //不能有参数
            //函数名和类相同



            Person1 p1 = new Person1("唐老狮", 177.5f, 18, "太阳系地球");
            Person1 p2 = new Person1("小火", 184.5f);

            Class C = new Class("Unity", 9999);
            Student s1 = new Student("小明",19);
            Student s2 = new Student("小王",20);
            
            
            Class c2 = new Class("C#", 9999999,new Student[] {s1,s2});


            Ticket T = new Ticket(1650);
            T.PriceInfo();

        }
    }
}