namespace AirlineTicketsSystemGui
{
    partial class StaffPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPage));
            this.tabs = new System.Windows.Forms.TabControl();
            this.FlightTab = new System.Windows.Forms.TabPage();
            this.FlightDetailsButton = new System.Windows.Forms.Button();
            this.FlightFilterButton = new System.Windows.Forms.Label();
            this.FlightOrderLabel = new System.Windows.Forms.Label();
            this.FlightDestinationLabel = new System.Windows.Forms.Label();
            this.FlightIdLabel = new System.Windows.Forms.Label();
            this.FlightDestinationTB = new System.Windows.Forms.TextBox();
            this.FlightIdTB = new System.Windows.Forms.TextBox();
            this.FlightDestinationButton = new System.Windows.Forms.Button();
            this.FlightIdButton = new System.Windows.Forms.Button();
            this.FlightListBox = new System.Windows.Forms.ListBox();
            this.PassengerTab = new System.Windows.Forms.TabPage();
            this.PassengerDetailsButton = new System.Windows.Forms.Button();
            this.PassengerFilterLabel = new System.Windows.Forms.Label();
            this.PassengerOrderLabel = new System.Windows.Forms.Label();
            this.PassengerUsernameLabel = new System.Windows.Forms.Label();
            this.PassengerIdLabel = new System.Windows.Forms.Label();
            this.PassengerUsernameTB = new System.Windows.Forms.TextBox();
            this.PassengerIdTB = new System.Windows.Forms.TextBox();
            this.PassengerUsernameButton = new System.Windows.Forms.Button();
            this.PassengerIdButton = new System.Windows.Forms.Button();
            this.PassengerListBox = new System.Windows.Forms.ListBox();
            this.StaffMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs.SuspendLayout();
            this.FlightTab.SuspendLayout();
            this.PassengerTab.SuspendLayout();
            this.StaffMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.Controls.Add(this.FlightTab);
            this.tabs.Controls.Add(this.PassengerTab);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // FlightTab
            // 
            resources.ApplyResources(this.FlightTab, "FlightTab");
            this.FlightTab.Controls.Add(this.FlightDetailsButton);
            this.FlightTab.Controls.Add(this.FlightFilterButton);
            this.FlightTab.Controls.Add(this.FlightOrderLabel);
            this.FlightTab.Controls.Add(this.FlightDestinationLabel);
            this.FlightTab.Controls.Add(this.FlightIdLabel);
            this.FlightTab.Controls.Add(this.FlightDestinationTB);
            this.FlightTab.Controls.Add(this.FlightIdTB);
            this.FlightTab.Controls.Add(this.FlightDestinationButton);
            this.FlightTab.Controls.Add(this.FlightIdButton);
            this.FlightTab.Controls.Add(this.FlightListBox);
            this.FlightTab.Name = "FlightTab";
            this.FlightTab.UseVisualStyleBackColor = true;
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
            // FlightFilterButton
            // 
            resources.ApplyResources(this.FlightFilterButton, "FlightFilterButton");
            this.FlightFilterButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightFilterButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightFilterButton.Name = "FlightFilterButton";
            // 
            // FlightOrderLabel
            // 
            resources.ApplyResources(this.FlightOrderLabel, "FlightOrderLabel");
            this.FlightOrderLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FlightOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightOrderLabel.Name = "FlightOrderLabel";
            // 
            // FlightDestinationLabel
            // 
            resources.ApplyResources(this.FlightDestinationLabel, "FlightDestinationLabel");
            this.FlightDestinationLabel.Name = "FlightDestinationLabel";
            // 
            // FlightIdLabel
            // 
            resources.ApplyResources(this.FlightIdLabel, "FlightIdLabel");
            this.FlightIdLabel.Name = "FlightIdLabel";
            // 
            // FlightDestinationTB
            // 
            resources.ApplyResources(this.FlightDestinationTB, "FlightDestinationTB");
            this.FlightDestinationTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightDestinationTB.Name = "FlightDestinationTB";
            this.FlightDestinationTB.TextChanged += new System.EventHandler(this.FlightDestinationTB_TextChanged);
            // 
            // FlightIdTB
            // 
            resources.ApplyResources(this.FlightIdTB, "FlightIdTB");
            this.FlightIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightIdTB.Name = "FlightIdTB";
            this.FlightIdTB.TextChanged += new System.EventHandler(this.FlightIdTB_TextChanged);
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
            // PassengerTab
            // 
            resources.ApplyResources(this.PassengerTab, "PassengerTab");
            this.PassengerTab.Controls.Add(this.PassengerDetailsButton);
            this.PassengerTab.Controls.Add(this.PassengerFilterLabel);
            this.PassengerTab.Controls.Add(this.PassengerOrderLabel);
            this.PassengerTab.Controls.Add(this.PassengerUsernameLabel);
            this.PassengerTab.Controls.Add(this.PassengerIdLabel);
            this.PassengerTab.Controls.Add(this.PassengerUsernameTB);
            this.PassengerTab.Controls.Add(this.PassengerIdTB);
            this.PassengerTab.Controls.Add(this.PassengerUsernameButton);
            this.PassengerTab.Controls.Add(this.PassengerIdButton);
            this.PassengerTab.Controls.Add(this.PassengerListBox);
            this.PassengerTab.Name = "PassengerTab";
            this.PassengerTab.UseVisualStyleBackColor = true;
            // 
            // PassengerDetailsButton
            // 
            resources.ApplyResources(this.PassengerDetailsButton, "PassengerDetailsButton");
            this.PassengerDetailsButton.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerDetailsButton.FlatAppearance.BorderSize = 2;
            this.PassengerDetailsButton.Name = "PassengerDetailsButton";
            this.PassengerDetailsButton.UseVisualStyleBackColor = false;
            this.PassengerDetailsButton.Click += new System.EventHandler(this.PassengerDetailsButton_Click);
            // 
            // PassengerFilterLabel
            // 
            resources.ApplyResources(this.PassengerFilterLabel, "PassengerFilterLabel");
            this.PassengerFilterLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PassengerFilterLabel.Name = "PassengerFilterLabel";
            // 
            // PassengerOrderLabel
            // 
            resources.ApplyResources(this.PassengerOrderLabel, "PassengerOrderLabel");
            this.PassengerOrderLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PassengerOrderLabel.Name = "PassengerOrderLabel";
            // 
            // PassengerUsernameLabel
            // 
            resources.ApplyResources(this.PassengerUsernameLabel, "PassengerUsernameLabel");
            this.PassengerUsernameLabel.Name = "PassengerUsernameLabel";
            // 
            // PassengerIdLabel
            // 
            resources.ApplyResources(this.PassengerIdLabel, "PassengerIdLabel");
            this.PassengerIdLabel.Name = "PassengerIdLabel";
            // 
            // PassengerUsernameTB
            // 
            resources.ApplyResources(this.PassengerUsernameTB, "PassengerUsernameTB");
            this.PassengerUsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerUsernameTB.Name = "PassengerUsernameTB";
            this.PassengerUsernameTB.TextChanged += new System.EventHandler(this.PassengerUsernameTB_TextChanged);
            // 
            // PassengerIdTB
            // 
            resources.ApplyResources(this.PassengerIdTB, "PassengerIdTB");
            this.PassengerIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerIdTB.Name = "PassengerIdTB";
            this.PassengerIdTB.TextChanged += new System.EventHandler(this.PassengerIdTB_TextChanged);
            // 
            // PassengerUsernameButton
            // 
            resources.ApplyResources(this.PassengerUsernameButton, "PassengerUsernameButton");
            this.PassengerUsernameButton.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerUsernameButton.FlatAppearance.BorderSize = 2;
            this.PassengerUsernameButton.Name = "PassengerUsernameButton";
            this.PassengerUsernameButton.UseVisualStyleBackColor = false;
            this.PassengerUsernameButton.Click += new System.EventHandler(this.PassengerUsernameButton_Click);
            // 
            // PassengerIdButton
            // 
            resources.ApplyResources(this.PassengerIdButton, "PassengerIdButton");
            this.PassengerIdButton.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerIdButton.FlatAppearance.BorderSize = 2;
            this.PassengerIdButton.Name = "PassengerIdButton";
            this.PassengerIdButton.UseVisualStyleBackColor = false;
            this.PassengerIdButton.Click += new System.EventHandler(this.PassengerIdButton_Click);
            // 
            // PassengerListBox
            // 
            resources.ApplyResources(this.PassengerListBox, "PassengerListBox");
            this.PassengerListBox.FormattingEnabled = true;
            this.PassengerListBox.Name = "PassengerListBox";
            // 
            // StaffMenuStrip
            // 
            resources.ApplyResources(this.StaffMenuStrip, "StaffMenuStrip");
            this.StaffMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.StaffMenuStrip.Name = "StaffMenuStrip";
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
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
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
            // StaffPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StaffMenuStrip);
            this.Controls.Add(this.tabs);
            this.Name = "StaffPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffPage_FormClosing);
            this.Load += new System.EventHandler(this.StaffPage_Load);
            this.tabs.ResumeLayout(false);
            this.FlightTab.ResumeLayout(false);
            this.FlightTab.PerformLayout();
            this.PassengerTab.ResumeLayout(false);
            this.PassengerTab.PerformLayout();
            this.StaffMenuStrip.ResumeLayout(false);
            this.StaffMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage FlightTab;
        private System.Windows.Forms.TabPage PassengerTab;
        private System.Windows.Forms.ListBox FlightListBox;
        private System.Windows.Forms.Label FlightDestinationLabel;
        private System.Windows.Forms.Label FlightIdLabel;
        private System.Windows.Forms.TextBox FlightDestinationTB;
        private System.Windows.Forms.TextBox FlightIdTB;
        private System.Windows.Forms.Button FlightDestinationButton;
        private System.Windows.Forms.Button FlightIdButton;
        private System.Windows.Forms.Label FlightFilterButton;
        private System.Windows.Forms.Label FlightOrderLabel;
        private System.Windows.Forms.Button FlightDetailsButton;
        private System.Windows.Forms.Button PassengerDetailsButton;
        private System.Windows.Forms.Label PassengerFilterLabel;
        private System.Windows.Forms.Label PassengerOrderLabel;
        private System.Windows.Forms.Label PassengerUsernameLabel;
        private System.Windows.Forms.Label PassengerIdLabel;
        private System.Windows.Forms.TextBox PassengerUsernameTB;
        private System.Windows.Forms.TextBox PassengerIdTB;
        private System.Windows.Forms.Button PassengerUsernameButton;
        private System.Windows.Forms.Button PassengerIdButton;
        private System.Windows.Forms.ListBox PassengerListBox;
        private System.Windows.Forms.MenuStrip StaffMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}