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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.PersonalRunButton = new System.Windows.Forms.Button();
            this.CalorieCalculatorButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.SignupSigninButton = new System.Windows.Forms.Button();
            this.trailsButton = new System.Windows.Forms.Button();
            this.indexButton = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.headerPanel.Controls.Add(this.LogoPictureBox);
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
            this.headerPanel.Size = new System.Drawing.Size(134, 460);
            this.headerPanel.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(35, 3);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(55, 39);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 16;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Click += new System.EventHandler(this.LogoPictureBox_Click);
            // 
            // PersonalRunButton
            // 
            this.PersonalRunButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersonalRunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PersonalRunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonalRunButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PersonalRunButton.FlatAppearance.BorderSize = 0;
            this.PersonalRunButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PersonalRunButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PersonalRunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalRunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonalRunButton.ForeColor = System.Drawing.Color.Green;
            this.PersonalRunButton.Location = new System.Drawing.Point(9, 263);
            this.PersonalRunButton.Margin = new System.Windows.Forms.Padding(0);
            this.PersonalRunButton.Name = "PersonalRunButton";
            this.PersonalRunButton.Size = new System.Drawing.Size(115, 56);
            this.PersonalRunButton.TabIndex = 8;
            this.PersonalRunButton.Text = "Personal runs";
            this.PersonalRunButton.UseVisualStyleBackColor = false;
            this.PersonalRunButton.Click += new System.EventHandler(this.PersonalRunButton_Click);
            // 
            // CalorieCalculatorButton
            // 
            this.CalorieCalculatorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalorieCalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CalorieCalculatorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalorieCalculatorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CalorieCalculatorButton.FlatAppearance.BorderSize = 0;
            this.CalorieCalculatorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalorieCalculatorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalorieCalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalorieCalculatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalorieCalculatorButton.ForeColor = System.Drawing.Color.Green;
            this.CalorieCalculatorButton.Location = new System.Drawing.Point(9, 207);
            this.CalorieCalculatorButton.Margin = new System.Windows.Forms.Padding(0);
            this.CalorieCalculatorButton.Name = "CalorieCalculatorButton";
            this.CalorieCalculatorButton.Size = new System.Drawing.Size(115, 56);
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
            this.SignOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignOutButton.FlatAppearance.BorderSize = 0;
            this.SignOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOutButton.ForeColor = System.Drawing.Color.Green;
            this.SignOutButton.Location = new System.Drawing.Point(21, 165);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(81, 30);
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
            this.SignupSigninButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupSigninButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignupSigninButton.FlatAppearance.BorderSize = 0;
            this.SignupSigninButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignupSigninButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignupSigninButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupSigninButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignupSigninButton.ForeColor = System.Drawing.Color.Green;
            this.SignupSigninButton.Location = new System.Drawing.Point(1, 122);
            this.SignupSigninButton.Margin = new System.Windows.Forms.Padding(0);
            this.SignupSigninButton.Name = "SignupSigninButton";
            this.SignupSigninButton.Size = new System.Drawing.Size(125, 30);
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
            this.trailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trailsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.trailsButton.FlatAppearance.BorderSize = 0;
            this.trailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trailsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.trailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trailsButton.ForeColor = System.Drawing.Color.Green;
            this.trailsButton.Location = new System.Drawing.Point(34, 81);
            this.trailsButton.Margin = new System.Windows.Forms.Padding(0);
            this.trailsButton.Name = "trailsButton";
            this.trailsButton.Size = new System.Drawing.Size(56, 30);
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
            this.indexButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indexButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.indexButton.FlatAppearance.BorderSize = 0;
            this.indexButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.indexButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.indexButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indexButton.ForeColor = System.Drawing.Color.Green;
            this.indexButton.Location = new System.Drawing.Point(9, 41);
            this.indexButton.Margin = new System.Windows.Forms.Padding(0);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(115, 30);
            this.indexButton.TabIndex = 0;
            this.indexButton.Text = "EncounterMe";
            this.indexButton.UseVisualStyleBackColor = false;
            this.indexButton.Click += new System.EventHandler(this.indexButton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(134, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(801, 460);
            this.panelContainer.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 460);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.headerPanel);
            this.Name = "mainForm";
            this.Text = "EncounterMe";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}

