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
    public partial class MojitoForm : Form
    {
        public MojitoForm()
        {
            InitializeComponent();
            ComponentServices.SetControlsUsingFoodFamily("Mojito", ref this.MojitoMenuPanel);
        }
    }
}
