namespace Lab7
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftBox = new System.Windows.Forms.ListBox();
            this.RightBox = new System.Windows.Forms.ListBox();
            this.ShiftLeftButton = new System.Windows.Forms.Button();
            this.ShiftRightButton = new System.Windows.Forms.Button();
            this.FileLoadButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FileSaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftBox
            // 
            this.LeftBox.FormattingEnabled = true;
            this.LeftBox.ItemHeight = 23;
            this.LeftBox.Location = new System.Drawing.Point(39, 39);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LeftBox.Size = new System.Drawing.Size(372, 211);
            this.LeftBox.TabIndex = 0;
            // 
            // RightBox
            // 
            this.RightBox.FormattingEnabled = true;
            this.RightBox.ItemHeight = 23;
            this.RightBox.Location = new System.Drawing.Point(509, 39);
            this.RightBox.Name = "RightBox";
            this.RightBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RightBox.Size = new System.Drawing.Size(372, 211);
            this.RightBox.TabIndex = 1;
            // 
            // ShiftLeftButton
            // 
            this.ShiftLeftButton.Location = new System.Drawing.Point(283, 296);
            this.ShiftLeftButton.Name = "ShiftLeftButton";
            this.ShiftLeftButton.Size = new System.Drawing.Size(128, 37);
            this.ShiftLeftButton.TabIndex = 2;
            this.ShiftLeftButton.Text = "<<";
            this.ShiftLeftButton.UseVisualStyleBackColor = true;
            this.ShiftLeftButton.Click += new System.EventHandler(this.ShiftLeftButton_Click);
            // 
            // ShiftRightButton
            // 
            this.ShiftRightButton.Location = new System.Drawing.Point(509, 296);
            this.ShiftRightButton.Name = "ShiftRightButton";
            this.ShiftRightButton.Size = new System.Drawing.Size(119, 37);
            this.ShiftRightButton.TabIndex = 3;
            this.ShiftRightButton.Text = ">>";
            this.ShiftRightButton.UseVisualStyleBackColor = true;
            this.ShiftRightButton.Click += new System.EventHandler(this.ShiftRightButton_Click);
            // 
            // FileLoadButton
            // 
            this.FileLoadButton.Location = new System.Drawing.Point(509, 373);
            this.FileLoadButton.Name = "FileLoadButton";
            this.FileLoadButton.Size = new System.Drawing.Size(209, 37);
            this.FileLoadButton.TabIndex = 4;
            this.FileLoadButton.Text = "Загрузить из файла";
            this.FileLoadButton.UseVisualStyleBackColor = true;
            this.FileLoadButton.Click += new System.EventHandler(this.FileLoadButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(397, 450);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(119, 37);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FileSaveButton
            // 
            this.FileSaveButton.Location = new System.Drawing.Point(202, 373);
            this.FileSaveButton.Name = "FileSaveButton";
            this.FileSaveButton.Size = new System.Drawing.Size(209, 37);
            this.FileSaveButton.TabIndex = 6;
            this.FileSaveButton.Text = "Сохранить в файл";
            this.FileSaveButton.UseVisualStyleBackColor = true;
            this.FileSaveButton.Click += new System.EventHandler(this.FileSaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ErrorLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(18, 20);
            this.ErrorLabel.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(918, 529);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.FileSaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FileLoadButton);
            this.Controls.Add(this.ShiftRightButton);
            this.Controls.Add(this.ShiftLeftButton);
            this.Controls.Add(this.RightBox);
            this.Controls.Add(this.LeftBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 7";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LeftBox;
        private System.Windows.Forms.ListBox RightBox;
        private System.Windows.Forms.Button ShiftLeftButton;
        private System.Windows.Forms.Button ShiftRightButton;
        private System.Windows.Forms.Button FileLoadButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FileSaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ErrorLabel;
    }
}

