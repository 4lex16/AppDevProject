namespace AirlineTicketsSystemGui
{
    partial class PassengerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerPage));
            this.PassengerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlightTab = new System.Windows.Forms.TabPage();
            this.FilghtDateButton = new System.Windows.Forms.Button();
            this.FlightBuyButton = new System.Windows.Forms.Button();
            this.FlightDetailsButton = new System.Windows.Forms.Button();
            this.FlightOrderLabel = new System.Windows.Forms.Label();
            this.FlightDestinationButton = new System.Windows.Forms.Button();
            this.FlightIdButton = new System.Windows.Forms.Button();
            this.FlightListBox = new System.Windows.Forms.ListBox();
            this.TicketTab = new System.Windows.Forms.TabPage();
            this.TicketPrintButton = new System.Windows.Forms.Button();
            this.TicketRefundButton = new System.Windows.Forms.Button();
            this.TicketDetailsButton = new System.Windows.Forms.Button();
            this.TicketOrderLabel = new System.Windows.Forms.Label();
            this.TicketIdButton = new System.Windows.Forms.Button();
            this.TicketListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.PassengerMenuStrip.SuspendLayout();
            this.FlightTab.SuspendLayout();
            this.TicketTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassengerMenuStrip
            // 
            resources.ApplyResources(this.PassengerMenuStrip, "PassengerMenuStrip");
            this.PassengerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.PassengerMenuStrip.Name = "PassengerMenuStrip";
            // 
            // pageToolStripMenuItem
            // 
            resources.ApplyResources(this.pageToolStripMenuItem, "pageToolStripMenuItem");
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            resources.ApplyResources(this.logoutToolStripMenuItem, "logoutToolStripMenuItem");
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // FlightTab
            // 
            resources.ApplyResources(this.FlightTab, "FlightTab");
            this.FlightTab.Controls.Add(this.FilghtDateButton);
            this.FlightTab.Controls.Add(this.FlightBuyButton);
            this.FlightTab.Controls.Add(this.FlightDetailsButton);
            this.FlightTab.Controls.Add(this.FlightOrderLabel);
            this.FlightTab.Controls.Add(this.FlightDestinationButton);
            this.FlightTab.Controls.Add(this.FlightIdButton);
            this.FlightTab.Controls.Add(this.FlightListBox);
            this.FlightTab.Name = "FlightTab";
            this.FlightTab.UseVisualStyleBackColor = true;
            // 
            // FilghtDateButton
            // 
            resources.ApplyResources(this.FilghtDateButton, "FilghtDateButton");
            this.FilghtDateButton.BackColor = System.Drawing.SystemColors.Window;
            this.FilghtDateButton.FlatAppearance.BorderSize = 2;
            this.FilghtDateButton.Name = "FilghtDateButton";
            this.FilghtDateButton.UseVisualStyleBackColor = false;
            this.FilghtDateButton.Click += new System.EventHandler(this.FilghtDateButton_Click);
            // 
            // FlightBuyButton
            // 
            resources.ApplyResources(this.FlightBuyButton, "FlightBuyButton");
            this.FlightBuyButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightBuyButton.FlatAppearance.BorderSize = 2;
            this.FlightBuyButton.Name = "FlightBuyButton";
            this.FlightBuyButton.UseVisualStyleBackColor = false;
            this.FlightBuyButton.Click += new System.EventHandler(this.FlightBuyButton_Click);
            // 
            // FlightDetailsButton
            // 
            resources.ApplyResources(this.FlightDetailsButton, "FlightDetailsButton");
            this.FlightDetailsButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightDetailsButton.FlatAppearance.BorderSize = 2;
            this.FlightDetailsButton.Name = "FlightDetailsButton";
            this.FlightDetailsButton.UseVisualStyleBackColor = false;
            this.FlightDetailsButton.Click += new System.EventHandler(this.FlightDetailsButton_Click);
            // 
            // FlightOrderLabel
            // 
            resources.ApplyResources(this.FlightOrderLabel, "FlightOrderLabel");
            this.FlightOrderLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FlightOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightOrderLabel.Name = "FlightOrderLabel";
            // 
            // FlightDestinationButton
            // 
            resources.ApplyResources(this.FlightDestinationButton, "FlightDestinationButton");
            this.FlightDestinationButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightDestinationButton.FlatAppearance.BorderSize = 2;
            this.FlightDestinationButton.Name = "FlightDestinationButton";
            this.FlightDestinationButton.UseVisualStyleBackColor = false;
            this.FlightDestinationButton.Click += new System.EventHandler(this.FlightDestinationButton_Click);
            // 
            // FlightIdButton
            // 
            resources.ApplyResources(this.FlightIdButton, "FlightIdButton");
            this.FlightIdButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightIdButton.FlatAppearance.BorderSize = 2;
            this.FlightIdButton.Name = "FlightIdButton";
            this.FlightIdButton.UseVisualStyleBackColor = false;
            this.FlightIdButton.Click += new System.EventHandler(this.FlightIdButton_Click);
            // 
            // FlightListBox
            // 
            resources.ApplyResources(this.FlightListBox, "FlightListBox");
            this.FlightListBox.FormattingEnabled = true;
            this.FlightListBox.Name = "FlightListBox";
            // 
            // TicketTab
            // 
            resources.ApplyResources(this.TicketTab, "TicketTab");
            this.TicketTab.Controls.Add(this.TicketPrintButton);
            this.TicketTab.Controls.Add(this.TicketRefundButton);
            this.TicketTab.Controls.Add(this.TicketDetailsButton);
            this.TicketTab.Controls.Add(this.TicketOrderLabel);
            this.TicketTab.Controls.Add(this.TicketIdButton);
            this.TicketTab.Controls.Add(this.TicketListBox);
            this.TicketTab.Name = "TicketTab";
            this.TicketTab.UseVisualStyleBackColor = true;
            // 
            // TicketPrintButton
            // 
            resources.ApplyResources(this.TicketPrintButton, "TicketPrintButton");
            this.TicketPrintButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketPrintButton.FlatAppearance.BorderSize = 2;
            this.TicketPrintButton.Name = "TicketPrintButton";
            this.TicketPrintButton.UseVisualStyleBackColor = false;
            this.TicketPrintButton.Click += new System.EventHandler(this.TicketPrintButton_Click);
            // 
            // TicketRefundButton
            // 
            resources.ApplyResources(this.TicketRefundButton, "TicketRefundButton");
            this.TicketRefundButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketRefundButton.FlatAppearance.BorderSize = 2;
            this.TicketRefundButton.Name = "TicketRefundButton";
            this.TicketRefundButton.UseVisualStyleBackColor = false;
            this.TicketRefundButton.Click += new System.EventHandler(this.TicketRefundButton_Click);
            // 
            // TicketDetailsButton
            // 
            resources.ApplyResources(this.TicketDetailsButton, "TicketDetailsButton");
            this.TicketDetailsButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketDetailsButton.FlatAppearance.BorderSize = 2;
            this.TicketDetailsButton.Name = "TicketDetailsButton";
            this.TicketDetailsButton.UseVisualStyleBackColor = false;
            this.TicketDetailsButton.Click += new System.EventHandler(this.TicketDetailsButton_Click);
            // 
            // TicketOrderLabel
            // 
            resources.ApplyResources(this.TicketOrderLabel, "TicketOrderLabel");
            this.TicketOrderLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TicketOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TicketOrderLabel.Name = "TicketOrderLabel";
            // 
            // TicketIdButton
            // 
            resources.ApplyResources(this.TicketIdButton, "TicketIdButton");
            this.TicketIdButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketIdButton.FlatAppearance.BorderSize = 2;
            this.TicketIdButton.Name = "TicketIdButton";
            this.TicketIdButton.UseVisualStyleBackColor = false;
            this.TicketIdButton.Click += new System.EventHandler(this.TicketIdButton_Click);
            // 
            // TicketListBox
            // 
            resources.ApplyResources(this.TicketListBox, "TicketListBox");
            this.TicketListBox.FormattingEnabled = true;
            this.TicketListBox.Name = "TicketListBox";
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.TicketTab);
            this.tabControl1.Controls.Add(this.FlightTab);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // RefreshButton
            // 
            resources.ApplyResources(this.RefreshButton, "RefreshButton");
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Window;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // PassengerPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PassengerMenuStrip);
            this.MainMenuStrip = this.PassengerMenuStrip;
            this.Name = "PassengerPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassengerPage_FormClosing);
            this.Load += new System.EventHandler(this.PassengerPage_Load);
            this.PassengerMenuStrip.ResumeLayout(false);
            this.PassengerMenuStrip.PerformLayout();
            this.FlightTab.ResumeLayout(false);
            this.TicketTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip PassengerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.TabPage FlightTab;
        private System.Windows.Forms.Button FlightBuyButton;
        private System.Windows.Forms.Button FlightDetailsButton;
        private System.Windows.Forms.Label FlightOrderLabel;
        private System.Windows.Forms.Button FlightDestinationButton;
        private System.Windows.Forms.Button FlightIdButton;
        private System.Windows.Forms.ListBox FlightListBox;
        private System.Windows.Forms.TabPage TicketTab;
        private System.Windows.Forms.Button TicketPrintButton;
        private System.Windows.Forms.Button TicketRefundButton;
        private System.Windows.Forms.Button TicketDetailsButton;
        private System.Windows.Forms.Label TicketOrderLabel;
        private System.Windows.Forms.Button TicketIdButton;
        private System.Windows.Forms.ListBox TicketListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button FilghtDateButton;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button RefreshButton;
    }
}