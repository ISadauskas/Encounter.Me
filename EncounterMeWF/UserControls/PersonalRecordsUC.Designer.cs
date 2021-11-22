
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(337, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrailGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TrailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrailGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.TrailGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TrailGridView.Location = new System.Drawing.Point(47, 60);
            this.TrailGridView.Name = "TrailGridView";
            this.TrailGridView.RowHeadersVisible = false;
            this.TrailGridView.RowHeadersWidth = 82;
            this.TrailGridView.RowTemplate.Height = 25;
            this.TrailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrailGridView.Size = new System.Drawing.Size(507, 324);
            this.TrailGridView.TabIndex = 28;
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteEntryButton.ForeColor = System.Drawing.Color.Green;
            this.DeleteEntryButton.Location = new System.Drawing.Point(449, 403);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteEntryButton.TabIndex = 29;
            this.DeleteEntryButton.Text = "Delete Entry";
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(569, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Most burned calories:";
            // 
            // MostBurnedCaloriesAnswer
            // 
            this.MostBurnedCaloriesAnswer.AutoSize = true;
            this.MostBurnedCaloriesAnswer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MostBurnedCaloriesAnswer.ForeColor = System.Drawing.Color.Green;
            this.MostBurnedCaloriesAnswer.Location = new System.Drawing.Point(624, 98);
            this.MostBurnedCaloriesAnswer.Name = "MostBurnedCaloriesAnswer";
            this.MostBurnedCaloriesAnswer.Size = new System.Drawing.Size(25, 30);
            this.MostBurnedCaloriesAnswer.TabIndex = 32;
            this.MostBurnedCaloriesAnswer.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(577, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "All burned calories:";
            // 
            // AllBurnedCaloriesAnswer
            // 
            this.AllBurnedCaloriesAnswer.AutoSize = true;
            this.AllBurnedCaloriesAnswer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllBurnedCaloriesAnswer.ForeColor = System.Drawing.Color.Green;
            this.AllBurnedCaloriesAnswer.Location = new System.Drawing.Point(624, 173);
            this.AllBurnedCaloriesAnswer.Name = "AllBurnedCaloriesAnswer";
            this.AllBurnedCaloriesAnswer.Size = new System.Drawing.Size(25, 30);
            this.AllBurnedCaloriesAnswer.TabIndex = 34;
            this.AllBurnedCaloriesAnswer.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(569, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Longest run distance:";
            // 
            // LongestRunDistanceAnswer
            // 
            this.LongestRunDistanceAnswer.AutoSize = true;
            this.LongestRunDistanceAnswer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongestRunDistanceAnswer.ForeColor = System.Drawing.Color.Green;
            this.LongestRunDistanceAnswer.Location = new System.Drawing.Point(624, 241);
            this.LongestRunDistanceAnswer.Name = "LongestRunDistanceAnswer";
            this.LongestRunDistanceAnswer.Size = new System.Drawing.Size(25, 30);
            this.LongestRunDistanceAnswer.TabIndex = 36;
            this.LongestRunDistanceAnswer.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(561, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "Longest walk distance:";
            // 
            // LongestWalkDistanceAnswer
            // 
            this.LongestWalkDistanceAnswer.AutoSize = true;
            this.LongestWalkDistanceAnswer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LongestWalkDistanceAnswer.ForeColor = System.Drawing.Color.Green;
            this.LongestWalkDistanceAnswer.Location = new System.Drawing.Point(624, 316);
            this.LongestWalkDistanceAnswer.Name = "LongestWalkDistanceAnswer";
            this.LongestWalkDistanceAnswer.Size = new System.Drawing.Size(25, 30);
            this.LongestWalkDistanceAnswer.TabIndex = 38;
            this.LongestWalkDistanceAnswer.Text = "0";
            // 
            // PersonalRecordsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "PersonalRecordsUC";
            this.Size = new System.Drawing.Size(801, 460);
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
