using System;

namespace class51_260521
{
    #region 接口的概念
    //接口是行为的抽象规范
    //它也是一种自定义类型
    //关键字：interface


    //接口申明的规范
    //1.不包含成员变量
    //2.只包含方法、属性、索引器、事件
    //3.成员不能被实现
    //4.成员可以不用写访问修饰符，不能是私有的
    //5.接口不能继承类，但是可以继承另一个接口

    //接口的使用规范
    //1.类可以继承多个接口
    //2.类继承接口后，必须实现接口中所有成员

    //特点：
    //1.它和类的申明类似
    //2.接口是用来继承的
    //3.接口不能被实例化，但可以作为容器存储对象

    #endregion

    #region 知识点二 接口的申明
    //接口关键字：interface
    //语法：
    //interface 接口名
    //{
    //
    //}
    //接口是抽象行为的"基类"
    //接口命名规范 帕斯卡前面加一个I
    interface IFly
    {
        void Fly();
        //不写访问修饰符默认是public，不能是私有的，
        //因为子类必须继承所有的方法
        string Name
        {
            get;
            set;
        }
        int this[int index]
        {
            get;
            set;
        }
        event Action doSomthing;
    }
    #endregion

    #region 知识点三 接口的使用
    //接口用来继承
    class Animal
    {
        
    }

    //1.类可以继承一个类，n个接口
    //2.继承了接口后 必须实现其中的内容 并且必须是public的

    class Person : Animal, IFly//后面加,可以继续接接口
    {
        public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action doSomthing;

        public void Fly()
        {
            throw new NotImplementedException();
            //站位的
        }

        //一定要加public，不然会报错，很少写protect修饰符
        //public void Fly()
        //{ 

        //}
        
        //public string Name
        //{
        //    get;
        //    set;
        //}
        //public int this[int index]
        //{
        //    get;
        //    set;
        //}
        //public event Action doSomthing;

    }


    //3.实现的接口函数，可以加V再在子类重写



    #endregion

    #region 知识点四 接口继承接口
    //接口继承接口时 不需要实现
    //等到类继承接口后 类自己去实现所有内容
    //如下的Test类
    interface IWalk
    {
        void Walk();
    }

    interface IMove : IFly, IWalk
    {
        void Move();
    }


    class Test : IMove
    {
        public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action doSomthing;

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }





    #endregion

    #region 知识点五 显示实现接口
    //当一个类继承两个接口
    //但是接口中存在着同名方法时
    //注意：显示实现接口时 不能写访问修饰符

    interface IAtk
    {
        void Atk();
    }

    interface ISuperAtk
    {
        void Atk();
    }
    class Player : IAtk, ISuperAtk
    {
        //显示实现接口 就是用接口名.行为名 去实现
        void IAtk.Atk()
        {

            Console.WriteLine("普通Atk");
        }

        void ISuperAtk.Atk()
        {
            Console.WriteLine("超级Atk"); 
        }


    }
    #endregion

    #region 练习题一
    //人，汽车，房子都需要登记，人需要到派出所登记，汽车需要到车管所登记，房子需要到房管局登记
    //使用接口实现登记方法

    interface IRegister
    {
        void Register();
    }

    class Persons : IRegister
    {
        public void Register()
        {
            Console.WriteLine("在派出所登记");
        }
    }

    class Car : IRegister
    {
        public void Register()
        {
            Console.WriteLine("在车管所登记");
        }
    }

    class House : IRegister
    {
        public void Register()
        {
            Console.WriteLine("在房管局登记");
        }
    }
    #endregion

    #region 练习题二
    //麻雀，鸵鸟，企鹅，鹦鹉，直升机，天鹅
    //直升机和部分鸟能飞
    //鸵鸟和企鹅不能飞
    //企鹅和天鹅能游泳
    //除直升机、其他都能走
    //请用面向对象相关知识实现

    abstract class Bird
    {
        public abstract void Walk();
        
    }
    interface IFly1
    {
        void Fly1();
    }
    interface ISwimming
    {
        void Swimming();
    }

    class Sparrow : Bird, IFly1 
    {
        public void Fly1()
        {
           
        }

        public override void Walk()
        {
            
        }
    }

    class Ostrich : Bird
    {
        public override void Walk()
        {
            
        }
    }
    class Penguin : Bird, ISwimming
    {
        public void Swimming()
        {
           
        }

        public override void Walk()
        {
            
        }
    }
    class Parrot : Bird,IFly1
    {
        public void Fly1()
        {

        }

        public override void Walk()
        {
            
        }
    }
    class Swan : Bird,ISwimming,IFly1
    {
        public void Fly1()
        {
            
        }

        public void Swimming()
        {
            
        }

        public override void Walk()
        {
            
        }
    }

    class Helicopter : IFly1
    {
        public void Fly1()
        {
           
        }
    }
    #endregion

    #region 练习题三
    //多态来模拟移动硬盘，u盘，MP3插到电脑上读取数据
    //移动硬盘与u盘都属于存储设备
    //MP3属于播放设备
    //但他们都能插在电脑上传输数据
    //电脑提供了一个USB接口
    //请实现电脑的传输数据功能

    interface IUSB
    {
        void ReadData();
    }
    class StorageDevice:IUSB
    {
        public string name;
        public StorageDevice(string name)
        {
            this.name = name;
        }

        public void ReadData()
        {
            Console.WriteLine("{0}传输数据",name);
        }
    }
    class MP3:IUSB
    {
        public void ReadData()
        {
            Console.WriteLine("电脑传输数据");
        }
    }

    class Computer
    {
        public IUSB usb;
    }


    #endregion

    class Program
    {
        static void Main(string[] rags)
        {
            
            Console.WriteLine("接口");
            //4.接口也遵循里氏替换原则
            IFly f = new Person();
            //接口不能实例化，但是可以像
            //里氏替换一样在new后面加上其他类的类名

            IMove im =new Test();
            IFly iF = new Test();
            IWalk iw = new Test();
            //Test既可以是IMove的子类，
            //也可以是IFly的子类，
            //还可以是IWalk的子类

            Player p = new Player();
            //在类里面继承了两个接口，
            //并且这两个接口都有Atk()行为，但行为的内容不相同
            //这个类里面又同时继承了两个接口的行为
            //用p.行为的方法时点不出来这个行为的因为重名了
            //当这个类里面本身有一个Atk()行为的话可以点出来
            (p as IAtk).Atk();
            (p as ISuperAtk).Atk();
            //可以用as转换成父类在点出这个方法

            IRegister[] arr = new IRegister[] { new Persons(), new Car(), new House() };
            arr[0].Register();
            arr[1].Register();
            arr[2].Register();

            StorageDevice hd = new StorageDevice("移动硬盘");
            StorageDevice uhd = new StorageDevice("u盘");
            MP3 mp3=new MP3();
            Computer computer = new Computer();

            //给computer类的usb赋值，模拟插入设备
            computer.usb = hd;
            computer.usb.ReadData();
            computer.usb = uhd;
            computer.usb.ReadData();
            computer.usb = mp3;
            computer.usb.ReadData();

        }
    }
    //总结：
    //继承类：是对象之间的继承，包括行为等等
    //继承接口：是行为之间的继承，继承接口的行为规范，按照规范去实现内容
    //由于接口也是遵循里氏替换原则，所以可以用接口容器装载对象
    //那么就可以实现 装载各种毫无关系但是却有用的相同行为的对象


    //注意：
    //1.接口只包含 成员方法、属性、索引器、事件、并且都不实现、没有修饰符
    //2.可以继承多个接口，但是只能继承一个类
    //3.接口可以继承接口，相当于在进行行为合并，待子类继承时再去实现具体行为
    //4.接口可以被显示实现 主要用于实现不同接口中的同名函数的不同表现
    //5.实现的接口方法 可以加 virtual关键字 之后的子类在重写
    
}
