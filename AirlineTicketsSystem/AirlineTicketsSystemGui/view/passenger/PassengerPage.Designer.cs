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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ticketListToolStripMenuItem
            // 
            this.ticketListToolStripMenuItem.Name = "ticketListToolStripMenuItem";
            this.ticketListToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ticketListToolStripMenuItem.Text = "&Ticket List";
            // 
            // flightListToolStripMenuItem
            // 
            this.flightListToolStripMenuItem.Name = "flightListToolStripMenuItem";
            this.flightListToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.flightListToolStripMenuItem.Text = "&Flight List";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
            this.FlightTab.Controls.Add(this.FilghtDateButton);
            this.FlightTab.Controls.Add(this.FlightBuyButton);
            this.FlightTab.Controls.Add(this.FlightDetailsButton);
            this.FlightTab.Controls.Add(this.FlightOrderLabel);
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
            // FilghtDateButton
            // 
            this.FilghtDateButton.BackColor = System.Drawing.SystemColors.Window;
            this.FilghtDateButton.FlatAppearance.BorderSize = 2;
            this.FilghtDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilghtDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilghtDateButton.Location = new System.Drawing.Point(273, 6);
            this.FilghtDateButton.Name = "FilghtDateButton";
            this.FilghtDateButton.Size = new System.Drawing.Size(70, 29);
            this.FilghtDateButton.TabIndex = 11;
            this.FilghtDateButton.Text = "Date";
            this.FilghtDateButton.UseVisualStyleBackColor = false;
            this.FilghtDateButton.Click += new System.EventHandler(this.FilghtDateButton_Click);
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
            this.FlightListBox.Location = new System.Drawing.Point(6, 41);
            this.FlightListBox.Name = "FlightListBox";
            this.FlightListBox.Size = new System.Drawing.Size(542, 212);
            this.FlightListBox.TabIndex = 0;
            // 
            // TicketTab
            // 
            this.TicketTab.Controls.Add(this.TicketPrintButton);
            this.TicketTab.Controls.Add(this.TicketRefundButton);
            this.TicketTab.Controls.Add(this.TicketDetailsButton);
            this.TicketTab.Controls.Add(this.TicketOrderLabel);
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
            this.TicketIdButton.Click += new System.EventHandler(this.TicketIdButton_Click);
            // 
            // TicketListBox
            // 
            this.TicketListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketListBox.FormattingEnabled = true;
            this.TicketListBox.ItemHeight = 16;
            this.TicketListBox.Location = new System.Drawing.Point(12, 41);
            this.TicketListBox.Name = "TicketListBox";
            this.TicketListBox.Size = new System.Drawing.Size(542, 212);
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
    }
}