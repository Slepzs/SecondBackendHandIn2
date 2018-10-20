using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Backend2
{
    public partial class CreateCustomer : System.Web.UI.Page
    {

        private void printCustomersLsit()
        {
            ListBoxFiltered.Items.Clear();
            foreach (var Customer in Customers.customerlist)
            {
                if (Customer.Region.Equals(DropDownList2.Text))
                {
                    ListBoxFiltered.Items.Add(Customer.ToString());
                }
               
            }
        }


        private void PrintCustomers()
        {
            ListboxAllCustomers.Items.Clear();
            foreach (var Customer in Customers.customerlist)
            {
                ListboxAllCustomers.Items.Add(Customer.ToString());
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            PrintCustomers();
        }
     
        protected void BtnCreate_Click(object sender, EventArgs e)
        {

            Customers customer = new Customers(TextBoxName.Text, Convert.ToInt32(TextBoxAge.Text), Convert.ToInt32(TextBoxZipcode.Text), TextBoxPassword.Text, DropDownList1.Text);

            Customers.customerlist.Add(customer);

            PrintCustomers();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            printCustomersLsit();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            printCustomersLsit();
        }
    }
}