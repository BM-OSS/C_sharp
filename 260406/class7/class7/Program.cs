using System;
using System.Security.Cryptography;

namespace class7
{
    class Program
    {
        static void Main(string[] regs)
        {
            Console.WriteLine("算数运算符");
            //算数运算符 适用于 数值类型变量计算的运算符
            //它的返回结果是数值
            #region 知识点一 赋值符号
            //=
            //先看右侧，再看左侧 把右侧的值赋值给左侧的变量
            string myName = "贝母";
            int i = 99;

            #endregion

            #region 知识点二 算数运算符

            #region 加 +
            //用自己计算 先算右侧结果 在赋值给左侧变量
            int i1 = 1;
            i1 = i1 + 2;
            Console.WriteLine(i1);
            //连续运算 先算右侧结果 在赋值给左侧变量
            i1 = 1 + 2 + 3 + i1;
            Console.WriteLine(i1);

            //初始化时就运算 先算右侧结果 再赋值给左侧变量
            int i2 = 1 + 2 + 3 + i1;
            Console.WriteLine(i2);
            #endregion

            #region 减 -
            //用自己计算 先算右侧结果 再赋值给左侧变量
            int j = 1;
            j = j - 1;
            Console.WriteLine(j);
            //连续运算 先算右侧结果 再赋值给左侧变量
            j = 1 - 2 - 3;
            Console.WriteLine(j);
            //初始化时就运算 先算右侧结果 再赋值给左侧变量
            int j2 = 1 - j - 0;
            Console.WriteLine(j2);
            #endregion

            #region 乘 *
            //用自己计算 先算结果 再赋值给左侧变量
            int c = 1;
            c = c * 2;
            Console.WriteLine(c);
            //连续运算 先算右侧结果 在赋值给左侧变量
            c = 1 * 2 * 3;
            Console.WriteLine(c);
            c = 2 * c * 3;
            Console.WriteLine(c);
            //初始化时就运算 先算右侧结果 再赋值给左侧变量
            int c2 = 2 * c * 2;
            Console.WriteLine(c2);
            #endregion

            #region 除 /
            //用自己计算 先算右侧结果 再赋值给左侧变量
            int chu = 1;
            chu = 10 / chu;
            Console.WriteLine(chu);
            //连续运算 先算右侧的结果 再赋值给左侧变量
            //初始化时就运算，先算右侧结果 再赋值给左侧变量
            //与前面的加，减，乘类似
            chu = 1;
            chu = 1 / 2;
            Console.WriteLine(chu);
            //由于用整数进行除法运算 会丢失小数部分
            //所以想要用浮点数存储计算结果
            //在运算时就应该有浮点数的特征
            float f = 1 / 2f;
            Console.WriteLine(f);


            #endregion

            #region 取余 %
            //用自己计算 先计算结果 再赋值
            int y = 1;
            y = y % 2;
            Console.WriteLine(y);
            //其他性质和加，减，乘，除类似

            #endregion
            #endregion

            #region 知识点三 算数运算符的优先级
            //先算乘除取余 在算加减
            int a = 1 + 2 + 3 * 5 - 6 + 8 / 5 + 9;
            Console.WriteLine(a);
            //括号可以改变优先级 先算括号里面的内容 再按原来的顺序
            a = 1+ 2 % 3 * (5 - 6) + 8 / 5 + 9;
            Console.WriteLine(a);
            //多组括号时 先算括号里面的 再算外面的
            a = 1 + 2 % ((3 * (5 - 6)) + 8 )/ 5 + 9;
            Console.WriteLine(a);
            #endregion

            #region 知识点四 算数运算符的复合运算符
            //固定写法 运算符=
            //+= -= *= /= %=
            //计算方法和C语言里面的对应复合运算方式一致
            int i3 = 1;
            i3 = i3 + 2;
            Console.WriteLine(i3);
            i3 = 1;
            i3 += 2;
            Console.WriteLine(i3);
            //上面这两种方式是相同的效果

            #endregion

            #region 知识点五 算数运算符的自增减
            //与C语言中的i++和++i一样
            //i++先用再加
            //++i先加再用
            int i4 = 1;
            Console.WriteLine(i4++);
            Console.WriteLine(++i4);
            //自减是一样的效果
            //和C语言里面的i--和--i一样
            #endregion

            #region 练习题一
            //定义一个变量储存你的年龄 
            //十年后你的年龄是多少？
            //在控制台上打印出来
            Console.WriteLine("练习题一");
            int myAge = 18;
            Console.WriteLine("现在我的年龄是"+myAge);
            myAge += 10;
            Console.WriteLine("十年后我的年龄是" + myAge);
            #endregion

            #region 练习题二
            //计算一个半径为5的圆的面积和周长
            Console.WriteLine("练习题二");
            float r = 5;
            float PI = 3.1415926f;
            float S = PI * r * r;
            float C = PI * 2 * r;
            Console.WriteLine("圆的面积是"+S);
            Console.WriteLine("圆的周长是"+C);




            #endregion

            #region 练习题三
            //计算任意三门成绩的总分，平均分并打印到控制台上
            //三门成绩为整形（C# 88，Unity 89，Math 92）
            Console.WriteLine("练习题三");
            int C_Sharp = 88;
            int Unity = 89;
            int Math = 92;
            Console.WriteLine("C#成绩为"+C_Sharp);
            Console.WriteLine("Unity成绩为" + Unity);
            Console.WriteLine("Math成绩为" + Math);
            int sum = C_Sharp + Unity + Math;
            float avg = sum / 3f;
            Console.WriteLine("总分为"+sum);
            Console.WriteLine("平均分为"+avg);

            #endregion

            #region 练习题四
            //商店T恤价格为285元/件，裤子价格为720元/件
            //小李在该商店买了2件T恤和3条裤子，
            //请计算小李该付多少钱？打3.8折后呢？
            Console.WriteLine("练习题四");
            int T_xu = 285;
            int kuZi = 720;
            int sum2 = T_xu * 2 + kuZi * 3;
            float sum3 = sum2 * 0.38f;
            Console.WriteLine("总价为"+sum2);
            Console.WriteLine("打3.8折后价格为"+sum3);
            #endregion

            #region 练习题五
            Console.WriteLine("练习题五");

            //说明以下number1，number2
            //number3的结果
            int a1 = 10, b1 = 20;
            int number1 = ++a1 + b1;
            //  number1 =  11  + 20
            //    31
            Console.WriteLine(number1);

            a1 = 10;
            b1 = 20;
            int number2 = a1 + b1++;
            //  number2 = 10 +  20
            //     30
            Console.WriteLine(number2);

            a1 = 10;
            b1 = 20;
            int number3 = a1++ + ++b1 + a1++;
            //  number3 =  10  +   21 +  11
            //    42
            Console.WriteLine(number3);
            #endregion

            #region 练习题六
            //有两个数a=99,b=87
            //请写出a=87,b=99
            Console.WriteLine("练习题六");
            int a2 = 99,b2=87;
            int temp;
            Console.WriteLine("交换前a2 "+ a2);
            Console.WriteLine("交换前b2 "+ b2);
            //申明中间变量交换
            temp = a2;
            a2 = b2;
            b2 = temp;
            
            Console.WriteLine("交换后a2 "+ a2);
            Console.WriteLine("交换后b2 "+ b2);
            //只用算数运算法
            Console.WriteLine("只用计算交换");
            a2 = 99;
            b2 = 87;
            Console.WriteLine("交换前a2 " + a2);
            Console.WriteLine("交换前b2 " + b2);
            a2 = a2 + b2;
            Console.WriteLine("第一次运算a2 " + a2);
            Console.WriteLine("第一次运算b2 " + b2);
            b2 = a2 - b2;
            Console.WriteLine("第二次运算a2 " + a2);
            Console.WriteLine("第二次运算b2 " + b2);
            a2 = a2 - b2;
            Console.WriteLine("第三次运算a2 "+ a2);
            Console.WriteLine("第三次运算b2 "+ b2);
            #endregion

            #region 练习题七
            //请把987652秒通过代码转换为n天n小时
            //n分n秒显示在控制台上
            Console.WriteLine("练习题六");
            int oneDayS = 24 * 60 * 60;
            int oneHourS = 60 * 60;
            int oneMinuteS = 60;

            int day = 987652 / oneDayS;
            int hour = 987652 % oneDayS / oneHourS;
            int minute = 987652 % oneHourS / oneMinuteS;
            int s = 987652 % oneMinuteS % 60;
            Console.WriteLine("987652对应的时间是"+day+"天"+ hour + "小时" + minute + "分"+s+"秒");

            #endregion
        }
    }
}
