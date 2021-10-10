namespace EncounterMeWF.UserControls
{
    partial class CreateTrailsEntryUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TrailIdTextBox = new System.Windows.Forms.TextBox();
            this.TrailNameTextBox = new System.Windows.Forms.TextBox();
            this.TrailLengthTextbox = new System.Windows.Forms.TextBox();
            this.TrailCoordinatesTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trails Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trail Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trail Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trail Coordinates";
            // 
            // TrailIdTextBox
            // 
            this.TrailIdTextBox.Location = new System.Drawing.Point(470, 83);
            this.TrailIdTextBox.Name = "TrailIdTextBox";
            this.TrailIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.TrailIdTextBox.TabIndex = 4;
            // 
            // TrailNameTextBox
            // 
            this.TrailNameTextBox.Location = new System.Drawing.Point(470, 132);
            this.TrailNameTextBox.Name = "TrailNameTextBox";
            this.TrailNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.TrailNameTextBox.TabIndex = 5;
            // 
            // TrailLengthTextbox
            // 
            this.TrailLengthTextbox.Location = new System.Drawing.Point(470, 178);
            this.TrailLengthTextbox.Name = "TrailLengthTextbox";
            this.TrailLengthTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailLengthTextbox.TabIndex = 6;
            // 
            // TrailCoordinatesTextbox
            // 
            this.TrailCoordinatesTextbox.Location = new System.Drawing.Point(470, 228);
            this.TrailCoordinatesTextbox.Name = "TrailCoordinatesTextbox";
            this.TrailCoordinatesTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailCoordinatesTextbox.TabIndex = 7;
            // 
            // CreateTrailsEntryUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TrailCoordinatesTextbox);
            this.Controls.Add(this.TrailLengthTextbox);
            this.Controls.Add(this.TrailNameTextBox);
            this.Controls.Add(this.TrailIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateTrailsEntryUS";
            this.Size = new System.Drawing.Size(801, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TrailIdTextBox;
        private System.Windows.Forms.TextBox TrailNameTextBox;
        private System.Windows.Forms.TextBox TrailLengthTextbox;
        private System.Windows.Forms.TextBox TrailCoordinatesTextbox;
    }
}
