using FoodOrderMenu.Models;
using FoodOrderMenu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderMenu
{
    public static class Global
    {
        public static orderModel orderList = new orderModel();
        public static OrderServices orderService = new OrderServices();
    }
}
