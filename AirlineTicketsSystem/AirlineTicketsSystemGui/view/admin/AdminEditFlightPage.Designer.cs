using System.ComponentModel;

namespace AirlineTicketsSystemGui
{
    partial class AdminEditFlightPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEditFlightPage));
            this.EditFlightMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinuteNup = new System.Windows.Forms.NumericUpDown();
            this.HourNup = new System.Windows.Forms.NumericUpDown();
            this.CoachCLabel = new System.Windows.Forms.Label();
            this.BuisnessCLabel = new System.Windows.Forms.Label();
            this.FirstCLabel = new System.Windows.Forms.Label();
            this.CoachCTb = new System.Windows.Forms.TextBox();
            this.BusinessCTb = new System.Windows.Forms.TextBox();
            this.FirstCTb = new System.Windows.Forms.TextBox();
            this.SeatsLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateDp = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditFlightMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourNup)).BeginInit();
            this.SuspendLayout();
            // 
            // EditFlightMenuStrip
            // 
            resources.ApplyResources(this.EditFlightMenuStrip, "EditFlightMenuStrip");
            this.EditFlightMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.EditFlightMenuStrip.Name = "EditFlightMenuStrip";
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
            // MinuteNup
            // 
            resources.ApplyResources(this.MinuteNup, "MinuteNup");
            this.MinuteNup.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinuteNup.Name = "MinuteNup";
            // 
            // HourNup
            // 
            resources.ApplyResources(this.HourNup, "HourNup");
            this.HourNup.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HourNup.Name = "HourNup";
            this.HourNup.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // CoachCLabel
            // 
            resources.ApplyResources(this.CoachCLabel, "CoachCLabel");
            this.CoachCLabel.Name = "CoachCLabel";
            // 
            // BuisnessCLabel
            // 
            resources.ApplyResources(this.BuisnessCLabel, "BuisnessCLabel");
            this.BuisnessCLabel.Name = "BuisnessCLabel";
            // 
            // FirstCLabel
            // 
            resources.ApplyResources(this.FirstCLabel, "FirstCLabel");
            this.FirstCLabel.Name = "FirstCLabel";
            // 
            // CoachCTb
            // 
            resources.ApplyResources(this.CoachCTb, "CoachCTb");
            this.CoachCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoachCTb.Name = "CoachCTb";
            // 
            // BusinessCTb
            // 
            resources.ApplyResources(this.BusinessCTb, "BusinessCTb");
            this.BusinessCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BusinessCTb.Name = "BusinessCTb";
            // 
            // FirstCTb
            // 
            resources.ApplyResources(this.FirstCTb, "FirstCTb");
            this.FirstCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstCTb.Name = "FirstCTb";
            // 
            // SeatsLabel
            // 
            resources.ApplyResources(this.SeatsLabel, "SeatsLabel");
            this.SeatsLabel.Name = "SeatsLabel";
            // 
            // MinuteLabel
            // 
            resources.ApplyResources(this.MinuteLabel, "MinuteLabel");
            this.MinuteLabel.Name = "MinuteLabel";
            // 
            // HourLabel
            // 
            resources.ApplyResources(this.HourLabel, "HourLabel");
            this.HourLabel.Name = "HourLabel";
            // 
            // TimeLabel
            // 
            resources.ApplyResources(this.TimeLabel, "TimeLabel");
            this.TimeLabel.Name = "TimeLabel";
            // 
            // DateDp
            // 
            resources.ApplyResources(this.DateDp, "DateDp");
            this.DateDp.Name = "DateDp";
            // 
            // DateLabel
            // 
            resources.ApplyResources(this.DateLabel, "DateLabel");
            this.DateLabel.Name = "DateLabel";
            // 
            // EditButton
            // 
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.BackColor = System.Drawing.SystemColors.Window;
            this.EditButton.Name = "EditButton";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DestinationTb
            // 
            resources.ApplyResources(this.DestinationTb, "DestinationTb");
            this.DestinationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationTb.Name = "DestinationTb";
            // 
            // DestinationLabel
            // 
            resources.ApplyResources(this.DestinationLabel, "DestinationLabel");
            this.DestinationLabel.Name = "DestinationLabel";
            // 
            // CancelButton
            // 
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AdminEditFlightPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditFlightMenuStrip);
            this.Controls.Add(this.MinuteNup);
            this.Controls.Add(this.HourNup);
            this.Controls.Add(this.CoachCLabel);
            this.Controls.Add(this.BuisnessCLabel);
            this.Controls.Add(this.FirstCLabel);
            this.Controls.Add(this.CoachCTb);
            this.Controls.Add(this.BusinessCTb);
            this.Controls.Add(this.FirstCTb);
            this.Controls.Add(this.SeatsLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateDp);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DestinationTb);
            this.Controls.Add(this.DestinationLabel);
            this.Name = "AdminEditFlightPage";
            this.Load += new System.EventHandler(this.AdminEditFlightPage_Load);
            this.EditFlightMenuStrip.ResumeLayout(false);
            this.EditFlightMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourNup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button CancelButton;

        private System.Windows.Forms.MenuStrip EditFlightMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown MinuteNup;
        private System.Windows.Forms.NumericUpDown HourNup;
        private System.Windows.Forms.Label CoachCLabel;
        private System.Windows.Forms.Label BuisnessCLabel;
        private System.Windows.Forms.Label FirstCLabel;
        private System.Windows.Forms.TextBox CoachCTb;
        private System.Windows.Forms.TextBox BusinessCTb;
        private System.Windows.Forms.TextBox FirstCTb;
        private System.Windows.Forms.Label SeatsLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.DateTimePicker DateDp;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox DestinationTb;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Button EditBtn;

        #endregion
    }
}