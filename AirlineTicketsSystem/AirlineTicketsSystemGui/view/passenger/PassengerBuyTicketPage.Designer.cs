using System.ComponentModel;

namespace AirlineTicketsSystemGui
{
    partial class PassengerBuyTicketPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateTb = new System.Windows.Forms.TextBox();
            this.TimeTb = new System.Windows.Forms.TextBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FlightDetailsGb = new System.Windows.Forms.GroupBox();
            this.FirstClassLabel = new System.Windows.Forms.Label();
            this.FirstClassTb = new System.Windows.Forms.TextBox();
            this.BusinessClassLabel = new System.Windows.Forms.Label();
            this.BusinessClassTb = new System.Windows.Forms.TextBox();
            this.CoachClassLabel = new System.Windows.Forms.Label();
            this.CoachClassTb = new System.Windows.Forms.TextBox();
            this.CvvCvcLabel = new System.Windows.Forms.Label();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.CvvCvcTb = new System.Windows.Forms.TextBox();
            this.ExpirationDateTb = new System.Windows.Forms.TextBox();
            this.CardNumberTb = new System.Windows.Forms.TextBox();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.SeatTypeCb = new System.Windows.Forms.ComboBox();
            this.SeatTypeLabel = new System.Windows.Forms.Label();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.PassengerMenuStrip.SuspendLayout();
            this.FlightDetailsGb.SuspendLayout();
            this.InformationGroupBox.SuspendLayout();
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
            this.PassengerMenuStrip.Size = new System.Drawing.Size(448, 24);
            this.PassengerMenuStrip.TabIndex = 4;
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ticketListToolStripMenuItem
            // 
            this.ticketListToolStripMenuItem.Name = "ticketListToolStripMenuItem";
            this.ticketListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ticketListToolStripMenuItem.Text = "&Ticket List";
            this.ticketListToolStripMenuItem.Click += new System.EventHandler(this.ticketListToolStripMenuItem_Click);
            // 
            // flightListToolStripMenuItem
            // 
            this.flightListToolStripMenuItem.Name = "flightListToolStripMenuItem";
            this.flightListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flightListToolStripMenuItem.Text = "&Flight List";
            this.flightListToolStripMenuItem.Click += new System.EventHandler(this.flightListToolStripMenuItem_Click);
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
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // DestinationLabel
            // 
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(12, 19);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(110, 36);
            this.DestinationLabel.TabIndex = 5;
            this.DestinationLabel.Text = "Destination :";
            this.DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DestinationTb
            // 
            this.DestinationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationTb.Location = new System.Drawing.Point(128, 27);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.ReadOnly = true;
            this.DestinationTb.Size = new System.Drawing.Size(315, 23);
            this.DestinationTb.TabIndex = 6;
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 55);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(110, 36);
            this.DateLabel.TabIndex = 9;
            this.DateLabel.Text = "Date :";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 91);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(110, 36);
            this.TimeLabel.TabIndex = 15;
            this.TimeLabel.Text = "Time :";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTb
            // 
            this.DateTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTb.Location = new System.Drawing.Point(128, 63);
            this.DateTb.Name = "DateTb";
            this.DateTb.ReadOnly = true;
            this.DateTb.Size = new System.Drawing.Size(315, 23);
            this.DateTb.TabIndex = 17;
            // 
            // TimeTb
            // 
            this.TimeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTb.Location = new System.Drawing.Point(128, 99);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.ReadOnly = true;
            this.TimeTb.Size = new System.Drawing.Size(315, 23);
            this.TimeTb.TabIndex = 18;
            // 
            // BuyButton
            // 
            this.BuyButton.BackColor = System.Drawing.SystemColors.Window;
            this.BuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyButton.Location = new System.Drawing.Point(12, 469);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(431, 31);
            this.BuyButton.TabIndex = 27;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(12, 506);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(431, 31);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FlightDetailsGb
            // 
            this.FlightDetailsGb.Controls.Add(this.CoachClassLabel);
            this.FlightDetailsGb.Controls.Add(this.CoachClassTb);
            this.FlightDetailsGb.Controls.Add(this.BusinessClassLabel);
            this.FlightDetailsGb.Controls.Add(this.BusinessClassTb);
            this.FlightDetailsGb.Controls.Add(this.FirstClassLabel);
            this.FlightDetailsGb.Controls.Add(this.FirstClassTb);
            this.FlightDetailsGb.Controls.Add(this.DestinationLabel);
            this.FlightDetailsGb.Controls.Add(this.DestinationTb);
            this.FlightDetailsGb.Controls.Add(this.DateLabel);
            this.FlightDetailsGb.Controls.Add(this.DateTb);
            this.FlightDetailsGb.Controls.Add(this.TimeLabel);
            this.FlightDetailsGb.Controls.Add(this.TimeTb);
            this.FlightDetailsGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDetailsGb.Location = new System.Drawing.Point(0, 27);
            this.FlightDetailsGb.Name = "FlightDetailsGb";
            this.FlightDetailsGb.Size = new System.Drawing.Size(446, 254);
            this.FlightDetailsGb.TabIndex = 30;
            this.FlightDetailsGb.TabStop = false;
            this.FlightDetailsGb.Text = "Flight Details";
            // 
            // FirstClassLabel
            // 
            this.FirstClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstClassLabel.Location = new System.Drawing.Point(12, 129);
            this.FirstClassLabel.Name = "FirstClassLabel";
            this.FirstClassLabel.Size = new System.Drawing.Size(211, 39);
            this.FirstClassLabel.TabIndex = 19;
            this.FirstClassLabel.Text = "First Class Available Seats:";
            this.FirstClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstClassTb
            // 
            this.FirstClassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstClassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstClassTb.Location = new System.Drawing.Point(229, 137);
            this.FirstClassTb.Name = "FirstClassTb";
            this.FirstClassTb.ReadOnly = true;
            this.FirstClassTb.Size = new System.Drawing.Size(214, 23);
            this.FirstClassTb.TabIndex = 20;
            this.FirstClassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BusinessClassLabel
            // 
            this.BusinessClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessClassLabel.Location = new System.Drawing.Point(12, 168);
            this.BusinessClassLabel.Name = "BusinessClassLabel";
            this.BusinessClassLabel.Size = new System.Drawing.Size(248, 36);
            this.BusinessClassLabel.TabIndex = 21;
            this.BusinessClassLabel.Text = "Business Class Available Seats:";
            this.BusinessClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BusinessClassTb
            // 
            this.BusinessClassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BusinessClassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessClassTb.Location = new System.Drawing.Point(260, 176);
            this.BusinessClassTb.Name = "BusinessClassTb";
            this.BusinessClassTb.ReadOnly = true;
            this.BusinessClassTb.Size = new System.Drawing.Size(183, 23);
            this.BusinessClassTb.TabIndex = 22;
            this.BusinessClassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CoachClassLabel
            // 
            this.CoachClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachClassLabel.Location = new System.Drawing.Point(12, 207);
            this.CoachClassLabel.Name = "CoachClassLabel";
            this.CoachClassLabel.Size = new System.Drawing.Size(224, 36);
            this.CoachClassLabel.TabIndex = 23;
            this.CoachClassLabel.Text = "Coach Class Available Seats:";
            this.CoachClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CoachClassTb
            // 
            this.CoachClassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoachClassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachClassTb.Location = new System.Drawing.Point(242, 215);
            this.CoachClassTb.Name = "CoachClassTb";
            this.CoachClassTb.ReadOnly = true;
            this.CoachClassTb.Size = new System.Drawing.Size(201, 23);
            this.CoachClassTb.TabIndex = 24;
            this.CoachClassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CvvCvcLabel
            // 
            this.CvvCvcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CvvCvcLabel.Location = new System.Drawing.Point(12, 135);
            this.CvvCvcLabel.Name = "CvvCvcLabel";
            this.CvvCvcLabel.Size = new System.Drawing.Size(122, 36);
            this.CvvCvcLabel.TabIndex = 23;
            this.CvvCvcLabel.Text = "CVV/CVC :";
            this.CvvCvcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateLabel.Location = new System.Drawing.Point(12, 106);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(122, 36);
            this.ExpirationDateLabel.TabIndex = 22;
            this.ExpirationDateLabel.Text = "Expiration Date";
            this.ExpirationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CvvCvcTb
            // 
            this.CvvCvcTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CvvCvcTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CvvCvcTb.Location = new System.Drawing.Point(140, 143);
            this.CvvCvcTb.Name = "CvvCvcTb";
            this.CvvCvcTb.Size = new System.Drawing.Size(303, 23);
            this.CvvCvcTb.TabIndex = 26;
            // 
            // ExpirationDateTb
            // 
            this.ExpirationDateTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpirationDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateTb.Location = new System.Drawing.Point(140, 114);
            this.ExpirationDateTb.Name = "ExpirationDateTb";
            this.ExpirationDateTb.Size = new System.Drawing.Size(303, 23);
            this.ExpirationDateTb.TabIndex = 25;
            // 
            // CardNumberTb
            // 
            this.CardNumberTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardNumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberTb.Location = new System.Drawing.Point(140, 85);
            this.CardNumberTb.Name = "CardNumberTb";
            this.CardNumberTb.Size = new System.Drawing.Size(303, 23);
            this.CardNumberTb.TabIndex = 24;
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.Location = new System.Drawing.Point(12, 77);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(122, 36);
            this.CardNumberLabel.TabIndex = 21;
            this.CardNumberLabel.Text = "Card Number :";
            this.CardNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeatTypeCb
            // 
            this.SeatTypeCb.FormattingEnabled = true;
            this.SeatTypeCb.Items.AddRange(new object[] {
            "First Class",
            "Business Class",
            "Coach Class"});
            this.SeatTypeCb.Location = new System.Drawing.Point(12, 55);
            this.SeatTypeCb.Name = "SeatTypeCb";
            this.SeatTypeCb.Size = new System.Drawing.Size(431, 24);
            this.SeatTypeCb.TabIndex = 7;
            // 
            // SeatTypeLabel
            // 
            this.SeatTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatTypeLabel.Location = new System.Drawing.Point(12, 16);
            this.SeatTypeLabel.Name = "SeatTypeLabel";
            this.SeatTypeLabel.Size = new System.Drawing.Size(431, 36);
            this.SeatTypeLabel.TabIndex = 20;
            this.SeatTypeLabel.Text = "Select Seat Type :";
            this.SeatTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.SeatTypeLabel);
            this.InformationGroupBox.Controls.Add(this.SeatTypeCb);
            this.InformationGroupBox.Controls.Add(this.CardNumberLabel);
            this.InformationGroupBox.Controls.Add(this.CardNumberTb);
            this.InformationGroupBox.Controls.Add(this.ExpirationDateTb);
            this.InformationGroupBox.Controls.Add(this.CvvCvcTb);
            this.InformationGroupBox.Controls.Add(this.ExpirationDateLabel);
            this.InformationGroupBox.Controls.Add(this.CvvCvcLabel);
            this.InformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationGroupBox.Location = new System.Drawing.Point(0, 287);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(448, 176);
            this.InformationGroupBox.TabIndex = 29;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Enter Information";
            // 
            // PassengerBuyTicketPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 553);
            this.Controls.Add(this.FlightDetailsGb);
            this.Controls.Add(this.InformationGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.PassengerMenuStrip);
            this.Name = "PassengerBuyTicketPage";
            this.Text = "PassengerBuyPage";
            this.Load += new System.EventHandler(this.PassengerBuyTicketPage_Load);
            this.PassengerMenuStrip.ResumeLayout(false);
            this.PassengerMenuStrip.PerformLayout();
            this.FlightDetailsGb.ResumeLayout(false);
            this.FlightDetailsGb.PerformLayout();
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox FlightDetailsGb;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button BuyButton;

        private System.Windows.Forms.TextBox DateTb;
        private System.Windows.Forms.TextBox TimeTb;

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;

        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.TextBox DestinationTb;

        private System.Windows.Forms.MenuStrip PassengerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;

        #endregion

        private System.Windows.Forms.Label CoachClassLabel;
        private System.Windows.Forms.TextBox CoachClassTb;
        private System.Windows.Forms.Label BusinessClassLabel;
        private System.Windows.Forms.TextBox BusinessClassTb;
        private System.Windows.Forms.Label FirstClassLabel;
        private System.Windows.Forms.TextBox FirstClassTb;
        private System.Windows.Forms.Label CvvCvcLabel;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.TextBox CvvCvcTb;
        private System.Windows.Forms.TextBox ExpirationDateTb;
        private System.Windows.Forms.TextBox CardNumberTb;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.ComboBox SeatTypeCb;
        private System.Windows.Forms.Label SeatTypeLabel;
        private System.Windows.Forms.GroupBox InformationGroupBox;
    }
}