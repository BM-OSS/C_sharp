using System;

namespace class10
{
    class Pragram
    {
        static void Main(string[] rags)
        {
            Console.WriteLine("逻辑运算符");
            //对bool类型 进行逻辑运算

            #region 知识点一 逻辑与
            //符号 &&
            //规则 对两个bool值进行逻辑运算 有假则假 同真为真

            bool result = true && false;
            Console.WriteLine(result);
            result = true && true;
            Console.WriteLine(result);
            result = false && true;
            Console.WriteLine(result);

            //bool相关的类型 bool变量 条件运算符
            //逻辑运算符优先级低于 条件运算符 再低于算数运算符
            //true && true
            result = 3 > 1 && 1 < 2;
            Console.WriteLine(result);

            int i = 3;
            //1<i<5;
            //true && true
            result = 1 < i && i < 5;
            Console.WriteLine(result);
            //多个逻辑与 组合运用
            int i2 = 5;
            result = i2 > 1 && i2 < 5 && i > 1 && i < 5;
            //result= true  &&   false &&  true &&   true
            Console.WriteLine(result);



            #endregion

            #region 知识点二 逻辑或
            //符号 ||
            //规则 对两个bool值进行逻辑运算 有真则真 同假为假
            Console.WriteLine("********************");
            result = true || false;
            Console.WriteLine(result);
            result = true || true;
            Console.WriteLine(result);
            result = false || true;
            Console.WriteLine(result);
            result = false || false;
            Console.WriteLine(result);

            result = 3 > 10 || 3 < 5;
            // false||true
            Console.WriteLine(result);

            int a = 5;
            int b = 11;
            result = a > 1 || b < 20 || a > 5;
            // true||true||false
            Console.WriteLine(result);
            // ?&&?
            // ?||?
            // ?可以是写死的bool变量 或则bool值
            //还可以是条件运算符相关

            #endregion

            #region 知识点三 逻辑非
            //符号 !
            //规则 对一个bool值进行取反 真变假 假变真
            result = !true;
            Console.WriteLine(result);
            result = !false;
            Console.WriteLine (result);
            result = !!true;
            Console.WriteLine(result);
            result = !(3 > 2);
            Console.WriteLine(result);

            a = 5;
            result = !(a > 5);
            Console.WriteLine(result);
            #endregion

            #region 知识点四 混合使用优先级问题
            //规则 !(逻辑非)优先级最高 &&（逻辑与）优先级高于||（逻辑或）
            //逻辑运算符优先级低于算数运算符再低于条件运算符（逻辑非除外）


            #endregion

            #region 知识点五 逻辑运算符的短路规则
            //与C语言里面一样再||运算里面左边为真
            //右边的算式就不计算了
            //同理&&左边为假，右边就不计算了
            int i3 = 5;
            result = i3 > 0 || ++i3 < 5;
            Console.WriteLine(result);
            Console.WriteLine(i3);
            //同理的&&短路原则一样的
            #endregion

            #region 练习题一
            //求以下打印结果
            Console.WriteLine("练习题一");
            Console.WriteLine(true || true);//true
            Console.WriteLine(false || true);//true
            Console.WriteLine(true && true);//true
            Console.WriteLine(true && false);//false
            Console.WriteLine(!true);//false



            #endregion

            #region 练习题二
            //求打印结果
            Console.WriteLine("练习题二");
            bool gameOver;
            bool isWin;
            int health = 100;
            gameOver = true;
            isWin = false;
            Console.WriteLine(gameOver || isWin && health > 0);
            //                  ture || false && true
            //                          true
            #endregion
        }
    }
}
