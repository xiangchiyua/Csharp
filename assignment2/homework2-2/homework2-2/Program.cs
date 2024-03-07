using System.ComponentModel.DataAnnotations;

namespace homework2_2
{
    internal class Program
    {

        public int Max(int[] a)
        {
            int max = 0;
            for(int i=0;i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                else continue;
            }
            return max;
        }
        public int Min(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min) min = a[i];
                else continue;
            }
            return min;
        }
        public int Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }
        public int Ave(int[] a)
        {
            int sum = 0;int ave=0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            ave = sum / a.Length;
            return ave;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字的个数以及各个数字");
            int len = int.Parse(Console.ReadLine());
            int[] a; a = new int[len];
            for (int i = 0; i < len; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            var sol = new Program();
            Console.WriteLine("最大值是" + sol.Max(a));
            Console.WriteLine("最小值是" + sol.Min(a));
            Console.WriteLine("总和是" + sol.Sum(a));
            Console.WriteLine("平均值是" + sol.Ave(a));
        }

    }
}
