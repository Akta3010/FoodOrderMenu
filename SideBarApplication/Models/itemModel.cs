using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderMenu.Models
{
    public class itemModel
    {
        public string foodFamily { get; set; }
        public string foodItem { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public int itemTotalCost { get; set; }
       
        public itemModel(string foodFamily, string foodItem, int count, int price)
        {
            this.foodFamily = foodFamily;
            this.foodItem = foodItem;
            this.count = count;
            this.price = price;
        }
    }
}
