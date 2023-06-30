using FoodOrderMenu.Services;
using FoodOrderMenu;
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
    public partial class Menu : Form
    {
        public Order orderForm = new Order();
        public OrderServices orderServices = null;
        public Menu()
        {
            InitializeComponent();
            customizeDesign();
            Global.orderService = new OrderServices(orderForm);
        }

        private void customizeDesign()
        {
            this.foodSubMenuPanel.Visible = false;
            this.drinkSubMenuPanel.Visible = false;

        }

        private void hideSubmenu()
        {
            if (this.foodSubMenuPanel.Visible == true)
                this.foodSubMenuPanel.Visible = false;
            if (this.drinkSubMenuPanel.Visible == true)
                this.drinkSubMenuPanel.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void foodBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(foodSubMenuPanel);
        }

        private void drinksBtn_Click(object sender, EventArgs e)
        {
            showSubmenu(drinkSubMenuPanel);
        }

        private void PizzaBtn_Click(object sender, EventArgs e)
        {
            //Implementation
            showChildForm(new PizzaForm());
            //
            hideSubmenu();
        }

        private void BurgerBtn_Click(object sender, EventArgs e)
        {
            //Implementation
            showChildForm(new BurgerForm());
            //
            hideSubmenu();
        }

        private void PastaBtn_Click(object sender, EventArgs e)
        {
            //Implementation
            showChildForm(new PastaForm());
            //
            hideSubmenu();
        }

        private void SnacksBtn_Click(object sender, EventArgs e)
        {
            //Implementation
            showChildForm(new SnacksForm());
            //
            hideSubmenu();
        }

        private void MocktailBtn_Click(object sender, EventArgs e)
        {
            //Implementation
            showChildForm(new MocktailForm());
            //
            hideSubmenu();
        }

        private void MojitoBtn_Click(object sender, EventArgs e)
        {
            //Implementation
            showChildForm(new MojitoForm());
            //
            hideSubmenu();
        }

        private void SoftDrinksBtn_Click(object sender, EventArgs e)
        {
            //Implementation
            showChildForm(new SoftDrinksForm());
            //
            hideSubmenu();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            //Implementation
            //...
            //
            hideSubmenu();
        }

        private Form activeForm = null;
        private void showChildForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            foodMenuPanel.Controls.Add(form);
            foodMenuPanel.Tag = form;
            form.BringToFront();
            form.Show();

            foodMenuPanel.Visible = true;
            orderPanel.Visible = true;
            showOrderForm();
        }

        private void showOrderForm()
        {
            orderForm.TopLevel = false;
            orderForm.Dock = DockStyle.Fill;
            this.orderPanel.Controls.Add(orderForm);
            orderForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_MaximumSizeChanged(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Size = this.Size;
            };
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Size = this.Size;
            };
        }
    }
}
