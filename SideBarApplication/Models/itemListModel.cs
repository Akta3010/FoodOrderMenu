using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderMenu.Models
{
    public class itemListModel
    {
        public static List<itemModel> itemList = new List<itemModel>();
        public itemListModel()
        {
            itemList.Add(new itemModel("Pizza", "Margherita", 0,199));
            itemList.Add(new itemModel("Pizza", "Neapolitan", 0, 309));
            itemList.Add(new itemModel("Pizza", "Fresh Veggi", 0, 309));
            itemList.Add(new itemModel("Pizza", "Italian", 0, 399));
            itemList.Add(new itemModel("Pizza", "Peppy Paneer", 0, 399));
            itemList.Add(new itemModel("Pizza", "Veggie Paradise", 0, 399));
            itemList.Add(new itemModel("Pizza", "Cheese n Corn", 0, 399));
            itemList.Add(new itemModel("Pizza", "Farmhouse", 0, 459));
            itemList.Add(new itemModel("Pizza", "Achari Do Pyaza", 0, 459));
            itemList.Add(new itemModel("Pizza", "Paneer Makhani", 0, 499));
            itemList.Add(new itemModel("Pizza", "Veg Extravaganza", 0, 499));

            itemList.Add(new itemModel("Burger", "Crispy Veg Burger", 0, 49));
            itemList.Add(new itemModel("Burger", "Crispy Veg Double Patty", 0, 69));
            itemList.Add(new itemModel("Burger", "Fresh Veggi", 0, 79));
            itemList.Add(new itemModel("Burger", "Veg Juicy", 0, 79));
            itemList.Add(new itemModel("Burger", "Veg Schezwan", 0, 99));
            itemList.Add(new itemModel("Burger", "Veg Masala", 0, 99));
            itemList.Add(new itemModel("Burger", "Veg Crispy", 0, 99));

            itemList.Add(new itemModel("Pasta", "Cheese Sauce", 0, 199));
            itemList.Add(new itemModel("Pasta", "Arabiata", 0, 199));
            itemList.Add(new itemModel("Pasta", "Creamy Pesto", 0, 309));
            itemList.Add(new itemModel("Pasta", "Aglie -e -olio", 0, 399));
            itemList.Add(new itemModel("Pasta", "Mix Sauce", 0, 499));
            itemList.Add(new itemModel("Pasta", "Bolognese", 0, 499));
            itemList.Add(new itemModel("Pasta", "Mac & Cheese", 0, 599));

            itemList.Add(new itemModel("Snacks", "Baked Fries", 0, 159));
            itemList.Add(new itemModel("Snacks", "French Fries", 0, 159));
            itemList.Add(new itemModel("Snacks", "Potato Wedges", 0, 179));
            itemList.Add(new itemModel("Snacks", "Nachos with Salsa", 0, 179));
            itemList.Add(new itemModel("Snacks", "Mexican Veg Enchilada", 0, 209));
            itemList.Add(new itemModel("Snacks", "Potato Jalapeno Chees Ball", 0, 299));
            itemList.Add(new itemModel("Snacks", "Loaded Fries", 0, 309));

            itemList.Add(new itemModel("Mocktail", "Strawberry Havana", 0, 159));
            itemList.Add(new itemModel("Mocktail", "Blue Ocean", 0, 159));
            itemList.Add(new itemModel("Mocktail", "Ginger Orange Blast", 0, 179));
            itemList.Add(new itemModel("Mocktail", "Pina Colada", 0, 179));
            itemList.Add(new itemModel("Mocktail", "Signature", 0, 209));

            itemList.Add(new itemModel("Mojito", "Virgin", 0, 159));
            itemList.Add(new itemModel("Mojito", "Mixed Fruit", 0, 159));
            itemList.Add(new itemModel("Mojito", "Green Apple", 0, 179));
            itemList.Add(new itemModel("Mojito", "Signature", 0, 209));

            itemList.Add(new itemModel("Soft Drinks", "Lime Mint Soda", 0, 129));
            itemList.Add(new itemModel("Soft Drinks", "Fresh Lime Soda", 0, 129));
            itemList.Add(new itemModel("Soft Drinks", "Masala Thums Up", 0, 139));
            itemList.Add(new itemModel("Soft Drinks", "Red Bull", 0, 179));
        }

    }
}
