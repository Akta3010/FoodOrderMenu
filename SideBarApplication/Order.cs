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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        public void OrderUpdated()
        {
            if (Global.orderList.items.Count > 0)
            {
                int total = 0;
                this.orderDataGridView.Rows.Clear();

                for (int i= 0; i < Global.orderList.items.Count; i++)
                {
                    this.orderDataGridView.Rows.Add(
                        Global.orderList.items[i].foodItem,
                        Global.orderList.items[i].count,
                        Global.orderList.items[i].itemTotalCost);
                    total += Global.orderList.items[i].itemTotalCost;
                }

                this.txtTotalAmount.Text = total.ToString();
            }
        }
    }
}
