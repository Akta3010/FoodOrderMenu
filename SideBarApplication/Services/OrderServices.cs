using FoodOrderMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderMenu.Services
{
    public class OrderServices
    {
        Order orderForm = null;
        public OrderServices(Order form)
        {
            this.orderForm = form;
        }
        public OrderServices()
        {
        }
        internal void AddOrder(string foodItem)
        {
            itemModel newItem;

            if (Global.orderList.items == null || Global.orderList.items.FirstOrDefault(x => x.foodItem == foodItem) == null)
            {
                newItem = itemListModel.itemList.FirstOrDefault(x => x.foodItem == foodItem);
                newItem.count += 1;
                newItem.itemTotalCost = newItem.count * newItem.price;
                if (Global.orderList.items == null)
                    Global.orderList.items = new List<itemModel>();
                Global.orderList.items.Add(newItem);
            }
            else
            {
                newItem = Global.orderList.items.FirstOrDefault(x => x.foodItem == foodItem);
                newItem.count += 1;
                newItem.itemTotalCost = newItem.count * newItem.price;
            }

            orderForm.OrderUpdated();
        }

    }
}
