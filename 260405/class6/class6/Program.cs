using System;

namespace class6
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("异常捕获");

            #region 作用
            //将玩家输入的内容存储到string类型中
            //string str = Console.ReadLine();
            //int i = int.Parse(str);
            //当输入不合法时这个就会出现报错卡死
            #endregion

            #region 基本语法
            //必备部分
            try
            {
                //希望异常捕获的代码块
                //如果在这里代码出错
                //不会让程序卡死
            }
            catch 
            {
                //如果出错了 会执行catch中的代码
                //来捕获异常
                //catch(Exception e)具体报错跟踪
                //通过e得到具体的错误信息
            }
            //可选部分
            finally
            {
                //最后执行的代码 不过有没有出错
                //都会执行这里的代码
            }


            #endregion

            #region 实践
            try
            {
                Console.WriteLine("请输入内容");
                string str2 = Console.ReadLine();
                int i2 = int.Parse(str2);
                Console.WriteLine(str2);
            }
            catch 
            {
                Console.WriteLine("请输入合法的数值");
            }
            #endregion

            #region 练习题一
            //请用户输入一个数字
            //如果输入有误，则提示用户输入有误
            try
            {
                Console.WriteLine("请输入一个数字");
                string str = Console.ReadLine();
                int i3 = int.Parse(str);
            }
            catch 
            {
                Console.WriteLine("\a输入错误，请输入合法的数字");

            }


            #endregion

            #region 练习题二
            //提示用户输入姓名 语文 数学 英语成绩
            //如果输入的成绩有无，则提示用户输入错误
            //否则将输入的字符串转换为整形变量存储
            try
            {
                Console.WriteLine("请输入你的姓名");
                string str = Console.ReadLine();
                Console.WriteLine("请输入你的语文成绩");
                int i4 = int.Parse(Console.ReadLine());
                Console.WriteLine("你的语文成绩是" + i4);
                Console.WriteLine("请输入你的数学成绩");
                int i5 = int.Parse(Console.ReadLine());
                Console.WriteLine("你的数学成绩是" + i5);
                Console.WriteLine("请输入你的英语成绩");
                int i6 = int.Parse(Console.ReadLine());
                Console.WriteLine("你的英语成绩是"+i6);
            }
            catch
            {
                Console.WriteLine("你输入的内容不合法，成绩必须是数字");
            }
            #endregion
        }
    }
}