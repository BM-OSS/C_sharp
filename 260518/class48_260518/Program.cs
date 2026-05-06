using System;
namespace class48_260518
{
    #region 知识点一 基本概念
    //密封类 是使用 sealed密封关键字修饰的类
    //作用：让类无法再被继承
    #endregion


    #region 知识点二 实例
    class Father
    {
        
    }
    //Son可以继承father，但是后面的类不能再继承Son了
    //不然会报错
    sealed class Son:Father
    {
        
    }

    #endregion

    #region 知识点三 作用
    //在面向对象程序的设计中，密封类的主作用就是不允许最低层的子类被继续继承
    //可以保证程序的规范性，和安全性
    //目前对于初学者来说，用处不打，后面积累后会用到



    #endregion


    #region 练习题一
    //定义一个载具类
    //有速度，最大速度，可乘人数，司机和乘客等，有上车，下车，行驶，车祸等方法
    //用载具类申明一个对象，并将若干人装载上车


    class Person
    { 

    }
    class Driver:Person
    { 

    }
    class Passenger:Person
    {
        
    }
    class Car
    {
        public int speed;
        public int max;
        public int num;

        public Person[] persons; 

        public Car(int speed, int max, int num)
        {
            this.speed = speed;
            this.max = max;
            this.num = 0;
            //当前装载了多少人
            persons = new Person[num];
        }

        public void GetIn(Person p)
        {
            if (num >= persons.Length)
            {
                Console.WriteLine("无法装载更多的人");
                return;
            }
            persons[num] = p;
            Console.WriteLine("乘客{0}已上车",p);
            ++num;
        }
        public void GetOut(Person P)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] == null)
                {
                    break;
                }
                if (persons[i]==P)
                {
                    //把这个位置以后得变量前移，然后删除最后一个变量
                    for (int j = i; j < num - 1; j++)
                    {
                        persons[j]=persons[j+1];
                    }
                    //清空最后一个位置
                    persons[num - 1] = null;
                    --num;
                    Console.WriteLine("乘客{0}已下车", P);
                    break;
                }
            }

        }
        public void Move()
        {
        }
        public void Boom()
        {
            
        }
    }

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封类");

            Car c = new Car(10, 30, 20);
            Driver d = new Driver();            
            c.GetIn(d);

            Passenger p = new Passenger();
            c.GetIn(p);
            Passenger p1 = new Passenger();
            c.GetIn(p1);
            Passenger p2 = new Passenger();
            c.GetIn(p2);
            Passenger p3 = new Passenger();
            c.GetIn(p3);
            Passenger p4 = new Passenger();
            c.GetIn(p4);

            c.GetOut(p2);
        }
    }
}