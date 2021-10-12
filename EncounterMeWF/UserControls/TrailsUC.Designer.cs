
namespace EncounterMeWF.UserControls
{
    partial class TrailsUC
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
            this.TrailGridView = new System.Windows.Forms.DataGridView();
            this.CreateEntryButton = new System.Windows.Forms.Button();
            this.TrailLengthTextbox = new System.Windows.Forms.TextBox();
            this.TrailCoordinatesTextbox = new System.Windows.Forms.TextBox();
            this.TrailNameTextbox = new System.Windows.Forms.TextBox();
            this.TrailIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            this.ModifyEntryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrailGridView
            // 
            this.TrailGridView.AllowUserToAddRows = false;
            this.TrailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrailGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
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
            this.TrailGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TrailGridView.Location = new System.Drawing.Point(277, 51);
            this.TrailGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TrailGridView.Name = "TrailGridView";
            this.TrailGridView.RowHeadersWidth = 82;
            this.TrailGridView.RowTemplate.Height = 25;
            this.TrailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrailGridView.Size = new System.Drawing.Size(942, 692);
            this.TrailGridView.TabIndex = 5;
            // 
            // CreateEntryButton
            // 
            this.CreateEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CreateEntryButton.ForeColor = System.Drawing.Color.Green;
            this.CreateEntryButton.Location = new System.Drawing.Point(57, 432);
            this.CreateEntryButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CreateEntryButton.Name = "CreateEntryButton";
            this.CreateEntryButton.Size = new System.Drawing.Size(155, 49);
            this.CreateEntryButton.TabIndex = 23;
            this.CreateEntryButton.Text = "Create Entry";
            this.CreateEntryButton.UseVisualStyleBackColor = false;
            this.CreateEntryButton.Click += new System.EventHandler(this.CreateEntryButton_Click);
            // 
            // TrailLengthTextbox
            // 
            this.TrailLengthTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrailLengthTextbox.Location = new System.Drawing.Point(26, 267);
            this.TrailLengthTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TrailLengthTextbox.Name = "TrailLengthTextbox";
            this.TrailLengthTextbox.Size = new System.Drawing.Size(220, 39);
            this.TrailLengthTextbox.TabIndex = 22;
            // 
            // TrailCoordinatesTextbox
            // 
            this.TrailCoordinatesTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrailCoordinatesTextbox.Location = new System.Drawing.Point(26, 350);
            this.TrailCoordinatesTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TrailCoordinatesTextbox.Name = "TrailCoordinatesTextbox";
            this.TrailCoordinatesTextbox.Size = new System.Drawing.Size(220, 39);
            this.TrailCoordinatesTextbox.TabIndex = 21;
            // 
            // TrailNameTextbox
            // 
            this.TrailNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrailNameTextbox.Location = new System.Drawing.Point(26, 184);
            this.TrailNameTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TrailNameTextbox.Name = "TrailNameTextbox";
            this.TrailNameTextbox.Size = new System.Drawing.Size(220, 39);
            this.TrailNameTextbox.TabIndex = 20;
            // 
            // TrailIdTextbox
            // 
            this.TrailIdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrailIdTextbox.Location = new System.Drawing.Point(26, 101);
            this.TrailIdTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TrailIdTextbox.Name = "TrailIdTextbox";
            this.TrailIdTextbox.Size = new System.Drawing.Size(220, 39);
            this.TrailIdTextbox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(26, 312);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Trail coordinates:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(26, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trail length:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(26, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trail Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(26, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Trail name:";
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteEntryButton.ForeColor = System.Drawing.Color.Green;
            this.DeleteEntryButton.Location = new System.Drawing.Point(717, 764);
            this.DeleteEntryButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(195, 49);
            this.DeleteEntryButton.TabIndex = 24;
            this.DeleteEntryButton.Text = "Delete Entry";
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // ModifyEntryButton
            // 
            this.ModifyEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ModifyEntryButton.ForeColor = System.Drawing.Color.Green;
            this.ModifyEntryButton.Location = new System.Drawing.Point(490, 764);
            this.ModifyEntryButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ModifyEntryButton.Name = "ModifyEntryButton";
            this.ModifyEntryButton.Size = new System.Drawing.Size(195, 49);
            this.ModifyEntryButton.TabIndex = 25;
            this.ModifyEntryButton.Text = "Modify Entry";
            this.ModifyEntryButton.UseVisualStyleBackColor = false;
            this.ModifyEntryButton.Click += new System.EventHandler(this.ModifyEntryButton_Click);
            // 
            // TrailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.ModifyEntryButton);
            this.Controls.Add(this.DeleteEntryButton);
            this.Controls.Add(this.CreateEntryButton);
            this.Controls.Add(this.TrailCoordinatesTextbox);
            this.Controls.Add(this.TrailLengthTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrailGridView);
            this.Controls.Add(this.TrailNameTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TrailIdTextbox);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TrailsUC";
            this.Size = new System.Drawing.Size(1488, 981);
            ((System.ComponentModel.ISupportInitialize)(this.TrailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TrailGridView;
        private System.Windows.Forms.Button CreateEntryButton;
        private System.Windows.Forms.TextBox TrailLengthTextbox;
        private System.Windows.Forms.TextBox TrailCoordinatesTextbox;
        private System.Windows.Forms.TextBox TrailNameTextbox;
        private System.Windows.Forms.TextBox TrailIdTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DeleteEntryButton;
        private System.Windows.Forms.Button ModifyEntryButton;
    }
}
