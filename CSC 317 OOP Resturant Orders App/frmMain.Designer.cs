namespace CSC_317_OOP_Resturant_Orders_App
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReceiptAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabReceipts = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1352, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newReceiptToolStripMenuItem,
            this.openReceiptToolStripMenuItem,
            this.saveReceiptToolStripMenuItem,
            this.saveReceiptAsToolStripMenuItem,
            this.closeReceiptToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newReceiptToolStripMenuItem
            // 
            this.newReceiptToolStripMenuItem.Name = "newReceiptToolStripMenuItem";
            this.newReceiptToolStripMenuItem.Size = new System.Drawing.Size(314, 44);
            this.newReceiptToolStripMenuItem.Text = "New Receipt";
            this.newReceiptToolStripMenuItem.Click += new System.EventHandler(this.newReceiptToolStripMenuItem_Click);
            // 
            // openReceiptToolStripMenuItem
            // 
            this.openReceiptToolStripMenuItem.Name = "openReceiptToolStripMenuItem";
            this.openReceiptToolStripMenuItem.Size = new System.Drawing.Size(314, 44);
            this.openReceiptToolStripMenuItem.Text = "Open Receipt";
            this.openReceiptToolStripMenuItem.Click += new System.EventHandler(this.openReceiptToolStripMenuItem_Click);
            // 
            // saveReceiptToolStripMenuItem
            // 
            this.saveReceiptToolStripMenuItem.Name = "saveReceiptToolStripMenuItem";
            this.saveReceiptToolStripMenuItem.Size = new System.Drawing.Size(314, 44);
            this.saveReceiptToolStripMenuItem.Text = "Save Receipt";
            this.saveReceiptToolStripMenuItem.Click += new System.EventHandler(this.saveReceiptToolStripMenuItem_Click);
            // 
            // saveReceiptAsToolStripMenuItem
            // 
            this.saveReceiptAsToolStripMenuItem.Name = "saveReceiptAsToolStripMenuItem";
            this.saveReceiptAsToolStripMenuItem.Size = new System.Drawing.Size(314, 44);
            this.saveReceiptAsToolStripMenuItem.Text = "Save Receipt As";
            this.saveReceiptAsToolStripMenuItem.Click += new System.EventHandler(this.saveReceiptAsToolStripMenuItem_Click);
            // 
            // closeReceiptToolStripMenuItem
            // 
            this.closeReceiptToolStripMenuItem.Name = "closeReceiptToolStripMenuItem";
            this.closeReceiptToolStripMenuItem.Size = new System.Drawing.Size(314, 44);
            this.closeReceiptToolStripMenuItem.Text = "Close Receipt";
            this.closeReceiptToolStripMenuItem.Click += new System.EventHandler(this.closeReceiptToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(314, 44);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            // 
            // tabReceipts
            // 
            this.tabReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReceipts.Location = new System.Drawing.Point(0, 40);
            this.tabReceipts.Name = "tabReceipts";
            this.tabReceipts.SelectedIndex = 0;
            this.tabReceipts.Size = new System.Drawing.Size(1352, 915);
            this.tabReceipts.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 955);
            this.Controls.Add(this.tabReceipts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Receipt Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newReceiptToolStripMenuItem;
        private ToolStripMenuItem openReceiptToolStripMenuItem;
        private ToolStripMenuItem saveReceiptToolStripMenuItem;
        private ToolStripMenuItem closeReceiptToolStripMenuItem;
        private ToolStripMenuItem exitProgramToolStripMenuItem;
        private TabControl tabReceipts;
        private ToolStripMenuItem saveReceiptAsToolStripMenuItem;
    }
}