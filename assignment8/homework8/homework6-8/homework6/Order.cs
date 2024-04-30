using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderApp {

    /**
     **/
    public class Order : IComparable<Order> {

       // private readonly List<OrderDetail> details = new List<OrderDetail>();

        public string Id { get; set; }

        public Customer Customer { get; set; }

        public DateTime CreateTime { get; set; }
        public List<OrderDetail> Details { get; set; }

        public float TotalPrice => Details.Sum(d => d.TotalPrice);

        //public List<OrderDetail> Details => details;

        public Order()
        {
            Id = Guid.NewGuid().ToString();
            Details = new List<OrderDetail>();
            CreateTime = DateTime.Now;
        }

        public Order(int orderId, Customer customer,DateTime createTime) {
            Id = Convert.ToString(orderId);
            Customer = customer;
            CreateTime = DateTime.Now;
        }

        public void AddDetails(OrderDetail orderDetail) {
            if (Details.Contains(orderDetail)) {
                throw new ApplicationException($"The goods ({orderDetail.Goods.Name}) exist in order {Id}");
            }
            Details.Add(orderDetail);
        }

        public int CompareTo(Order other) {
            return (other == null)?1: Convert.ToInt32(Id) - Convert.ToInt32(other.Id);
        }

        public override bool Equals(object obj) {
            var order = obj as Order;
            return order != null && Id == order.Id;
        }

        public override int GetHashCode() {
            return Id.GetHashCode();
        }

        public void RemoveDetails(int num) {
            Details.RemoveAt(num);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{Id}, customer:{Customer},orderTime:{CreateTime},totalPrice：{TotalPrice}");
            Details.ForEach(od => strBuilder.Append("\n\t" + od));
            return strBuilder.ToString();
        }
        private void AddNewOrder(Order order)
        {
            
        }

    }
}
