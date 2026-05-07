//引用空间MyGame和System


using System;
using HeGame.UI;
using HeGame.Game;
using MyGame;


#region 知识点一 命名空间的基本概念
//概念
//命名空间是用来组织和重用代码的
//作用
//就像是一个工具包，类就像是一件一件工具，都是申明在命名空间的


#endregion


#region 知识点二 命名空间的使用
//基本语法
//namespace 命名空间名
//{
//
//
//}
namespace MyGame
{
    class GameObject
    {
        
    }
        
        
}
//命名空间和分部类一样可以写多个，但里面的类不能相同
//可以理解成分部命名空间
namespace MyGame
{
    class Players:GameObject
    {

    }
}

#endregion

#region 知识点四 不同命名空间中允许有同名类
namespace YouGame
{
    //正如现在YouGame和MyGame里面都有GameObject类，
    //但是现在不会报错，
    //但在其他命名空间里面要用GameObject
    //就要和刚才知识点三一样，用指明出处的方式来使用

    class GameObject
    {
        
    }
}



#endregion
#region 知识点五 命名空间可以包裹命名空间
namespace HeGame
{
    //有点类似与工具包里面的小工具包一样
    //就像一个大工具包里面还有一个专门装载螺丝钉的小工具包
    namespace UI
    {
        class Image
        {

        }
    }
    namespace Game
    { 
        class Image
        {

        }
    }


}




#endregion

#region 知识点六 关于修饰符的类访问修饰符
//public——命名空间中的类，默认为public
//internal——只能在该程序集中使用，就是在这一个文件中使用
//abstract——抽象类
//sealed——密封类
//partial——分部类






#endregion

#region 练习题一
//请说明关键字using有什么用
//using 是用来引用命名空间的


#endregion



namespace class53_260523
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间");

            #region 知识点三 不同的命名空间中相互使用 需要引用命名空间或者指明出处

            //直接在另一个空间中用GameObject是不行的，除非在外面引用一个
            //用using 引用GameObject这个类的空间才行
            //using MyGame；
            GameObject go = new GameObject();
            //第二个方法就是指明出处用MyGame.GameObject也是可以的
            MyGame.GameObject ga = new MyGame.GameObject();
            YouGame.GameObject yga=new YouGame.GameObject();
            HeGame.Game.Image tm1= new HeGame.Game.Image();
            HeGame.UI.Image tm2=new HeGame.UI.Image();

            #endregion

        }
    }
    
}


