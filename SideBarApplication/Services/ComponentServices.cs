using FoodOrderMenu;
using FoodOrderMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderMenu.Services
{
    public class ComponentServices
    {
        public static List<Control> CreateControlUsingFoodFamily(string foodFamily)
        {
            ItemUIComponent control = null;
            List<Control> controls = new List<Control>();
            List<itemModel> items = itemListModel.itemList.Where(x => x.foodFamily == foodFamily).ToList();

            for (int i = 0; i < items.Count; i++)
            {
                control = ItemUIComponent.CreateItemControl(items[i].foodItem, items[i].price);
                controls.Add(control);
            }

            return controls;
        }

        public static void SetControlsUsingFoodFamily(string foodFamily, ref FlowLayoutPanel panel)
        {
            List<Control> controls = ComponentServices.CreateControlUsingFoodFamily(foodFamily);

            if (controls != null)
            {
                panel.Controls.AddRange(controls.ToArray());
            }
        }
    }
}
