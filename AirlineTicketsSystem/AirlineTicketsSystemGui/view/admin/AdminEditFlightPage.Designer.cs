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
            this.EditFlightMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinuteNup = new System.Windows.Forms.NumericUpDown();
            this.HourNup = new System.Windows.Forms.NumericUpDown();
            this.CoachCLabel = new System.Windows.Forms.Label();
            this.BuisnessCLabel = new System.Windows.Forms.Label();
            this.FirstCLabel = new System.Windows.Forms.Label();
            this.CoachCTb = new System.Windows.Forms.TextBox();
            this.BusinessCTb = new System.Windows.Forms.TextBox();
            this.FirstCTb = new System.Windows.Forms.TextBox();
            this.SeatsLabel = new System.Windows.Forms.Label();
            this.AmPmLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.AmPmCb = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateDp = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.EditingButton = new System.Windows.Forms.Button();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditFlightMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourNup)).BeginInit();
            this.SuspendLayout();
            // 
            // EditFlightMenuStrip
            // 
            this.EditFlightMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.EditFlightMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EditFlightMenuStrip.Name = "EditFlightMenuStrip";
            this.EditFlightMenuStrip.Size = new System.Drawing.Size(418, 24);
            this.EditFlightMenuStrip.TabIndex = 42;
            this.EditFlightMenuStrip.Text = "menuStrip1";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // MinuteNup
            // 
            this.MinuteNup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinuteNup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteNup.Location = new System.Drawing.Point(316, 209);
            this.MinuteNup.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinuteNup.Name = "MinuteNup";
            this.MinuteNup.Size = new System.Drawing.Size(93, 23);
            this.MinuteNup.TabIndex = 41;
            this.MinuteNup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HourNup
            // 
            this.HourNup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HourNup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourNup.Location = new System.Drawing.Point(316, 180);
            this.HourNup.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.HourNup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HourNup.Name = "HourNup";
            this.HourNup.Size = new System.Drawing.Size(93, 23);
            this.HourNup.TabIndex = 40;
            this.HourNup.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CoachCLabel
            // 
            this.CoachCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachCLabel.Location = new System.Drawing.Point(12, 239);
            this.CoachCLabel.Name = "CoachCLabel";
            this.CoachCLabel.Size = new System.Drawing.Size(107, 23);
            this.CoachCLabel.TabIndex = 39;
            this.CoachCLabel.Text = "Coach C. :";
            this.CoachCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BuisnessCLabel
            // 
            this.BuisnessCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuisnessCLabel.Location = new System.Drawing.Point(12, 210);
            this.BuisnessCLabel.Name = "BuisnessCLabel";
            this.BuisnessCLabel.Size = new System.Drawing.Size(107, 23);
            this.BuisnessCLabel.TabIndex = 38;
            this.BuisnessCLabel.Text = "Business C. :";
            this.BuisnessCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstCLabel
            // 
            this.FirstCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstCLabel.Location = new System.Drawing.Point(12, 179);
            this.FirstCLabel.Name = "FirstCLabel";
            this.FirstCLabel.Size = new System.Drawing.Size(107, 23);
            this.FirstCLabel.TabIndex = 37;
            this.FirstCLabel.Text = "First C. :";
            this.FirstCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CoachCTb
            // 
            this.CoachCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoachCTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachCTb.Location = new System.Drawing.Point(125, 240);
            this.CoachCTb.Name = "CoachCTb";
            this.CoachCTb.Size = new System.Drawing.Size(101, 23);
            this.CoachCTb.TabIndex = 36;
            // 
            // BusinessCTb
            // 
            this.BusinessCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BusinessCTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessCTb.Location = new System.Drawing.Point(125, 209);
            this.BusinessCTb.Name = "BusinessCTb";
            this.BusinessCTb.Size = new System.Drawing.Size(101, 23);
            this.BusinessCTb.TabIndex = 35;
            // 
            // FirstCTb
            // 
            this.FirstCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstCTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstCTb.Location = new System.Drawing.Point(125, 180);
            this.FirstCTb.Name = "FirstCTb";
            this.FirstCTb.Size = new System.Drawing.Size(101, 23);
            this.FirstCTb.TabIndex = 34;
            // 
            // SeatsLabel
            // 
            this.SeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsLabel.Location = new System.Drawing.Point(12, 143);
            this.SeatsLabel.Name = "SeatsLabel";
            this.SeatsLabel.Size = new System.Drawing.Size(212, 23);
            this.SeatsLabel.TabIndex = 33;
            this.SeatsLabel.Text = "Seats";
            this.SeatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AmPmLabel
            // 
            this.AmPmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmPmLabel.Location = new System.Drawing.Point(231, 239);
            this.AmPmLabel.Name = "AmPmLabel";
            this.AmPmLabel.Size = new System.Drawing.Size(80, 23);
            this.AmPmLabel.TabIndex = 32;
            this.AmPmLabel.Text = "AM/PM :";
            this.AmPmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteLabel.Location = new System.Drawing.Point(230, 210);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(80, 23);
            this.MinuteLabel.TabIndex = 31;
            this.MinuteLabel.Text = "Minute :";
            this.MinuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HourLabel
            // 
            this.HourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourLabel.Location = new System.Drawing.Point(231, 179);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(80, 23);
            this.HourLabel.TabIndex = 30;
            this.HourLabel.Text = "Hour :";
            this.HourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AmPmCb
            // 
            this.AmPmCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmPmCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmPmCb.FormattingEnabled = true;
            this.AmPmCb.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AmPmCb.Location = new System.Drawing.Point(316, 239);
            this.AmPmCb.Name = "AmPmCb";
            this.AmPmCb.Size = new System.Drawing.Size(93, 24);
            this.AmPmCb.TabIndex = 29;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(230, 143);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(179, 23);
            this.TimeLabel.TabIndex = 28;
            this.TimeLabel.Text = "Departure Time";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateDp
            // 
            this.DateDp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDp.Location = new System.Drawing.Point(12, 106);
            this.DateDp.Name = "DateDp";
            this.DateDp.Size = new System.Drawing.Size(397, 23);
            this.DateDp.TabIndex = 27;
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 80);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(397, 23);
            this.DateLabel.TabIndex = 26;
            this.DateLabel.Text = "Departure Date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditingButton
            // 
            this.EditingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditingButton.BackColor = System.Drawing.SystemColors.Window;
            this.EditingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditingButton.Location = new System.Drawing.Point(12, 282);
            this.EditingButton.Name = "EditingButton";
            this.EditingButton.Size = new System.Drawing.Size(397, 35);
            this.EditingButton.TabIndex = 25;
            this.EditingButton.Text = "Edit";
            this.EditingButton.UseVisualStyleBackColor = false;
            // 
            // DestinationTb
            // 
            this.DestinationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationTb.Location = new System.Drawing.Point(12, 54);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.Size = new System.Drawing.Size(397, 23);
            this.DestinationTb.TabIndex = 24;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(12, 28);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(397, 23);
            this.DestinationLabel.TabIndex = 23;
            this.DestinationLabel.Text = "Destination";
            this.DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.SystemColors.Window;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(12, 323);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(397, 35);
            this.EditButton.TabIndex = 43;
            this.EditButton.Text = "Cancel";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // AdminEditFlightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 364);
            this.Controls.Add(this.EditButton);
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
            this.Controls.Add(this.AmPmLabel);
            this.Controls.Add(this.MinuteLabel);
            this.Controls.Add(this.HourLabel);
            this.Controls.Add(this.AmPmCb);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.DateDp);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.EditingButton);
            this.Controls.Add(this.DestinationTb);
            this.Controls.Add(this.DestinationLabel);
            this.Name = "AdminEditFlightPage";
            this.Text = "Edit Flight";
            this.EditFlightMenuStrip.ResumeLayout(false);
            this.EditFlightMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HourNup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button EditButton;

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
        private System.Windows.Forms.Label AmPmLabel;
        private System.Windows.Forms.Label MinuteLabel;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.ComboBox AmPmCb;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.DateTimePicker DateDp;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button EditingButton;
        private System.Windows.Forms.TextBox DestinationTb;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Button EditBtn;

        #endregion
    }
}