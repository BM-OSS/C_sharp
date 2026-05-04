using System;
using System.Reflection.Metadata;

namespace class41_260511
{
    #region 知识点一 拓展方法基本概念
    //概念
    //为现有非静态 变量类型 添加 新方法
    //作用
    //1.提升程序拓展性
    //2.不需要在对对象中重新写方法
    //3.不需要继承来添加方法
    //4.为别人封装的类型写额外的方法

    //特点
    //1.一定是写在静态类中
    //2.一定是一个静态函数
    //3.第一个参数拓展目标
    //4.第一个参数用this修饰

    #endregion


    #region 知识点二 基本语法
    //访问修饰符 static 返回值 函数名(this 拓展类名 参数名，参数类型 参数名，参数类型 参数名)


    #endregion

    #region 知识点三 实例
    static class Tool
    {
        //为int拓展了一个成员方法
        //成员方法 是需要 实例化对象后才能使用的
        //value 代表 使用该方法的 实例化对象
        public static void SpeakValue(this int value)
        {
            //拓展方法的逻辑
            Console.WriteLine("唐老狮为int拓展的方法"+value);
        }

        public static void SpeakValue(this string value)
        {
            Console.WriteLine("唐老狮为string拓展的方法是"+value);
        }
        
        public static void Fun3(this Test value)
        {
            Console.WriteLine("唐老狮为Test拓展的方法Fun3");  
        }


    }

    #endregion

    #region 知识点五 为自定义的类型拓展方法
    class Test
    {
        public int i = 10;
        
        public void Fun1()
        {
            Console.WriteLine("123");
        }
        public void Fun2()
        {
            Console.WriteLine("456");
        }

        

    }


    #endregion

    #region 练习题一
    //为整形拓展一个求平方的方法
    static class Tools
    {
        public static int Square(this int value)
        {


            return value*value;
        }
        public static void SelfKill(this Player player)
        {
            Console.WriteLine("玩家"+player.name+"对自己使用了自杀");
        }
    }

    #endregion

    #region 练习题二
    //写一个玩家类，包含姓名，血量，攻击力，防御力等特征，攻击，移动，受伤等方法
    //为该玩家类拓展一个自杀的方法

    class Player
    {
        public string name;
        public int hp;
        public int atk;
        public int def;


        public void Atk()
        {

        }
        public void Def()
        {

        }

        public void Move()
        {

        }

        public void Hart()
        {
            
        }



    }


    #endregion

    class Program
    {
        static void Main()
        {
            Console.WriteLine("拓展方法");

            #region 知识点四 使用
            int i = 10;
            i.SpeakValue();

            string s = "string的新方法";
            s.SpeakValue();

            Test t = new Test();
            t.Fun3();


            Console.WriteLine("练习题一");

            int i2 = 10;
            Console.WriteLine(i2.Square());
            #endregion

            Console.WriteLine("练习题二");
            Player Player = new Player();
            Player.name = "小红果";
            Player.SelfKill();

        }
    }
    //总结：
    //概念：为现有的非静态 变量类型 添加 方法
    //作用：
    // 提升程序拓展性
    // 不需要在对象中重新写方法
    // 不需要继承来添加方法
    // 为别人封装的类型写额外的方法
    
    //特点：
    //静态类中的静态方法
    //第一个参数 代表拓展的目标
    //第一个参数前面一定要this
    
    //注意：
    //可以有返回值 其中的参数不限
    //假如拓展的方法和原方法名相同的话不会报错，
    //但调用时是有限调用原来的方法
    
}


