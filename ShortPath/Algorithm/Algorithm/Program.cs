using System;

namespace Algorithm
{
    /* 首先，bx2k在对话框中输入了一个表情，接下来，他可以进行三种操作。
第一种，是全选复制，把所有表情全选然后复制到剪贴板中。
第二种，是粘贴，把剪贴板中的表情粘贴到对话框中。
第三种，是退格，把对话框中的最后一个表情删去。
假设当前对话框中的表情数是num0，剪贴板中的表情数是num1，
那么第一种操作就是num1=num0
第二种操作就是num0+=num1
第三种操作就是num0--
现在bx2k想知道，如果要得到n(1<=n<=10^6)个表情，最少需要几次操作。
请你设计一个程序帮助bx2k水群吧*/
    class Program
    {
        static void Main(string[] args)
        {
            int targerNum = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcuCount(targerNum - 1).ToString());//去除输入第一个表情的操作数。
            Console.ReadLine();
        }

        static int CalcuCount(int targetNum)
        {
            Console.WriteLine("tagetNum:" + targetNum);
            int count = 0;
            if (targetNum < 6)
            {
                count += targetNum;
            }
            else
            {
                if (targetNum % 2 > 0)//若是奇数
                {
                    count += 3;
                    count += CalcuCount((targetNum - 1) / 2);
                }
                else
                {
                    count += 2;
                    count += CalcuCount(targetNum / 2);
                }
            }
            Console.WriteLine("count:" + count);
            return count;
        }
    }
}
