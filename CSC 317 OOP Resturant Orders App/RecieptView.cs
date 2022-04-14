using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC_317_OOP_Resturant_Orders_App
{
    public partial class RecieptView : UserControl
    {
        //Used to store the menu selections
        Dictionary<string, decimal> appetizers = new();
        Dictionary<string, decimal> beverages = new();
        Dictionary<string, decimal> desserts = new();
        Dictionary<string, decimal> maincourse = new();

        private string _fileName;

        const decimal TAX = 0.10M;

        public string FileName {

            get
            {
                return _fileName;
            }

            set
            {
               _fileName = value;
               lblFileNameLabel.Text = "Opened from following file: \n";
               lblFileNameLabel.Text += value;
            }

        }
        public string ReceiptID{ get; set; }

        public string ServerName
        {
            get { return txtServer.Text; }

            set { txtServer.Text = value; }
        }

        public string TableName
        {
            get { return txtTableNumber.Text; }
            set { txtTableNumber.Text = value; }
        }


        public string[] OrderList
        {
            get {

                string[] list = new string[lstOrderList.Items.Count];

                for(int i = 0; i < lstOrderList.Items.Count; i++)
                {
                    list[i] = lstOrderList.Items[i].ToString();
                }

                return list;
            }
            set 
            {
                lstOrderList.Items.Clear();
                
                foreach(var item in value)
                {
                    lstOrderList.Items.Add(item);
                }
            }
        }
        public RecieptView()
        {
            InitializeComponent();

            appetizers.Add(   "Buffalo Wings ($5.95)",  5.95M);
            appetizers.Add( "Buffalo Fingers ($6.95)",  6.95M);
            appetizers.Add(    "Potato Skins ($8.95)",  8.95M);
            appetizers.Add(          "Nachos ($8.95)",  8.95M);
            appetizers.Add(  "Mushroom Caps ($10.95)", 10.95M);
            appetizers.Add("Shrimp Cocktail ($12.95)", 12.95M);
            appetizers.Add( "Chips and Salsa ($6.95)",  6.95M);

            beverages.Add(              "Soda ($1.95)", 1.95M);
            beverages.Add(               "Tea ($1.50)", 2.95M);
            beverages.Add(            "Coffee ($2.95)", 1.25M);
            beverages.Add(     "Mineral Water ($2.95)", 2.95M);
            beverages.Add(             "Juice ($2.50)", 2.50M);
            beverages.Add(              "Milk ($1.50)", 1.50M);

            maincourse.Add("Seafood Alfredo ($15.95)", 15.95M);
            maincourse.Add("Chicken Alfredo ($13.95)", 13.95M);
            maincourse.Add("Chicken Picatta ($13.95)", 13.95M);
            maincourse.Add(    "Turkey Club ($11.95)", 11.95M);
            maincourse.Add(    "Lobster Pie ($19.95)", 19.95M);
            maincourse.Add(      "Prime Rib ($20.95)", 20.95M);
            maincourse.Add(  "Shrimp Scampi ($18.95)", 18.95M);
            maincourse.Add(  "Turkey Dinner ($13.95)", 13.95M);
            maincourse.Add("Stuffed Chicken ($14.95)", 14.95M);

            desserts.Add(         "Apple Pie ($5.95)", 5.95M);
            desserts.Add(            "Sundae ($3.95)", 3.95M);
            desserts.Add(       "Carrot Cake ($5.95)", 5.95M);
            desserts.Add(           "Mud Pie ($4.95)", 4.95M);
            desserts.Add(       "Apple Crisp ($5.95)", 5.95M);

            foreach(string appetizer in appetizers.Keys)
                lstAppetizers.Items.Add(appetizer);

            foreach(string beverage in beverages.Keys)
                lstBeverages.Items.Add(beverage);

            foreach(string dessert in desserts.Keys)
                lstDessert.Items.Add(dessert);

            foreach(string maincourseitem in maincourse.Keys)
                lstMainCourse.Items.Add(maincourseitem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListBox menuCategory = (sender as ListBox);

            if (menuCategory.SelectedIndex != -1)
            {
                string orderItem = menuCategory.SelectedItem.ToString();

                lstOrderList.Items.Add(orderItem);
            }
        }

        private void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstOrderList.SelectedIndex != -1)
                lstOrderList.Items.RemoveAt(lstOrderList.SelectedIndex);
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            StringBuilder receipt = new();

            receipt.Append("----------------------------------------------------\n");
            receipt.Append("Your Server: " + txtServer.Text + "\n");
            receipt.Append("Table Number: " + txtTableNumber.Text + "\n");
            receipt.Append("----------------------------------------------------\n\n");


            receipt.Append("\nItems Ordered: \n");
            receipt.Append("----------------------------------------------------\n");

            int count = 1;
            foreach (var item in lstOrderList.Items)
            {
                receipt.Append($"\t{count++}. ");
                receipt.Append(item.ToString());
                receipt.Append("\n");
            }

            receipt.Append("----------------------------------------------------\n\n");

            decimal subtotal = 0M;

            foreach(string item in lstOrderList.Items)
            {
                decimal price = lookupPrice(item);

                if (price != -1M)
                    subtotal += price;
                else
                {
                    MessageBox.Show("Error: Could not find price for " + item);
                }    
            }

            receipt.Append($"Sub Total: ${subtotal}\n");
            receipt.Append($"Tax: ${subtotal * TAX}\n");

            decimal total = subtotal + subtotal * TAX;

            receipt.Append($"Amount Owed: ${total}\n");
            

            receipt.Append("----------------------------------------------------\n\n");

           
            ReceiptPrint r = new ReceiptPrint();
            r.Receipt = receipt.ToString();
            r.ReceiptID = ReceiptID;
            r.Show();

        }

        private decimal lookupPrice(string key)
        {
            if (appetizers.Keys.Contains(key))
                return appetizers[key];
            else if (beverages.Keys.Contains(key))
                return beverages[key];
            else if (maincourse.Keys.Contains(key))
                return maincourse[key];
            else if (desserts.Keys.Contains(key))
                return desserts[key];
            else
                return -1M;
        }
    }
}
