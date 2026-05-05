using System;
using System.Net.Cache;
using System.Security;



namespace class44_260514
{
    #region 知识点一 基本概念
    //一个类A继承一个类B
    //类A将会继承类B的所有成员
    //A类将拥有B类的所有特征和行为

    //被继承的类
    //称为 父类，基类，超类

    //继承的类
    //称为子类，派生类

    //子类可以有自己的特征和行为

    //特点
    //1.单根性 子类只能有一个父类
    //2.传递性 子类可以间接继承父类的父类
    #endregion


    #region 知识点二 基本语法
    //class 类名：被继承的类名
    //{
    //
    //
    //}


    #endregion


    #region 知识点三 实例
    class Teacher
    {
        //姓名
        public string name;
        //职工号
        public int number;

        protected int age;
        //介绍名字
        public void SpeakName(string name)
        {
            this.name = name;
            age = 20;
            Console.WriteLine(name);
        }
    }
    class TeachingTeacher : Teacher 
    {
        //科目

        public string subject;

        //public string name;这种写法会隐藏父类的成员
        public new string name;//这种写法会把父类的同名成员覆盖掉

        //科目老师
        public void SpeakSubject(string subject)
        {
            age = 23;
            Console.WriteLine(subject+"老师");
        }


    }

    class ChineseTeacher : TeachingTeacher
    {
        public void Skill()
        {
            Console.WriteLine("一行白鹭上青天");
        }
    }


    #endregion
    #region 知识点四 访问修饰符的影响
    //public -公共的 内外部都可以访问
    //private -私有的 内部访问(使用时外部和子类都不能访问，如果想要子类可以访问就可以使用protect修饰符)
    //protect -保护的 内部和子类访问(一般在继承的时候开始使用)
    //内部和子类都可以使用，外不是无法使用的
    //internal -内部的 只有在同一个程序的文件夹中，内部类型或者是成员才可以访问



    #endregion

    #region 知识点五 子类和父类的同名成员
    //概念
    //C#中允许子类存在父类同名的成员
    //但是 及不建议使用





    #endregion

    #region 练习题一
    //写一个人类，人类中有姓名，年龄属性，有说话行为
    //战士类继承人类，有攻击行为

    class Warrior : Person 
    {
        
        public void AtkActon(Warrior otherWarrior)
        {
            
            Console.WriteLine("{0}攻击了{1}",Name,otherWarrior.Name);
        }
    }
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        private int Age
        {
            get;
            set;
        }
        public void SpeakAction()
        {
            Age = 30;
            Console.WriteLine("我是{0}，我今年{1}岁",Name,Age);
        }
    }


    #endregion

    class Progrm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承的基本规则");

            TeachingTeacher tt = new TeachingTeacher();
            tt.SpeakName("唐老狮");
            tt.SpeakSubject("语文");

            ChineseTeacher ct = new ChineseTeacher();
            ct.name = "唐老狮";
            ct.number = 3;
            ct.subject = "语文";
            ct.SpeakName(ct.name);
            ct.SpeakSubject("Unity");
            ct.Skill();

            Console.WriteLine("练习题一");
            Warrior w1= new Warrior();
            w1.Name = "唐老狮";
            Warrior w2 = new Warrior();
            w2.Name = "奥特曼";
            w1.AtkActon(w2);
            w1.SpeakAction();//把父类的成员改为private子类不可以直接使用，但是可以间接的使用，
                             //如像现在这样在继承的方法里面调用
        }
    }
}
