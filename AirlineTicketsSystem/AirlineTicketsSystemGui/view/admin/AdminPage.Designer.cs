namespace AirlineTicketsSystemGui
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.AdminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StaffTab = new System.Windows.Forms.TabPage();
            this.StaffRemoveButton = new System.Windows.Forms.Button();
            this.StaffEditButton = new System.Windows.Forms.Button();
            this.StaffAddButton = new System.Windows.Forms.Button();
            this.StaffDetailsButton = new System.Windows.Forms.Button();
            this.StaffFilterLabel = new System.Windows.Forms.Label();
            this.StaffIdLabel = new System.Windows.Forms.Label();
            this.StaffIdTb = new System.Windows.Forms.TextBox();
            this.StaffListBox = new System.Windows.Forms.ListBox();
            this.FlightTab = new System.Windows.Forms.TabPage();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FlightEditButton = new System.Windows.Forms.Button();
            this.FlightBuyButton = new System.Windows.Forms.Button();
            this.FlightDetailsButton = new System.Windows.Forms.Button();
            this.FlightFilterLabel = new System.Windows.Forms.Label();
            this.FlightOrderLabel = new System.Windows.Forms.Label();
            this.FlightDestinationLabel = new System.Windows.Forms.Label();
            this.FlightIdLabel = new System.Windows.Forms.Label();
            this.FlightDestinationTb = new System.Windows.Forms.TextBox();
            this.FlightIdTb = new System.Windows.Forms.TextBox();
            this.FlightDestinationButton = new System.Windows.Forms.Button();
            this.FlightIdButton = new System.Windows.Forms.Button();
            this.FlightListBox = new System.Windows.Forms.ListBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AdminMenuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.StaffTab.SuspendLayout();
            this.FlightTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminMenuStrip
            // 
            resources.ApplyResources(this.AdminMenuStrip, "AdminMenuStrip");
            this.AdminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.AdminMenuStrip.Name = "AdminMenuStrip";
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
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.StaffTab);
            this.tabControl1.Controls.Add(this.FlightTab);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // StaffTab
            // 
            resources.ApplyResources(this.StaffTab, "StaffTab");
            this.StaffTab.Controls.Add(this.StaffRemoveButton);
            this.StaffTab.Controls.Add(this.StaffEditButton);
            this.StaffTab.Controls.Add(this.StaffAddButton);
            this.StaffTab.Controls.Add(this.StaffDetailsButton);
            this.StaffTab.Controls.Add(this.StaffFilterLabel);
            this.StaffTab.Controls.Add(this.StaffIdLabel);
            this.StaffTab.Controls.Add(this.StaffIdTb);
            this.StaffTab.Controls.Add(this.StaffListBox);
            this.StaffTab.Name = "StaffTab";
            this.StaffTab.UseVisualStyleBackColor = true;
            // 
            // StaffRemoveButton
            // 
            resources.ApplyResources(this.StaffRemoveButton, "StaffRemoveButton");
            this.StaffRemoveButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffRemoveButton.FlatAppearance.BorderSize = 2;
            this.StaffRemoveButton.Name = "StaffRemoveButton";
            this.StaffRemoveButton.UseVisualStyleBackColor = false;
            this.StaffRemoveButton.Click += new System.EventHandler(this.StaffRemoveButton_Click);
            // 
            // StaffEditButton
            // 
            resources.ApplyResources(this.StaffEditButton, "StaffEditButton");
            this.StaffEditButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffEditButton.FlatAppearance.BorderSize = 2;
            this.StaffEditButton.Name = "StaffEditButton";
            this.StaffEditButton.UseVisualStyleBackColor = false;
            this.StaffEditButton.Click += new System.EventHandler(this.StaffEditButton_Click);
            // 
            // StaffAddButton
            // 
            resources.ApplyResources(this.StaffAddButton, "StaffAddButton");
            this.StaffAddButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffAddButton.FlatAppearance.BorderSize = 2;
            this.StaffAddButton.Name = "StaffAddButton";
            this.StaffAddButton.UseVisualStyleBackColor = false;
            this.StaffAddButton.Click += new System.EventHandler(this.StaffAddButton_Click);
            // 
            // StaffDetailsButton
            // 
            resources.ApplyResources(this.StaffDetailsButton, "StaffDetailsButton");
            this.StaffDetailsButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffDetailsButton.FlatAppearance.BorderSize = 2;
            this.StaffDetailsButton.Name = "StaffDetailsButton";
            this.StaffDetailsButton.UseVisualStyleBackColor = false;
            this.StaffDetailsButton.Click += new System.EventHandler(this.StaffDetailsButton_Click);
            // 
            // StaffFilterLabel
            // 
            resources.ApplyResources(this.StaffFilterLabel, "StaffFilterLabel");
            this.StaffFilterLabel.BackColor = System.Drawing.SystemColors.Window;
            this.StaffFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StaffFilterLabel.Name = "StaffFilterLabel";
            // 
            // StaffIdLabel
            // 
            resources.ApplyResources(this.StaffIdLabel, "StaffIdLabel");
            this.StaffIdLabel.Name = "StaffIdLabel";
            // 
            // StaffIdTb
            // 
            resources.ApplyResources(this.StaffIdTb, "StaffIdTb");
            this.StaffIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffIdTb.Name = "StaffIdTb";
            this.StaffIdTb.TextChanged += new System.EventHandler(this.StaffIdTb_TextChanged);
            // 
            // StaffListBox
            // 
            resources.ApplyResources(this.StaffListBox, "StaffListBox");
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.Name = "StaffListBox";
            // 
            // FlightTab
            // 
            resources.ApplyResources(this.FlightTab, "FlightTab");
            this.FlightTab.Controls.Add(this.CancelButton);
            this.FlightTab.Controls.Add(this.FlightEditButton);
            this.FlightTab.Controls.Add(this.FlightBuyButton);
            this.FlightTab.Controls.Add(this.FlightDetailsButton);
            this.FlightTab.Controls.Add(this.FlightFilterLabel);
            this.FlightTab.Controls.Add(this.FlightOrderLabel);
            this.FlightTab.Controls.Add(this.FlightDestinationLabel);
            this.FlightTab.Controls.Add(this.FlightIdLabel);
            this.FlightTab.Controls.Add(this.FlightDestinationTb);
            this.FlightTab.Controls.Add(this.FlightIdTb);
            this.FlightTab.Controls.Add(this.FlightDestinationButton);
            this.FlightTab.Controls.Add(this.FlightIdButton);
            this.FlightTab.Controls.Add(this.FlightListBox);
            this.FlightTab.Name = "FlightTab";
            this.FlightTab.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton.FlatAppearance.BorderSize = 2;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // FlightEditButton
            // 
            resources.ApplyResources(this.FlightEditButton, "FlightEditButton");
            this.FlightEditButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightEditButton.FlatAppearance.BorderSize = 2;
            this.FlightEditButton.Name = "FlightEditButton";
            this.FlightEditButton.UseVisualStyleBackColor = false;
            this.FlightEditButton.Click += new System.EventHandler(this.FlightEditButton_Click);
            // 
            // FlightBuyButton
            // 
            resources.ApplyResources(this.FlightBuyButton, "FlightBuyButton");
            this.FlightBuyButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightBuyButton.FlatAppearance.BorderSize = 2;
            this.FlightBuyButton.Name = "FlightBuyButton";
            this.FlightBuyButton.UseVisualStyleBackColor = false;
            this.FlightBuyButton.Click += new System.EventHandler(this.FlightAddButton_Click);
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
            // FlightFilterLabel
            // 
            resources.ApplyResources(this.FlightFilterLabel, "FlightFilterLabel");
            this.FlightFilterLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FlightFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightFilterLabel.Name = "FlightFilterLabel";
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
            // FlightDestinationTb
            // 
            resources.ApplyResources(this.FlightDestinationTb, "FlightDestinationTb");
            this.FlightDestinationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightDestinationTb.Name = "FlightDestinationTb";
            this.FlightDestinationTb.TextChanged += new System.EventHandler(this.FlightDestinationTb_TextChanged);
            // 
            // FlightIdTb
            // 
            resources.ApplyResources(this.FlightIdTb, "FlightIdTb");
            this.FlightIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightIdTb.Name = "FlightIdTb";
            this.FlightIdTb.TextChanged += new System.EventHandler(this.FlightIdTb_TextChanged);
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
            // RefreshButton
            // 
            resources.ApplyResources(this.RefreshButton, "RefreshButton");
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Window;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AdminPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AdminMenuStrip);
            this.Name = "AdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPage_FormClosing);
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.AdminMenuStrip.ResumeLayout(false);
            this.AdminMenuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.StaffTab.ResumeLayout(false);
            this.StaffTab.PerformLayout();
            this.FlightTab.ResumeLayout(false);
            this.FlightTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button CancelButton;

        #endregion
        private System.Windows.Forms.MenuStrip AdminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StaffTab;
        private System.Windows.Forms.TabPage FlightTab;
        private System.Windows.Forms.Button FlightBuyButton;
        private System.Windows.Forms.Button FlightDetailsButton;
        private System.Windows.Forms.Label FlightFilterLabel;
        private System.Windows.Forms.Label FlightOrderLabel;
        private System.Windows.Forms.Label FlightDestinationLabel;
        private System.Windows.Forms.Label FlightIdLabel;
        private System.Windows.Forms.TextBox FlightDestinationTb;
        private System.Windows.Forms.TextBox FlightIdTb;
        private System.Windows.Forms.Button FlightDestinationButton;
        private System.Windows.Forms.Button FlightIdButton;
        private System.Windows.Forms.ListBox FlightListBox;
        private System.Windows.Forms.Button FlightEditButton;
        private System.Windows.Forms.Button StaffEditButton;
        private System.Windows.Forms.Button StaffAddButton;
        private System.Windows.Forms.Button StaffDetailsButton;
        private System.Windows.Forms.Label StaffFilterLabel;
        private System.Windows.Forms.Label StaffIdLabel;
        private System.Windows.Forms.TextBox StaffIdTb;
        private System.Windows.Forms.ListBox StaffListBox;
        private System.Windows.Forms.Button StaffRemoveButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}