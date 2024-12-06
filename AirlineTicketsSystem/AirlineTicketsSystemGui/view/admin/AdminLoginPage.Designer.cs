using System.ComponentModel;

namespace AirlineTicketsSystemGui
{
    partial class AdminLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginPage));
            this.LoginMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminKeyLabel = new System.Windows.Forms.Label();
            this.AdminKeyTb = new System.Windows.Forms.TextBox();
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.LoginMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginMenuStrip
            // 
            resources.ApplyResources(this.LoginMenuStrip, "LoginMenuStrip");
            this.LoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.LoginMenuStrip.Name = "LoginMenuStrip";
            // 
            // pageToolStripMenuItem
            // 
            resources.ApplyResources(this.pageToolStripMenuItem, "pageToolStripMenuItem");
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.loginPageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loginPageToolStripMenuItem
            // 
            resources.ApplyResources(this.loginPageToolStripMenuItem, "loginPageToolStripMenuItem");
            this.loginPageToolStripMenuItem.Name = "loginPageToolStripMenuItem";
            this.loginPageToolStripMenuItem.Click += new System.EventHandler(this.loginPageToolStripMenuItem_Click);
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
            // AdminKeyLabel
            // 
            resources.ApplyResources(this.AdminKeyLabel, "AdminKeyLabel");
            this.AdminKeyLabel.Name = "AdminKeyLabel";
            // 
            // AdminKeyTb
            // 
            resources.ApplyResources(this.AdminKeyTb, "AdminKeyTb");
            this.AdminKeyTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminKeyTb.Name = "AdminKeyTb";
            // 
            // AdminLoginButton
            // 
            resources.ApplyResources(this.AdminLoginButton, "AdminLoginButton");
            this.AdminLoginButton.BackColor = System.Drawing.SystemColors.Window;
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.UseVisualStyleBackColor = false;
            this.AdminLoginButton.Click += new System.EventHandler(this.AdminLoginButton_Click);
            // 
            // AdminLoginPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.AdminKeyLabel);
            this.Controls.Add(this.AdminKeyTb);
            this.Controls.Add(this.LoginMenuStrip);
            this.Name = "AdminLoginPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminLoginPage_FormClosing);
            this.LoginMenuStrip.ResumeLayout(false);
            this.LoginMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button AdminLoginButton;

        private System.Windows.Forms.Label AdminKeyLabel;
        private System.Windows.Forms.TextBox AdminKeyTb;

        private System.Windows.Forms.MenuStrip LoginMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginPageToolStripMenuItem;

        #endregion
    }
}