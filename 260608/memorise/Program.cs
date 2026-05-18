using System;

namespace memorise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型栈和队列");

            #region 知识点一 回顾数据容器

            #region 变量
            //无符号
            //byte ushort uint ulong
            //有符号
            //sbyte short int long
            //浮点数
            //float double decimal
            //特殊
            //char bool string
            #endregion


            #region 复杂数据容器
            //枚举 enum
            //结构体 struct
            //数组（一维、二维、交错） []  [,]  [][]
            //类
            #endregion

            #region 数据集合
            //using System.Collections;

            //ArrayList    object数据列表
            //Stack  栈   先进后出
            //Queue  队列  先进先出
            //Hashtable    哈希表  键值对
            #endregion


            #region 泛型数据集合
            //using System.Collections.Generic;

            //List      列表   泛型列表
            //Dictionary 字典  泛型哈希表
            //LinkedList 双向链表
            //Stack<T>   泛型栈
            //Queue<T>   泛型队列
            #endregion





            #endregion

            #region 知识点二 泛型栈和队列
            //命名空间: using System.Collections.Generic;
            //使用上 和之前的Stack和Queue一模一样

            Stack<int> stack = new Stack<int>();
            Queue<int> qeue = new Queue<int>();



            #endregion


            #region 练习题
            //自己总结一下
            //数组、List、Dictionary、Stack、Queue、LinkedList
            //这些存储容器，对于我们来说应该如何选择他们来使用

            #region 答案
            //普通线性表:
            //数组, List, LinkedList
            //数组: 固定的不变的一组数据
            //List: 经常改变, 经常通过下标查找
            //LinkedList: 不确定长度的, 经常临时插入改变, 查找不多

            //先进后出:
            //Stack
            //对于一些可以利用先进后出存储特点的逻辑
            //比如: UI面板显隐规则

            //先进先出:
            //Queue
            //对于一些可以利用先进先出存储特点的逻辑
            //比如: 消息队列, 有了就往里放, 然后慢慢依次处理

            //键值对:
            //Dictionary
            //需要频繁查找的, 有对应关系的数据
            //比如一些数据存储  id对应数据内容
            //道具ID —> 道具信息
            //怪物ID —> 怪物对象
            //等等

            #endregion

            #endregion

        }
    }
}