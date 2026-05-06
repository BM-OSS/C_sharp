using System;

namespace class50_260520
{
    #region 知识点一 抽象类
    //概念
    //被抽象关键字abstract修饰的类

    //特点：
    //1.不能被实例化的类
    //2.可以包含抽象方法
    //3.继承抽象类必须重写

    abstract class Thing
    {
        //抽象类中 封装的所有知识点都可以在其中书写
        public string name;

        //可以在抽象类中写抽象函数


    }

    class Water : Thing
    {
        


    }


    #endregion

    #region 知识点二 抽象函数
    //抽象函数 又叫 纯虚方法 
    //用 abstract关键字修饰的方法

    //特点：
    //1.只能在抽象类中申明
    //2.没有方法体
    //也就是说不能加{}，也不能在括号里面写东西
    //就申明一下变量就行了
    //3.不能是私有的
    //4.继承后必须实现 用override重写

    abstract class Fruits
    {

        public string name;

        //抽象方法 是一定不能有函数体的
        public abstract void Bad();

        public virtual void Test()
        { 

        }
    }
    class Apple : Fruits
    {

        public override void Bad()
        {
            //这句话，是没有什么作用的，
            //书写逻辑的话我们把这句话删除掉接着写就行
            throw new NotImplementedException();
        }
        public override void Test()
        {
            base.Test();
        }
        //在子类中虚方法时可以由我们的子类选则性类实现的
        
        //抽象方法必须要实现
        //但是在继承的子类的子类里面抽象方法不需要去实现
    }

    class SuperApple : Apple
    {
        public override void Test()
        {
            base.Test();
        }
        
    }

    #endregion


    #region 练习题一
    //写一个动物抽象类 写三个子类
    //人叫，狗叫，猫叫

    abstract class Animal
    {
        public abstract void Speak();
        
    }
    class Person : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("你好");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("汪汪");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("喵喵");
        }
    }

    #endregion
    #region 练习题二
    //创建一个图形类，有求面积和周长两个方法
    //创建矩形类，正方形类，圆形类继承图形类
    //实例化矩形，正方形，圆形对象求面积和周长


    abstract class Graph
    {
        public abstract float GetLength();

        public abstract float GetArea();
        
    }

    class Rect : Graph
    {
        public float w;
        public float h;
        public Rect(float w, float h)
        {
            this.w = w;
            this.h = h;
        }
        public override float GetLength()
        {
            return 2 * (w + h);
        }
        public override float GetArea()
        {
            return w * h;
        }
    }

    class Square : Graph
    {
        public float l;
        public Square(float l)
        {
            this.l = l;

        }
        public override float GetLength()
        {
            return 4 * l;
        }
        public override float GetArea()
        {
            return l * l;
        }
    }

    class Circular : Graph
    {
        public float r;
        const float PI = 3.14f;
        public Circular(float r)
        {
            this.r = r;

        }
        public override float GetLength()
        {
            return PI * r * 2;
        }
        public override float GetArea()
        {
            return PI * r * r;
        }
    }


    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("抽象类和抽象方法");
            
            //抽象不能被实例化
            //如下new出来时要报错的
            //Thing t=new Thing();
            //但是可以遵循里氏替换原则，用父类装子类
            Thing t = new Water();

            Console.WriteLine("练习题一");
            Animal p=new Person();
            p.Speak();
            Dog d = new Dog();
            d.Speak();
            Animal c = new Cat();
            c.Speak();

            Console.WriteLine("练习题二");
            Rect r = new Rect(5, 7);
            Console.WriteLine("矩形的周长是" + r.GetLength());
            Console.WriteLine("矩形的面积是" + r.GetArea());


            Square s1 = new Square(5.5f);
            Console.WriteLine("正方形的周长是" + s1.GetLength());
            Console.WriteLine("正方形的面积是" + s1.GetArea());



            Circular c1 = new Circular(6.6f);
            Console.WriteLine("圆的周长是" + c1.GetLength());
            Console.WriteLine("圆的面积是" + c1.GetArea());

        }
    }
    //总结
    //抽象类 被abstract修饰的类 不能被实例化 可以包含抽象方法
    //抽象方法 没有方法的纯虚方法 继承后必须去实现的方法
    //注意：
    //如何选择普通类还是抽象类
    //不希望被实例化的对象，相对比较抽象的类可以使用抽象类
    //父类中的行为不太需要被实现的，只希望子类去定义具体的规则的 可以选择 抽象类然后使用其中的抽象方法类定义规则
    //作用：
    //整体框架设计时 会使用

}