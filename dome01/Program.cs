using System;

namespace dome01
{
    class Program
    {
        static void Main(string[] args)

        {
            #region  没用但是不想删除
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
            Console.ReadKey();


            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
            Console.ReadKey();


            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            #endregion



        }

        /// <summary>
        /// 这个方法的作用就是求两个整数的最大值
        /// </summary>
        /// <param name="i1">第一个整数</param>
        /// <param name="i2">第二个整数</param>
        /// <returns>返回的最大值</returns>
        public static int GetMax(int i1, int i2)
        {
            return i1 > i2 ? i1 : i2;
        }
    }


    /// <summary>
    /// 这个类用来描述一个人的信息，从名字性别
    /// </summary>
    public class Person
    {
        public String Name
        {
            get;
            set;
        }

        public String sex
        {
            get;
            set;
        }
    }
}
