using System.ComponentModel;

namespace AirlineTicketsSystemGui
{
    partial class AdminAddFlightPage
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
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateDp = new System.Windows.Forms.DateTimePicker();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.HourLabel = new System.Windows.Forms.Label();
            this.MinuteLabel = new System.Windows.Forms.Label();
            this.FirstCTb = new System.Windows.Forms.TextBox();
            this.SeatsLabel = new System.Windows.Forms.Label();
            this.BusinessCTb = new System.Windows.Forms.TextBox();
            this.CoachCTb = new System.Windows.Forms.TextBox();
            this.CoachCLabel = new System.Windows.Forms.Label();
            this.BuisnessCLabel = new System.Windows.Forms.Label();
            this.FirstCLabel = new System.Windows.Forms.Label();
            this.HourNup = new System.Windows.Forms.NumericUpDown();
            this.MinuteNup = new System.Windows.Forms.NumericUpDown();
            this.AddFlightMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.HourNup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNup)).BeginInit();
            this.AddFlightMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(12, 24);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(397, 23);
            this.DestinationLabel.TabIndex = 0;
            this.DestinationLabel.Text = "Destination";
            this.DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DestinationTb
            // 
            this.DestinationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationTb.Location = new System.Drawing.Point(12, 50);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.Size = new System.Drawing.Size(397, 23);
            this.DestinationTb.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.SystemColors.Window;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 278);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(397, 35);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 76);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(397, 23);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Departure Date";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateDp
            // 
            this.DateDp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDp.Location = new System.Drawing.Point(12, 102);
            this.DateDp.Name = "DateDp";
            this.DateDp.Size = new System.Drawing.Size(397, 23);
            this.DateDp.TabIndex = 5;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(230, 139);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(179, 23);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "Departure Time";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HourLabel
            // 
            this.HourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourLabel.Location = new System.Drawing.Point(231, 175);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(80, 23);
            this.HourLabel.TabIndex = 10;
            this.HourLabel.Text = "Hour :";
            this.HourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MinuteLabel
            // 
            this.MinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteLabel.Location = new System.Drawing.Point(230, 206);
            this.MinuteLabel.Name = "MinuteLabel";
            this.MinuteLabel.Size = new System.Drawing.Size(80, 23);
            this.MinuteLabel.TabIndex = 11;
            this.MinuteLabel.Text = "Minute :";
            this.MinuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstCTb
            // 
            this.FirstCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstCTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstCTb.Location = new System.Drawing.Point(125, 176);
            this.FirstCTb.Name = "FirstCTb";
            this.FirstCTb.Size = new System.Drawing.Size(101, 23);
            this.FirstCTb.TabIndex = 14;
            // 
            // SeatsLabel
            // 
            this.SeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsLabel.Location = new System.Drawing.Point(12, 139);
            this.SeatsLabel.Name = "SeatsLabel";
            this.SeatsLabel.Size = new System.Drawing.Size(212, 23);
            this.SeatsLabel.TabIndex = 13;
            this.SeatsLabel.Text = "Seats";
            this.SeatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BusinessCTb
            // 
            this.BusinessCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BusinessCTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessCTb.Location = new System.Drawing.Point(125, 205);
            this.BusinessCTb.Name = "BusinessCTb";
            this.BusinessCTb.Size = new System.Drawing.Size(101, 23);
            this.BusinessCTb.TabIndex = 15;
            // 
            // CoachCTb
            // 
            this.CoachCTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoachCTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachCTb.Location = new System.Drawing.Point(125, 236);
            this.CoachCTb.Name = "CoachCTb";
            this.CoachCTb.Size = new System.Drawing.Size(101, 23);
            this.CoachCTb.TabIndex = 16;
            // 
            // CoachCLabel
            // 
            this.CoachCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoachCLabel.Location = new System.Drawing.Point(12, 235);
            this.CoachCLabel.Name = "CoachCLabel";
            this.CoachCLabel.Size = new System.Drawing.Size(107, 23);
            this.CoachCLabel.TabIndex = 19;
            this.CoachCLabel.Text = "Coach C. :";
            this.CoachCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BuisnessCLabel
            // 
            this.BuisnessCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuisnessCLabel.Location = new System.Drawing.Point(12, 206);
            this.BuisnessCLabel.Name = "BuisnessCLabel";
            this.BuisnessCLabel.Size = new System.Drawing.Size(107, 23);
            this.BuisnessCLabel.TabIndex = 18;
            this.BuisnessCLabel.Text = "Business C. :";
            this.BuisnessCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstCLabel
            // 
            this.FirstCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstCLabel.Location = new System.Drawing.Point(12, 175);
            this.FirstCLabel.Name = "FirstCLabel";
            this.FirstCLabel.Size = new System.Drawing.Size(107, 23);
            this.FirstCLabel.TabIndex = 17;
            this.FirstCLabel.Text = "First C. :";
            this.FirstCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HourNup
            // 
            this.HourNup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HourNup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourNup.Location = new System.Drawing.Point(316, 176);
            this.HourNup.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HourNup.Name = "HourNup";
            this.HourNup.Size = new System.Drawing.Size(93, 23);
            this.HourNup.TabIndex = 20;
            this.HourNup.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // MinuteNup
            // 
            this.MinuteNup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinuteNup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteNup.Location = new System.Drawing.Point(316, 205);
            this.MinuteNup.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinuteNup.Name = "MinuteNup";
            this.MinuteNup.Size = new System.Drawing.Size(93, 23);
            this.MinuteNup.TabIndex = 21;
            // 
            // AddFlightMenuStrip
            // 
            this.AddFlightMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.AddFlightMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AddFlightMenuStrip.Name = "AddFlightMenuStrip";
            this.AddFlightMenuStrip.Size = new System.Drawing.Size(418, 24);
            this.AddFlightMenuStrip.TabIndex = 22;
            this.AddFlightMenuStrip.Text = "menuStrip1";
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            this.frenchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frenchToolStripMenuItem.Text = "F&rançais";
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishToolStripMenuItem.Text = "E&nglish";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            this.spanishToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spanishToolStripMenuItem.Text = "Spanish";
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // AdminAddFlightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 321);
            this.Controls.Add(this.AddFlightMenuStrip);
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
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DestinationTb);
            this.Controls.Add(this.DestinationLabel);
            this.Name = "AdminAddFlightPage";
            this.Text = "Add Flight";
            ((System.ComponentModel.ISupportInitialize)(this.HourNup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinuteNup)).EndInit();
            this.AddFlightMenuStrip.ResumeLayout(false);
            this.AddFlightMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip AddFlightMenuStrip;
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

        private System.Windows.Forms.TextBox BusinessCTb;
        private System.Windows.Forms.TextBox CoachCTb;

        private System.Windows.Forms.TextBox FirstCTb;
        private System.Windows.Forms.Label SeatsLabel;

        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label MinuteLabel;

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker DateDp;
        private System.Windows.Forms.Label TimeLabel;

        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.TextBox DestinationTb;
        private System.Windows.Forms.Button AddButton;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
    }
}