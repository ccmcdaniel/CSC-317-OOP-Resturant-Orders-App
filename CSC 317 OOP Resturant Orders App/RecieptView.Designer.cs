namespace CSC_317_OOP_Resturant_Orders_App
{
    partial class RecieptView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTableNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.tabRestMenu = new System.Windows.Forms.TabControl();
            this.tabBeverage = new System.Windows.Forms.TabPage();
            this.lstBeverages = new System.Windows.Forms.ListBox();
            this.tabAppetizers = new System.Windows.Forms.TabPage();
            this.lstAppetizers = new System.Windows.Forms.ListBox();
            this.tabMainCourse = new System.Windows.Forms.TabPage();
            this.lstMainCourse = new System.Windows.Forms.ListBox();
            this.tabDessert = new System.Windows.Forms.TabPage();
            this.lstDessert = new System.Windows.Forms.ListBox();
            this.lstOrderList = new System.Windows.Forms.ListBox();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabRestMenu.SuspendLayout();
            this.tabBeverage.SuspendLayout();
            this.tabAppetizers.SuspendLayout();
            this.tabMainCourse.SuspendLayout();
            this.tabDessert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtTableNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtServer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabRestMenu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lstOrderList, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerateReceipt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFileNameLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1305, 1011);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTableNumber
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTableNumber, 2);
            this.txtTableNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTableNumber.Location = new System.Drawing.Point(329, 205);
            this.txtTableNumber.Multiline = true;
            this.txtTableNumber.Name = "txtTableNumber";
            this.txtTableNumber.Size = new System.Drawing.Size(646, 95);
            this.txtTableNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtServer, 2);
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServer.Location = new System.Drawing.Point(329, 104);
            this.txtServer.Multiline = true;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(646, 95);
            this.txtServer.TabIndex = 1;
            // 
            // tabRestMenu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabRestMenu, 2);
            this.tabRestMenu.Controls.Add(this.tabBeverage);
            this.tabRestMenu.Controls.Add(this.tabAppetizers);
            this.tabRestMenu.Controls.Add(this.tabMainCourse);
            this.tabRestMenu.Controls.Add(this.tabDessert);
            this.tabRestMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRestMenu.Location = new System.Drawing.Point(3, 306);
            this.tabRestMenu.Name = "tabRestMenu";
            this.tabRestMenu.SelectedIndex = 0;
            this.tabRestMenu.Size = new System.Drawing.Size(646, 600);
            this.tabRestMenu.TabIndex = 5;
            // 
            // tabBeverage
            // 
            this.tabBeverage.Controls.Add(this.lstBeverages);
            this.tabBeverage.Location = new System.Drawing.Point(8, 46);
            this.tabBeverage.Name = "tabBeverage";
            this.tabBeverage.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeverage.Size = new System.Drawing.Size(630, 546);
            this.tabBeverage.TabIndex = 0;
            this.tabBeverage.Text = "Beverages";
            this.tabBeverage.UseVisualStyleBackColor = true;
            // 
            // lstBeverages
            // 
            this.lstBeverages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBeverages.FormattingEnabled = true;
            this.lstBeverages.ItemHeight = 32;
            this.lstBeverages.Location = new System.Drawing.Point(3, 3);
            this.lstBeverages.Name = "lstBeverages";
            this.lstBeverages.Size = new System.Drawing.Size(624, 540);
            this.lstBeverages.TabIndex = 0;
            this.lstBeverages.SelectedIndexChanged += new System.EventHandler(this.lstBeverages_SelectedIndexChanged);
            // 
            // tabAppetizers
            // 
            this.tabAppetizers.Controls.Add(this.lstAppetizers);
            this.tabAppetizers.Location = new System.Drawing.Point(8, 46);
            this.tabAppetizers.Name = "tabAppetizers";
            this.tabAppetizers.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppetizers.Size = new System.Drawing.Size(630, 647);
            this.tabAppetizers.TabIndex = 1;
            this.tabAppetizers.Text = "Appetizers";
            this.tabAppetizers.UseVisualStyleBackColor = true;
            // 
            // lstAppetizers
            // 
            this.lstAppetizers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAppetizers.FormattingEnabled = true;
            this.lstAppetizers.ItemHeight = 32;
            this.lstAppetizers.Location = new System.Drawing.Point(3, 3);
            this.lstAppetizers.Name = "lstAppetizers";
            this.lstAppetizers.Size = new System.Drawing.Size(624, 641);
            this.lstAppetizers.TabIndex = 0;
            this.lstAppetizers.SelectedIndexChanged += new System.EventHandler(this.lstBeverages_SelectedIndexChanged);
            // 
            // tabMainCourse
            // 
            this.tabMainCourse.Controls.Add(this.lstMainCourse);
            this.tabMainCourse.Location = new System.Drawing.Point(8, 46);
            this.tabMainCourse.Name = "tabMainCourse";
            this.tabMainCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainCourse.Size = new System.Drawing.Size(630, 647);
            this.tabMainCourse.TabIndex = 2;
            this.tabMainCourse.Text = "Main Course";
            this.tabMainCourse.UseVisualStyleBackColor = true;
            // 
            // lstMainCourse
            // 
            this.lstMainCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMainCourse.FormattingEnabled = true;
            this.lstMainCourse.ItemHeight = 32;
            this.lstMainCourse.Location = new System.Drawing.Point(3, 3);
            this.lstMainCourse.Name = "lstMainCourse";
            this.lstMainCourse.Size = new System.Drawing.Size(624, 641);
            this.lstMainCourse.TabIndex = 0;
            this.lstMainCourse.SelectedIndexChanged += new System.EventHandler(this.lstBeverages_SelectedIndexChanged);
            // 
            // tabDessert
            // 
            this.tabDessert.Controls.Add(this.lstDessert);
            this.tabDessert.Location = new System.Drawing.Point(8, 46);
            this.tabDessert.Name = "tabDessert";
            this.tabDessert.Padding = new System.Windows.Forms.Padding(3);
            this.tabDessert.Size = new System.Drawing.Size(630, 647);
            this.tabDessert.TabIndex = 3;
            this.tabDessert.Text = "Dessert";
            this.tabDessert.UseVisualStyleBackColor = true;
            // 
            // lstDessert
            // 
            this.lstDessert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDessert.FormattingEnabled = true;
            this.lstDessert.ItemHeight = 32;
            this.lstDessert.Location = new System.Drawing.Point(3, 3);
            this.lstDessert.Name = "lstDessert";
            this.lstDessert.Size = new System.Drawing.Size(624, 641);
            this.lstDessert.TabIndex = 0;
            this.lstDessert.SelectedIndexChanged += new System.EventHandler(this.lstBeverages_SelectedIndexChanged);
            // 
            // lstOrderList
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lstOrderList, 2);
            this.lstOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOrderList.FormattingEnabled = true;
            this.lstOrderList.ItemHeight = 32;
            this.lstOrderList.Location = new System.Drawing.Point(655, 306);
            this.lstOrderList.Name = "lstOrderList";
            this.lstOrderList.Size = new System.Drawing.Size(647, 600);
            this.lstOrderList.TabIndex = 6;
            this.lstOrderList.SelectedIndexChanged += new System.EventHandler(this.lstOrderList_SelectedIndexChanged);
            // 
            // btnGenerateReceipt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnGenerateReceipt, 2);
            this.btnGenerateReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateReceipt.Location = new System.Drawing.Point(329, 912);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(646, 96);
            this.btnGenerateReceipt.TabIndex = 7;
            this.btnGenerateReceipt.Text = "Generate Receipt";
            this.btnGenerateReceipt.UseVisualStyleBackColor = true;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 101);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table Number: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileNameLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblFileNameLabel, 2);
            this.lblFileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileNameLabel.Location = new System.Drawing.Point(329, 0);
            this.lblFileNameLabel.Name = "lblFileNameLabel";
            this.lblFileNameLabel.Size = new System.Drawing.Size(646, 101);
            this.lblFileNameLabel.TabIndex = 8;
            this.lblFileNameLabel.Text = "Unsaved Receipt";
            this.lblFileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecieptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RecieptView";
            this.Size = new System.Drawing.Size(1305, 1011);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabRestMenu.ResumeLayout(false);
            this.tabBeverage.ResumeLayout(false);
            this.tabAppetizers.ResumeLayout(false);
            this.tabMainCourse.ResumeLayout(false);
            this.tabDessert.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTableNumber;
        private Label label1;
        private TextBox txtServer;
        private TabControl tabRestMenu;
        private TabPage tabBeverage;
        private TabPage tabAppetizers;
        private TabPage tabMainCourse;
        private TabPage tabDessert;
        private ListBox lstBeverages;
        private ListBox lstAppetizers;
        private ListBox lstMainCourse;
        private ListBox lstDessert;
        private ListBox lstOrderList;
        private Button btnGenerateReceipt;
        private Label label2;
        private Label lblFileNameLabel;
    }
}
