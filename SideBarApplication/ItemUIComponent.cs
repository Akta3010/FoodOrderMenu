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
    public partial class ItemUIComponent : UserControl
    {
        public ItemUIComponent()
        {
            InitializeComponent();
        }

        private void itemPicture_Click(object sender, EventArgs e)
        {
            PictureBox itemPic = (PictureBox)sender;
            Global.orderService.AddOrder(itemPic.Name);
        }

        public static ItemUIComponent CreateItemControl(string itemName, int price)
        {
            //string name = itemName.Replace(' ','_');
            ItemUIComponent control = new ItemUIComponent();
            control.itemControlPanel.Name = itemName + "_ControlPanel";
            control.itemPicPanel.Name = itemName + "_PicPanel";
            control.itemNamePanel.Name = itemName + "_NamePanelPanel";
            control.ItemPricePanel.Name = itemName + "_PricePanel";

            control.itemPicture.Name = itemName;

            control.itemName.Text = itemName;
            control.itemName.Name = itemName + "_txt";

            control.itemPrice.Text = price.ToString();
            control.itemPrice.Name = itemName + "_pri";

            control.Size = control.itemControlPanel.Size;
            return control;
        }
    }
}
