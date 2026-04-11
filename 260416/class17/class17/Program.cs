using System;

namespace class17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("控制台相关");
            #region 知识点一 复习 输入输出输出
            Console.WriteLine("12345");
            Console.Write("123123123");
            //输入
            string str = Console.ReadLine();
            //如果在ReadKey里面加上（true）
            //不会把输入的内容显示
            char c = Console.ReadKey(true).KeyChar;
            Console.WriteLine("*********");
            Console.WriteLine(c);

            #endregion

            #region 知识点二 控制台其他方法
            //1.清空
            //Console.Clear();
            //2.设置控制台大小
            //窗口大小 缓冲区大小
            //注意
            //1.先设置窗口大小，在设置缓冲区大小
            //2.缓冲区的大小不能小于窗口的大小
            //3.窗口的大小不能大于控制台的最大尺寸
            //窗口打小
            Console.SetWindowSize(100, 50);
            //缓冲区大小
            Console.SetBufferSize(1000, 1000);

            //3.设置光标的位置
            //控制台左上角位原点（0.0）右侧是x轴的正方向
            //下侧是y轴的正方向
            //注意：
            //1.边界问题
            //2.横纵单位距离不同1y=2x（视觉上的）
            Console.SetCursorPosition(5, 3);
            //第一个值改变x轴上的位置，第二个值改变y轴上的位置
            Console.WriteLine("1234");
            //4.设置颜色相关
            //文字颜色设置
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("123123");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("123123");

            //背景颜色设置
            Console.BackgroundColor = ConsoleColor.White;
            //重置背颜色后，需要Clear一次才能把整个背景颜色改变
            //Console.Clear();

            //5.光标显隐
            //Console.CursorVisible = false;

            //6.关闭控制台
            //Environment.Exit(0);
            #endregion


        }
    }
}