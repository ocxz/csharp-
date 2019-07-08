using System;

namespace demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region   卡西西自述
            //string name = "卡卡西";
            //int age = 30;
            //string email = "卡卡西@qq.com";
            //string address = "火影村";
            //decimal solary = 5000m;
            //Console.WriteLine("我叫" + name + "，我住在" + address + "。我今年" + age + "岁了" + "，我的邮箱是" + email + "，工资有" + solary + "块钱一个月。");
            //Console.WriteLine("我叫{0},我住在{1}。我今年{2}岁了,我的邮箱是{3},我每个月的工资是:{4}。", name, address, age, email, solary);
            //Console.ReadKey();
            #endregion

            #region 变量重新赋值
            //int age = 18;
            //age = 81;
            //Console.WriteLine("原来你都" + age + "岁了呀！！！");
            //Console.WriteLine("原来你都{0}岁了呀!!!",age);
            //Console.ReadKey();
            #endregion

            #region 占位符
            //int num1 = 10;
            //int num2 = 20;
            //int num3 = 30;
            //int num4 = 40;
            //Console.WriteLine("第一个数字是:" + num1 + ",第二个数字是:" + num2 + ",第三个数字是:" + num3);
            //Console.WriteLine("第一个数字是:{0},第二个数字是:{1},第三个数字是:{2}", num1, num2, num3);
            //Console.WriteLine("第一个数字是:{0},第二个数字是:{1},第三个数字是:{2}", num1, num2, num3, num4);
            //Console.WriteLine("第一个数字是:{0},第二个数字是:{1},第三个数字是:{2}", num1, num2);
            //Console.WriteLine("第一个数字是:{2},第二个数字是:{1},第三个数字是:{0}", num1, num2,num3);
            //Console.ReadKey();
            #endregion

            #region 占位符练习,打印个人信息

            //string name = "张三";
            //string sex = "男";
            //int age = 18;
            //string telephoneNumber = "18375812805";
            //Console.WriteLine("我叫{0},我今年{1}岁了,我是{2}生,我的电话是{3}", name, age, sex, telephoneNumber);
            //Console.ReadKey();

            #endregion

            #region 交换值,借助第三方变量

            int n1 = 580;
            int n2 = 950;

            Console.WriteLine("n1的值为:{0},n2的值为:{1}", n1, n2);
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            //Console.WriteLine("n1的值为:{0},n2的值为:{1}", n1, n2);
            SwapNum(n1, n2);
            #endregion
        }

        #region SwapNum(int n1, int n2)函数用来换两个int类型的值,要求不使用第三方变量,利用数学计算凑出来
        public static void SwapNum(int n1, int n2)
        {
            n1 = n1 - n2;  // -10
            n2 = n1 + n2;  // 20
            n1 = n2 - n1;   // 30
            Console.WriteLine("n1的值为:{0},n2的值为:{1}", n1, n2);
            Console.ReadKey();
        }
        #endregion
    }


}
 