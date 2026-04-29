using System;

namespace calss32_260503
{

    #region 知识点一 什么是类
    //类是具有相同特征相同行为的一类事物的抽象
    //类是对象的模版可以通过类创建出对象
    //类的关键词————class
    //一般申明在namespace里面
    #endregion

    #region 知识点二 类的申明
    class number
    {
        //特征——成员变量
        //行为——成员方法
        //保护特征——成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员
    }


    #endregion

    #region 知识点三 申明实例
    //这个类是用来形容人类的
    //用帕斯卡命名法
    class Person
    {
        //特征——成员变量
        //行为——成员方法
        //保护特征——成员属性

        //构造函数和析构函数
        //索引器
        //运算符重载
        //静态成员




    }

    //用来表示机器类
    class Machine
    {
        
    }
    #endregion

    class GameObject
    {


    }   


    class Prgram
    {
        static void Main(string[] args)
        {
            #region 知识点四 什么是（类）对象
            //基本概念
            //类的申明和类对象的申明是两个概念
            //类的申明类似枚举和枚举，结构体的申明，相当于申明了一个变量类型
            //而对象是类创建出来的
            //相当于申明了一个指定类的变量
            //类创建对象的过程一般是称为实例对象
            //类对象 都是引用类型的

            #endregion

            #region 知识点五 实例化对象基本语法
            //类名 变量名；
            //类名 变量名= null；
            //类名 变量名= new 类名（）；


            #endregion

            #region 知识点六 实例化对象
            Person p;
            Person p2 = null;//null 代表空 不分配堆内存
            Person P3 = new Person();
            Person p4 = new Person();
            //虽然他们是来自一个类的实例化对象
            //但是他们是不同的对象
            //他们的地址不同，特征，行为等都是独立的

            //面向对象编程 就是通过类创建对象来使用的编程方式
            //面向对象编程的三大特征：封装，继承，多态
            #endregion

            #region 练习题一
            //将下面事物进行分类
            //机器人，机器，人，猫，张阿姨，隔壁老王，汽车，飞机，向日葵，菊花，太阳，星星，荷花
            //机器：机器人，汽车，飞机
            //人：人，张阿姨，隔壁老王
            //动物：猫
            //植物：向日葵，菊花，太阳，荷花
            //星球：星星


            #endregion

            #region 练习题二 
            GameObject A = new GameObject();
            GameObject B = A;
            B = null;
            //A目前等于多少？
            //A=GsmeObject();
            #endregion

            #region 练习题三
            //GameObject A = new GameObject();
            //GameObject B = A;
            //B = new GameObject();
            //A和B有什么关系？
            //A和B分别指向了两个不同的对象，他们的地址不相同
            #endregion

        }
    }
}