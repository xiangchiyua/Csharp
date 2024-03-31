namespace homework5
{
    public class Order : IComparable
    {
        private string orderId;
        private float price;
        public Order() { orderId = "0";price = 0; }
        public Order(string orderId,float price) 
        {
            this.orderId = orderId;this.price = price;
        }
        public override bool Equals(object obj)
        {
            Order a = obj as Order;
            return this.orderId == a.orderId;
        }
        public string GetOrderId() { return orderId; }
        public float GetPrice() { return price; }
        public int CompareTo(object obj)
        {
            Order a = obj as Order;
            return this.orderId.CompareTo(a.orderId);
        }
    }
    
    public class OrderDetails : IComparable
    {
        private string orderId;
        private string commodityId;
        private string commodityName;
        private string custom;
        private float price;
        public OrderDetails(string orderId,string commodityId,string commodityName,
                            string custom,float price)
        {
            this.orderId=orderId;
            this.commodityId=commodityId;
            this.commodityName=commodityName;
            this.custom=custom;
            this.price=price;
        }
        public override bool Equals(object obj)
        {
            OrderDetails a = obj as OrderDetails;
            return this.orderId == a.orderId;
        }
        public string GetOrderId() { return orderId; }
        public string getCommodityName() { return commodityName; }
        public string getCustom() { return custom; }
        public float getPrice() { return price; }
        public int CompareTo(object obj)
        {
            OrderDetails a = obj as OrderDetails;
            return this.orderId.CompareTo(a.orderId);
        }
    }
    public class OrderService
    {
        List <Order> orderList=new List<Order>();
        List <OrderDetails> orderDetailsList=new List<OrderDetails>();
        public void SortOrder()
        {
            orderList.Sort(); orderDetailsList.Sort() ;
        }
        public void addOrder()
        {
            try
            {
                Console.WriteLine("请输入订单编号和金额");
                string orderId = Console.ReadLine();
                float price = float.Parse(Console.ReadLine());
                Order order = new Order(orderId, price);
                bool judge = true;
                foreach(Order m in this.orderList)
                {
                    if (m.Equals(orderId)) judge=false;
                    //if (m.Equals(orderId)) Console.WriteLine("有重复订单！");
                }
                if (!judge) Console.WriteLine("有重复订单！");
                else
                {
                    Console.WriteLine("请继续输入订单明细");
                    Console.WriteLine("请输入产品名称：");
                    string name = Console.ReadLine();
                    Console.WriteLine("请输入顾客名称：");
                    string custom = Console.ReadLine();
                    Console.WriteLine("请输入产品编号：");
                    string commodityId = Console.ReadLine();
                    OrderDetails details = new OrderDetails(orderId,commodityId,name,custom,price);
                    orderList.Add(order);
                    orderDetailsList.Add(details);
                    Console.WriteLine("添加成功！");
                }
            }
            catch
            {
                Console.WriteLine("输入错误！");
            }
        }
        
        public void removeOrder()
        {
            try
            {
                Console.WriteLine("请输入订单信息（订单号或者商品名称或者客户）");
                string orderInfo = Console.ReadLine();
                var orderSelect = from n in orderList
                                  join m in orderDetailsList on n.GetOrderId() equals m.GetOrderId()
                                  where n.GetOrderId() == orderInfo || m.getCustom() == orderInfo || m.getCommodityName() == orderInfo
                                  orderby m.getPrice()
                                  select n;
                foreach (var x in orderSelect)
                {
                    orderList.Remove(x);
                }
                var orderDetailsSelect = from n in orderDetailsList
                                  join m in orderList on n.GetOrderId() equals m.GetOrderId()
                                  where n.GetOrderId() == orderInfo || n.getCustom() == orderInfo || n.getCommodityName() == orderInfo
                                  orderby n.getPrice()
                                  select n;
                foreach (var x in orderDetailsSelect)
                {
                    orderDetailsList.Remove(x);
                }

            }
            catch
            {
                Console.WriteLine("输入的信息错误！");
            } 
        }
        public void Inquire()
        {
            try
            {
                Console.WriteLine("请选择你要查询的信息（输入1表示订单号，2表示顾客名称，3表示商品名称）");
                int index = Convert.ToInt32(Console.ReadLine());
                string orderInfo= Console.ReadLine();
                var search = from n in orderDetailsList
                             where n.GetOrderId() == orderInfo || n.getCustom() == orderInfo || n.getCommodityName() == orderInfo
                             orderby n.getPrice()
                             select n;
                foreach (var x in search)
                {
                    Console.WriteLine($"订单号{x.GetOrderId} 客户{x.getCustom} 商品名称{x.getCommodityName} 价格{x.getPrice}");
                }

            }
            catch
            {
                Console.WriteLine("查询失败！");
            }           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            bool state = true;
            while (state)
            {
                Console.WriteLine("输入1增加订单，输入2删除订单，输入3查询订单，输入4为订单排序,输入5退出");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1": service.addOrder(); break;
                    case "2": service.removeOrder(); break;
                    case "3": service.Inquire(); break;
                    case "4": service.SortOrder();break;
                    case "5": state = false; break;
                    default: Console.WriteLine("输入错误!"); break;
                }
            }
        }
    }
}
