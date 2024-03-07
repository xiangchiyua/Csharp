namespace homework2_4
{
    internal class Program
    {
        public int[,] InputRec()
        {
            Console.WriteLine("请输入矩阵的m、n");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] rec = new int[m,n];
            Console.WriteLine("请输入矩阵内容");
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rec[i,j]= int.Parse(Console.ReadLine());
                }
            }
            //Console.WriteLine("矩阵维度"+rec.Rank);
            return rec;
        }
        public bool Judge(int [,]arr)
        {
            bool ans=true;
            int i = 0;int j;
            while (i < arr.GetLength(0)-1)
            {
                int temp = i;
                j = 0;
                while (j < (arr.GetLength(1))-1&&i < (arr.GetLength(0))-1)
                {
                    if (arr[i,j] != arr[i+1,j+1])
                    {
                        ans = false;break;
                    }
                    i++;j++;
                }
                i = temp + 1;
            }
            j = 0;
            while (j < arr.GetLength(1) - 1)
            {
                int temp = j;
                i = 0;
                while (i < arr.GetLength(0) - 1 && j < arr.GetLength(1) - 1)
                {
                    if (arr[i,j] != arr[i+1,j+1])
                    {
                        ans = false; break;
                    }
                    i++;j++;
                }
                j = temp + 1;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            var sol = new Program();
            Console.WriteLine(sol.Judge(sol.InputRec()));
        }
    }
}
