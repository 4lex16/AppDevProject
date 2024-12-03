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
            this.PassengerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlightTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
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
            this.TicketTab = new System.Windows.Forms.TabPage();
            this.TicketPrintButton = new System.Windows.Forms.Button();
            this.TicketRefundButton = new System.Windows.Forms.Button();
            this.TicketDetailsButton = new System.Windows.Forms.Button();
            this.TicketFilterLabel = new System.Windows.Forms.Label();
            this.TicketOrderLabel = new System.Windows.Forms.Label();
            this.TicketDestinationLabel = new System.Windows.Forms.Label();
            this.TicketIdLabel = new System.Windows.Forms.Label();
            this.TicketDestinationTb = new System.Windows.Forms.TextBox();
            this.TicketIdTb = new System.Windows.Forms.TextBox();
            this.TicketDestinationButton = new System.Windows.Forms.Button();
            this.TicketIdButton = new System.Windows.Forms.Button();
            this.TicketListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PassengerMenuStrip.SuspendLayout();
            this.FlightTab.SuspendLayout();
            this.TicketTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassengerMenuStrip
            // 
            this.PassengerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.PassengerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PassengerMenuStrip.Name = "PassengerMenuStrip";
            this.PassengerMenuStrip.Size = new System.Drawing.Size(586, 24);
            this.PassengerMenuStrip.TabIndex = 2;
            this.PassengerMenuStrip.Text = "menuStrip1";
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.ticketListToolStripMenuItem,
            this.flightListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "&Page";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            // 
            // ticketListToolStripMenuItem
            // 
            this.ticketListToolStripMenuItem.Name = "ticketListToolStripMenuItem";
            this.ticketListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ticketListToolStripMenuItem.Text = "&Ticket List";
            // 
            // flightListToolStripMenuItem
            // 
            this.flightListToolStripMenuItem.Name = "flightListToolStripMenuItem";
            this.flightListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flightListToolStripMenuItem.Text = "&Flight List";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // FlightTab
            // 
            this.FlightTab.Controls.Add(this.button1);
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
            this.FlightTab.Size = new System.Drawing.Size(554, 305);
            this.FlightTab.TabIndex = 0;
            this.FlightTab.Text = "Flight";
            this.FlightTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "DateTime";
            this.button1.UseVisualStyleBackColor = false;
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
            this.FlightBuyButton.Text = "Buy";
            this.FlightBuyButton.UseVisualStyleBackColor = false;
            this.FlightBuyButton.Click += new System.EventHandler(this.FlightBuyButton_Click);
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
            // 
            // FlightIdTb
            // 
            this.FlightIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightIdTb.Location = new System.Drawing.Point(144, 40);
            this.FlightIdTb.Name = "FlightIdTb";
            this.FlightIdTb.Size = new System.Drawing.Size(151, 23);
            this.FlightIdTb.TabIndex = 3;
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
            // 
            // FlightListBox
            // 
            this.FlightListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightListBox.FormattingEnabled = true;
            this.FlightListBox.ItemHeight = 16;
            this.FlightListBox.Location = new System.Drawing.Point(6, 65);
            this.FlightListBox.Name = "FlightListBox";
            this.FlightListBox.Size = new System.Drawing.Size(542, 180);
            this.FlightListBox.TabIndex = 0;
            // 
            // TicketTab
            // 
            this.TicketTab.Controls.Add(this.TicketPrintButton);
            this.TicketTab.Controls.Add(this.TicketRefundButton);
            this.TicketTab.Controls.Add(this.TicketDetailsButton);
            this.TicketTab.Controls.Add(this.TicketFilterLabel);
            this.TicketTab.Controls.Add(this.TicketOrderLabel);
            this.TicketTab.Controls.Add(this.TicketDestinationLabel);
            this.TicketTab.Controls.Add(this.TicketIdLabel);
            this.TicketTab.Controls.Add(this.TicketDestinationTb);
            this.TicketTab.Controls.Add(this.TicketIdTb);
            this.TicketTab.Controls.Add(this.TicketDestinationButton);
            this.TicketTab.Controls.Add(this.TicketIdButton);
            this.TicketTab.Controls.Add(this.TicketListBox);
            this.TicketTab.Location = new System.Drawing.Point(4, 25);
            this.TicketTab.Name = "TicketTab";
            this.TicketTab.Padding = new System.Windows.Forms.Padding(3);
            this.TicketTab.Size = new System.Drawing.Size(554, 305);
            this.TicketTab.TabIndex = 1;
            this.TicketTab.Text = "Ticket List";
            this.TicketTab.UseVisualStyleBackColor = true;
            // 
            // TicketPrintButton
            // 
            this.TicketPrintButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketPrintButton.FlatAppearance.BorderSize = 2;
            this.TicketPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketPrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPrintButton.Location = new System.Drawing.Point(218, 257);
            this.TicketPrintButton.Name = "TicketPrintButton";
            this.TicketPrintButton.Size = new System.Drawing.Size(100, 44);
            this.TicketPrintButton.TabIndex = 24;
            this.TicketPrintButton.Text = "Print";
            this.TicketPrintButton.UseVisualStyleBackColor = false;
            this.TicketPrintButton.Click += new System.EventHandler(this.TicketPrintButton_Click);
            // 
            // TicketRefundButton
            // 
            this.TicketRefundButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketRefundButton.FlatAppearance.BorderSize = 2;
            this.TicketRefundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketRefundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketRefundButton.Location = new System.Drawing.Point(112, 257);
            this.TicketRefundButton.Name = "TicketRefundButton";
            this.TicketRefundButton.Size = new System.Drawing.Size(100, 44);
            this.TicketRefundButton.TabIndex = 23;
            this.TicketRefundButton.Text = "Refund";
            this.TicketRefundButton.UseVisualStyleBackColor = false;
            this.TicketRefundButton.Click += new System.EventHandler(this.TicketRefundButton_Click);
            // 
            // TicketDetailsButton
            // 
            this.TicketDetailsButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketDetailsButton.FlatAppearance.BorderSize = 2;
            this.TicketDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketDetailsButton.Location = new System.Drawing.Point(6, 257);
            this.TicketDetailsButton.Name = "TicketDetailsButton";
            this.TicketDetailsButton.Size = new System.Drawing.Size(100, 44);
            this.TicketDetailsButton.TabIndex = 22;
            this.TicketDetailsButton.Text = "Details";
            this.TicketDetailsButton.UseVisualStyleBackColor = false;
            this.TicketDetailsButton.Click += new System.EventHandler(this.TicketDetailsButton_Click);
            // 
            // TicketFilterLabel
            // 
            this.TicketFilterLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TicketFilterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TicketFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketFilterLabel.Location = new System.Drawing.Point(6, 39);
            this.TicketFilterLabel.Name = "TicketFilterLabel";
            this.TicketFilterLabel.Size = new System.Drawing.Size(93, 23);
            this.TicketFilterLabel.TabIndex = 21;
            this.TicketFilterLabel.Text = "Filter By :";
            this.TicketFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TicketOrderLabel
            // 
            this.TicketOrderLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TicketOrderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TicketOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketOrderLabel.Location = new System.Drawing.Point(6, 6);
            this.TicketOrderLabel.Name = "TicketOrderLabel";
            this.TicketOrderLabel.Size = new System.Drawing.Size(93, 23);
            this.TicketOrderLabel.TabIndex = 20;
            this.TicketOrderLabel.Text = "Order By :";
            this.TicketOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TicketDestinationLabel
            // 
            this.TicketDestinationLabel.AutoSize = true;
            this.TicketDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketDestinationLabel.Location = new System.Drawing.Point(301, 42);
            this.TicketDestinationLabel.Name = "TicketDestinationLabel";
            this.TicketDestinationLabel.Size = new System.Drawing.Size(100, 17);
            this.TicketDestinationLabel.TabIndex = 19;
            this.TicketDestinationLabel.Text = "Destination :";
            // 
            // TicketIdLabel
            // 
            this.TicketIdLabel.AutoSize = true;
            this.TicketIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketIdLabel.Location = new System.Drawing.Point(105, 42);
            this.TicketIdLabel.Name = "TicketIdLabel";
            this.TicketIdLabel.Size = new System.Drawing.Size(33, 17);
            this.TicketIdLabel.TabIndex = 18;
            this.TicketIdLabel.Text = "ID :";
            // 
            // TicketDestinationTb
            // 
            this.TicketDestinationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketDestinationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketDestinationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketDestinationTb.Location = new System.Drawing.Point(407, 40);
            this.TicketDestinationTb.Name = "TicketDestinationTb";
            this.TicketDestinationTb.Size = new System.Drawing.Size(141, 23);
            this.TicketDestinationTb.TabIndex = 17;
            // 
            // TicketIdTb
            // 
            this.TicketIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketIdTb.Location = new System.Drawing.Point(144, 40);
            this.TicketIdTb.Name = "TicketIdTb";
            this.TicketIdTb.Size = new System.Drawing.Size(151, 23);
            this.TicketIdTb.TabIndex = 16;
            // 
            // TicketDestinationButton
            // 
            this.TicketDestinationButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketDestinationButton.FlatAppearance.BorderSize = 2;
            this.TicketDestinationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketDestinationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketDestinationButton.Location = new System.Drawing.Point(162, 6);
            this.TicketDestinationButton.Name = "TicketDestinationButton";
            this.TicketDestinationButton.Size = new System.Drawing.Size(105, 29);
            this.TicketDestinationButton.TabIndex = 15;
            this.TicketDestinationButton.Text = "Destination";
            this.TicketDestinationButton.UseVisualStyleBackColor = false;
            // 
            // TicketIdButton
            // 
            this.TicketIdButton.BackColor = System.Drawing.SystemColors.Window;
            this.TicketIdButton.FlatAppearance.BorderSize = 2;
            this.TicketIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketIdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketIdButton.Location = new System.Drawing.Point(108, 6);
            this.TicketIdButton.Name = "TicketIdButton";
            this.TicketIdButton.Size = new System.Drawing.Size(48, 29);
            this.TicketIdButton.TabIndex = 14;
            this.TicketIdButton.Text = "ID";
            this.TicketIdButton.UseVisualStyleBackColor = false;
            // 
            // TicketListBox
            // 
            this.TicketListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketListBox.FormattingEnabled = true;
            this.TicketListBox.ItemHeight = 16;
            this.TicketListBox.Location = new System.Drawing.Point(12, 62);
            this.TicketListBox.Name = "TicketListBox";
            this.TicketListBox.Size = new System.Drawing.Size(542, 180);
            this.TicketListBox.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.TicketTab);
            this.tabControl1.Controls.Add(this.FlightTab);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 334);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // PassengerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 373);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PassengerMenuStrip);
            this.MainMenuStrip = this.PassengerMenuStrip;
            this.Name = "PassengerPage";
            this.Text = "Passenger Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassengerPage_FormClosing);
            this.Load += new System.EventHandler(this.PassengerPage_Load);
            this.PassengerMenuStrip.ResumeLayout(false);
            this.PassengerMenuStrip.PerformLayout();
            this.FlightTab.ResumeLayout(false);
            this.FlightTab.PerformLayout();
            this.TicketTab.ResumeLayout(false);
            this.TicketTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip PassengerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
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
        private System.Windows.Forms.TabPage TicketTab;
        private System.Windows.Forms.Button TicketPrintButton;
        private System.Windows.Forms.Button TicketRefundButton;
        private System.Windows.Forms.Button TicketDetailsButton;
        private System.Windows.Forms.Label TicketFilterLabel;
        private System.Windows.Forms.Label TicketOrderLabel;
        private System.Windows.Forms.Label TicketDestinationLabel;
        private System.Windows.Forms.Label TicketIdLabel;
        private System.Windows.Forms.TextBox TicketDestinationTb;
        private System.Windows.Forms.TextBox TicketIdTb;
        private System.Windows.Forms.Button TicketDestinationButton;
        private System.Windows.Forms.Button TicketIdButton;
        private System.Windows.Forms.ListBox TicketListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
    }
}