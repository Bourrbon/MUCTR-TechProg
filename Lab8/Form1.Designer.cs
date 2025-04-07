namespace Lab8
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
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TransformOutputBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ErrorMessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LetterSelector = new System.Windows.Forms.DomainUpDown();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterBox
            // 
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Items.AddRange(new object[] {
            "Элементы, начинающиеся на...",
            "Элементы, содержащие...",
            "Только числа",
            "Только знаки + и -",
            "Считывать всё"});
            this.filterBox.Location = new System.Drawing.Point(42, 69);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(244, 24);
            this.filterBox.TabIndex = 0;
            this.filterBox.SelectedIndexChanged += new System.EventHandler(this.filterBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фильтры:";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(42, 238);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(739, 406);
            this.OutputBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(42, 122);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(97, 30);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Преобразовать вывод:";
            // 
            // TransformOutputBox
            // 
            this.TransformOutputBox.FormattingEnabled = true;
            this.TransformOutputBox.Items.AddRange(new object[] {
            "В верхний регистр",
            "В нижний регистр",
            "Нет"});
            this.TransformOutputBox.Location = new System.Drawing.Point(42, 203);
            this.TransformOutputBox.Name = "TransformOutputBox";
            this.TransformOutputBox.Size = new System.Drawing.Size(244, 24);
            this.TransformOutputBox.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ErrorMessageLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(836, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(18, 20);
            this.ErrorMessageLabel.Text = "...";
            // 
            // LetterSelector
            // 
            this.LetterSelector.Items.Add("A");
            this.LetterSelector.Items.Add("B");
            this.LetterSelector.Items.Add("C");
            this.LetterSelector.Items.Add("D");
            this.LetterSelector.Items.Add("E");
            this.LetterSelector.Items.Add("F");
            this.LetterSelector.Items.Add("G");
            this.LetterSelector.Items.Add("H");
            this.LetterSelector.Items.Add("I");
            this.LetterSelector.Items.Add("J");
            this.LetterSelector.Items.Add("K");
            this.LetterSelector.Items.Add("L");
            this.LetterSelector.Items.Add("M");
            this.LetterSelector.Items.Add("N");
            this.LetterSelector.Items.Add("O");
            this.LetterSelector.Items.Add("P");
            this.LetterSelector.Items.Add("Q");
            this.LetterSelector.Items.Add("R");
            this.LetterSelector.Items.Add("S");
            this.LetterSelector.Items.Add("T");
            this.LetterSelector.Items.Add("U");
            this.LetterSelector.Items.Add("V");
            this.LetterSelector.Items.Add("W");
            this.LetterSelector.Items.Add("X");
            this.LetterSelector.Items.Add("Y");
            this.LetterSelector.Items.Add("Z");
            this.LetterSelector.Location = new System.Drawing.Point(325, 70);
            this.LetterSelector.Name = "LetterSelector";
            this.LetterSelector.Size = new System.Drawing.Size(121, 22);
            this.LetterSelector.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 693);
            this.Controls.Add(this.LetterSelector);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TransformOutputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 8";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TransformOutputBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ErrorMessageLabel;
        public System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.DomainUpDown LetterSelector;
    }
}

