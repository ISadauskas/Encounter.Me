﻿
namespace EncounterMeWF
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.LogoButton = new System.Windows.Forms.Button();
            this.PersonalRunButton = new System.Windows.Forms.Button();
            this.CalorieCalculatorButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SignupSigninButton = new System.Windows.Forms.Button();
            this.trailsButton = new System.Windows.Forms.Button();
            this.indexButton = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.headerPanel.Controls.Add(this.LogoButton);
            this.headerPanel.Controls.Add(this.PersonalRunButton);
            this.headerPanel.Controls.Add(this.CalorieCalculatorButton);
            this.headerPanel.Controls.Add(this.SignOutButton);
            this.headerPanel.Controls.Add(this.SignupSigninButton);
            this.headerPanel.Controls.Add(this.trailsButton);
            this.headerPanel.Controls.Add(this.indexButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(249, 981);
            this.headerPanel.TabIndex = 0;
            // 
            // LogoButton
            // 
            this.LogoButton.AutoSize = true;
            this.LogoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogoButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoButton.FlatAppearance.BorderSize = 0;
            this.LogoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoButton.Image = global::EncounterMeWF.Properties.Resources.LeafLogo;
            this.LogoButton.Location = new System.Drawing.Point(65, 26);
            this.LogoButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LogoButton.Name = "LogoButton";
            this.LogoButton.Size = new System.Drawing.Size(51, 36);
            this.LogoButton.TabIndex = 9;
            this.LogoButton.UseVisualStyleBackColor = false;
            // 
            // PersonalRunButton
            // 
            this.PersonalRunButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersonalRunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PersonalRunButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PersonalRunButton.FlatAppearance.BorderSize = 0;
            this.PersonalRunButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PersonalRunButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PersonalRunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalRunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonalRunButton.ForeColor = System.Drawing.Color.Green;
            this.PersonalRunButton.Location = new System.Drawing.Point(11, 484);
            this.PersonalRunButton.Margin = new System.Windows.Forms.Padding(0);
            this.PersonalRunButton.Name = "PersonalRunButton";
            this.PersonalRunButton.Size = new System.Drawing.Size(219, 92);
            this.PersonalRunButton.TabIndex = 8;
            this.PersonalRunButton.Text = "Personal runs";
            this.PersonalRunButton.UseVisualStyleBackColor = false;
            this.PersonalRunButton.Click += new System.EventHandler(this.PersonalRunButton_Click);
            // 
            // CalorieCalculatorButton
            // 
            this.CalorieCalculatorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalorieCalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CalorieCalculatorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CalorieCalculatorButton.FlatAppearance.BorderSize = 0;
            this.CalorieCalculatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalorieCalculatorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalorieCalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalorieCalculatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalorieCalculatorButton.ForeColor = System.Drawing.Color.Green;
            this.CalorieCalculatorButton.Location = new System.Drawing.Point(11, 365);
            this.CalorieCalculatorButton.Margin = new System.Windows.Forms.Padding(0);
            this.CalorieCalculatorButton.Name = "CalorieCalculatorButton";
            this.CalorieCalculatorButton.Size = new System.Drawing.Size(219, 119);
            this.CalorieCalculatorButton.TabIndex = 7;
            this.CalorieCalculatorButton.Text = "Calorie calculator";
            this.CalorieCalculatorButton.UseVisualStyleBackColor = false;
            this.CalorieCalculatorButton.Click += new System.EventHandler(this.CalorieCalculatorButton_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.AutoSize = true;
            this.SignOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SignOutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignOutButton.FlatAppearance.BorderSize = 0;
            this.SignOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOutButton.ForeColor = System.Drawing.Color.Green;
            this.SignOutButton.Location = new System.Drawing.Point(37, 301);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(152, 47);
            this.SignOutButton.TabIndex = 5;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // SignupSigninButton
            // 
            this.SignupSigninButton.AutoSize = true;
            this.SignupSigninButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignupSigninButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SignupSigninButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignupSigninButton.FlatAppearance.BorderSize = 0;
            this.SignupSigninButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignupSigninButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignupSigninButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupSigninButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignupSigninButton.ForeColor = System.Drawing.Color.Green;
            this.SignupSigninButton.Location = new System.Drawing.Point(11, 237);
            this.SignupSigninButton.Margin = new System.Windows.Forms.Padding(0);
            this.SignupSigninButton.Name = "SignupSigninButton";
            this.SignupSigninButton.Size = new System.Drawing.Size(243, 47);
            this.SignupSigninButton.TabIndex = 2;
            this.SignupSigninButton.Text = "Sign up/Sign in";
            this.SignupSigninButton.UseVisualStyleBackColor = false;
            this.SignupSigninButton.Click += new System.EventHandler(this.SignupSigninButton_Click);
            // 
            // trailsButton
            // 
            this.trailsButton.AutoSize = true;
            this.trailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trailsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.trailsButton.FlatAppearance.BorderSize = 0;
            this.trailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trailsButton.ForeColor = System.Drawing.Color.Green;
            this.trailsButton.Location = new System.Drawing.Point(56, 173);
            this.trailsButton.Margin = new System.Windows.Forms.Padding(0);
            this.trailsButton.Name = "trailsButton";
            this.trailsButton.Size = new System.Drawing.Size(106, 47);
            this.trailsButton.TabIndex = 1;
            this.trailsButton.Text = "Trails";
            this.trailsButton.UseVisualStyleBackColor = false;
            this.trailsButton.Click += new System.EventHandler(this.trailsButton_Click);
            // 
            // indexButton
            // 
            this.indexButton.AutoSize = true;
            this.indexButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.indexButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.indexButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.indexButton.FlatAppearance.BorderSize = 0;
            this.indexButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.indexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.indexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indexButton.ForeColor = System.Drawing.Color.Green;
            this.indexButton.Location = new System.Drawing.Point(17, 109);
            this.indexButton.Margin = new System.Windows.Forms.Padding(0);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(216, 47);
            this.indexButton.TabIndex = 0;
            this.indexButton.Text = "EncounterMe";
            this.indexButton.UseVisualStyleBackColor = false;
            this.indexButton.Click += new System.EventHandler(this.indexButton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(249, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1487, 981);
            this.panelContainer.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 981);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "mainForm";
            this.Text = "EncounterMe";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button indexButton;
        private System.Windows.Forms.Button trailsButton;
        private System.Windows.Forms.Button SignupSigninButton;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Button CalorieCalculatorButton;
        private System.Windows.Forms.Button PersonalRunButton;
        private System.Windows.Forms.Button LogoButton;
    }
}

