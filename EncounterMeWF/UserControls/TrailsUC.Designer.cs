
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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Convert to Json";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrailGridView
            // 
            this.TrailGridView.AllowUserToAddRows = false;
            this.TrailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrailGridView.Location = new System.Drawing.Point(176, 27);
            this.TrailGridView.Name = "TrailGridView";
            this.TrailGridView.RowTemplate.Height = 25;
            this.TrailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrailGridView.Size = new System.Drawing.Size(600, 144);
            this.TrailGridView.TabIndex = 5;
            // 
            // CreateEntryButton
            // 
            this.CreateEntryButton.Location = new System.Drawing.Point(375, 210);
            this.CreateEntryButton.Name = "CreateEntryButton";
            this.CreateEntryButton.Size = new System.Drawing.Size(105, 23);
            this.CreateEntryButton.TabIndex = 23;
            this.CreateEntryButton.Text = "Create Entry";
            this.CreateEntryButton.UseVisualStyleBackColor = true;
            this.CreateEntryButton.Click += new System.EventHandler(this.CreateEntryButton_Click);
            // 
            // TrailLengthTextbox
            // 
            this.TrailLengthTextbox.Location = new System.Drawing.Point(191, 301);
            this.TrailLengthTextbox.Name = "TrailLengthTextbox";
            this.TrailLengthTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailLengthTextbox.TabIndex = 22;
            // 
            // TrailCoordinatesTextbox
            // 
            this.TrailCoordinatesTextbox.Location = new System.Drawing.Point(191, 349);
            this.TrailCoordinatesTextbox.Name = "TrailCoordinatesTextbox";
            this.TrailCoordinatesTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailCoordinatesTextbox.TabIndex = 21;
            // 
            // TrailNameTextbox
            // 
            this.TrailNameTextbox.Location = new System.Drawing.Point(191, 252);
            this.TrailNameTextbox.Name = "TrailNameTextbox";
            this.TrailNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailNameTextbox.TabIndex = 20;
            // 
            // TrailIdTextbox
            // 
            this.TrailIdTextbox.Location = new System.Drawing.Point(191, 211);
            this.TrailIdTextbox.Name = "TrailIdTextbox";
            this.TrailIdTextbox.Size = new System.Drawing.Size(100, 23);
            this.TrailIdTextbox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Trail coordinates:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trail length:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trail Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Trail name:";
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.Location = new System.Drawing.Point(597, 211);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteEntryButton.TabIndex = 24;
            this.DeleteEntryButton.Text = "Delete Entry";
            this.DeleteEntryButton.UseVisualStyleBackColor = true;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // ModifyEntryButton
            // 
            this.ModifyEntryButton.Location = new System.Drawing.Point(486, 210);
            this.ModifyEntryButton.Name = "ModifyEntryButton";
            this.ModifyEntryButton.Size = new System.Drawing.Size(105, 23);
            this.ModifyEntryButton.TabIndex = 25;
            this.ModifyEntryButton.Text = "Modify Entry";
            this.ModifyEntryButton.UseVisualStyleBackColor = true;
            this.ModifyEntryButton.Click += new System.EventHandler(this.ModifyEntryButton_Click);
            // 
            // TrailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModifyEntryButton);
            this.Controls.Add(this.DeleteEntryButton);
            this.Controls.Add(this.CreateEntryButton);
            this.Controls.Add(this.TrailCoordinatesTextbox);
            this.Controls.Add(this.TrailLengthTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
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
