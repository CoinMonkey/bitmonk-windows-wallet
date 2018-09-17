namespace BitMonk
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.rpcHost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rpcPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rpcLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rpcPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.securityBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.securityBox.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpcHost
            // 
            this.rpcHost.Location = new System.Drawing.Point(74, 19);
            this.rpcHost.Name = "rpcHost";
            this.rpcHost.Size = new System.Drawing.Size(137, 20);
            this.rpcHost.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rpcPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rpcLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rpcPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rpcHost);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RPC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // rpcPassword
            // 
            this.rpcPassword.Location = new System.Drawing.Point(74, 99);
            this.rpcPassword.Name = "rpcPassword";
            this.rpcPassword.PasswordChar = '*';
            this.rpcPassword.Size = new System.Drawing.Size(137, 20);
            this.rpcPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Login";
            // 
            // rpcLogin
            // 
            this.rpcLogin.Location = new System.Drawing.Point(74, 73);
            this.rpcLogin.Name = "rpcLogin";
            this.rpcLogin.Size = new System.Drawing.Size(137, 20);
            this.rpcLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // rpcPort
            // 
            this.rpcPort.Location = new System.Drawing.Point(74, 45);
            this.rpcPort.Name = "rpcPort";
            this.rpcPort.Size = new System.Drawing.Size(137, 20);
            this.rpcPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // securityBox
            // 
            this.securityBox.Controls.Add(this.label8);
            this.securityBox.Controls.Add(this.password);
            this.securityBox.Location = new System.Drawing.Point(241, 91);
            this.securityBox.Name = "securityBox";
            this.securityBox.Size = new System.Drawing.Size(229, 58);
            this.securityBox.TabIndex = 8;
            this.securityBox.TabStop = false;
            this.securityBox.Text = "Security";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(74, 19);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(137, 20);
            this.password.TabIndex = 0;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.label5);
            this.settingsGroupBox.Controls.Add(this.account);
            this.settingsGroupBox.Location = new System.Drawing.Point(241, 19);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(229, 58);
            this.settingsGroupBox.TabIndex = 9;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Account";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(74, 19);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(137, 20);
            this.account.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 195);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.securityBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.securityBox.ResumeLayout(false);
            this.securityBox.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox rpcHost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rpcPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rpcLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rpcPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox securityBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox account;
    }
}