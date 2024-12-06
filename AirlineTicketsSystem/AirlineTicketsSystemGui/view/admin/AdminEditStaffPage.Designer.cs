using System.ComponentModel;

namespace AirlineTicketsSystemGui
{
    partial class AdminEditStaffPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEditStaffPage));
            this.EditButton = new System.Windows.Forms.Button();
            this.NewStaffEmailTb = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.StaffIDTb = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EditStaffMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewStaffPasswordTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditStaffMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            resources.ApplyResources(this.EditButton, "EditButton");
            this.EditButton.BackColor = System.Drawing.SystemColors.Window;
            this.EditButton.Name = "EditButton";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NewStaffEmailTb
            // 
            resources.ApplyResources(this.NewStaffEmailTb, "NewStaffEmailTb");
            this.NewStaffEmailTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewStaffEmailTb.Name = "NewStaffEmailTb";
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            // 
            // StaffIDTb
            // 
            resources.ApplyResources(this.StaffIDTb, "StaffIDTb");
            this.StaffIDTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffIDTb.Name = "StaffIDTb";
            // 
            // EmailLabel
            // 
            resources.ApplyResources(this.EmailLabel, "EmailLabel");
            this.EmailLabel.Name = "EmailLabel";
            // 
            // EditStaffMenuStrip
            // 
            resources.ApplyResources(this.EditStaffMenuStrip, "EditStaffMenuStrip");
            this.EditStaffMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.EditStaffMenuStrip.Name = "EditStaffMenuStrip";
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
            // CancelButton
            // 
            resources.ApplyResources(this.CancelButton, "CancelButton");
            this.CancelButton.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewStaffPasswordTb
            // 
            resources.ApplyResources(this.NewStaffPasswordTb, "NewStaffPasswordTb");
            this.NewStaffPasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewStaffPasswordTb.Name = "NewStaffPasswordTb";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // AdminEditStaffPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewStaffPasswordTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewStaffEmailTb);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.StaffIDTb);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EditStaffMenuStrip);
            this.Name = "AdminEditStaffPage";
            this.Load += new System.EventHandler(this.AdminEditStaffPage_Load);
            this.EditStaffMenuStrip.ResumeLayout(false);
            this.EditStaffMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox NewStaffEmailTb;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox StaffIDTb;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.MenuStrip EditStaffMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Button CancelButton;

        #endregion
        private System.Windows.Forms.TextBox NewStaffPasswordTb;
        private System.Windows.Forms.Label label1;
    }
}