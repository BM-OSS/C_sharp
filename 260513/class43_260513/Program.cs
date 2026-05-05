using System;

namespace class43_260513
{
    #region 知识点一 内部类
    //概念
    //在一个类中再声明一个类
    //可以理解为类的嵌套


    //特点
    //使用时要用包裹者点出自己

    //作用
    //亲密关系的变现

    //注意
    //访问修饰符作用很大

    class Person
    {
        public int age;
        public string name;
        public Body body;
        public class Body//要在前面加上pblic才能被外面访问内部类
        {
            Arm leftArm;
            Arm rightArm;
            class Arm//Arm类没有加public就不能再访问这个内部类了
            { 

            }
        }


    }

    #endregion

    #region 知识点二 分部类
    //概念
    //把一个类分成几部分申明

    //关键字
    //partial

    //作用
    //分部描述一个类
    //增加程序的拓展性

    //注意
    //分部类可以写在多个脚本文件中
    //分部类的访问修饰符要一致
    //分部类中不能有重复成员

    partial class Student
    {
        public bool sex;
        public int age;
        partial void Speak();
        
    }
    partial class Student
    {
        public string name;
        public float height;
        partial void Speak()
        {

        }
        //public bool sex上一个分部类声明类这个成员变量，这个分部类就不能声明相同的了
    }
    //从感觉上好像是声明了两个类，
    //但实际上这是把一个类分开来声明了。
    //用起来和声明的一个类是一样的效果
    //public partial class Student修饰符一定要写在partial关键字的前面

    #endregion

    #region 知识点三 分部方法
    //概念
    //将方法的申明和实现分离
    //特点
    //1.不能加访问修饰符 默认为私有
    //2.只能在分部类中申明
    //3.返回值只能是viod
    //4.可以有参数但不能用 out关键字
    //分布方法局限性比较大，很少使用
    
    
    

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("内部类和分布类");

            Person p = new Person();
            
            Person.Body body = new Person.Body();


        }
    }
}