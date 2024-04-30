using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp {

  /**
   **/
  public class OrderDetail {

        public string Id { get; set; }
        public Goods Goods { get; set; }


    public int Quantity { get; set; }

    public float TotalPrice {
      get => Goods.Price * Quantity;
    }


    public string getGoodName()
        {
            return Goods.Name;
        }
        public string getGoodId()
        {
            return Goods.Id;
        }

    public OrderDetail(Goods goods, int quantity) {
      this.Goods = goods;
      this.Quantity = quantity;
    }
        public OrderDetail()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override bool Equals(object obj) {
      var detail = obj as OrderDetail;
      return detail != null &&
             EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
    }

    public override int GetHashCode() {
      return 785010553 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
    }

    public override string ToString() {
      return $"OrderDetail:{Goods},{Quantity}";
    }
    
    }
}
