namespace homework2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数据");
            int data = int.Parse(Console.ReadLine());
            int temp = 2;int[] rec = new int[100];int j = 1;
            while (data >= temp)
            {
                if (data % temp == 0)
                {
                    data /= temp;
                    if (rec[j - 1] != temp) { rec[j] = temp; j++; }
                }
                else if (data == temp)
                {
                    rec[j] = temp;j++;
                }
                else 
                {
                    temp++;
                }   
            }
            for(int i = 1; i < 20; i++)
            {
                if (rec[i]!=0) Console.Write(rec[i] + " ");
            }
        }
    }
}
