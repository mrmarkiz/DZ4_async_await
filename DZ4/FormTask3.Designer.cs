namespace DZ4
{
    partial class FormTask3
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
            listBox1 = new ListBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            buttonGenerate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(13, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 284);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 17);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "upper bound";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 40);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(12, 76);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(151, 35);
            buttonGenerate.TabIndex = 3;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // FormTask3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(173, 414);
            Controls.Add(buttonGenerate);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "FormTask3";
            Text = "FormTask3";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button buttonGenerate;
    }
}