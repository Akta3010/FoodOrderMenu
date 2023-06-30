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
    public partial class BurgerForm : Form
    {
        public BurgerForm()
        {
            InitializeComponent();
            ComponentServices.SetControlsUsingFoodFamily("Burger", ref this.BurgerMenuPanel);
        }
    }
}
