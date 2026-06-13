using System;
using System.Collections;
namespace class60_260530
{
    #region 练习题二
    //创建一个背包管理类，使用ArrayList存储物品，
    //实现购买物品、卖出物品、显示物品的功能。购买与卖出物品会导致金钱变化

    class BagMar
    {
        //背包管理类
        private ArrayList items;

        private int money;

        public BagMar(int money)
        {
            this.money = money;
            items = new ArrayList();
        }

        public void BuyItem(Item item)
        {
            if (item.num <= 0 || item.money < 0)
            {
                Console.WriteLine("请传入正确的物品信息");
            }

            if (this.money < item.money)
            {
                //钱不够
                Console.WriteLine("资金不足，请先充值");
                return;
            }
            this.money -= item.money * item.num;
            Console.WriteLine("购买{0}{1}个花费{2}钱",item.name,item.num,item.money*item.num);
            Console.WriteLine("剩余{0}元钱",this.money);
            //如果想要叠加物品的话，
            //就要在加入前判断是否有这个物品，
            //然后在加数量
            for (int i = 0; i < items.Count; i++)
            {
                if ((items[i] as Item).id == item.id)
                {
                    //叠加数量
                    (items[i] as Item).num += item.num;
                    return;
                }
            }
            //把一组物品加到 list中
            items.Add(item);
        }
        public void SellItem(Item item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                //如何判断 卖的东西我没有
                //这是在判断两个引用地址 指向的是不是同一个房间
                //一般是用id来判断
                if ((items[i] as Item).id==item.id)
                {
                    int num = 0;
                    string name = (items[i] as Item).name;
                    int money = (items[i] as Item).money;
                    //分两种情况
                    //1.比我身上少
                    if ((items[i] as Item).num > item.num)
                    {
                        num = item.num;
                    }
                    //2.比我身上多
                    else 
                    {
                        num = (items[i] as Item).num;
                        items.RemoveAt(i);
                    }

                    int sellMoney= (int)(num * money * 0.8f);
                    this.money += sellMoney;

                    Console.WriteLine("卖了{0}{1}个，赚了{2}钱", name, num,sellMoney);
                    Console.WriteLine("目前拥有{0}元钱",this.money);
                }
            }
        }
        public void SellItem(int id,int num=1)
        {
            //直接复用上面的代码
            Item item = new Item(id,num);
            
            SellItem(item);
        }

        public void ShowItem()
        {
            Item item;
            for (int i = 0; i < items.Count; i++)
            {
                item = items[i] as Item;
                Console.WriteLine("有{0}{1}个",item.name,item.num);
            }
            Console.WriteLine("当前拥有{0}钱",this.money);
        }
    }
    class Item
    {
        //给物品写一个单独的ID
        public int id;
        //物品的价值
        public int money;//单个物品的价值
        //物品的名字
        public string name;

        //物品数量
        public int num;
        public Item(int id, int money, string name, int num)
        {
            this.id = id;
            this.money = money;
            this.num = num;
            this.name = name;
        }
        public Item(int id,int num)
        {
            this.id=id;
            this.num=num;
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数据结构——Arralist");

            #region 知识点一 ArratList的本质
            //ArratList是一个C#封装好的类，
            //他的本质是一个，object类型的数组，
            //ArrayList类帮助我们实现了很多方法，
            //比如数组的增删查改
            #endregion

            #region 知识点二 申明
            //需要引用命名空间，System.Collections;
            ArrayList array = new ArrayList();
            #endregion

            #region 知识点三 增删查改

            #region 增
            //万物之父的类，可以存储任何的变量
            array.Add(1);
            array.Add("12346");
            array.Add(true);
            array.Add(true);
            array.Add(false);
            array.Add(true);
            ArrayList array2 = new ArrayList();
            array2.Add(123);
            //这种写法是给增加一个范围类，
            //把另一个容器里面的内容依次增加进去
            array.AddRange(array2);


            //在固定的位置中插入的元素

            array.Insert(1,12234567);
            Console.WriteLine(array[1]);
            #endregion

            #region 删
            //删除这个数组中的元素，
            //则里面的逻辑就是依次按值遍历，删除第一个相同的元素
            array.Remove(1);
            //删除这个数组中对应下标的元素
            //这里是按照下标遍历的
            array.RemoveAt(1);
            //清空数组
            //array.Clear();

            #endregion

            #region 查
            //得到指定位置的元素
            Console.WriteLine(array[0]);

            //查看元素是否存在
            if (array.Contains(123))
            {
                Console.WriteLine("存在123");
            }

            //正向查找元素位置
            //找到的返回值 是下标位置 找不到 返回是-1
            int index = array.IndexOf(true);
            Console.WriteLine(index);

            Console.WriteLine(array.IndexOf(false));

            //反向查找元素位置
            index = array.LastIndexOf(true);
            Console.WriteLine(index);

            #endregion

            #region 改
            Console.WriteLine(array[0]);
            array[0] = "999";
            Console.WriteLine(array[0]);


            #endregion

            #endregion


            #region 遍历
            //长度,代表的是元素的个数
            Console.WriteLine(array.Count);
            //容量
            Console.WriteLine(array.Capacity);
            Console.WriteLine();
            //for循环遍历
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }

            //迭代器遍历
            foreach (Object item in array)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 知识点四 装箱，拆箱
            //ArrayList本质上是一个可以自动扩容的object数组，
            //由于用万物之父来存储数据，自然存在装箱拆箱。
            //当往其中进行值类型存储时就是在装箱，当将值类型对象取出来转换使用时，就存在拆箱。
            //所以ArrayList尽量少用，之后我们会学习更好的数据容器。



            #endregion
            #region 练习题
            
            BagMar bag = new BagMar(9999);
            Item i1 = new Item(1,10,"红药",10);
            Item i2 = new Item(2, 20, "蓝药", 10);
            Item i3 = new Item(3, 999, "屠龙刀", 1);

            bag.BuyItem(i1);
            bag.BuyItem(i2);
            bag.BuyItem(i3);

            bag.SellItem(i3);
            bag.SellItem(1, 1);
            bag.SellItem(1, 1);
            bag.SellItem(1, 1);
            bag.SellItem(2, 1);
            bag.SellItem(2, 1);
            #endregion
        }
    }
}
