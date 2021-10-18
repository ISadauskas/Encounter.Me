
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TrailGridView = new System.Windows.Forms.DataGridView();
            this.CreateEntryButton = new System.Windows.Forms.Button();
            this.TrailLengthTextbox = new System.Windows.Forms.TextBox();
            this.TrailNameTextbox = new System.Windows.Forms.TextBox();
            this.TrailIdTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            this.ModifyEntryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TrailSeasonCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LengthFromTextBox = new System.Windows.Forms.TextBox();
            this.LengthToTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrailGridView
            // 
            this.TrailGridView.AllowUserToAddRows = false;
            this.TrailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrailGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TrailGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrailGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TrailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrailGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.TrailGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TrailGridView.Location = new System.Drawing.Point(149, 24);
            this.TrailGridView.Name = "TrailGridView";
            this.TrailGridView.RowHeadersWidth = 82;
            this.TrailGridView.RowTemplate.Height = 25;
            this.TrailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrailGridView.Size = new System.Drawing.Size(507, 324);
            this.TrailGridView.TabIndex = 5;
            this.TrailGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrailGridView_MouseClick);
            // 
            // CreateEntryButton
            // 
            this.CreateEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CreateEntryButton.ForeColor = System.Drawing.Color.Green;
            this.CreateEntryButton.Location = new System.Drawing.Point(27, 198);
            this.CreateEntryButton.Name = "CreateEntryButton";
            this.CreateEntryButton.Size = new System.Drawing.Size(83, 23);
            this.CreateEntryButton.TabIndex = 23;
            this.CreateEntryButton.Text = "Create Entry";
            this.CreateEntryButton.UseVisualStyleBackColor = false;
            this.CreateEntryButton.Click += new System.EventHandler(this.CreateEntryButton_Click);
            // 
            // TrailLengthTextbox
            // 
            this.TrailLengthTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrailLengthTextbox.Location = new System.Drawing.Point(14, 125);
            this.TrailLengthTextbox.Name = "TrailLengthTextbox";
            this.TrailLengthTextbox.Size = new System.Drawing.Size(120, 23);
            this.TrailLengthTextbox.TabIndex = 22;
            // 
            // TrailNameTextbox
            // 
            this.TrailNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrailNameTextbox.Location = new System.Drawing.Point(14, 86);
            this.TrailNameTextbox.Name = "TrailNameTextbox";
            this.TrailNameTextbox.Size = new System.Drawing.Size(120, 23);
            this.TrailNameTextbox.TabIndex = 20;
            // 
            // TrailIdTextbox
            // 
            this.TrailIdTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TrailIdTextbox.Location = new System.Drawing.Point(14, 47);
            this.TrailIdTextbox.Name = "TrailIdTextbox";
            this.TrailIdTextbox.Size = new System.Drawing.Size(120, 23);
            this.TrailIdTextbox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(14, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trail length:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(14, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trail Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(14, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Trail name:";
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteEntryButton.ForeColor = System.Drawing.Color.Green;
            this.DeleteEntryButton.Location = new System.Drawing.Point(386, 358);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteEntryButton.TabIndex = 24;
            this.DeleteEntryButton.Text = "Delete Entry";
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // ModifyEntryButton
            // 
            this.ModifyEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ModifyEntryButton.ForeColor = System.Drawing.Color.Green;
            this.ModifyEntryButton.Location = new System.Drawing.Point(264, 358);
            this.ModifyEntryButton.Name = "ModifyEntryButton";
            this.ModifyEntryButton.Size = new System.Drawing.Size(105, 23);
            this.ModifyEntryButton.TabIndex = 25;
            this.ModifyEntryButton.Text = "Modify Entry";
            this.ModifyEntryButton.UseVisualStyleBackColor = false;
            this.ModifyEntryButton.Click += new System.EventHandler(this.ModifyEntryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Trail Season:";
            // 
            // TrailSeasonCombobox
            // 
            this.TrailSeasonCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrailSeasonCombobox.FormattingEnabled = true;
            this.TrailSeasonCombobox.Items.AddRange(new object[] {
            "Summer",
            "Autumn",
            "Winter ",
            "Spring"});
            this.TrailSeasonCombobox.Location = new System.Drawing.Point(13, 169);
            this.TrailSeasonCombobox.Name = "TrailSeasonCombobox";
            this.TrailSeasonCombobox.Size = new System.Drawing.Size(121, 23);
            this.TrailSeasonCombobox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(13, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Trail length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(64, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "To:";
            // 
            // LengthFromTextBox
            // 
            this.LengthFromTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LengthFromTextBox.Location = new System.Drawing.Point(15, 276);
            this.LengthFromTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LengthFromTextBox.Name = "LengthFromTextBox";
            this.LengthFromTextBox.Size = new System.Drawing.Size(37, 23);
            this.LengthFromTextBox.TabIndex = 38;
            // 
            // LengthToTextBox
            // 
            this.LengthToTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LengthToTextBox.Location = new System.Drawing.Point(64, 276);
            this.LengthToTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LengthToTextBox.Name = "LengthToTextBox";
            this.LengthToTextBox.Size = new System.Drawing.Size(37, 23);
            this.LengthToTextBox.TabIndex = 39;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SearchButton.ForeColor = System.Drawing.Color.Green;
            this.SearchButton.Location = new System.Drawing.Point(14, 303);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(87, 23);
            this.SearchButton.TabIndex = 40;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TrailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LengthToTextBox);
            this.Controls.Add(this.LengthFromTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TrailSeasonCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModifyEntryButton);
            this.Controls.Add(this.DeleteEntryButton);
            this.Controls.Add(this.CreateEntryButton);
            this.Controls.Add(this.TrailLengthTextbox);
            this.Controls.Add(this.TrailGridView);
            this.Controls.Add(this.TrailNameTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TrailIdTextbox);
            this.Controls.Add(this.label8);
            this.Name = "TrailsUC";
            this.Size = new System.Drawing.Size(801, 460);
            ((System.ComponentModel.ISupportInitialize)(this.TrailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TrailGridView;
        private System.Windows.Forms.Button CreateEntryButton;
        private System.Windows.Forms.TextBox TrailLengthTextbox;
        private System.Windows.Forms.TextBox TrailNameTextbox;
        private System.Windows.Forms.TextBox TrailIdTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DeleteEntryButton;
        private System.Windows.Forms.Button ModifyEntryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TrailSeasonCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LengthFromTextBox;
        private System.Windows.Forms.TextBox LengthToTextBox;
        private System.Windows.Forms.Button SearchButton;
    }
}
