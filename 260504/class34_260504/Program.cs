using System;
using System.Security.Cryptography;

namespace class34_260504
{
    #region 知识点一 成员变量
    //1.申明在类语句块中
    //2.用来描述对象的特征
    //3.可以是任意变量类型
    //4.数量不做限制
    //5.是否赋值根据需求定
    enum E_SexTYpe
    {
        Man,
        Woman,
    }

    struct Position
    {
        public int x;
        public int y;
    }

    class Pet
    {
        
    }

    class Person
    {
        //特征——成员变量
        string name="唐老狮";//可以初始化
        int age;
        E_SexTYpe sex;
        Person gridFriend;//可以是引用类型
        //在类里面可以申明一个和自己一样的类型
        Person[] boyFriend;//可以是数组类型
        Position Pos;
        Pet pet;//可以申明另一个类的对象类型
        //在类里面不能new一个新的自己相同的，
        //如这里面不能给变量赋值为new Person()，会造成死循环

    }



    #endregion

    #region 知识点二 访问修饰符
    //public 公开的，任何地方都可以访问
    //private 私有的，只有在本类中可以访问,不加默认为private
    //protected 受保护的，只有在本类和子类中可以访问
    //internal 内部的，只有在同一程序集（同一项目）中可以访问

    #endregion


    #region 练习题一
    //3p是什么
    //public 都可用
    //private 只能在类中访问
    //protected 只能在类和子类中访问
    #endregion


    #region 练习题二
    //定义一个人类，有姓名，身高，年龄，家庭住址等特征
    //用人创建若干个对象
    class Person2
    {
        public string name;
        public float height;
        public int age;
        public string address;
    }

    #endregion


    #region 练习题三
    //定义一个学生类，包含姓名，学号，年龄，同桌等成员变量

    class Student
    {
        public string name;
        public int age;
        public string studentID;
        public Student deskmate;


    }





    #endregion

    #region 练习题四
    //定义一个班级类，有专业名称，教师容量，学生等
    //创建一个班级对象
    class Class
    {
        public string name;
        public int capacity;
        public Student[] students;
    }


    #endregion



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量，访问修饰符");

            #region 知识点三 成员变量的使用和初始值
            //值类型来说 数字类型 默认都是0，bool类型默认为false
            //引用类型默认为null
            Person p1 = new Person();
            Console.WriteLine(default(Person));
            //用default关键字可以获得这个类型的默认值

            #endregion

            Person2 p = new Person2();
            p.name = "张三";
            p.age = 18;
            p.height = 1.88f;
            p.address = "北京市朝阳区";
            Console.WriteLine($"姓名：{p.name}，年龄：{p.age}，身高：{p.height}，地址：{p.address}");
            Person2 p2 = new Person2();
            p2.name = "李四";
            p2.age = 24;
            p2.height = 1.83f;
            p2.address = "南京市江宁区";


            Student s = new Student();
            s.name = "火山哥";
            s.studentID = "20260504001";
            s.age = 22;


            Student s1 = new Student();
            s1.name = "平头哥";
            s1.studentID = "20260504002";
            s1.age = 23;

            s.deskmate = s1;
            s1.deskmate = s;

            Class c = new Class();
            c.name = "Unity";
            c.capacity = 50;
            c.students = new Student[] {s,s1 };



            #region 练习题五
            //Person p=new Person();
            //p.age=10;
            //Person p2=new Person();
            //p2.age=20;
            //请问p.age为多少？
            //10
            #endregion

            #region 练习题六
            //Person p=new Person();
            //p.age=10;
            //Person p2=p;
            //p2.age=20;
            //请问p.age为多少？
            //20;

            #endregion

            #region 练习题七
            //Student s=new Student();
            //s.age=10;
            //int age=s.age;
            //age=20;
            //请问s.age为多少？
            //10;


            #endregion


            #region 练习题八
            //Student s=new Student();
            //s.deskmate=new Student();
            //s.deskmate.age=10;
            //Student s2=s.deskmate;
            //s2.age=20;
            //请问s.deskmate.age为多少？
            //20;
            #endregion


        }
    }


}
