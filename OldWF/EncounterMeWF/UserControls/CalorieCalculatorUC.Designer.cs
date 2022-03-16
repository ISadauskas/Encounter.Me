namespace EncounterMeWF.UserControls
{
    partial class CalorieCalculatorUC
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
            this.RunWalkCombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WeightTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CalorieBurn = new System.Windows.Forms.Label();
            this.AddToRecordButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CaloriesNeedButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.CaloriesNeedToConsume = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.WeightTextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(157, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Activity:";
            // 
            // RunWalkCombobox
            // 
            this.RunWalkCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunWalkCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RunWalkCombobox.FormattingEnabled = true;
            this.RunWalkCombobox.Items.AddRange(new object[] {
            "Run",
            "Walk"});
            this.RunWalkCombobox.Location = new System.Drawing.Point(213, 125);
            this.RunWalkCombobox.Name = "RunWalkCombobox";
            this.RunWalkCombobox.Size = new System.Drawing.Size(115, 23);
            this.RunWalkCombobox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(377, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Weight:";
            // 
            // WeightTextBox2
            // 
            this.WeightTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WeightTextBox2.Location = new System.Drawing.Point(443, 151);
            this.WeightTextBox2.Name = "WeightTextBox2";
            this.WeightTextBox2.Size = new System.Drawing.Size(38, 23);
            this.WeightTextBox2.TabIndex = 32;
            this.WeightTextBox2.TextChanged += new System.EventHandler(this.WeightTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(160, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Distance:";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DistanceTextBox.Location = new System.Drawing.Point(221, 200);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(38, 23);
            this.DistanceTextBox.TabIndex = 34;
            // 
            // CalculationButton
            // 
            this.CalculationButton.BackColor = System.Drawing.Color.Green;
            this.CalculationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculationButton.FlatAppearance.BorderSize = 0;
            this.CalculationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculationButton.ForeColor = System.Drawing.Color.White;
            this.CalculationButton.Location = new System.Drawing.Point(164, 242);
            this.CalculationButton.Name = "CalculationButton";
            this.CalculationButton.Size = new System.Drawing.Size(174, 23);
            this.CalculationButton.TabIndex = 35;
            this.CalculationButton.Text = "Calculate burned calories";
            this.CalculationButton.UseVisualStyleBackColor = false;
            this.CalculationButton.Click += new System.EventHandler(this.CalculationButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(164, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Total calories burned:";
            // 
            // CalorieBurn
            // 
            this.CalorieBurn.AutoSize = true;
            this.CalorieBurn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalorieBurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CalorieBurn.Location = new System.Drawing.Point(234, 304);
            this.CalorieBurn.Name = "CalorieBurn";
            this.CalorieBurn.Size = new System.Drawing.Size(25, 30);
            this.CalorieBurn.TabIndex = 37;
            this.CalorieBurn.Text = "0";
            // 
            // AddToRecordButton
            // 
            this.AddToRecordButton.BackColor = System.Drawing.Color.Green;
            this.AddToRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddToRecordButton.FlatAppearance.BorderSize = 0;
            this.AddToRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToRecordButton.ForeColor = System.Drawing.Color.White;
            this.AddToRecordButton.Location = new System.Drawing.Point(278, 358);
            this.AddToRecordButton.Name = "AddToRecordButton";
            this.AddToRecordButton.Size = new System.Drawing.Size(174, 23);
            this.AddToRecordButton.TabIndex = 38;
            this.AddToRecordButton.Text = "Add to your record";
            this.AddToRecordButton.UseVisualStyleBackColor = false;
            this.AddToRecordButton.Visible = false;
            this.AddToRecordButton.Click += new System.EventHandler(this.AddToRecordButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(159, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Duration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(270, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "minutes";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DurationTextBox.Location = new System.Drawing.Point(221, 176);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(38, 23);
            this.DurationTextBox.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(496, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "kg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(278, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "km";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(443, 125);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(115, 23);
            this.GenderComboBox.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(377, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(392, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Age:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AgeTextBox.Location = new System.Drawing.Point(443, 176);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(38, 23);
            this.AgeTextBox.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(377, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "Height:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HeightTextBox.Location = new System.Drawing.Point(443, 200);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(38, 23);
            this.HeightTextBox.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(496, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 15);
            this.label12.TabIndex = 52;
            this.label12.Text = "cm";
            // 
            // CaloriesNeedButton
            // 
            this.CaloriesNeedButton.BackColor = System.Drawing.Color.Green;
            this.CaloriesNeedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaloriesNeedButton.FlatAppearance.BorderSize = 0;
            this.CaloriesNeedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaloriesNeedButton.ForeColor = System.Drawing.Color.White;
            this.CaloriesNeedButton.Location = new System.Drawing.Point(377, 242);
            this.CaloriesNeedButton.Name = "CaloriesNeedButton";
            this.CaloriesNeedButton.Size = new System.Drawing.Size(174, 23);
            this.CaloriesNeedButton.TabIndex = 53;
            this.CaloriesNeedButton.Text = "Calculate calories";
            this.CaloriesNeedButton.UseVisualStyleBackColor = false;
            this.CaloriesNeedButton.Click += new System.EventHandler(this.CaloriesNeedButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(360, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 21);
            this.label13.TabIndex = 54;
            this.label13.Text = "Total calories need to consume:";
            // 
            // CaloriesNeedToConsume
            // 
            this.CaloriesNeedToConsume.AutoSize = true;
            this.CaloriesNeedToConsume.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaloriesNeedToConsume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CaloriesNeedToConsume.Location = new System.Drawing.Point(453, 304);
            this.CaloriesNeedToConsume.Name = "CaloriesNeedToConsume";
            this.CaloriesNeedToConsume.Size = new System.Drawing.Size(25, 30);
            this.CaloriesNeedToConsume.TabIndex = 55;
            this.CaloriesNeedToConsume.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(160, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 56;
            this.label14.Text = "Weight:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(265, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 15);
            this.label15.TabIndex = 57;
            this.label15.Text = "kg";
            // 
            // WeightTextBox1
            // 
            this.WeightTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WeightTextBox1.Location = new System.Drawing.Point(221, 151);
            this.WeightTextBox1.Name = "WeightTextBox1";
            this.WeightTextBox1.Size = new System.Drawing.Size(38, 23);
            this.WeightTextBox1.TabIndex = 58;
            this.WeightTextBox1.TextChanged += new System.EventHandler(this.WeightTextBox1_TextChanged);
            // 
            // CalorieCalculatorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.WeightTextBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CaloriesNeedToConsume);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CaloriesNeedButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddToRecordButton);
            this.Controls.Add(this.CalorieBurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeightTextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RunWalkCombobox);
            this.Controls.Add(this.label1);
            this.Name = "CalorieCalculatorUC";
            this.Size = new System.Drawing.Size(801, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RunWalkCombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WeightTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CalorieBurn;
        private System.Windows.Forms.Button AddToRecordButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CaloriesNeedButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label CaloriesNeedToConsume;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox WeightTextBox1;
    }
}
