using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Models {
  public class Goods {
    public string Id { get; set; }
    public string Name { get; set; }
        private float price;
        public float Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("error");
                price = value;
            }
        }

        public Goods() {
      Id = Guid.NewGuid().ToString();
    }

    public Goods(string name, float price):this() {
      Name = name;
      Price = price;
    }

    public override bool Equals(object obj) {
      var goods = obj as Goods;
      return goods != null &&
             Id == goods.Id &&
             Name == goods.Name;
    }
    public override string ToString()
    {
       return $"Id:{Id}, Name:{Name}, Value:{Price}";
    }


    }


}
