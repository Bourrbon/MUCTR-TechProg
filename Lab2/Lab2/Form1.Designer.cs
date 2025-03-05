namespace Lab2
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tStartBox = new System.Windows.Forms.TextBox();
            this.tMaxBox = new System.Windows.Forms.TextBox();
            this.tStepBox = new System.Windows.Forms.TextBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(8, 126);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(191, 32);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Рассчитать вязкость η";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLabel1,
            this.toolLabel2,
            this.ErrorLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 366);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolLabel1
            // 
            this.toolLabel1.Name = "toolLabel1";
            this.toolLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolLabel1.Text = "Версия: ";
            // 
            // toolLabel2
            // 
            this.toolLabel2.Name = "toolLabel2";
            this.toolLabel2.Size = new System.Drawing.Size(101, 17);
            this.toolLabel2.Text = "Дата изменения: ";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(23, 17);
            this.ErrorLabel.Text = "OK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "t (нач.) °C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "t (кон.) °C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Шаг Δt";
            // 
            // tStartBox
            // 
            this.tStartBox.Location = new System.Drawing.Point(103, 17);
            this.tStartBox.Margin = new System.Windows.Forms.Padding(2);
            this.tStartBox.Name = "tStartBox";
            this.tStartBox.Size = new System.Drawing.Size(76, 20);
            this.tStartBox.TabIndex = 13;
            // 
            // tMaxBox
            // 
            this.tMaxBox.Location = new System.Drawing.Point(103, 56);
            this.tMaxBox.Margin = new System.Windows.Forms.Padding(2);
            this.tMaxBox.Name = "tMaxBox";
            this.tMaxBox.Size = new System.Drawing.Size(76, 20);
            this.tMaxBox.TabIndex = 14;
            // 
            // tStepBox
            // 
            this.tStepBox.Location = new System.Drawing.Point(103, 91);
            this.tStepBox.Margin = new System.Windows.Forms.Padding(2);
            this.tStepBox.Name = "tStepBox";
            this.tStepBox.Size = new System.Drawing.Size(76, 20);
            this.tStepBox.TabIndex = 15;
            // 
            // ValueBox
            // 
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueBox.Location = new System.Drawing.Point(240, 17);
            this.ValueBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValueBox.Multiline = true;
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(458, 337);
            this.ValueBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 388);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.tStepBox);
            this.Controls.Add(this.tMaxBox);
            this.Controls.Add(this.tStartBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CalculateButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tStartBox;
        private System.Windows.Forms.TextBox tMaxBox;
        private System.Windows.Forms.TextBox tStepBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.ToolStripStatusLabel ErrorLabel;
    }
}

