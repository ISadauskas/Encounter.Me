
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
            this.label1 = new System.Windows.Forms.Label();
            this.JsonText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TrailGridView = new System.Windows.Forms.DataGridView();
            this.CreateEntryButton = new System.Windows.Forms.Button();
            this.ModifyEntryButton = new System.Windows.Forms.Button();
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConvertToJasonTab = new System.Windows.Forms.TabPage();
            this.CreateEntryTab = new System.Windows.Forms.TabPage();
            this.TrailLengthTextbox = new System.Windows.Forms.TextBox();
            this.TrailCoordinatesTextbox = new System.Windows.Forms.TextBox();
            this.TrailNameTextbox = new System.Windows.Forms.TextBox();
            this.TrailIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifyEntryTab = new System.Windows.Forms.TabPage();
            this.DeleteEntryTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.TrailGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ConvertToJasonTab.SuspendLayout();
            this.CreateEntryTab.SuspendLayout();
            this.ModifyEntryTab.SuspendLayout();
            this.DeleteEntryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Json output";
            // 
            // JsonText
            // 
            this.JsonText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JsonText.Location = new System.Drawing.Point(135, 18);
            this.JsonText.Multiline = true;
            this.JsonText.Name = "JsonText";
            this.JsonText.Size = new System.Drawing.Size(600, 126);
            this.JsonText.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Convert to Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrailGridView
            // 
            this.TrailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrailGridView.Location = new System.Drawing.Point(135, 181);
            this.TrailGridView.Name = "TrailGridView";
            this.TrailGridView.RowTemplate.Height = 25;
            this.TrailGridView.Size = new System.Drawing.Size(600, 202);
            this.TrailGridView.TabIndex = 5;
            // 
            // CreateEntryButton
            // 
            this.CreateEntryButton.Location = new System.Drawing.Point(339, 342);
            this.CreateEntryButton.Name = "CreateEntryButton";
            this.CreateEntryButton.Size = new System.Drawing.Size(105, 23);
            this.CreateEntryButton.TabIndex = 6;
            this.CreateEntryButton.Text = "Create Entry";
            this.CreateEntryButton.UseVisualStyleBackColor = true;
            this.CreateEntryButton.Click += new System.EventHandler(this.CreateEntryButton_Click);
            // 
            // ModifyEntryButton
            // 
            this.ModifyEntryButton.Location = new System.Drawing.Point(39, 60);
            this.ModifyEntryButton.Name = "ModifyEntryButton";
            this.ModifyEntryButton.Size = new System.Drawing.Size(105, 23);
            this.ModifyEntryButton.TabIndex = 7;
            this.ModifyEntryButton.Text = "Modify Entry";
            this.ModifyEntryButton.UseVisualStyleBackColor = true;
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.Location = new System.Drawing.Point(72, 54);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteEntryButton.TabIndex = 8;
            this.DeleteEntryButton.Text = "Delete Entry";
            this.DeleteEntryButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ConvertToJasonTab);
            this.tabControl1.Controls.Add(this.CreateEntryTab);
            this.tabControl1.Controls.Add(this.ModifyEntryTab);
            this.tabControl1.Controls.Add(this.DeleteEntryTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 460);
            this.tabControl1.TabIndex = 9;
            // 
            // ConvertToJasonTab
            // 
            this.ConvertToJasonTab.Controls.Add(this.button1);
            this.ConvertToJasonTab.Controls.Add(this.label1);
            this.ConvertToJasonTab.Controls.Add(this.JsonText);
            this.ConvertToJasonTab.Controls.Add(this.TrailGridView);
            this.ConvertToJasonTab.Location = new System.Drawing.Point(4, 24);
            this.ConvertToJasonTab.Name = "ConvertToJasonTab";
            this.ConvertToJasonTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConvertToJasonTab.Size = new System.Drawing.Size(793, 432);
            this.ConvertToJasonTab.TabIndex = 0;
            this.ConvertToJasonTab.Text = "Convert to Json";
            this.ConvertToJasonTab.UseVisualStyleBackColor = true;
            // 
            // CreateEntryTab
            // 
            this.CreateEntryTab.Controls.Add(this.TrailLengthTextbox);
            this.CreateEntryTab.Controls.Add(this.TrailCoordinatesTextbox);
            this.CreateEntryTab.Controls.Add(this.TrailNameTextbox);
            this.CreateEntryTab.Controls.Add(this.TrailIdTextBox);
            this.CreateEntryTab.Controls.Add(this.label5);
            this.CreateEntryTab.Controls.Add(this.label4);
            this.CreateEntryTab.Controls.Add(this.label3);
            this.CreateEntryTab.Controls.Add(this.label2);
            this.CreateEntryTab.Controls.Add(this.CreateEntryButton);
            this.CreateEntryTab.Location = new System.Drawing.Point(4, 24);
            this.CreateEntryTab.Name = "CreateEntryTab";
            this.CreateEntryTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateEntryTab.Size = new System.Drawing.Size(793, 432);
            this.CreateEntryTab.TabIndex = 1;
            this.CreateEntryTab.Text = "CreateEntry";
            this.CreateEntryTab.UseVisualStyleBackColor = true;
            // 
            // TrailLengthTextbox
            // 
            this.TrailLengthTextbox.Location = new System.Drawing.Point(487, 168);
            this.TrailLengthTextbox.Name = "TrailLengthTextbox";
            this.TrailLengthTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailLengthTextbox.TabIndex = 14;
            // 
            // TrailCoordinatesTextbox
            // 
            this.TrailCoordinatesTextbox.Location = new System.Drawing.Point(487, 218);
            this.TrailCoordinatesTextbox.Name = "TrailCoordinatesTextbox";
            this.TrailCoordinatesTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailCoordinatesTextbox.TabIndex = 13;
            // 
            // TrailNameTextbox
            // 
            this.TrailNameTextbox.Location = new System.Drawing.Point(487, 116);
            this.TrailNameTextbox.Name = "TrailNameTextbox";
            this.TrailNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailNameTextbox.TabIndex = 12;
            // 
            // TrailIdTextBox
            // 
            this.TrailIdTextBox.Location = new System.Drawing.Point(487, 59);
            this.TrailIdTextBox.Name = "TrailIdTextBox";
            this.TrailIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.TrailIdTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trail coordinates:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trail length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trail Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trail name:";
            // 
            // ModifyEntryTab
            // 
            this.ModifyEntryTab.Controls.Add(this.ModifyEntryButton);
            this.ModifyEntryTab.Location = new System.Drawing.Point(4, 24);
            this.ModifyEntryTab.Name = "ModifyEntryTab";
            this.ModifyEntryTab.Size = new System.Drawing.Size(793, 432);
            this.ModifyEntryTab.TabIndex = 2;
            this.ModifyEntryTab.Text = "Modify Entry";
            this.ModifyEntryTab.UseVisualStyleBackColor = true;
            // 
            // DeleteEntryTab
            // 
            this.DeleteEntryTab.Controls.Add(this.DeleteEntryButton);
            this.DeleteEntryTab.Location = new System.Drawing.Point(4, 24);
            this.DeleteEntryTab.Name = "DeleteEntryTab";
            this.DeleteEntryTab.Size = new System.Drawing.Size(793, 432);
            this.DeleteEntryTab.TabIndex = 3;
            this.DeleteEntryTab.Text = "Delete Entry";
            this.DeleteEntryTab.UseVisualStyleBackColor = true;
            // 
            // TrailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "TrailsUC";
            this.Size = new System.Drawing.Size(801, 460);
            ((System.ComponentModel.ISupportInitialize)(this.TrailGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ConvertToJasonTab.ResumeLayout(false);
            this.ConvertToJasonTab.PerformLayout();
            this.CreateEntryTab.ResumeLayout(false);
            this.CreateEntryTab.PerformLayout();
            this.ModifyEntryTab.ResumeLayout(false);
            this.DeleteEntryTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox JsonText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TrailGridView;
        private System.Windows.Forms.Button CreateEntryButton;
        private System.Windows.Forms.Button ModifyEntryButton;
        private System.Windows.Forms.Button DeleteEntryButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConvertToJasonTab;
        private System.Windows.Forms.TabPage CreateEntryTab;
        private System.Windows.Forms.TabPage ModifyEntryTab;
        private System.Windows.Forms.TabPage DeleteEntryTab;
        private System.Windows.Forms.TextBox TrailLengthTextbox;
        private System.Windows.Forms.TextBox TrailCoordinatesTextbox;
        private System.Windows.Forms.TextBox TrailNameTextbox;
        private System.Windows.Forms.TextBox TrailIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
