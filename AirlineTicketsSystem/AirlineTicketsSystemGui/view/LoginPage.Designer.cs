namespace AirlineTicketsSystemGui
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.LoginTabControl = new System.Windows.Forms.TabControl();
            this.StaffLoginTab = new System.Windows.Forms.TabPage();
            this.StaffAdminLabel = new System.Windows.Forms.Label();
            this.StaffPasswordLabel = new System.Windows.Forms.Label();
            this.StaffIdLabel = new System.Windows.Forms.Label();
            this.StaffPasswordTb = new System.Windows.Forms.TextBox();
            this.StaffIdTb = new System.Windows.Forms.TextBox();
            this.StaffLoginButton = new System.Windows.Forms.Button();
            this.PassengerLoginTab = new System.Windows.Forms.TabPage();
            this.PassengerPasswordLabel = new System.Windows.Forms.Label();
            this.PassengerIdLabel = new System.Windows.Forms.Label();
            this.PassengerPasswordTb = new System.Windows.Forms.TextBox();
            this.PassengerUsernameTb = new System.Windows.Forms.TextBox();
            this.PassengerLoginButton = new System.Windows.Forms.Button();
            this.PassengerSignupLabel = new System.Windows.Forms.Label();
            this.LoginMenuStrip = new System.Windows.Forms.MenuStrip();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginTabControl.SuspendLayout();
            this.StaffLoginTab.SuspendLayout();
            this.PassengerLoginTab.SuspendLayout();
            this.LoginMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTabControl
            // 
            resources.ApplyResources(this.LoginTabControl, "LoginTabControl");
            this.LoginTabControl.Controls.Add(this.StaffLoginTab);
            this.LoginTabControl.Controls.Add(this.PassengerLoginTab);
            this.LoginTabControl.Multiline = true;
            this.LoginTabControl.Name = "LoginTabControl";
            this.LoginTabControl.SelectedIndex = 0;
            this.LoginTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // StaffLoginTab
            // 
            resources.ApplyResources(this.StaffLoginTab, "StaffLoginTab");
            this.StaffLoginTab.Controls.Add(this.StaffAdminLabel);
            this.StaffLoginTab.Controls.Add(this.StaffPasswordLabel);
            this.StaffLoginTab.Controls.Add(this.StaffIdLabel);
            this.StaffLoginTab.Controls.Add(this.StaffPasswordTb);
            this.StaffLoginTab.Controls.Add(this.StaffIdTb);
            this.StaffLoginTab.Controls.Add(this.StaffLoginButton);
            this.StaffLoginTab.Name = "StaffLoginTab";
            this.StaffLoginTab.UseVisualStyleBackColor = true;
            // 
            // StaffAdminLabel
            // 
            resources.ApplyResources(this.StaffAdminLabel, "StaffAdminLabel");
            this.StaffAdminLabel.Name = "StaffAdminLabel";
            this.StaffAdminLabel.Click += new System.EventHandler(this.StaffAdminLabel_Click);
            // 
            // StaffPasswordLabel
            // 
            resources.ApplyResources(this.StaffPasswordLabel, "StaffPasswordLabel");
            this.StaffPasswordLabel.Name = "StaffPasswordLabel";
            // 
            // StaffIdLabel
            // 
            resources.ApplyResources(this.StaffIdLabel, "StaffIdLabel");
            this.StaffIdLabel.Name = "StaffIdLabel";
            // 
            // StaffPasswordTb
            // 
            resources.ApplyResources(this.StaffPasswordTb, "StaffPasswordTb");
            this.StaffPasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffPasswordTb.Name = "StaffPasswordTb";
            // 
            // StaffIdTb
            // 
            resources.ApplyResources(this.StaffIdTb, "StaffIdTb");
            this.StaffIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffIdTb.Name = "StaffIdTb";
            // 
            // StaffLoginButton
            // 
            resources.ApplyResources(this.StaffLoginButton, "StaffLoginButton");
            this.StaffLoginButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffLoginButton.Name = "StaffLoginButton";
            this.StaffLoginButton.UseVisualStyleBackColor = false;
            this.StaffLoginButton.Click += new System.EventHandler(this.StaffLoginButton_Click);
            // 
            // PassengerLoginTab
            // 
            resources.ApplyResources(this.PassengerLoginTab, "PassengerLoginTab");
            this.PassengerLoginTab.Controls.Add(this.PassengerPasswordLabel);
            this.PassengerLoginTab.Controls.Add(this.PassengerIdLabel);
            this.PassengerLoginTab.Controls.Add(this.PassengerPasswordTb);
            this.PassengerLoginTab.Controls.Add(this.PassengerUsernameTb);
            this.PassengerLoginTab.Controls.Add(this.PassengerLoginButton);
            this.PassengerLoginTab.Controls.Add(this.PassengerSignupLabel);
            this.PassengerLoginTab.Name = "PassengerLoginTab";
            this.PassengerLoginTab.UseVisualStyleBackColor = true;
            // 
            // PassengerPasswordLabel
            // 
            resources.ApplyResources(this.PassengerPasswordLabel, "PassengerPasswordLabel");
            this.PassengerPasswordLabel.Name = "PassengerPasswordLabel";
            // 
            // PassengerIdLabel
            // 
            resources.ApplyResources(this.PassengerIdLabel, "PassengerIdLabel");
            this.PassengerIdLabel.Name = "PassengerIdLabel";
            // 
            // PassengerPasswordTb
            // 
            resources.ApplyResources(this.PassengerPasswordTb, "PassengerPasswordTb");
            this.PassengerPasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerPasswordTb.Name = "PassengerPasswordTb";
            // 
            // PassengerUsernameTb
            // 
            resources.ApplyResources(this.PassengerUsernameTb, "PassengerUsernameTb");
            this.PassengerUsernameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerUsernameTb.Name = "PassengerUsernameTb";
            // 
            // PassengerLoginButton
            // 
            resources.ApplyResources(this.PassengerLoginButton, "PassengerLoginButton");
            this.PassengerLoginButton.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerLoginButton.Name = "PassengerLoginButton";
            this.PassengerLoginButton.UseVisualStyleBackColor = false;
            this.PassengerLoginButton.Click += new System.EventHandler(this.PassengerLoginButton_Click);
            // 
            // PassengerSignupLabel
            // 
            resources.ApplyResources(this.PassengerSignupLabel, "PassengerSignupLabel");
            this.PassengerSignupLabel.Name = "PassengerSignupLabel";
            this.PassengerSignupLabel.Click += new System.EventHandler(this.PassengerSignupLabel_Click);
            // 
            // LoginMenuStrip
            // 
            resources.ApplyResources(this.LoginMenuStrip, "LoginMenuStrip");
            this.LoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.pageToolStripMenuItem, this.languageToolStripMenuItem });
            this.LoginMenuStrip.Name = "LoginMenuStrip";
            // 
            // pageToolStripMenuItem
            // 
            resources.ApplyResources(this.pageToolStripMenuItem, "pageToolStripMenuItem");
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.aboutToolStripMenuItem, this.exitToolStripMenuItem });
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.frenchToolStripMenuItem, this.englishToolStripMenuItem });
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // frenchToolStripMenuItem
            // 
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            // 
            // LoginPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginMenuStrip);
            this.Controls.Add(this.LoginTabControl);
            this.Name = "LoginPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.LoginTabControl.ResumeLayout(false);
            this.StaffLoginTab.ResumeLayout(false);
            this.StaffLoginTab.PerformLayout();
            this.PassengerLoginTab.ResumeLayout(false);
            this.PassengerLoginTab.PerformLayout();
            this.LoginMenuStrip.ResumeLayout(false);
            this.LoginMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl LoginTabControl;
        private System.Windows.Forms.TabPage StaffLoginTab;
        private System.Windows.Forms.Label StaffPasswordLabel;
        private System.Windows.Forms.Label StaffIdLabel;
        private System.Windows.Forms.TextBox StaffPasswordTb;
        private System.Windows.Forms.TextBox StaffIdTb;
        private System.Windows.Forms.Button StaffLoginButton;
        private System.Windows.Forms.TabPage PassengerLoginTab;
        private System.Windows.Forms.Label PassengerPasswordLabel;
        private System.Windows.Forms.Label PassengerIdLabel;
        private System.Windows.Forms.TextBox PassengerPasswordTb;
        private System.Windows.Forms.TextBox PassengerUsernameTb;
        private System.Windows.Forms.Button PassengerLoginButton;
        private System.Windows.Forms.Label PassengerSignupLabel;
        private System.Windows.Forms.MenuStrip LoginMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Label StaffAdminLabel;
    }
}

