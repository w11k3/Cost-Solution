namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            healthyBox = new CheckBox();
            fancyBox = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            costLabel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // healthyBox
            // 
            healthyBox.AutoSize = true;
            healthyBox.Location = new Point(134, 132);
            healthyBox.Name = "healthyBox";
            healthyBox.Size = new Size(104, 24);
            healthyBox.TabIndex = 0;
            healthyBox.Text = "healthyBox";
            healthyBox.UseVisualStyleBackColor = true;
            // 
            // fancyBox
            // 
            fancyBox.AutoSize = true;
            fancyBox.Location = new Point(131, 195);
            fancyBox.Name = "fancyBox";
            fancyBox.Size = new Size(95, 24);
            fancyBox.TabIndex = 1;
            fancyBox.Text = "fancy Box";
            fancyBox.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(161, 85);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // costLabel
            // 
            costLabel.Location = new Point(131, 278);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(125, 27);
            costLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(costLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(fancyBox);
            Controls.Add(healthyBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox healthyBox;
        private CheckBox fancyBox;
        private NumericUpDown numericUpDown1;
        private TextBox costLabel;
    }
}
