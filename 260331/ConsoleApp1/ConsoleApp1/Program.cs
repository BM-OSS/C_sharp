//练习题一
//1. 6个杯子排成一排，右边的3杯有水，左边的3杯没有水，只移动一个杯子，让有水的和没水的杯子完全间隔，该怎么移动？
//2. 一个粗细均匀的长直管子，两端开口，里面有4个白球和4个黑球，球的直径等于管子的内径，现在白球和黑球的排列是WWWWBBBB，要求不取出任何一个球，使得排列变为BBWWWWBB，应该如何操作？



//1. 将从左到右第5杯水倒入第二杯水里面。
//2. 将管子首位相连，把最右边的2两个黑球晃动到左边，再将管子分离开，形成BBWWWWBB。


//练习题二
//1. 怎样种4棵树使得任意两颗数的距离相等？
//2. 有两根不均匀分布的香，香烧完的时间是1个小时，你能用什么方法来确定一段15分钟的使使时间？


//1. 将4棵树放在正四面体的4个顶点上。
//2. 将第一根香的两端点燃，同时点燃第二根香的一端点燃，在第一根香燃完后将第二根香的另一端点燃。

//知识点1：理解写代码
//类似于写作文，写代码也是一种表达方式。我们需要清晰地表达我们的想法，让别人能够理解我们的代码。我们可以通过注释来解释我们的代码，或者使用有意义的变量名来让代码更易读（程序代码之间的相互调用，这个过程是API）。


//知识点2：注释
//对代码的解释说明，便于自己和他人理解代码。
//注释的类型：单行注释（//）和多行注释（/* */）3杠注释（///）。


//知识点3：程序文件的基础结构
//大括号包裹的部分称为语句块，不同的语句块中书写的代码规则不一样
namespace lesson1_第一个应用程序
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine();在控制台打印信息
            //打印结束后自动换行
            //在双引号“”中的内容会被当作字符串处理，既可以是中文也可以是英文
            Console.WriteLine("HelloWorld!");

            //Console.Write();与Console.WriteLine();类似
            //但打印后不换行
            Console.Write("Hello_World!");
            Console.Write("I_like_C#");
            //检测玩家输入的内容
            //等待输入完毕后按下回车键，才会执行后面的代码
            Console.WriteLine("\n请输入信息");

            Console.ReadLine();

            Console.WriteLine("输入完毕");

            Console.WriteLine("请再次输入内容");


            //检测玩家按键，只要按下任意键就结束
            Console.ReadKey();
            DoExercise3_2();
            DoExercise3_3();
        }



        //习题三
        //1.请简述Console.WriteLine()和Console.Write()的区别
        //简单描述Console.Readkey()和 Console.ReadLine()的区别



        //2.请输入用户名、年龄、班级




        //3.问用户喜欢什么运动，不管用户输入什么，
        //你都回答：“哈哈，好巧，我也喜欢这个运动”

        //1.Console.WriteLine()会在输出结束后自动换行
        //Console.Write()不会自动换行
        //Console.Readkey()在用户按下任意一个键后就会
        //结束执行下一个内容
        //Console.ReadLine()会在用户输入内容完成并且
        //按下回车键后才会执行下一个内容


        //2. 
        static void DoExercise3_2()
        {
            Console.WriteLine("\n请输入用户名");
            Console.ReadLine();
            Console.WriteLine("请输入年龄");
            Console.ReadLine();
            Console.WriteLine("请输入班级");
            Console.ReadLine();
        }


        //3.
        static void DoExercise3_3()
        {
            Console.WriteLine("你喜欢什么运动");
            Console.ReadLine();
            Console.WriteLine("哈哈，好巧，我也喜欢这个运动");
        }




    }

}