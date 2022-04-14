namespace CSC_317_OOP_Resturant_Orders_App
{
    partial class ReceiptPrint
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReceiptDisplay = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCloseReceipt = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceiptDisplay
            // 
            this.lblReceiptDisplay.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.lblReceiptDisplay, 2);
            this.lblReceiptDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiptDisplay.Location = new System.Drawing.Point(3, 0);
            this.lblReceiptDisplay.Name = "lblReceiptDisplay";
            this.lblReceiptDisplay.Size = new System.Drawing.Size(833, 861);
            this.lblReceiptDisplay.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCloseReceipt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblReceiptDisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintReceipt, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 957);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCloseReceipt
            // 
            this.btnCloseReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseReceipt.Location = new System.Drawing.Point(422, 864);
            this.btnCloseReceipt.Name = "btnCloseReceipt";
            this.btnCloseReceipt.Size = new System.Drawing.Size(414, 90);
            this.btnCloseReceipt.TabIndex = 2;
            this.btnCloseReceipt.Text = "Close Receipt";
            this.btnCloseReceipt.UseVisualStyleBackColor = true;
            this.btnCloseReceipt.Click += new System.EventHandler(this.btnCloseReceipt_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReceipt.Location = new System.Drawing.Point(3, 864);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(413, 90);
            this.btnPrintReceipt.TabIndex = 1;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // ReceiptPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 957);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReceiptPrint";
            this.Text = "Receipt";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblReceiptDisplay;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCloseReceipt;
        private Button btnPrintReceipt;
    }
}