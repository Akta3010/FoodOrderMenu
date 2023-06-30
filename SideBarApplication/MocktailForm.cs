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
    public partial class MocktailForm : Form
    {
        public MocktailForm()
        {
            InitializeComponent();
            ComponentServices.SetControlsUsingFoodFamily("Mocktail", ref this.MocktailMenuPanel);
        }
    }
}
