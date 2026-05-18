using System;
using System.ComponentModel;

namespace class68_260607
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("链式存储和顺序存储");


            #region 知识点一 数据结构
            //数据结构
            //数据结构是计算机存储、组织数据的方式（规则）
            //数据结构是指相互之间存在一种或多种特定关系的数据元素的集合
            //比如自定义的一个 类 也可以称为一种数据结构 自己定义的数据组合规则

            //不要把数据结构想的太复杂
            //简单点理解，就是人定义的 存储数据 和 表示数据之间关系 的规则而已

            //常用的数据结构（前辈总结和制定的一些经典规则）
            //数组、栈、队列、链表、树、图、堆、散列表


            #endregion

            #region 知识点二 线性表
            //线性表是一种数据结构，是由n个具有相同特性的数据元素的有限序列
            //比如数组、ArrayList、Stack、Queue、链表等等


            #endregion

            #region 知识点三 顺序存储
            //数组、Stack、Queue、List、ArrayList —— 顺序存储
            //只是 数组、Stack、Queue的 组织规则不同而已
            //顺序存储:
            //用一组地址连续的存储单元依次存储线性表的各个数据元素

            #endregion

            #region 知识点四 链式存储
            //单项链表、双向链表、循环链表——链式存储
            //链式存储（链接存储）：
            //用一组任意的存储单元存储线性表中的各个数据的元素

            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            LinkedNode<int> node = list.head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }
            Console.WriteLine("*************");
            list.Remove(1);
            //每次遍历都要给头结点赋值个node
            node = list.head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }
            Console.WriteLine("*************");
            list.Add(99);
            node = list.head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }
            #endregion

            #region 知识点六 顺序存储和链式存储的优缺点
            //从增删查改的角度去思考
            //增: 链式存储 计算上 优于顺序存储  (中间插入时链式不用像顺序一样去移动位置)
            //删: 链式存储 计算上 优于顺序存储  (中间删除时链式不用像顺序一样去移动位置)
            //查: 顺序存储 使用上 优于链式存储  (数组可以直接通过下标得到元素, 链式需要遍历)
            //改: 顺序存储 使用上 优于链式存储  (数组可以直接通过下标得到元素, 链式需要遍历)
            #endregion

            #region 练习题二
            //描述链式存储和顺序存储的区别

            //链式储存：储存的地址是任意的，通过一个一个节点来链接起来
            //顺序存储：存储地址是连续的，通过存储单元线性表链接起来的

            #endregion

            #region 练习题三
            //请尝试自己实现一个双向链表
            //并提供以下方法和属性
            //数据的个数，头节点，尾节点
            //增加数据到链表最后
            //删除指定位置节点
            Console.WriteLine("****************");
            List<int> lists = new List<int>();
            lists.Add(1);
            lists.Add(2);
            lists.Add(3);
            lists.Add(4);
            lists.Add(5);
            lists.Add(6);
            //正向遍历
            ListNode<int> listNode = lists.Head;

            while (listNode != null)
            {
                Console.WriteLine(listNode.value);
                listNode = listNode.nextNode;
            }
            Console.WriteLine("****************");
            //反向遍历
            listNode = lists.Last;

            while (listNode != null)
            {
                Console.WriteLine(listNode.value);
                listNode = listNode.frontNode;
            }

            lists.Remove(0);
            Console.WriteLine("****************");
            //正向遍历
            listNode = lists.Head;

            while (listNode != null)
            {
                Console.WriteLine(listNode.value);
                listNode = listNode.nextNode;
            }

            Console.WriteLine("****************");
            //反向遍历
            listNode = lists.Last;

            while (listNode != null)
            {
                Console.WriteLine(listNode.value);
                listNode = listNode.frontNode;
            }

            #endregion



        }
    }

    #region 知识点五 自己实现一个简单的单向链表
    class LinkedNode<T>
    {
        public T value;
        //存储下一个元素
        public LinkedNode<T> nextNode;


        public LinkedNode(T value)
        {
            this.value = value;
        }

    }

    class LinkedList<T>
    {
        public LinkedNode<T> head;
        public LinkedNode<T> last;

        public void Add(T value)
        {
            LinkedNode<T> node = new LinkedNode<T>(value);
            if (head == null)
            {
                head = node;
                last = node;
            }
            else
            {
                last.nextNode = node;
                last = node;
            }

        }
        public void Remove(T value)
        {
            if (head == null)
            {
                return;
            }
            if (head.value.Equals(value))
            {
                head = head.nextNode;
                //如果头结点被移除了，变成空了
                //那么说明只有一个节点，此时尾结点也要变空
                if (head == null)
                {
                    last = null;
                }
                return;


            }
            LinkedNode<T> node = head;
            while (node.nextNode != null)
            {
                if (node.nextNode.value.Equals(value))
                {
                    //让当前找到的这个元素的 上一个节点
                    //指向 自己下一个节点
                    node.nextNode = node.nextNode.nextNode;
                    break;
                }
                node = node.nextNode;
            }
        }
    }




    #endregion


    #region 练习题三

    class ListNode<T>
    {
        public T value;
        public ListNode<T> frontNode;
        public ListNode<T> nextNode;

        public ListNode(T value)
        {
            this.value = value;
        }
    }
    class List<T>
    {
        private int count;
        private ListNode<T> head;
        private ListNode<T> last;

        public int Count
        {
            get 
            {
                return count;
            }
        }

        public ListNode<T> Head
        {
            get
            {
                return head;
            }
        }

        public ListNode<T> Last
        {
            get
            {
                return last;
            }
        }

        public void Add(T value)
        {
            ListNode<T> node = new ListNode<T>(value);
            if (head == null)
            {
                head = node;
                last = node;
            }
            else 
            {
                //添加到尾部
                last.nextNode = node;
                //再把添加出来的尾部节点记录上一个节点
                node.frontNode = last;




                //让刚才新加的节点作为最新的尾结点
                last = node;
            }
            ++count;
        }


        public void Remove(int index)
        {
            //判断是否越界
            if (index<0 || index >= count)
            {
                Console.WriteLine("只有{0}个节点,请输入合法的下标值",count);
                return;
            }
            int tempCount = 0;

            //创建一个指标节点，指向链表中的节点，用来遍历
            ListNode<T> node = head;
            while (true)
            {
                //找到对应节点位置，并且移除该节点
                if (tempCount == index)
                {
                    //把此节点的上一个节点的下一个节点（指向标志）指向此节点的下一个节点
                    //再把此节点的下一个节点的上一个节点（指向标志）指向此节点的上一个节点
                    if (node.frontNode != null)
                    {
                        node.frontNode.nextNode = node.nextNode;
                    }
                    if (node.nextNode != null)
                    {
                        node.nextNode.frontNode = node.frontNode;
                    }
                    //如果移除的是头结点，就给出一个新的头结点
                    if (index == 0)
                    {
                        head = head.nextNode;
                    }
                    //如果移除的是尾结点，接给出一个新的尾结点
                    else if (index == count - 1)
                    {
                        last = last.frontNode;
                    }
                    //移除一个元素就减少计数值
                    --count;
                    break;
                    

                }
                node = node.nextNode;
                ++tempCount;
            }
        }


    }



    #endregion


}
