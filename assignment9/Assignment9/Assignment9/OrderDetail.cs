using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models {

    /**
     **/
    public class OrderDetail {

        public string Id { get; set; }

        public int Index { get; set; } //序号

        public string GoodsId { get; set; }

        [ForeignKey("GoodsId")]
        public Goods GoodsItem { get; set; }

        public String GoodsName { get => GoodsItem != null ? this.GoodsItem.Name : ""; }


        public string OrderId { get; set; }

        public int Quantity { get; set; }

        public OrderDetail() {
            Id = Guid.NewGuid().ToString();
        }

        public OrderDetail(int index, Goods goods, int quantity) {
            this.Index = index;
            this.GoodsItem = goods;
            this.Quantity = quantity;
        }

        public double TotalPrice {
            get => GoodsItem == null ? 0.0 : GoodsItem.Price * Quantity;
        }

        public override string ToString() {
            return $"[No.:{Index},goods:{GoodsName},quantity:{Quantity},totalPrice:{TotalPrice}]";
        }

        public override bool Equals(object obj) {
            var item = obj as OrderDetail;
            return item != null &&
                   GoodsName == item.GoodsName;
        }

        
    }
}
