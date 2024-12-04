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
            this.AdminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.AdminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.AdminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AdminMenuStrip.Name = "AdminMenuStrip";
            this.AdminMenuStrip.Size = new System.Drawing.Size(586, 24);
            this.AdminMenuStrip.TabIndex = 5;
            this.AdminMenuStrip.Text = "menuStrip1";
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "&Page";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "&Admin";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem1.Text = "&Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "E&nglish";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.frenchToolStripMenuItem.Text = "F&rançais";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.spanishToolStripMenuItem.Text = "&Spanish";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.StaffTab);
            this.tabControl1.Controls.Add(this.FlightTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 335);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 6;
            // 
            // StaffTab
            // 
            this.StaffTab.AutoScroll = true;
            this.StaffTab.Controls.Add(this.StaffRemoveButton);
            this.StaffTab.Controls.Add(this.StaffEditButton);
            this.StaffTab.Controls.Add(this.StaffAddButton);
            this.StaffTab.Controls.Add(this.StaffDetailsButton);
            this.StaffTab.Controls.Add(this.StaffFilterLabel);
            this.StaffTab.Controls.Add(this.StaffIdLabel);
            this.StaffTab.Controls.Add(this.StaffIdTb);
            this.StaffTab.Controls.Add(this.StaffListBox);
            this.StaffTab.Location = new System.Drawing.Point(4, 25);
            this.StaffTab.Name = "StaffTab";
            this.StaffTab.Padding = new System.Windows.Forms.Padding(3);
            this.StaffTab.Size = new System.Drawing.Size(554, 306);
            this.StaffTab.TabIndex = 1;
            this.StaffTab.Text = "Staff";
            this.StaffTab.UseVisualStyleBackColor = true;
            // 
            // StaffRemoveButton
            // 
            this.StaffRemoveButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffRemoveButton.FlatAppearance.BorderSize = 2;
            this.StaffRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffRemoveButton.Location = new System.Drawing.Point(323, 256);
            this.StaffRemoveButton.Name = "StaffRemoveButton";
            this.StaffRemoveButton.Size = new System.Drawing.Size(100, 44);
            this.StaffRemoveButton.TabIndex = 24;
            this.StaffRemoveButton.Text = "Remove";
            this.StaffRemoveButton.UseVisualStyleBackColor = false;
            this.StaffRemoveButton.Click += new System.EventHandler(this.StaffRemoveButton_Click);
            // 
            // StaffEditButton
            // 
            this.StaffEditButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffEditButton.FlatAppearance.BorderSize = 2;
            this.StaffEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffEditButton.Location = new System.Drawing.Point(217, 257);
            this.StaffEditButton.Name = "StaffEditButton";
            this.StaffEditButton.Size = new System.Drawing.Size(100, 44);
            this.StaffEditButton.TabIndex = 23;
            this.StaffEditButton.Text = "Edit";
            this.StaffEditButton.UseVisualStyleBackColor = false;
            this.StaffEditButton.Click += new System.EventHandler(this.StaffEditButton_Click);
            // 
            // StaffAddButton
            // 
            this.StaffAddButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffAddButton.FlatAppearance.BorderSize = 2;
            this.StaffAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffAddButton.Location = new System.Drawing.Point(111, 257);
            this.StaffAddButton.Name = "StaffAddButton";
            this.StaffAddButton.Size = new System.Drawing.Size(100, 44);
            this.StaffAddButton.TabIndex = 22;
            this.StaffAddButton.Text = "Add";
            this.StaffAddButton.UseVisualStyleBackColor = false;
            this.StaffAddButton.Click += new System.EventHandler(this.StaffAddButton_Click);
            // 
            // StaffDetailsButton
            // 
            this.StaffDetailsButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffDetailsButton.FlatAppearance.BorderSize = 2;
            this.StaffDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffDetailsButton.Location = new System.Drawing.Point(5, 257);
            this.StaffDetailsButton.Name = "StaffDetailsButton";
            this.StaffDetailsButton.Size = new System.Drawing.Size(100, 44);
            this.StaffDetailsButton.TabIndex = 21;
            this.StaffDetailsButton.Text = "Details";
            this.StaffDetailsButton.UseVisualStyleBackColor = false;
            this.StaffDetailsButton.Click += new System.EventHandler(this.StaffDetailsButton_Click);
            // 
            // StaffFilterLabel
            // 
            this.StaffFilterLabel.BackColor = System.Drawing.SystemColors.Window;
            this.StaffFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StaffFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffFilterLabel.Location = new System.Drawing.Point(5, 39);
            this.StaffFilterLabel.Name = "StaffFilterLabel";
            this.StaffFilterLabel.Size = new System.Drawing.Size(93, 23);
            this.StaffFilterLabel.TabIndex = 20;
            this.StaffFilterLabel.Text = "Filter By :";
            this.StaffFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaffIdLabel
            // 
            this.StaffIdLabel.AutoSize = true;
            this.StaffIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIdLabel.Location = new System.Drawing.Point(104, 42);
            this.StaffIdLabel.Name = "StaffIdLabel";
            this.StaffIdLabel.Size = new System.Drawing.Size(33, 17);
            this.StaffIdLabel.TabIndex = 17;
            this.StaffIdLabel.Text = "ID :";
            // 
            // StaffIdTb
            // 
            this.StaffIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIdTb.Location = new System.Drawing.Point(143, 39);
            this.StaffIdTb.Name = "StaffIdTb";
            this.StaffIdTb.Size = new System.Drawing.Size(151, 23);
            this.StaffIdTb.TabIndex = 15;
            this.StaffIdTb.TextChanged += new System.EventHandler(this.StaffIdTb_TextChanged);
            // 
            // StaffListBox
            // 
            this.StaffListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.ItemHeight = 16;
            this.StaffListBox.Location = new System.Drawing.Point(8, 71);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.Size = new System.Drawing.Size(542, 180);
            this.StaffListBox.TabIndex = 12;
            // 
            // FlightTab
            // 
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
            this.FlightTab.Location = new System.Drawing.Point(4, 25);
            this.FlightTab.Name = "FlightTab";
            this.FlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.FlightTab.Size = new System.Drawing.Size(554, 306);
            this.FlightTab.TabIndex = 0;
            this.FlightTab.Text = "Flight";
            this.FlightTab.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton.FlatAppearance.BorderSize = 2;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(324, 256);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 44);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // FlightEditButton
            // 
            this.FlightEditButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightEditButton.FlatAppearance.BorderSize = 2;
            this.FlightEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightEditButton.Location = new System.Drawing.Point(218, 257);
            this.FlightEditButton.Name = "FlightEditButton";
            this.FlightEditButton.Size = new System.Drawing.Size(100, 44);
            this.FlightEditButton.TabIndex = 11;
            this.FlightEditButton.Text = "Edit";
            this.FlightEditButton.UseVisualStyleBackColor = false;
            this.FlightEditButton.Click += new System.EventHandler(this.FlightEditButton_Click);
            // 
            // FlightBuyButton
            // 
            this.FlightBuyButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightBuyButton.FlatAppearance.BorderSize = 2;
            this.FlightBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightBuyButton.Location = new System.Drawing.Point(112, 257);
            this.FlightBuyButton.Name = "FlightBuyButton";
            this.FlightBuyButton.Size = new System.Drawing.Size(100, 44);
            this.FlightBuyButton.TabIndex = 10;
            this.FlightBuyButton.Text = "Add";
            this.FlightBuyButton.UseVisualStyleBackColor = false;
            this.FlightBuyButton.Click += new System.EventHandler(this.FlightAddButton_Click);
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
            // FlightFilterLabel
            // 
            this.FlightFilterLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FlightFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightFilterLabel.Location = new System.Drawing.Point(6, 39);
            this.FlightFilterLabel.Name = "FlightFilterLabel";
            this.FlightFilterLabel.Size = new System.Drawing.Size(93, 23);
            this.FlightFilterLabel.TabIndex = 8;
            this.FlightFilterLabel.Text = "Filter By :";
            this.FlightFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // FlightDestinationTb
            // 
            this.FlightDestinationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightDestinationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightDestinationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDestinationTb.Location = new System.Drawing.Point(407, 40);
            this.FlightDestinationTb.Name = "FlightDestinationTb";
            this.FlightDestinationTb.Size = new System.Drawing.Size(141, 23);
            this.FlightDestinationTb.TabIndex = 4;
            this.FlightDestinationTb.TextChanged += new System.EventHandler(this.FlightDestinationTb_TextChanged);
            // 
            // FlightIdTb
            // 
            this.FlightIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightIdTb.Location = new System.Drawing.Point(144, 40);
            this.FlightIdTb.Name = "FlightIdTb";
            this.FlightIdTb.Size = new System.Drawing.Size(151, 23);
            this.FlightIdTb.TabIndex = 3;
            this.FlightIdTb.TextChanged += new System.EventHandler(this.FlightIdTb_TextChanged);
            // 
            // FlightDestinationButton
            // 
            this.FlightDestinationButton.BackColor = System.Drawing.SystemColors.Window;
            this.FlightDestinationButton.FlatAppearance.BorderSize = 2;
            this.FlightDestinationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlightDestinationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDestinationButton.Location = new System.Drawing.Point(162, 6);
            this.FlightDestinationButton.Name = "FlightDestinationButton";
            this.FlightDestinationButton.Size = new System.Drawing.Size(105, 29);
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
            this.FlightIdButton.Size = new System.Drawing.Size(48, 29);
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
            this.FlightListBox.Location = new System.Drawing.Point(9, 71);
            this.FlightListBox.Name = "FlightListBox";
            this.FlightListBox.Size = new System.Drawing.Size(542, 180);
            this.FlightListBox.TabIndex = 0;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.Window;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(515, 0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(71, 24);
            this.RefreshButton.TabIndex = 13;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 374);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AdminMenuStrip);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
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

        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;

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
    }
}