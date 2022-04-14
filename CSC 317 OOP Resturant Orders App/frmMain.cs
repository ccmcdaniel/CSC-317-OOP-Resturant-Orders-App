using System.Xml.Serialization;
using System.Xml;

namespace CSC_317_OOP_Resturant_Orders_App
{
    public partial class frmMain : Form
    {
        Random r = new Random();

        //Create a serializer for our Receipt class.
        XmlSerializer serializer = new XmlSerializer(typeof(Receipt));
        StreamWriter fileWriter;
        StreamReader fileReader;

        public frmMain()
        {
            InitializeComponent();
        }

        private void newReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string receiptName = "Receipt #" + r.Next(1000, 9999);
            generateNewReceipt(receiptName);
        }

        private RecieptView generateNewReceipt(string receiptName)
        {
            TabPage receipt = new TabPage();
            tabReceipts.Controls.Add(receipt);

            receipt.Text = receiptName;
            RecieptView control = new RecieptView();
            control.ReceiptID = receiptName;

            receipt.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            return control; 
        }

        private void closeReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("You are about to close a receipt with possible unsaved changes.  " +
                "Would you like to save this receipe?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                //Call the event method for Save Receipt, as the functionality is the same.
                saveReceiptToolStripMenuItem_Click(sender, e);
            }

            //After the user has confirmed, then you can dispose of the object.
            tabReceipts.SelectedTab.Dispose();

        }

        private void openReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (var fileChooser = new OpenFileDialog())
            {
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if(result == DialogResult.OK)
            {
                if(string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Could Not Open File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        fileReader = new StreamReader(output);

                        var obj = (serializer.Deserialize(fileReader) as Receipt);

                        RecieptView newReceipt = generateNewReceipt(obj.ReceiptId);

                        newReceipt.FileName = fileName;
                        newReceipt.ServerName = obj.Server;
                        newReceipt.TableName = obj.TableNumber;
                        newReceipt.OrderList = obj.OrderedItems;

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save the receipt to an XML file.

            if (tabReceipts.SelectedTab != null)
            {
                var ActiveReceipt = (tabReceipts.SelectedTab.Controls[0] as CSC_317_OOP_Resturant_Orders_App.RecieptView);

                //If the fileName of the current opened recept is not set....
                if (string.IsNullOrEmpty(ActiveReceipt.FileName))
                {
                    //then create a new save file from the user and set the file.
                    ActiveReceipt.FileName = saveNewReceipt();
                }
                else
                {
                    //Save the changes to an existing file.
                    saveChanges(ActiveReceipt.FileName);
                }
            }
            else
            {
                MessageBox.Show("No receipt is Open.  Try creating a new receipt or opening a receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string saveNewReceipt()
        {

            DialogResult result;
            string fileName;

            //Create a SaveFileDialog object that will be shown to the user.
            using (var fileChooser = new SaveFileDialog())
            {

                //Disables file checking since we are potentially creating a new file.
                fileChooser.CheckFileExists = false;

                //Tells the dialogbox to add an extension to the file.
                fileChooser.AddExtension = true;

                //Sets the default extension to XML.
                fileChooser.DefaultExt = "xml";

                //Show the dialog and store the result(i.e., whether the user pressed "OK")
                result = fileChooser.ShowDialog();

                //Get the filename and path from the users chosen location.
                fileName = fileChooser.FileName;
            }

            //If the user pressed OK on the result...
            if (result == DialogResult.OK)
            {
                //If the filename was empty(i.e., filename was not set in the dialog box abobve).....
                if (string.IsNullOrEmpty(fileName))
                {
                    //.....then output an error message to the user.
                    MessageBox.Show("Could Not Open File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
                //Otherwise, start the saving process.
                else
                {
                    try
                    {
                        var output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        fileWriter = new StreamWriter(output);

                        //Save the receipt to an XML file.
                        var ActiveReceipt = (tabReceipts.SelectedTab.Controls[0] as CSC_317_OOP_Resturant_Orders_App.RecieptView);
                        Receipt obj = new Receipt();

                        //copy the data in our Receipt textboxes and Listbox into our Receipt class object.
                        obj.Server = ActiveReceipt.ServerName;
                        obj.TableNumber = ActiveReceipt.TableName;
                        obj.OrderedItems = ActiveReceipt.OrderList;
                        obj.ReceiptId = ActiveReceipt.ReceiptID;

                        //Serialize and store the data in our file.
                        serializer.Serialize(output, obj);

                        //Close the file to commit changes.

                        fileWriter.Close();

                        return fileName;

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return "";
                    }
                }
            }
            else
                return "";
        }

        private bool saveChanges(string fileName)
        {
            try
            {
                var output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fileWriter = new StreamWriter(output);

                //Save the receipt to an XML file.
                var ActiveReceipt = (tabReceipts.SelectedTab.Controls[0] as CSC_317_OOP_Resturant_Orders_App.RecieptView);
                Receipt obj = new Receipt();

                //copy the data in our Receipt textboxes and Listbox into our Receipt class object.
                obj.Server = ActiveReceipt.ServerName;
                obj.TableNumber = ActiveReceipt.TableName;
                obj.OrderedItems = ActiveReceipt.OrderList;
                obj.ReceiptId = ActiveReceipt.ReceiptID;

                //Serialize and store the data in our file.
                serializer.Serialize(output, obj);

                //Close the file to commit changes.

                fileWriter.Close();

                MessageBox.Show("Receipt Saved!", "Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return true;

            }
            catch (IOException)
            {
                MessageBox.Show("Error Opening File", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        private void saveReceiptAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabReceipts.SelectedTab != null)
            {
                var ActiveReceipt = (tabReceipts.SelectedTab.Controls[0] as CSC_317_OOP_Resturant_Orders_App.RecieptView);

                //Since this is "Save As", we will save it as a new receipt and overwrite the previous file name.
                ActiveReceipt.FileName = saveNewReceipt();
            }
            else
            {
                MessageBox.Show("No receipt is Open.  Try creating a new receipt or opening a receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}