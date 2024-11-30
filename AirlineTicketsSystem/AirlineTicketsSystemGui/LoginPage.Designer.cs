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
            this.LoginTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.LoginTabControl.Controls.Add(this.StaffLoginTab);
            this.LoginTabControl.Controls.Add(this.PassengerLoginTab);
            this.LoginTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTabControl.ItemSize = new System.Drawing.Size(150, 30);
            this.LoginTabControl.Location = new System.Drawing.Point(0, 27);
            this.LoginTabControl.Multiline = true;
            this.LoginTabControl.Name = "LoginTabControl";
            this.LoginTabControl.SelectedIndex = 0;
            this.LoginTabControl.Size = new System.Drawing.Size(311, 218);
            this.LoginTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.LoginTabControl.TabIndex = 1;
            // 
            // StaffLoginTab
            // 
            this.StaffLoginTab.Controls.Add(this.StaffAdminLabel);
            this.StaffLoginTab.Controls.Add(this.StaffPasswordLabel);
            this.StaffLoginTab.Controls.Add(this.StaffIdLabel);
            this.StaffLoginTab.Controls.Add(this.StaffPasswordTb);
            this.StaffLoginTab.Controls.Add(this.StaffIdTb);
            this.StaffLoginTab.Controls.Add(this.StaffLoginButton);
            this.StaffLoginTab.Location = new System.Drawing.Point(4, 34);
            this.StaffLoginTab.Name = "StaffLoginTab";
            this.StaffLoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.StaffLoginTab.Size = new System.Drawing.Size(303, 180);
            this.StaffLoginTab.TabIndex = 0;
            this.StaffLoginTab.Text = "Staff";
            this.StaffLoginTab.UseVisualStyleBackColor = true;
            // 
            // StaffAdminLabel
            // 
            this.StaffAdminLabel.Location = new System.Drawing.Point(11, 139);
            this.StaffAdminLabel.Name = "StaffAdminLabel";
            this.StaffAdminLabel.Size = new System.Drawing.Size(284, 34);
            this.StaffAdminLabel.TabIndex = 11;
            this.StaffAdminLabel.Text = "Login as Admin?";
            this.StaffAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffPasswordLabel
            // 
            this.StaffPasswordLabel.AutoSize = true;
            this.StaffPasswordLabel.Location = new System.Drawing.Point(8, 49);
            this.StaffPasswordLabel.Name = "StaffPasswordLabel";
            this.StaffPasswordLabel.Size = new System.Drawing.Size(87, 17);
            this.StaffPasswordLabel.TabIndex = 10;
            this.StaffPasswordLabel.Text = "Password :";
            // 
            // StaffIdLabel
            // 
            this.StaffIdLabel.AutoSize = true;
            this.StaffIdLabel.Location = new System.Drawing.Point(8, 3);
            this.StaffIdLabel.Name = "StaffIdLabel";
            this.StaffIdLabel.Size = new System.Drawing.Size(33, 17);
            this.StaffIdLabel.TabIndex = 9;
            this.StaffIdLabel.Text = "ID :";
            // 
            // StaffPasswordTb
            // 
            this.StaffPasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffPasswordTb.Location = new System.Drawing.Point(11, 69);
            this.StaffPasswordTb.Name = "StaffPasswordTb";
            this.StaffPasswordTb.Size = new System.Drawing.Size(284, 23);
            this.StaffPasswordTb.TabIndex = 8;
            // 
            // StaffIdTb
            // 
            this.StaffIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffIdTb.Location = new System.Drawing.Point(11, 23);
            this.StaffIdTb.Name = "StaffIdTb";
            this.StaffIdTb.Size = new System.Drawing.Size(284, 23);
            this.StaffIdTb.TabIndex = 7;
            // 
            // StaffLoginButton
            // 
            this.StaffLoginButton.BackColor = System.Drawing.SystemColors.Window;
            this.StaffLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLoginButton.Location = new System.Drawing.Point(11, 102);
            this.StaffLoginButton.Name = "StaffLoginButton";
            this.StaffLoginButton.Size = new System.Drawing.Size(284, 34);
            this.StaffLoginButton.TabIndex = 1;
            this.StaffLoginButton.Text = "Login";
            this.StaffLoginButton.UseVisualStyleBackColor = false;
            this.StaffLoginButton.Click += new System.EventHandler(this.StaffLoginButton_Click);
            // 
            // PassengerLoginTab
            // 
            this.PassengerLoginTab.Controls.Add(this.PassengerPasswordLabel);
            this.PassengerLoginTab.Controls.Add(this.PassengerIdLabel);
            this.PassengerLoginTab.Controls.Add(this.PassengerPasswordTb);
            this.PassengerLoginTab.Controls.Add(this.PassengerUsernameTb);
            this.PassengerLoginTab.Controls.Add(this.PassengerLoginButton);
            this.PassengerLoginTab.Controls.Add(this.PassengerSignupLabel);
            this.PassengerLoginTab.Location = new System.Drawing.Point(4, 34);
            this.PassengerLoginTab.Name = "PassengerLoginTab";
            this.PassengerLoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.PassengerLoginTab.Size = new System.Drawing.Size(303, 180);
            this.PassengerLoginTab.TabIndex = 1;
            this.PassengerLoginTab.Text = "Passenger";
            this.PassengerLoginTab.UseVisualStyleBackColor = true;
            // 
            // PassengerPasswordLabel
            // 
            this.PassengerPasswordLabel.AutoSize = true;
            this.PassengerPasswordLabel.Location = new System.Drawing.Point(8, 49);
            this.PassengerPasswordLabel.Name = "PassengerPasswordLabel";
            this.PassengerPasswordLabel.Size = new System.Drawing.Size(87, 17);
            this.PassengerPasswordLabel.TabIndex = 6;
            this.PassengerPasswordLabel.Text = "Password :";
            // 
            // PassengerIdLabel
            // 
            this.PassengerIdLabel.AutoSize = true;
            this.PassengerIdLabel.Location = new System.Drawing.Point(8, 3);
            this.PassengerIdLabel.Name = "PassengerIdLabel";
            this.PassengerIdLabel.Size = new System.Drawing.Size(91, 17);
            this.PassengerIdLabel.TabIndex = 5;
            this.PassengerIdLabel.Text = "Username :";
            // 
            // PassengerPasswordTb
            // 
            this.PassengerPasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerPasswordTb.Location = new System.Drawing.Point(11, 69);
            this.PassengerPasswordTb.Name = "PassengerPasswordTb";
            this.PassengerPasswordTb.Size = new System.Drawing.Size(284, 23);
            this.PassengerPasswordTb.TabIndex = 4;
            // 
            // PassengerUsernameTb
            // 
            this.PassengerUsernameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassengerUsernameTb.Location = new System.Drawing.Point(11, 23);
            this.PassengerUsernameTb.Name = "PassengerUsernameTb";
            this.PassengerUsernameTb.Size = new System.Drawing.Size(284, 23);
            this.PassengerUsernameTb.TabIndex = 3;
            // 
            // PassengerLoginButton
            // 
            this.PassengerLoginButton.BackColor = System.Drawing.SystemColors.Window;
            this.PassengerLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassengerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerLoginButton.Location = new System.Drawing.Point(11, 102);
            this.PassengerLoginButton.Name = "PassengerLoginButton";
            this.PassengerLoginButton.Size = new System.Drawing.Size(284, 34);
            this.PassengerLoginButton.TabIndex = 2;
            this.PassengerLoginButton.Text = "Login";
            this.PassengerLoginButton.UseVisualStyleBackColor = false;
            this.PassengerLoginButton.Click += new System.EventHandler(this.PassengerLoginButton_Click);
            // 
            // PassengerSignupLabel
            // 
            this.PassengerSignupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassengerSignupLabel.Location = new System.Drawing.Point(11, 136);
            this.PassengerSignupLabel.Name = "PassengerSignupLabel";
            this.PassengerSignupLabel.Size = new System.Drawing.Size(284, 34);
            this.PassengerSignupLabel.TabIndex = 2;
            this.PassengerSignupLabel.Text = "Don\'t have an account? Sign Up";
            this.PassengerSignupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginMenuStrip
            // 
            this.LoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.LoginMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.LoginMenuStrip.Name = "LoginMenuStrip";
            this.LoginMenuStrip.Size = new System.Drawing.Size(311, 24);
            this.LoginMenuStrip.TabIndex = 4;
            this.LoginMenuStrip.Text = "menuStrip1";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
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
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 244);
            this.Controls.Add(this.LoginMenuStrip);
            this.Controls.Add(this.LoginTabControl);
            this.Name = "LoginPage";
            this.Text = "Login Page";
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

