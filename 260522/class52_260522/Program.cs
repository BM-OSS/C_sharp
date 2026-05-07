using System;

namespace class52_260522
{

    #region 知识点一 密封方法的概念
    //用密封关键字sealed 修饰的重写函数
    //作用：让虚方法或则抽象方法之后不能再被重写
    //特点：和override一起出现

    #endregion

    #region 知识点二 实例
    abstract class Animal
    {
        public string name;

        public abstract void Eat();
        public virtual void Speak()
        {
            Console.WriteLine("说话");
        }
    }

    class Person : Animal
    {
        //public后面加上sealed后后面的继承类不能再继承重写这个函数
        //不写sealed则可以继承重写这个函数
        //public sealed override void Eat()
        //{
           
        //}
        public  override void Eat()
        {

        }
        public override void Speak()
        {
            base.Speak();
        }
    }

    class WhitePerson : Person
    {
        public override void Eat() 
        { 
        }
        
    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封方法");
        }
    }
}