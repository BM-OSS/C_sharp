using System;

namespace class42_260512
{
    #region 知识点一 基本概念
    //概念
    //让自定义类和结构体
    //能够使用运算符


    //使用关键字 operator

    //特点：
    //1.一定是一个公共的静态方法
    //2.返回值写在operator前
    //3.逻辑处理自定义

    //作用：
    //让定义类和结构体对象可以进行运算

    //注意：
    //1.条件运算符需要成对实现
    //2.一个符号可以多个重载
    //3.不能使用ref和out



    #endregion

    #region 知识点二 基本语法
    //public static 返回类型 operator 运算符（参数列表）

    #endregion

    #region 知识点三 实例

    class Point
    {
        public int x;
        public int y;

        //必须有一个参数的类型是和重载的类的类型是相同的
        //例如下面重载的两个运算符
        public static Point operator +(Point p1, Point p2)
        {
            Point p=new Point();
            p.x=p1.x+p2.x;
            p.y=p1.y+p2.y;
            return p;
        }
        public static Point operator +(Point p,int value)
        {
            
            p.x = p.x + value;
            p.y = p.y + value;
            return p;
        }
        //运算符重载和函数重载类似，
        //即使参数类型的顺序改变也会变成新的重载运算符

        #region 知识点五 可重载和不可重载的运算符
       
        
        
        #region 可以重载的算数运输符

        #region 算数运输符 
        //注意：符号需要两个参数还是一个参数
        public static Point operator -(Point p1, Point p2)
        {
            return null;
        }

        public static Point operator *(Point p1, Point p2)
        {
            return null;
        }

        public static Point operator /(Point p1, Point p2)
        {
            return null;
        }
        #endregion

        #region 逻辑运算符
        //注意：符号需要连个参数还是一个参数
        public static bool operator !(Point p)
        {
            return false;
        }

        //逻辑或和逻辑与是不允许运算符重载的

        #endregion

        #region 位运算符
        //注意：参数个数问题
        public static Point operator |(Point p1, Point p2)
        {
            return null;
        }

        public static Point operator &(Point p1, Point p2)
        {
            return null;
        }

        public static Point operator ^(Point p1, Point p2)
        {
            return null;
        }

        public static Point operator ~(Point p1)
        {
            return null;
        }

        public static Point operator >>(Point p1, Point num)
        {
            return null;
        }
        public static Point operator <<(Point p1, Point num)
        {
            return null;
        }
        #endregion

        #region 条件运算符
        //1.返回值一般是bool值类型，也可以是其他的类型
        //2.相关符号必须配对实现
        //例如给>用了运算符重载，就得给<也用运算符重载
        public static bool operator >(Point p1, Point p2)
        {
            return false;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return false;
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return false;
        }

        public static bool operator <=(Point p1, Point p2)
        {
            return false;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return false;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return false;
        }
        #endregion

        #endregion


        #region 不可重载运算符
        //逻辑与(&&)和逻辑或(||)
        //索引符[]
        //强转运算符()
        //特殊运算符
        //点(.)三目运算符(?:)赋值符(=)
        


        #endregion

        #endregion
    }

    #endregion


    #region 练习题一
    //定义一个位置结构体或类，为其重载判断是否相等的运算符
    //(x1,y1)==(x2,y2) -> 两个值相同时才为true

    struct Position
    {
        public int x;
        public int y;

        public static bool operator ==(Position p1, Position p2)
        {
            if(p1.x==p2.x&&p1.y==p2.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Position p1, Position p2)
        {
            if (p1.x != p2.x || p1.y != p2.y)
            {
                return true;
            }
            return false;
        }
    }



    #endregion

    #region 练习题二
    //定义一个Vector3类(x,y,z)通过重载运算符实现以下运算
    //(x1,y1,z1)+(x2,y2,z2)=(x1+x2,y1+y2,z1+z2)
    //(x1,y1,z1)-(x2,y2,z2)=(x1-x2,y1-y2,z1-z2)
    //(x1,y1,z1)*num=(x1*num,y1*num,z1*num)
    class Vector3
    {
        public int x;
        public int y;
        public int z;

        public Vector3(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector3 operator *(Vector3 v1, int value)
        {
            return new Vector3(v1.x * value, v1.y * value, v1.z * value);
        }

    }


    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符重载");
            
            #region 知识点四 使用

            Point p1=new Point();
            p1.x = 1;
            p1.y = 2;
            Point p2= new Point();
            p2.x = 3;
            p2.y = 3;
            Point p3 = p1 + p2;
            Console.WriteLine("p3的横坐标是{0}，纵坐标是{1}",p3.x,p3.y);


            int value = 5;
            Point p4 = new Point();
            p4.x = 3;
            p4.y = 5;
            Console.WriteLine("p4的横坐标增加前是{0}，纵坐标增加前是{1}", p4.x, p4.y);
            p4 = p4 + value;
            Console.WriteLine("p4的横坐标增加后是{0}，纵坐标增加后是{1}", p4.x, p4.y);

            Console.WriteLine("练习题一");
            Position p5 = new Position();
            Position p6 = new Position();

            p5.x = 6;
            p5.y = 6;

            p6.x = 3;
            p6.y = 6; 

            Console.WriteLine("当它为true及为相等，为false时为不等,现在是{0}的情况",(p5==p6)?"相等":"不相等");

            Console.WriteLine("练习题二");
            Vector3 v1 = new Vector3(2, 5, 9);
            Vector3 v2 = new Vector3(3, 9, 5);
            Vector3 v3 = v1 + v2;
            Console.WriteLine("相加后({0},{1},{2})",v3.x,v3.y,v3.z);
            v3 = v1 - v2;
            
            Console.WriteLine("相减后({0},{1},{2})", v3.x, v3.y, v3.z);
            v3 = v1 * 7;
            //v3*=10;
            //这种写法是合理的因重载运算符后类的运算和变量的运算就类似了
            Console.WriteLine("相乘后({0},{1},{2})", v3.x, v3.y, v3.z);

            #endregion
        }
    }
}