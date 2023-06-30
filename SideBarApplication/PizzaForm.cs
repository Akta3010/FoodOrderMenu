using FoodOrderMenu.Models;
using FoodOrderMenu.Services;
using FoodOrderMenu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderMenu
{
    public partial class PizzaForm : Form
    {
        ItemUIComponent control = null;
        public PizzaForm()
        {
            InitializeComponent();
            ComponentServices.SetControlsUsingFoodFamily("Pizza",ref this.PizzaMenuPanel);

            //AddPizzaMenu();
        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {

        }

        private void AddPizzaMenu()
        {
            List<Control> controls = ComponentServices.CreateControlUsingFoodFamily("Pizza");

            if (controls != null )
            {
                this.PizzaMenuPanel.Controls.AddRange(controls.ToArray());
            }
            
            //List<itemModel> items = new List<itemModel>() { };

            //items = itemListModel.itemList.Where(x => x.foodFamily == "Pizza").ToList();

            //for (int i = 0; i < items.Count; i++)
            //{
            //    control = ItemUIComponent.CreateItemControl(items[i].foodItem, items[i].price);
            //    this.PizzaMenuPanel.Controls.Add(control);
            //}
        }
    }
}
