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
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.CalculationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CalorieBurn = new System.Windows.Forms.Label();
            this.AddToRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(233, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Run/walk:";
            // 
            // RunWalkCombobox
            // 
            this.RunWalkCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RunWalkCombobox.FormattingEnabled = true;
            this.RunWalkCombobox.Items.AddRange(new object[] {
            "Run",
            "Walk"});
            this.RunWalkCombobox.Location = new System.Drawing.Point(299, 99);
            this.RunWalkCombobox.Name = "RunWalkCombobox";
            this.RunWalkCombobox.Size = new System.Drawing.Size(121, 23);
            this.RunWalkCombobox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(245, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Weight:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WeightTextBox.Location = new System.Drawing.Point(299, 143);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(120, 23);
            this.WeightTextBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(238, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Distance:";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DistanceTextBox.Location = new System.Drawing.Point(299, 186);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(120, 23);
            this.DistanceTextBox.TabIndex = 34;
            // 
            // CalculationButton
            // 
            this.CalculationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CalculationButton.ForeColor = System.Drawing.Color.Green;
            this.CalculationButton.Location = new System.Drawing.Point(246, 229);
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
            this.label3.Location = new System.Drawing.Point(263, 272);
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
            this.CalorieBurn.Location = new System.Drawing.Point(328, 309);
            this.CalorieBurn.Name = "CalorieBurn";
            this.CalorieBurn.Size = new System.Drawing.Size(25, 30);
            this.CalorieBurn.TabIndex = 37;
            this.CalorieBurn.Text = "0";
            // 
            // AddToRecordButton
            // 
            this.AddToRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddToRecordButton.ForeColor = System.Drawing.Color.Green;
            this.AddToRecordButton.Location = new System.Drawing.Point(246, 359);
            this.AddToRecordButton.Name = "AddToRecordButton";
            this.AddToRecordButton.Size = new System.Drawing.Size(174, 23);
            this.AddToRecordButton.TabIndex = 38;
            this.AddToRecordButton.Text = "Add to your record";
            this.AddToRecordButton.UseVisualStyleBackColor = false;
            this.AddToRecordButton.Visible = false;
            // 
            // CalorieCalculatorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.AddToRecordButton);
            this.Controls.Add(this.CalorieBurn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalculationButton);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeightTextBox);
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
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Button CalculationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CalorieBurn;
        private System.Windows.Forms.Button AddToRecordButton;
    }
}
