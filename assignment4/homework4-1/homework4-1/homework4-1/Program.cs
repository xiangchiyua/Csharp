namespace homework4_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { set; get; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            Node <T>n=new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(GenericList<T> list,Action<T> action)
        {
            if(action==null) throw new ArgumentNullException("action");
            Node<T> current = head;
            while(current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                intlist.Add(i);
            }

            Action<int> action1 = (m=>Console.WriteLine(m));
            intlist.ForEach(intlist,action1);
            int sum = 0;
            intlist.ForEach(intlist, m=>sum+=m);
            Console.WriteLine($"sum={sum}");

        }
    }
}
