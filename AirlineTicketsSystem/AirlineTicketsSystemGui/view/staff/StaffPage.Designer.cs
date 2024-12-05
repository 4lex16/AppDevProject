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
            this.passengerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs.SuspendLayout();
            this.FlightTab.SuspendLayout();
            this.PassengerTab.SuspendLayout();
            this.StaffMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabs.Controls.Add(this.FlightTab);
            this.tabs.Controls.Add(this.PassengerTab);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.ItemSize = new System.Drawing.Size(100, 21);
            this.tabs.Location = new System.Drawing.Point(12, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(642, 334);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 0;
            // 
            // FlightTab
            // 
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
            this.FlightTab.Location = new System.Drawing.Point(4, 25);
            this.FlightTab.Name = "FlightTab";
            this.FlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.FlightTab.Size = new System.Drawing.Size(634, 305);
            this.FlightTab.TabIndex = 0;
            this.FlightTab.Text = "Flight";
            this.FlightTab.UseVisualStyleBackColor = true;
            // 
            // FlightDetailsButton
            // 
            this.FlightDetailsButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightDetailsButton.FlatAppearance.BorderSize = 2;
            this.FlightDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDetailsButton.Location = new System.Drawing.Point(6, 257);
            this.FlightDetailsButton.Name = "FlightDetailsButton";
            this.FlightDetailsButton.Size = new System.Drawing.Size(100, 44);
            this.FlightDetailsButton.TabIndex = 9;
            this.FlightDetailsButton.Text = "Details";
            this.FlightDetailsButton.UseVisualStyleBackColor = false;
            this.FlightDetailsButton.Click += new System.EventHandler(this.FlightDetailsButton_Click);
            // 
            // FlightFilterButton
            // 
            this.FlightFilterButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightFilterButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightFilterButton.Location = new System.Drawing.Point(6, 39);
            this.FlightFilterButton.Name = "FlightFilterButton";
            this.FlightFilterButton.Size = new System.Drawing.Size(93, 23);
            this.FlightFilterButton.TabIndex = 8;
            this.FlightFilterButton.Text = "Filter By :";
            this.FlightFilterButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FlightOrderLabel
            // 
            this.FlightOrderLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FlightOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightOrderLabel.Location = new System.Drawing.Point(6, 6);
            this.FlightOrderLabel.Name = "FlightOrderLabel";
            this.FlightOrderLabel.Size = new System.Drawing.Size(93, 23);
            this.FlightOrderLabel.TabIndex = 7;
            this.FlightOrderLabel.Text = "Order By :";
            this.FlightOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FlightDestinationLabel
            // 
            this.FlightDestinationLabel.AutoSize = true;
            this.FlightDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDestinationLabel.Location = new System.Drawing.Point(301, 42);
            this.FlightDestinationLabel.Name = "FlightDestinationLabel";
            this.FlightDestinationLabel.Size = new System.Drawing.Size(100, 17);
            this.FlightDestinationLabel.TabIndex = 6;
            this.FlightDestinationLabel.Text = "Destination :";
            // 
            // FlightIdLabel
            // 
            this.FlightIdLabel.AutoSize = true;
            this.FlightIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightIdLabel.Location = new System.Drawing.Point(105, 42);
            this.FlightIdLabel.Name = "FlightIdLabel";
            this.FlightIdLabel.Size = new System.Drawing.Size(33, 17);
            this.FlightIdLabel.TabIndex = 5;
            this.FlightIdLabel.Text = "ID :";
            // 
            // FlightDestinationTB
            // 
            this.FlightDestinationTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightDestinationTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightDestinationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDestinationTB.Location = new System.Drawing.Point(407, 40);
            this.FlightDestinationTB.Name = "FlightDestinationTB";
            this.FlightDestinationTB.Size = new System.Drawing.Size(176, 23);
            this.FlightDestinationTB.TabIndex = 4;
            this.FlightDestinationTB.TextChanged += new System.EventHandler(this.FlightDestinationTB_TextChanged);
            // 
            // FlightIdTB
            // 
            this.FlightIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightIdTB.Location = new System.Drawing.Point(144, 40);
            this.FlightIdTB.Name = "FlightIdTB";
            this.FlightIdTB.Size = new System.Drawing.Size(151, 23);
            this.FlightIdTB.TabIndex = 3;
            this.FlightIdTB.TextChanged += new System.EventHandler(this.FlightIdTB_TextChanged);
            // 
            // FlightDestinationButton
            // 
            this.FlightDestinationButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightDestinationButton.FlatAppearance.BorderSize = 2;
            this.FlightDestinationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightDestinationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDestinationButton.Location = new System.Drawing.Point(181, 6);
            this.FlightDestinationButton.Name = "FlightDestinationButton";
            this.FlightDestinationButton.Size = new System.Drawing.Size(114, 29);
            this.FlightDestinationButton.TabIndex = 2;
            this.FlightDestinationButton.Text = "Destination";
            this.FlightDestinationButton.UseVisualStyleBackColor = false;
            this.FlightDestinationButton.Click += new System.EventHandler(this.FlightDestinationButton_Click);
            // 
            // FlightIdButton
            // 
            this.FlightIdButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightIdButton.FlatAppearance.BorderSize = 2;
            this.FlightIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightIdButton.Location = new System.Drawing.Point(108, 6);
            this.FlightIdButton.Name = "FlightIdButton";
            this.FlightIdButton.Size = new System.Drawing.Size(67, 29);
            this.FlightIdButton.TabIndex = 1;
            this.FlightIdButton.Text = "ID";
            this.FlightIdButton.UseVisualStyleBackColor = false;
            this.FlightIdButton.Click += new System.EventHandler(this.FlightIdButton_Click);
            // 
            // FlightListBox
            // 
            this.FlightListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightListBox.FormattingEnabled = true;
            this.FlightListBox.ItemHeight = 16;
            this.FlightListBox.Location = new System.Drawing.Point(6, 65);
            this.FlightListBox.Name = "FlightListBox";
            this.FlightListBox.Size = new System.Drawing.Size(622, 180);
            this.FlightListBox.TabIndex = 0;
            // 
            // PassengerTab
            // 
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
            this.PassengerTab.Location = new System.Drawing.Point(4, 25);
            this.PassengerTab.Name = "PassengerTab";
            this.PassengerTab.Padding = new System.Windows.Forms.Padding(3);
            this.PassengerTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassengerTab.Size = new System.Drawing.Size(634, 305);
            this.PassengerTab.TabIndex = 1;
            this.PassengerTab.Text = "Passenger";
            this.PassengerTab.UseVisualStyleBackColor = true;
            // 
            // PassengerDetailsButton
            // 
            this.PassengerDetailsButton.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerDetailsButton.FlatAppearance.BorderSize = 2;
            this.PassengerDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerDetailsButton.Location = new System.Drawing.Point(6, 257);
            this.PassengerDetailsButton.Name = "PassengerDetailsButton";
            this.PassengerDetailsButton.Size = new System.Drawing.Size(100, 44);
            this.PassengerDetailsButton.TabIndex = 22;
            this.PassengerDetailsButton.Text = "Details";
            this.PassengerDetailsButton.UseVisualStyleBackColor = false;
            this.PassengerDetailsButton.Click += new System.EventHandler(this.PassengerDetailsButton_Click);
            // 
            // PassengerFilterLabel
            // 
            this.PassengerFilterLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PassengerFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerFilterLabel.Location = new System.Drawing.Point(6, 39);
            this.PassengerFilterLabel.Name = "PassengerFilterLabel";
            this.PassengerFilterLabel.Size = new System.Drawing.Size(93, 23);
            this.PassengerFilterLabel.TabIndex = 21;
            this.PassengerFilterLabel.Text = "Filter By :";
            this.PassengerFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassengerOrderLabel
            // 
            this.PassengerOrderLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PassengerOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerOrderLabel.Location = new System.Drawing.Point(6, 6);
            this.PassengerOrderLabel.Name = "PassengerOrderLabel";
            this.PassengerOrderLabel.Size = new System.Drawing.Size(93, 23);
            this.PassengerOrderLabel.TabIndex = 20;
            this.PassengerOrderLabel.Text = "Order By :";
            this.PassengerOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassengerUsernameLabel
            // 
            this.PassengerUsernameLabel.AutoSize = true;
            this.PassengerUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerUsernameLabel.Location = new System.Drawing.Point(296, 42);
            this.PassengerUsernameLabel.Name = "PassengerUsernameLabel";
            this.PassengerUsernameLabel.Size = new System.Drawing.Size(129, 17);
            this.PassengerUsernameLabel.TabIndex = 19;
            this.PassengerUsernameLabel.Text = "Passenger name";
            // 
            // PassengerIdLabel
            // 
            this.PassengerIdLabel.AutoSize = true;
            this.PassengerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerIdLabel.Location = new System.Drawing.Point(105, 42);
            this.PassengerIdLabel.Name = "PassengerIdLabel";
            this.PassengerIdLabel.Size = new System.Drawing.Size(33, 17);
            this.PassengerIdLabel.TabIndex = 18;
            this.PassengerIdLabel.Text = "ID :";
            // 
            // PassengerUsernameTB
            // 
            this.PassengerUsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerUsernameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerUsernameTB.Location = new System.Drawing.Point(431, 40);
            this.PassengerUsernameTB.Name = "PassengerUsernameTB";
            this.PassengerUsernameTB.Size = new System.Drawing.Size(156, 23);
            this.PassengerUsernameTB.TabIndex = 17;
            this.PassengerUsernameTB.TextChanged += new System.EventHandler(this.PassengerUsernameTB_TextChanged);
            // 
            // PassengerIdTB
            // 
            this.PassengerIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerIdTB.Location = new System.Drawing.Point(144, 40);
            this.PassengerIdTB.Name = "PassengerIdTB";
            this.PassengerIdTB.Size = new System.Drawing.Size(136, 23);
            this.PassengerIdTB.TabIndex = 16;
            this.PassengerIdTB.TextChanged += new System.EventHandler(this.PassengerIdTB_TextChanged);
            // 
            // PassengerUsernameButton
            // 
            this.PassengerUsernameButton.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerUsernameButton.FlatAppearance.BorderSize = 2;
            this.PassengerUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerUsernameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerUsernameButton.Location = new System.Drawing.Point(181, 6);
            this.PassengerUsernameButton.Name = "PassengerUsernameButton";
            this.PassengerUsernameButton.Size = new System.Drawing.Size(159, 29);
            this.PassengerUsernameButton.TabIndex = 15;
            this.PassengerUsernameButton.Text = "Passenger Name";
            this.PassengerUsernameButton.UseVisualStyleBackColor = false;
            this.PassengerUsernameButton.Click += new System.EventHandler(this.PassengerUsernameButton_Click);
            // 
            // PassengerIdButton
            // 
            this.PassengerIdButton.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerIdButton.FlatAppearance.BorderSize = 2;
            this.PassengerIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerIdButton.Location = new System.Drawing.Point(108, 6);
            this.PassengerIdButton.Name = "PassengerIdButton";
            this.PassengerIdButton.Size = new System.Drawing.Size(67, 29);
            this.PassengerIdButton.TabIndex = 14;
            this.PassengerIdButton.Text = "ID";
            this.PassengerIdButton.UseVisualStyleBackColor = false;
            this.PassengerIdButton.Click += new System.EventHandler(this.PassengerIdButton_Click);
            // 
            // PassengerListBox
            // 
            this.PassengerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassengerListBox.FormattingEnabled = true;
            this.PassengerListBox.ItemHeight = 16;
            this.PassengerListBox.Location = new System.Drawing.Point(6, 65);
            this.PassengerListBox.Name = "PassengerListBox";
            this.PassengerListBox.Size = new System.Drawing.Size(622, 180);
            this.PassengerListBox.TabIndex = 13;
            // 
            // StaffMenuStrip
            // 
            this.StaffMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.StaffMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StaffMenuStrip.Name = "StaffMenuStrip";
            this.StaffMenuStrip.Size = new System.Drawing.Size(666, 24);
            this.StaffMenuStrip.TabIndex = 3;
            this.StaffMenuStrip.Text = "menuStrip1";
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.passengerListToolStripMenuItem,
            this.flightListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "&Page";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // passengerListToolStripMenuItem
            // 
            this.passengerListToolStripMenuItem.Name = "passengerListToolStripMenuItem";
            this.passengerListToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.passengerListToolStripMenuItem.Text = "Pa&ssenger List";
            this.passengerListToolStripMenuItem.Click += new System.EventHandler(this.passengerListToolStripMenuItem_Click);
            // 
            // flightListToolStripMenuItem
            // 
            this.flightListToolStripMenuItem.Name = "flightListToolStripMenuItem";
            this.flightListToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.flightListToolStripMenuItem.Text = "&Flight List";
            this.flightListToolStripMenuItem.Click += new System.EventHandler(this.flightListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "&Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "&Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frenchToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.frenchToolStripMenuItem.Text = "F&rançais";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "E&nglish";
            // 
            // StaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 373);
            this.Controls.Add(this.StaffMenuStrip);
            this.Controls.Add(this.tabs);
            this.Name = "StaffPage";
            this.Text = "Staff Page";
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
        private System.Windows.Forms.ToolStripMenuItem passengerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}