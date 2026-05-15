using System;
using System.Collections;

namespace class62_260601
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Queue");
            #region 知识点一 队列的本质
            //Queue是一个C#为我们封装好的类
            //它的本质也是object[]数组，只是封装了特殊的存储规则

            //Queue是队列存储容器
            //队列是一种先进先出的数据结构
            //先存入的数据先获取，后存入的数据后获取
            //先进先出
            #endregion

            #region 知识点二 申明
            //和栈一样要引用相同的引用空间
            Queue queue = new Queue();


            #endregion

            #region 增取查改
            //增
            queue.Enqueue(1);
            queue.Enqueue(1234);
            queue.Enqueue(false);
            queue.Enqueue(235.5f);
            queue.Enqueue(1.4f);
            //取
            //和队列一样先进先出
            object v = queue.Dequeue();
            Console.WriteLine(v);
            v = queue.Dequeue();
            Console.WriteLine(v);

            //查
            //1.查看队列头部元素但不会移除
            v= queue.Peek();
            Console.WriteLine(v);
            v= queue.Dequeue();
            Console.WriteLine(v);

            //2.查看元素是存在
            if (queue.Contains(1.4f))
            {
                Console.WriteLine("存在1.4f");
            }

            //改
            //和栈一样
            //用clear（）方法清楚




            #endregion

            #region 知识点四 遍历
            //1.长度
            Console.WriteLine(queue.Count);
            //2.用foreach遍历
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            //3.和栈一样，用object数转换后再用
            //for循环遍历

            //4.循环出列
            while (queue.Count>0)
            {
                object o = queue.Dequeue();
                Console.WriteLine(o);
            }

            #endregion
            #region 练习题
            //使用队列存储消息，一次性存10条消息，每隔一段时间打印一条消息
            //控制台打印消息时要有明显停顿感

            Queue queue1 = new Queue();

            queue1.Enqueue("获得99金币");
            queue1.Enqueue("获得96金币");
            queue1.Enqueue("获得药瓶");
            queue1.Enqueue("获得屠龙刀");
            queue1.Enqueue("获得99金币");
            queue1.Enqueue("获得99金币");
            queue1.Enqueue("获得99金币");
            queue1.Enqueue("获得99金币");

            int Update = 500000000;
            while (queue1.Count>0)
            {
                if (Update <= 0)
                {
                    Console.WriteLine(queue1.Dequeue());
                    Update = 500000000;
                }
                --Update;
            }



            #endregion

        }
    }
}
