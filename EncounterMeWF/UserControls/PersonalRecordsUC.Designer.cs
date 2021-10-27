
namespace EncounterMeWF.UserControls
{
    partial class PersonalRecordsUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TrailGridView = new System.Windows.Forms.DataGridView();
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MostBurnedCaloriesAnswer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AllBurnedCaloriesAnswer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LongestRunDistanceAnswer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LongestWalkDistanceAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(625, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 59);
            this.label1.TabIndex = 27;
            this.label1.Text = "Your runs";
            // 
            // TrailGridView
            // 
            this.TrailGridView.AllowUserToAddRows = false;
            this.TrailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrailGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TrailGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.TrailGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrailGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TrailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrailGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TrailGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrailGridView.Location = new System.Drawing.Point(87, 129);
            this.TrailGridView.Margin = new System.Windows.Forms.Padding(6);
            this.TrailGridView.Name = "TrailGridView";
            this.TrailGridView.RowHeadersVisible = false;
            this.TrailGridView.RowHeadersWidth = 82;
            this.TrailGridView.RowTemplate.Height = 25;
            this.TrailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrailGridView.Size = new System.Drawing.Size(942, 691);
            this.TrailGridView.TabIndex = 28;
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteEntryButton.ForeColor = System.Drawing.Color.Green;
            this.DeleteEntryButton.Location = new System.Drawing.Point(834, 860);
            this.DeleteEntryButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(195, 49);
            this.DeleteEntryButton.TabIndex = 29;
            this.DeleteEntryButton.Text = "Delete Entry";
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1056, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 59);
            this.label2.TabIndex = 30;
            this.label2.Text = "Most burned calories:";
            // 
            // MostBurnedCaloriesAnswer
            // 
            this.MostBurnedCaloriesAnswer.AutoSize = true;
            this.MostBurnedCaloriesAnswer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MostBurnedCaloriesAnswer.Location = new System.Drawing.Point(1158, 209);
            this.MostBurnedCaloriesAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MostBurnedCaloriesAnswer.Name = "MostBurnedCaloriesAnswer";
            this.MostBurnedCaloriesAnswer.Size = new System.Drawing.Size(48, 59);
            this.MostBurnedCaloriesAnswer.TabIndex = 32;
            this.MostBurnedCaloriesAnswer.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1071, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 59);
            this.label3.TabIndex = 33;
            this.label3.Text = "All burned calories:";
            // 
            // AllBurnedCaloriesAnswer
            // 
            this.AllBurnedCaloriesAnswer.AutoSize = true;
            this.AllBurnedCaloriesAnswer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllBurnedCaloriesAnswer.Location = new System.Drawing.Point(1158, 363);
            this.AllBurnedCaloriesAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AllBurnedCaloriesAnswer.Name = "AllBurnedCaloriesAnswer";
            this.AllBurnedCaloriesAnswer.Size = new System.Drawing.Size(48, 59);
            this.AllBurnedCaloriesAnswer.TabIndex = 34;
            this.AllBurnedCaloriesAnswer.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1056, 433);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 59);
            this.label4.TabIndex = 35;
            this.label4.Text = "Longest run distance:";
            // 
            // LongestRunDistanceAnswer
            // 
            this.LongestRunDistanceAnswer.AutoSize = true;
            this.LongestRunDistanceAnswer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongestRunDistanceAnswer.Location = new System.Drawing.Point(1158, 515);
            this.LongestRunDistanceAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LongestRunDistanceAnswer.Name = "LongestRunDistanceAnswer";
            this.LongestRunDistanceAnswer.Size = new System.Drawing.Size(48, 59);
            this.LongestRunDistanceAnswer.TabIndex = 36;
            this.LongestRunDistanceAnswer.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1041, 585);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(447, 59);
            this.label5.TabIndex = 37;
            this.label5.Text = "Longest walk distance:";
            // 
            // LongestWalkDistanceAnswer
            // 
            this.LongestWalkDistanceAnswer.AutoSize = true;
            this.LongestWalkDistanceAnswer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongestWalkDistanceAnswer.Location = new System.Drawing.Point(1158, 675);
            this.LongestWalkDistanceAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LongestWalkDistanceAnswer.Name = "LongestWalkDistanceAnswer";
            this.LongestWalkDistanceAnswer.Size = new System.Drawing.Size(48, 59);
            this.LongestWalkDistanceAnswer.TabIndex = 38;
            this.LongestWalkDistanceAnswer.Text = "0";
            // 
            // PersonalRecordsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.LongestWalkDistanceAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LongestRunDistanceAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllBurnedCaloriesAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MostBurnedCaloriesAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteEntryButton);
            this.Controls.Add(this.TrailGridView);
            this.Controls.Add(this.label1);
            this.Name = "PersonalRecordsUC";
            this.Size = new System.Drawing.Size(1488, 981);
            ((System.ComponentModel.ISupportInitialize)(this.TrailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TrailGridView;
        private System.Windows.Forms.Button DeleteEntryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MostBurnedCaloriesAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AllBurnedCaloriesAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LongestRunDistanceAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LongestWalkDistanceAnswer;
    }
}
