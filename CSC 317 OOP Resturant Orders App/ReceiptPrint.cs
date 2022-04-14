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
   
    public partial class ReceiptPrint : Form
    {
        public string Receipt
        {
            get
            {
                return lblReceiptDisplay.Text;
            }
            set
            {
                lblReceiptDisplay.Text = value;
            }
        }

        public string ReceiptID { get; set; }

        public ReceiptPrint()
        {
            InitializeComponent();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
           //Hypothetically this is where you would specify what actually
           //happens when you print a receipt.
        }

        private void btnCloseReceipt_Click(object sender, EventArgs e)
        {
            //Just close the form
            this.Close();
        }
    }
}
