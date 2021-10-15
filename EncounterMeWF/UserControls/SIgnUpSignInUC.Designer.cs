namespace EncounterMeWF.UserControls
{
    partial class SIgnUpSignInUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SignUpUsernameTextbox = new System.Windows.Forms.TextBox();
            this.SignUpEmailTextbox = new System.Windows.Forms.TextBox();
            this.SignUpPasswordTextbox = new System.Windows.Forms.TextBox();
            this.SignUpConfirmPasswordTextbox = new System.Windows.Forms.TextBox();
            this.SingInEmailTextbox = new System.Windows.Forms.TextBox();
            this.SignInPasswordTexbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(171, 320);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(504, 320);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 23);
            this.SignInButton.TabIndex = 1;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            // 
            // SignUpUsernameTextbox
            // 
            this.SignUpUsernameTextbox.Location = new System.Drawing.Point(159, 72);
            this.SignUpUsernameTextbox.Name = "SignUpUsernameTextbox";
            this.SignUpUsernameTextbox.Size = new System.Drawing.Size(100, 23);
            this.SignUpUsernameTextbox.TabIndex = 2;
            // 
            // SignUpEmailTextbox
            // 
            this.SignUpEmailTextbox.Location = new System.Drawing.Point(159, 120);
            this.SignUpEmailTextbox.Name = "SignUpEmailTextbox";
            this.SignUpEmailTextbox.Size = new System.Drawing.Size(100, 23);
            this.SignUpEmailTextbox.TabIndex = 3;
            // 
            // SignUpPasswordTextbox
            // 
            this.SignUpPasswordTextbox.Location = new System.Drawing.Point(159, 182);
            this.SignUpPasswordTextbox.Name = "SignUpPasswordTextbox";
            this.SignUpPasswordTextbox.PasswordChar = '*';
            this.SignUpPasswordTextbox.Size = new System.Drawing.Size(100, 23);
            this.SignUpPasswordTextbox.TabIndex = 4;
            // 
            // SignUpConfirmPasswordTextbox
            // 
            this.SignUpConfirmPasswordTextbox.Location = new System.Drawing.Point(159, 242);
            this.SignUpConfirmPasswordTextbox.Name = "SignUpConfirmPasswordTextbox";
            this.SignUpConfirmPasswordTextbox.PasswordChar = '*';
            this.SignUpConfirmPasswordTextbox.Size = new System.Drawing.Size(100, 23);
            this.SignUpConfirmPasswordTextbox.TabIndex = 5;
            // 
            // SingInEmailTextbox
            // 
            this.SingInEmailTextbox.Location = new System.Drawing.Point(493, 182);
            this.SingInEmailTextbox.Name = "SingInEmailTextbox";
            this.SingInEmailTextbox.Size = new System.Drawing.Size(100, 23);
            this.SingInEmailTextbox.TabIndex = 6;
            // 
            // SignInPasswordTexbox
            // 
            this.SignInPasswordTexbox.Location = new System.Drawing.Point(493, 237);
            this.SignInPasswordTexbox.Name = "SignInPasswordTexbox";
            this.SignInPasswordTexbox.Size = new System.Drawing.Size(100, 23);
            this.SignInPasswordTexbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email adress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Confirm password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email adress:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password:";
            // 
            // SIgnUpSignInUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignInPasswordTexbox);
            this.Controls.Add(this.SingInEmailTextbox);
            this.Controls.Add(this.SignUpConfirmPasswordTextbox);
            this.Controls.Add(this.SignUpPasswordTextbox);
            this.Controls.Add(this.SignUpEmailTextbox);
            this.Controls.Add(this.SignUpUsernameTextbox);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.SignUpButton);
            this.Name = "SIgnUpSignInUC";
            this.Size = new System.Drawing.Size(801, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox SignUpUsernameTextbox;
        private System.Windows.Forms.TextBox SignUpEmailTextbox;
        private System.Windows.Forms.TextBox SignUpPasswordTextbox;
        private System.Windows.Forms.TextBox SignUpConfirmPasswordTextbox;
        private System.Windows.Forms.TextBox SingInEmailTextbox;
        private System.Windows.Forms.TextBox SignInPasswordTexbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
