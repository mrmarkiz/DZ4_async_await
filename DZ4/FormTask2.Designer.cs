namespace DZ4
{
    partial class FormTask2
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
            button1 = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar5 = new ProgressBar();
            label1 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(159, 39);
            button1.TabIndex = 0;
            button1.Text = "Start race";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 70);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(159, 29);
            progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 105);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(159, 29);
            progressBar2.TabIndex = 1;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 140);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(159, 29);
            progressBar3.TabIndex = 1;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(12, 175);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(159, 29);
            progressBar4.TabIndex = 1;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(12, 210);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(159, 29);
            progressBar5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 12);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Results";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(200, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 204);
            listBox1.TabIndex = 3;
            // 
            // FormTask2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 248);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(progressBar5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Name = "FormTask2";
            Text = "FormTask2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
        private Label label1;
        private ListBox listBox1;
    }
}