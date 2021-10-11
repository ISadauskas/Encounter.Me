
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
            this.trailsButton = new System.Windows.Forms.Button();
            this.indexButton = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.headerPanel.Controls.Add(this.trailsButton);
            this.headerPanel.Controls.Add(this.indexButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(238, 1103);
            this.headerPanel.TabIndex = 0;
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
            this.trailsButton.Location = new System.Drawing.Point(60, 130);
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
            this.indexButton.Location = new System.Drawing.Point(9, 48);
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
            this.panelContainer.Location = new System.Drawing.Point(238, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1250, 1103);
            this.panelContainer.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 1103);
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
    }
}

