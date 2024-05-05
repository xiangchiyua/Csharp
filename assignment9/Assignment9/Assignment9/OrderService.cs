using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Assignment9.Models {

    public class OrderService {

        OrderDbContext DbCon;

        public OrderService(OrderDbContext dbContext) {
            this.DbCon = dbContext;
        }

        public List<Order> GetAllOrders() {
            return DbCon.Orders
                .Include(o => o.Details)
                .ThenInclude(d => d.GoodsItem)
                .Include(o => o.Customer)
                .ToList<Order>();
        }
        public void SortOrder()
        {
            //orders.Sort();
        }
       /* public Order GetById(int orderId)
        {
            using (var ctx = new OrderContext())
            {
                return ctx.Orders
                  .Include(o => o.Details.Select(d => d.Goods))
                  .Include(o => o.Customer)
                  .SingleOrDefault(o => o.Id == Convert.ToString(orderId));
            }
            //return orders.FirstOrDefault(o => o.Id == orderId);
        }*/
        public Order GetOrder(string id) {
            return DbCon.Orders
                .Include(o => o.Details.Select(d => d.GoodsItem))
                .Include(o => o.Customer)
                .SingleOrDefault(o => o.OrderId == id);
        }

        public void AddOrder(Order order) {
            FixOrder(order);
            DbCon.Entry(order).State = EntityState.Added;
            DbCon.SaveChanges();
        }

        public void RemoveOrder(string orderId) {
            var order = DbCon.Orders
                .Include(o => o.Details)
                .SingleOrDefault(o => o.OrderId == orderId);
            if (order == null) return;
            DbCon.OrderDetails.RemoveRange(order.Details);
            DbCon.Orders.Remove(order);
            DbCon.SaveChanges();
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName) {
            var query = DbCon.Orders
                .Include(o => o.Details)
                .ThenInclude(d => d.GoodsItem)
                .Include(o=> o.Customer)
                .Where(order => order.Details.Any(item => item.GoodsItem.Name == goodsName));
            return query.ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName) {
            return DbCon.Orders
                .Include(o => o.Details)
                .ThenInclude(d => d.GoodsItem)
                .Include("Customer")
              .Where(order => order.Customer.Name == customerName)
              .ToList();
        }

        public void UpdateOrder(Order newOrder) {
            RemoveOrder(newOrder.OrderId);
            AddOrder(newOrder);
        }

        //避免级联添加或修改Customer和Goods
        private static void FixOrder(Order newOrder) {
            if (newOrder.Customer != null) {
                newOrder.CustomerId = newOrder.Customer.Id;
            }
            newOrder.Customer = null;
            newOrder.Details.ForEach(d => {
                if (d.GoodsItem != null) {
                    d.GoodsId = d.GoodsItem.Id;
                }
                d.GoodsItem = null;
            });
        }



        public object QueryByTotalAmount(float amout) {
            return DbCon.Orders.Include(o => o.Details).ThenInclude(d => d.GoodsItem).Include("Customer")
            .Where(order => order.Details.Sum(d => d.Quantity * d.GoodsItem.Price) > amout)
            .ToList();
        }
        /*public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            //return orders.Where(o => condition(o)).OrderBy(o => o.TotalPrice);
        }**/
    }
}
