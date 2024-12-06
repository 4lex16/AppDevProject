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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengerBuyTicketPage));
            this.PassengerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateTb = new System.Windows.Forms.TextBox();
            this.TimeTb = new System.Windows.Forms.TextBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FlightDetailsGb = new System.Windows.Forms.GroupBox();
            this.CoachClassLabel = new System.Windows.Forms.Label();
            this.CoachClassTb = new System.Windows.Forms.TextBox();
            this.BusinessClassLabel = new System.Windows.Forms.Label();
            this.BusinessClassTb = new System.Windows.Forms.TextBox();
            this.FirstClassLabel = new System.Windows.Forms.Label();
            this.FirstClassTb = new System.Windows.Forms.TextBox();
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
            this.exitToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // DestinationLabel
            // 
            resources.ApplyResources(this.DestinationLabel, "DestinationLabel");
            this.DestinationLabel.Name = "DestinationLabel";
            // 
            // DestinationTb
            // 
            resources.ApplyResources(this.DestinationTb, "DestinationTb");
            this.DestinationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.ReadOnly = true;
            // 
            // DateLabel
            // 
            resources.ApplyResources(this.DateLabel, "DateLabel");
            this.DateLabel.Name = "DateLabel";
            // 
            // TimeLabel
            // 
            resources.ApplyResources(this.TimeLabel, "TimeLabel");
            this.TimeLabel.Name = "TimeLabel";
            // 
            // DateTb
            // 
            resources.ApplyResources(this.DateTb, "DateTb");
            this.DateTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateTb.Name = "DateTb";
            this.DateTb.ReadOnly = true;
            // 
            // TimeTb
            // 
            resources.ApplyResources(this.TimeTb, "TimeTb");
            this.TimeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.ReadOnly = true;
            // 
            // BuyButton
            // 
            resources.ApplyResources(this.BuyButton, "BuyButton");
            this.BuyButton.BackColor = System.Drawing.SystemColors.Window;
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // CancelButton
            // 
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FlightDetailsGb
            // 
            resources.ApplyResources(this.FlightDetailsGb, "FlightDetailsGb");
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
            this.FlightDetailsGb.Name = "FlightDetailsGb";
            this.FlightDetailsGb.TabStop = false;
            // 
            // CoachClassLabel
            // 
            resources.ApplyResources(this.CoachClassLabel, "CoachClassLabel");
            this.CoachClassLabel.Name = "CoachClassLabel";
            // 
            // CoachClassTb
            // 
            resources.ApplyResources(this.CoachClassTb, "CoachClassTb");
            this.CoachClassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoachClassTb.Name = "CoachClassTb";
            this.CoachClassTb.ReadOnly = true;
            // 
            // BusinessClassLabel
            // 
            resources.ApplyResources(this.BusinessClassLabel, "BusinessClassLabel");
            this.BusinessClassLabel.Name = "BusinessClassLabel";
            // 
            // BusinessClassTb
            // 
            resources.ApplyResources(this.BusinessClassTb, "BusinessClassTb");
            this.BusinessClassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BusinessClassTb.Name = "BusinessClassTb";
            this.BusinessClassTb.ReadOnly = true;
            // 
            // FirstClassLabel
            // 
            resources.ApplyResources(this.FirstClassLabel, "FirstClassLabel");
            this.FirstClassLabel.Name = "FirstClassLabel";
            // 
            // FirstClassTb
            // 
            resources.ApplyResources(this.FirstClassTb, "FirstClassTb");
            this.FirstClassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstClassTb.Name = "FirstClassTb";
            this.FirstClassTb.ReadOnly = true;
            // 
            // CvvCvcLabel
            // 
            resources.ApplyResources(this.CvvCvcLabel, "CvvCvcLabel");
            this.CvvCvcLabel.Name = "CvvCvcLabel";
            // 
            // ExpirationDateLabel
            // 
            resources.ApplyResources(this.ExpirationDateLabel, "ExpirationDateLabel");
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            // 
            // CvvCvcTb
            // 
            resources.ApplyResources(this.CvvCvcTb, "CvvCvcTb");
            this.CvvCvcTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CvvCvcTb.Name = "CvvCvcTb";
            // 
            // ExpirationDateTb
            // 
            resources.ApplyResources(this.ExpirationDateTb, "ExpirationDateTb");
            this.ExpirationDateTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpirationDateTb.Name = "ExpirationDateTb";
            // 
            // CardNumberTb
            // 
            resources.ApplyResources(this.CardNumberTb, "CardNumberTb");
            this.CardNumberTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardNumberTb.Name = "CardNumberTb";
            // 
            // CardNumberLabel
            // 
            resources.ApplyResources(this.CardNumberLabel, "CardNumberLabel");
            this.CardNumberLabel.Name = "CardNumberLabel";
            // 
            // SeatTypeCb
            // 
            resources.ApplyResources(this.SeatTypeCb, "SeatTypeCb");
            this.SeatTypeCb.FormattingEnabled = true;
            this.SeatTypeCb.Items.AddRange(new object[] {
            resources.GetString("SeatTypeCb.Items"),
            resources.GetString("SeatTypeCb.Items1"),
            resources.GetString("SeatTypeCb.Items2")});
            this.SeatTypeCb.Name = "SeatTypeCb";
            // 
            // SeatTypeLabel
            // 
            resources.ApplyResources(this.SeatTypeLabel, "SeatTypeLabel");
            this.SeatTypeLabel.Name = "SeatTypeLabel";
            // 
            // InformationGroupBox
            // 
            resources.ApplyResources(this.InformationGroupBox, "InformationGroupBox");
            this.InformationGroupBox.Controls.Add(this.SeatTypeLabel);
            this.InformationGroupBox.Controls.Add(this.SeatTypeCb);
            this.InformationGroupBox.Controls.Add(this.CardNumberLabel);
            this.InformationGroupBox.Controls.Add(this.CardNumberTb);
            this.InformationGroupBox.Controls.Add(this.ExpirationDateTb);
            this.InformationGroupBox.Controls.Add(this.CvvCvcTb);
            this.InformationGroupBox.Controls.Add(this.ExpirationDateLabel);
            this.InformationGroupBox.Controls.Add(this.CvvCvcLabel);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.TabStop = false;
            // 
            // PassengerBuyTicketPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlightDetailsGb);
            this.Controls.Add(this.InformationGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.PassengerMenuStrip);
            this.Name = "PassengerBuyTicketPage";
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
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