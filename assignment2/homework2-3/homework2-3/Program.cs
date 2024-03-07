namespace homework2_3
{
    internal class Program
    {
        /*public int Max(int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                else continue;
            }
            return max;
        }*/
        /*public int[] InitArr(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 2;
            }
            return arr;
        }*/
        public int [] Screen()
        {
            int temp = 2;
            int[] arr = new int[101];
            arr[0] = 1; arr[1] = 1;
            while (temp <= 10)
            {
                for(int i = 0; i < 101; i++)
                {
                    if (i % temp == 0 && i != temp) arr[i] = 1;
                }
                temp++;
            }
            
            return arr;
        }
        public void PrintNum(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 1)
                {
                    Console.Write(i+" ");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] ans = new int[99];
            int[] arr = new int[99];
            var sol = new Program();
            sol.PrintNum(sol.Screen());
        }
    }
}
